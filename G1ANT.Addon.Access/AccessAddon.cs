/**
*    Copyright(C) G1ANT Robot Ltd, All rights reserved
*    Solution G1ANT.Addon.Access, Project G1ANT.Addon.Access
*    www.g1ant.com
*
*    Licensed under the G1ANT license.
*    See License.txt file in the project root for full license information.
*
*/
using G1ANT.Language;

namespace G1ANT.Addon.Access
{
    [Addon(Name = "Access", Tooltip = "Microsoft Access commands")]
    [Copyright(Author = "G1ANT Robot Ltd", Copyright = "G1ANT Robot Ltd", Email = "hi@g1ant.com", Website = "www.g1ant.com")]
    [License(Type = "LGPL", ResourceName = "License.txt")]
    [CommandGroup(Name = "access", Tooltip = "Commands related with managing Microsoft Access projects (requires installed Access)")]
    public class AccessAddon : Language.Addon
    {
    }
}