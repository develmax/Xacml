namespace Xacml.Elements.Function.Bag
{
    using Xacml.Types.Web;

    public class DayTimeDurationBagSize : BagSize
    {
        public const string stringIdentifer = "urn:oasis:names:tc:xacml:1.0:function:dayTimeDuration-bag-size";
        internal static readonly URI URIID = URI.Create(stringIdentifer);

        internal override string StringIdentifer
        {
            get { return stringIdentifer; }
        }

        public override URI Identifier
        {
            get { return URIID; }
        }
    }
}