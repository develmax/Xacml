namespace Xacml.CombiningAlgorithm.V30
{
    using Xacml.Elements.Context;
    using Xacml.Elements.Policy;

    public class CombingAlgorithmPolicyDenyUnlessPermit30 : ICombiningAlgorithm
    {
        public const string Identifer = "urn:oasis:names:tc:xacml:3.0:policy-combining-algorithm:deny-unless-permit";

        #region ICombiningAlgorithm Members

        public void Evaluate(EvaluationContext ctx, IPolicyLanguageModel[] evals, string ID)
        {
            if (ctx.GetResult(ID).HasDecision())
            {
                return;
            }

            for (int i = 0; i < evals.Length; i++)
            {
                evals[i].Evaluate(ctx, ID);
                Decision _Decision = ctx.GetResult(evals[i].ElementId).Decision;

                if (_Decision.IsPermit)
                {
                    ctx.GetResult(ID).Decision = Decision.Permit;
                    ctx.GetResult(ID).PassObligationsAndAdvices(ctx.GetResult(evals[i].ElementId));
                    return;
                }
            }
            ctx.GetResult(ID).Decision = Decision.Deny;
        }

        #endregion
    }
}