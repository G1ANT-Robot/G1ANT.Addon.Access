﻿/**
*    Copyright(C) G1ANT Ltd, All rights reserved
*    Solution G1ANT.Addon, Project G1ANT.Addon.Access
*    www.g1ant.com
*
*    Licensed under the G1ANT license.
*    See License.txt file in the project root for full license information.
*
*/

using Microsoft.Office.Interop.Access;
using System.Collections.Generic;

namespace G1ANT.Addon.Access.Models.Access.Data
{
    internal class AccessReportCollectionModel : List<AccessReportModel>
    {
        public AccessReportCollectionModel(Reports reports)
        {
            try
            {
                try
                {
                    foreach (Report report in reports)
                    {
                        try
                        {
                            var model = new AccessReportModel(report);
                            Add(model);
                        }
                        catch { }
                    }
                }
                catch { }
            }
            catch
            { }
        }
    }
}
