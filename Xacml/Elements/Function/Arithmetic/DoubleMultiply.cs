namespace Xacml.Elements.Function.Arithmetic
{
    using System;

    using Xacml.Elements.Context;
    using Xacml.Elements.DataType;
    using Xacml.Exceptions;
    using Xacml.Types.Streams;
    using Xacml.Types.Web;
    using Xacml.Utils;

    public class DoubleMultiply : Function
    {
        public const string stringIdentifer = "urn:oasis:names:tc:xacml:1.0:function:double-multiply";
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
            double result = 1.0;
            int size = @params.Length;
            if (size >= paramsnum)
            {
                for (int i = 0; i < size; i++)
                {
                    result *= ((DoubleDataType)@params[i]).Double;
                }
                return new DoubleDataType(Convert.ToString(result));
            }
            throw new IllegalExpressionEvaluationException(stringIdentifer);
        }
    }
}