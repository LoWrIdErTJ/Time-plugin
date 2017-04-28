namespace time
{
    using System;
    using System.Collections.Generic;
    using UBotPlugin;

    public class previousyear : IUBotFunction
    {
        private List<UBotParameterDefinition> _parameters = new List<UBotParameterDefinition>();
        private string _returnValue;

        public void Execute(IUBotStudio ubotStudio, Dictionary<string, string> parameters)
        {
            string year = DateTime.Now.ToString("yyyy");
            int curYear = Convert.ToInt32(year);
            int lastYear = curYear - 1;
            this._returnValue = lastYear.ToString();
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
                return "$previousyear";
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

