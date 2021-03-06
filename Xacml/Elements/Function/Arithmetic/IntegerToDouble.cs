namespace Xacml.Elements.Function.Arithmetic
{
    using System;

    using Xacml.Elements.Context;
    using Xacml.Elements.DataType;
    using Xacml.Exceptions;
    using Xacml.Types.Streams;
    using Xacml.Types.Web;
    using Xacml.Utils;

    public class IntegerToDouble : Function
    {
        public const string stringIdentifer = "urn:oasis:names:tc:xacml:1.0:function:integer-to-double";
        internal const int paramsnum = 1;
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
            if (@params.Length == paramsnum && @params[0] is IntegerDataType)
            {
                double res = ((IntegerDataType)@params[0]).Integer;
                return new DoubleDataType(Convert.ToString(res));
            }
            throw new IllegalExpressionEvaluationException(stringIdentifer);
        }
    }
}