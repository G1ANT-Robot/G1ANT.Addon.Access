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

namespace G1ANT.Addon.Access.Commands.Access.Data.Tables
{
    [Command(Name = "access.closetable", Tooltip = "This command closes and optionally saves an Access Table")]
    public class AccesCloseTableCommand : Command
    {
        public class Arguments : CommandArguments
        {
            [Argument(Tooltip = "Name of the table to close", Required = true)]
            public TextStructure Name { get; set; }

            [Argument(Tooltip = "Set to true to save changes, false to discard them, don't set any value to prompt user")]
            public BooleanStructure SaveChanges { get; set; }
        }

        public AccesCloseTableCommand(AbstractScripter scripter) : base(scripter)
        { }

        public void Execute(Arguments arguments)
        {
            AccessManager.CurrentAccess.Close(Microsoft.Office.Interop.Access.AcObjectType.acTable, arguments.Name.Value, arguments.SaveChanges?.Value);
        }
    }
}