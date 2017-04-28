namespace time
{
    using System;
    using System.Collections.Generic;
    using UBotPlugin;

    public class linuxtimestamp : IUBotFunction
    {
        private List<UBotParameterDefinition> _parameters = new List<UBotParameterDefinition>();
        private string _returnValue;

        public void Execute(IUBotStudio ubotStudio, Dictionary<string, string> parameters)
        {
            TimeSpan timeSpan = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0);
            long unixVersion = (long)ConvertToUnixTimestamp(DateTime.Now);


            this._returnValue = unixVersion.ToString();
        }

        public static double ConvertToUnixTimestamp(DateTime value)
        {
            var span = (value - new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime());
            return span.TotalSeconds;
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
                return "$linuxtimestamp";
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

