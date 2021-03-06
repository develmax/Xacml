namespace Xacml.Elements.Function.Bag
{
    using Xacml.Types.Web;

    public class DnsNameBagSize : BagSize
    {
        public const string stringIdentifer = "urn:oasis:names:tc:xacml:2.0:function:dnsName-bag-size";
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