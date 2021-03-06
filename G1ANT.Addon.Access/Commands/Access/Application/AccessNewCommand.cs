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

namespace G1ANT.Addon.Access.Commands.Access.Application
{
    [Command(Name = "access.new", Tooltip = "This command opens new, empty Access instance")]
    public class AccessNewCommand : Command
    {
        public class Arguments : CommandArguments
        {
        }

        public AccessNewCommand(AbstractScripter scripter) : base(scripter)
        { }

        public void Execute(Arguments arguments)
        {
            AccessManager.AddAccess();
            AccessManager.CurrentAccess.New();
        }
    }
}