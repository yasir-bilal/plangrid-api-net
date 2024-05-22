using System;
using System.Reflection;
using Refit;

namespace PlanGrid.Api.JsonConverters
{
    public class DateUrlParameterFormatter : BaseUrlParameterFormatter
    {
        public override bool CanFormat(object argument, ParameterInfo parameter)
        {
            return argument is DateTime;
        }

        public override string Format(object value, ParameterInfo parameterInfo)
        {
            return ((DateTime)value).ToString("yyyy-MM-ddTHH\\:mm\\:ss");
        }
    }
}
