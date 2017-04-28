namespace time
{
    using System;
    using System.Collections.Generic;
    using UBotPlugin;

    public class currentweekday : IUBotFunction
    {
        private List<UBotParameterDefinition> _parameters = new List<UBotParameterDefinition>();
        private string _returnValue;

        public void Execute(IUBotStudio ubotStudio, Dictionary<string, string> parameters)
        {
            this._returnValue = DateTime.Now.ToString("dddd");
        }

        public string Category
        {
            get
            {
                return "Time Functions";
            }
        }

        public string FunctionName
        {
            get
            {
                return "$currentweekday";
            }
        }

        public IEnumerable<UBotParameterDefinition> ParameterDefinitions
        {
            get
            {
                return this._parameters;
            }
        }

        public object ReturnValue
        {
            get
            {
                return this._returnValue;
            }
        }

        public UBotType ReturnValueType
        {
            get
            {
                return UBotType.String;
            }
        }

        public UBotPlugin.UBotVersion UBotVersion
        {
            get
            {
                return UBotPlugin.UBotVersion.Standard;
            }
        }
    }
}

