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

namespace G1ANT.Addon.Access.Commands.Access.Data
{
    [Command(Name = "access.committransaction", Tooltip = "This command commits transaction")]
    public class AccessCommitTransactionCommand : Command
    {
        public class Arguments : CommandArguments
        {
            [Argument(Tooltip = "This forces the database engine to immediately flush all updates to disk, instead of caching them temporarily. False by default")]
            public BooleanStructure Flush { get; set; } = new BooleanStructure(false);
        }

        public AccessCommitTransactionCommand(AbstractScripter scripter) : base(scripter)
        { }

        public void Execute(Arguments arguments)
        {
            AccessManager.CurrentAccess.CommitTransaction(arguments.Flush.Value);
        }
    }
}