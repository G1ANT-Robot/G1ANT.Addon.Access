﻿/**
*    Copyright(C) G1ANT Ltd, All rights reserved
*    Solution G1ANT.Addon, Project G1ANT.Addon.Access
*    www.g1ant.com
*
*    Licensed under the G1ANT license.
*    See License.txt file in the project root for full license information.
*
*/

using G1ANT.Addon.Access.Models.Access.AccessObjects;

namespace G1ANT.Addon.Access.Models.Access.Data
{
    public class AccessObjectViewCollectionModel : AccessObjectCollectionModel
    {
        public AccessObjectViewCollectionModel(RotApplicationModel rotApplicationModel)
        {
            try
            {
                Initialize(rotApplicationModel.Application.CurrentData.AllViews);
            }
            catch
            { }
        }
    }
}
