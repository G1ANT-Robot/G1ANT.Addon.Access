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

namespace G1ANT.Addon.Access.Commands.Access.Controls
{
    [Command(Name = "access.clickcontrol", Tooltip = "Executes action assigned to a click at control selected by path")]
    public class AccessControlExecuteOnClickCommand : Command
    {
        public class Arguments : CommandArguments
        {
            [Argument(Required = true, Tooltip = "Path to the control. See `access.getcontrol` tooltip for path examples")]
            public TextStructure Path { get; set; }
        }

        public AccessControlExecuteOnClickCommand(AbstractScripter scripter) : base(scripter)
        { }

        public void Execute(Arguments arguments)
        {
            AccessManager.CurrentAccess.ExecuteDefaultClickEvent(arguments.Path.Value);
        }
    }
}
