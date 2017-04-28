namespace time
{
    using System;
    using System.Collections.Generic;
    using UBotPlugin;

    public class currentmonthdays : IUBotFunction
    {
        private List<UBotParameterDefinition> _parameters = new List<UBotParameterDefinition>();
        private string _returnValue;

        public void Execute(IUBotStudio ubotStudio, Dictionary<string, string> parameters)
        {
            
            int year = DateTime.Now.Year;
            int month = DateTime.Today.Month;
            string days_in_month = DateTime.DaysInMonth(year, month).ToString();

            this._returnValue = days_in_month;
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
                return "$currentmonth days";
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

