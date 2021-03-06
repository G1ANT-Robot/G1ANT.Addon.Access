﻿/**
*    Copyright(C) G1ANT Ltd, All rights reserved
*    Solution G1ANT.Addon, Project G1ANT.Addon.Access
*    www.g1ant.com
*
*    Licensed under the G1ANT license.
*    See License.txt file in the project root for full license information.
*
*/
using G1ANT.Addon.Access.Models.Access.Forms.Recordsets;
using Microsoft.Office.Interop.Access;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace G1ANT.Addon.Access.Models.Access
{
    internal class AccessFormModel : IComparable, INameModel, IDetailedNameModel
    {
        public string Name { get; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        internal string Value { get; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        internal string Caption { get; }

        [JsonIgnore]
        internal Form Form { get; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        internal string FormName { get; }

        internal int Hwnd { get; }
        internal int InsideWidth { get; }
        internal short Width { get; }
        internal short Height { get; }
        internal short X { get; }
        internal short Y { get; }
        internal int InsideHeight { get; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        internal ICollection<AccessControlModel> Controls { get; private set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        internal Lazy<AccessDynamicPropertyCollectionModel> Properties { get; }

        internal Lazy<AccessRecordsetModel> Recordset { get; }
        internal bool HasRecordset()
        {
            try { return Form.Recordset != null; }
            catch { }

            return false;
        }


        internal AccessFormModel(Form form, bool getFormProperties, bool getControls, bool getControlsProperties)
        {
            Form = form ?? throw new ArgumentNullException(nameof(form));

            Name = form.Name;
            Value = form.accValue;

            Caption = form.Caption;
            FormName = form.FormName;
            Hwnd = form.Hwnd;
            InsideWidth = form.InsideWidth;
            InsideHeight = form.InsideHeight;
            Width = form.WindowWidth;
            Height = form.WindowHeight;
            X = form.WindowLeft;
            Y = form.WindowTop;

            Recordset = new Lazy<AccessRecordsetModel>(() => new AccessRecordsetModel(Form.Recordset));

            Properties = !getFormProperties || form.Properties.Count == 0 ? null : new Lazy<AccessDynamicPropertyCollectionModel>(() => new AccessDynamicPropertyCollectionModel(form.Properties));
            if (getControls)
                LoadControls(getControlsProperties);
        }


        internal void LoadControls(bool getControlsProperties)
        {
            if (Form.Controls.Count > 0)
                Controls = Form.Controls.Cast<Control>().Select(c => new AccessControlModel(c, getControlsProperties, false)).ToList();
        }

        internal List<NameValueModel> GetProperties(bool getValues = true)
        {
            return TypeDescriptor.GetProperties(Form)
                .Cast<PropertyDescriptor>()
                .Select(pd => new NameValueModel(pd.Name, getValues ? pd.GetValue(Form) : null))
                .ToList();
        }

        internal AccessDynamicPropertyCollectionModel GetDynamicProperties() => new AccessDynamicPropertyCollectionModel(Form.Properties);


        internal object GetPropertyValue(string name)
        {
            try
            {
                var property = TypeDescriptor.GetProperties(Form)[name];
                return property.GetValue(Form);
            }
            catch (COMException ex)
            {
                throw new Exception($"Error getting the property {name} value", ex);
            }
        }

        internal void SetPropertyValue(string name, object value)
        {
            try
            {
                var property = TypeDescriptor.GetProperties(Form)[name];
                property.SetValue(Form, value);
            }
            catch (COMException ex)
            {
                throw new Exception($"Error setting the value of property {name}", ex);
            }
        }


        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;

            if (!(obj is AccessFormModel))
                return 1;

            var model = (AccessFormModel)obj;

            if (Form.Application.hWndAccessApp() != model.Form.Application.hWndAccessApp())
                return 1;

            return model.Name == this.Name ? 0 : 1; // names of forms seem to be unique
        }


        public override string ToString() => $"{Name}{(Name != Caption ? " " + Caption : "")}{(Name != FormName ? " " + FormName : "")}";

        public string ToDetailedString()
        {
            var result = new StringBuilder();

            result.AppendLine($"Name: {Name}");
            result.AppendLine($"Caption: {Caption}");
            if (FormName != Name)
                result.AppendLine($"FormName: {FormName}");
            result.AppendLine($"Height: {Height}");
            result.AppendLine($"Width: {Width}");
            result.AppendLine($"X: {X}");
            result.AppendLine($"Y: {Y}");

            return result.ToString();
        }
    }
}
