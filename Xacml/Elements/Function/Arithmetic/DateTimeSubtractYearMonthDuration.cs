namespace Xacml.Elements.Function.Arithmetic
{
    using Xacml.Elements.Context;
    using Xacml.Elements.DataType;
    using Xacml.Exceptions;
    using Xacml.Types.Date;
    using Xacml.Types.Streams;
    using Xacml.Types.Web;
    using Xacml.Utils;

    public class DateTimeSubtractYearMonthDuration : Function
    {
        public const string stringIdentifer =
            "urn:oasis:names:tc:xacml:3.0:function:dateTime-subtract-yearMonthDurationn";

        internal const int paramsnum = 2;
        internal static readonly URI URIID = URI.Create(stringIdentifer);

        public override URI Identifier
        {
            get { throw new UnsupportedOperationException("Not supported yet."); }
        }

        public override void Encode(OutputStream output, Indentation indenter)
        {
            throw new UnsupportedOperationException("Not supported yet.");
        }

        public override DataTypeValue Evaluate(DataTypeValue[] @params, EvaluationContext ctx)
        {
            if (@params.Length == paramsnum && @params[0] is DateTimeDataType && @params[1] is YearMonthDurationDataType)
            {
                var datetime = new DateTimeDataType(((DateTimeDataType)@params[0]));
                Calendar cal = datetime.Calendar;
                var period = (YearMonthDurationDataType)@params[1];
                cal.add(Calendar.YEAR, -period.Year);
                cal.add(Calendar.MONTH, -period.Month);
                return datetime;
            }
            throw new IllegalExpressionEvaluationException(stringIdentifer);
        }
    }
}