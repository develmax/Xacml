namespace Xacml.Elements.Function.Equal
{
    using Xacml.Elements.Context;
    using Xacml.Elements.DataType;
    using Xacml.Exceptions;
    using Xacml.Types.Streams;
    using Xacml.Types.Web;
    using Xacml.Utils;

    public class TimeEqual : Function
    {
        public const string stringIdentifer = "urn:oasis:names:tc:xacml:1.0:function:time-equal";
        internal const int paramsnum = 2;
        internal static readonly URI URIID = URI.Create(stringIdentifer);

        public override URI Identifier
        {
            get { return URIID; }
        }

        public override void Encode(OutputStream output, Indentation indenter)
        {
            throw new UnsupportedOperationException("Not supported yet.");
        }

        public override DataTypeValue Evaluate(DataTypeValue[] @params, EvaluationContext ctx)
        {
            if (@params.Length == paramsnum)
            {
                if (@params[0].Equals(@params[1])) return BooleanDataType.True;
                else return BooleanDataType.False;
            }
            throw new IllegalExpressionEvaluationException(stringIdentifer);
        }
    }
}