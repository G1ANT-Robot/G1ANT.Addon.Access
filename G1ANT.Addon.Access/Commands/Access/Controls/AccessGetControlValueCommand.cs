/**
*    Copyright(C) G1ANT Ltd, All rights reserved
*    Solution G1ANT.Addon, Project G1ANT.Addon.Access
*    www.g1ant.com
*
*    Licensed under the G1ANT license.
*    See License.txt file in the project root for full license information.
*
*/

using G1ANT.Addon.Access.Api;
using G1ANT.Language;

namespace G1ANT.Addon.Access.Commands.Access.Controls
{
    [Command(Name = "access.getcontrolvalue", Tooltip = "Get value of control of form of Access application")]
    public class AccessGetControlValueCommand : Command
    {
        public class Arguments : CommandArguments
        {
            [Argument(Required = true, Tooltip = "Path to the control. See `access.getcontrol` tooltip for path examples")]
            public TextStructure Path { get; set; }

            [Argument(Tooltip = "Name of a variable where the command's result will be stored")]
            public VariableStructure Result { get; set; } = new VariableStructure("result");
        }

        public AccessGetControlValueCommand(AbstractScripter scripter) : base(scripter)
        { }

        public void Execute(Arguments arguments)
        {
            var control = AccessManager.CurrentAccess.GetControlByPath(arguments.Path.Value);
            var value = control.GetValue();
            var result = new StructureConverter().Convert(value);

            Scripter.Variables.SetVariableValue(arguments.Result.Value, result);
        }
    }
}