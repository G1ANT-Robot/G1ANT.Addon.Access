/**
*    Copyright(C) G1ANT Ltd, All rights reserved
*    Solution G1ANT.Addon, Project G1ANT.Addon.Access
*    www.g1ant.com
*
*    Licensed under the G1ANT license.
*    See License.txt file in the project root for full license information.
*
*/

using G1ANT.Language;

namespace G1ANT.Addon.Access.Commands.Access.Controls.Items
{
    [Command(Name = "access.setselectionofcontrolitem", Tooltip = "Set if item of Access control is selected")]
    public class AccessSetSelectedItemCommand : Command
    {
        public class Arguments : CommandArguments
        {
            [Argument(Required = true, Tooltip = "Path to the control. See `access.getcontrol` tooltip for path examples")]
            public TextStructure Path { get; set; }

            [Argument(Required = true, Tooltip = "Index of item (starting from 0)")]
            public IntegerStructure Index { get; set; }

            [Argument(Required = true, Tooltip = "True if item should be selected, otherwise false")]
            public BooleanStructure IsSelected { get; set; }
        }

        public AccessSetSelectedItemCommand(AbstractScripter scripter) : base(scripter)
        { }

        public void Execute(Arguments arguments)
        {
            var control = AccessManager.CurrentAccess.GetControlByPath(arguments.Path.Value);
            control.SetItemSelected(arguments.Index.Value, arguments.IsSelected.Value);
        }
    }
}
