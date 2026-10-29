using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.WAFRegional;
using Amazon.WAFRegional.Model;

namespace AWSSDKDocSamples.Amazon.WAFRegional.Generated
{
    class WAFRegionalSamples : ISample
    {
        public void WAFRegionalCreateIPSet()
        {
            #region CreateIPSet-1

            var client = new AmazonWAFRegionalClient();
            var response = client.CreateIPSet(new CreateIPSetRequest
            {
                ChangeToken = "abcd12f2-46da-4fdb-b8d5-fbd4c466928f",
                Name = "MyIPSetFriendlyName"
            });

            string changeToken = response.ChangeToken;
            IPSet ipSet = response.IPSet;

            #endregion
        }

        public void WAFRegionalCreateRule()
        {
            #region CreateRule-1

            var client = new AmazonWAFRegionalClient();
            var response = client.CreateRule(new CreateRuleRequest
            {
                ChangeToken = "abcd12f2-46da-4fdb-b8d5-fbd4c466928f",
                MetricName = "WAFByteHeaderRule",
                Name = "WAFByteHeaderRule"
            });

            string changeToken = response.ChangeToken;
            Rule rule = response.Rule;

            #endregion
        }

        public void WAFRegionalCreateSizeConstraintSet()
        {
            #region CreateSizeConstraintSet-1

            var client = new AmazonWAFRegionalClient();
            var response = client.CreateSizeConstraintSet(new CreateSizeConstraintSetRequest
            {
                ChangeToken = "abcd12f2-46da-4fdb-b8d5-fbd4c466928f",
                Name = "MySampleSizeConstraintSet"
            });

            string changeToken = response.ChangeToken;
            SizeConstraintSet sizeConstraintSet = response.SizeConstraintSet;

            #endregion
        }

        public void WAFRegionalCreateSqlInjectionMatchSet()
        {
            #region CreateSqlInjectionMatchSet-1

            var client = new AmazonWAFRegionalClient();
            var response = client.CreateSqlInjectionMatchSet(new CreateSqlInjectionMatchSetRequest
            {
                ChangeToken = "abcd12f2-46da-4fdb-b8d5-fbd4c466928f",
                Name = "MySQLInjectionMatchSet"
            });

            string changeToken = response.ChangeToken;
            SqlInjectionMatchSet sqlInjectionMatchSet = response.SqlInjectionMatchSet;

            #endregion
        }

        public void WAFRegionalCreateWebACL()
        {
            #region CreateWebACL-1

            var client = new AmazonWAFRegionalClient();
            var response = client.CreateWebACL(new CreateWebACLRequest
            {
                ChangeToken = "abcd12f2-46da-4fdb-b8d5-fbd4c466928f",
                DefaultAction = new WafAction { Type = "ALLOW" },
                MetricName = "CreateExample",
                Name = "CreateExample"
            });

            string changeToken = response.ChangeToken;
            WebACL webACL = response.WebACL;

            #endregion
        }

        public void WAFRegionalCreateXssMatchSet()
        {
            #region CreateXssMatchSet-1

            var client = new AmazonWAFRegionalClient();
            var response = client.CreateXssMatchSet(new CreateXssMatchSetRequest
            {
                ChangeToken = "abcd12f2-46da-4fdb-b8d5-fbd4c466928f",
                Name = "MySampleXssMatchSet"
            });

            string changeToken = response.ChangeToken;
            XssMatchSet xssMatchSet = response.XssMatchSet;

            #endregion
        }

        public void WAFRegionalDeleteByteMatchSet()
        {
            #region DeleteByteMatchSet-1

            var client = new AmazonWAFRegionalClient();
            var response = client.DeleteByteMatchSet(new DeleteByteMatchSetRequest
            {
                ByteMatchSetId = "exampleIDs3t-46da-4fdb-b8d5-abc321j569j5",
                ChangeToken = "abcd12f2-46da-4fdb-b8d5-fbd4c466928f"
            });

            string changeToken = response.ChangeToken;

            #endregion
        }

        public void WAFRegionalDeleteIPSet()
        {
            #region DeleteIPSet-1

            var client = new AmazonWAFRegionalClient();
            var response = client.DeleteIPSet(new DeleteIPSetRequest
            {
                ChangeToken = "abcd12f2-46da-4fdb-b8d5-fbd4c466928f",
                IPSetId = "example1ds3t-46da-4fdb-b8d5-abc321j569j5"
            });

            string changeToken = response.ChangeToken;

            #endregion
        }

        public void WAFRegionalDeleteRule()
        {
            #region DeleteRule-1

            var client = new AmazonWAFRegionalClient();
            var response = client.DeleteRule(new DeleteRuleRequest
            {
                ChangeToken = "abcd12f2-46da-4fdb-b8d5-fbd4c466928f",
                RuleId = "WAFRule-1-Example"
            });

            string changeToken = response.ChangeToken;

            #endregion
        }

        public void WAFRegionalDeleteSizeConstraintSet()
        {
            #region DeleteSizeConstraintSet-1

            var client = new AmazonWAFRegionalClient();
            var response = client.DeleteSizeConstraintSet(new DeleteSizeConstraintSetRequest
            {
                ChangeToken = "abcd12f2-46da-4fdb-b8d5-fbd4c466928f",
                SizeConstraintSetId = "example1ds3t-46da-4fdb-b8d5-abc321j569j5"
            });

            string changeToken = response.ChangeToken;

            #endregion
        }

        public void WAFRegionalDeleteSqlInjectionMatchSet()
        {
            #region DeleteSqlInjectionMatchSet-1

            var client = new AmazonWAFRegionalClient();
            var response = client.DeleteSqlInjectionMatchSet(new DeleteSqlInjectionMatchSetRequest
            {
                ChangeToken = "abcd12f2-46da-4fdb-b8d5-fbd4c466928f",
                SqlInjectionMatchSetId = "example1ds3t-46da-4fdb-b8d5-abc321j569j5"
            });

            string changeToken = response.ChangeToken;

            #endregion
        }

        public void WAFRegionalDeleteWebACL()
        {
            #region DeleteWebACL-1

            var client = new AmazonWAFRegionalClient();
            var response = client.DeleteWebACL(new DeleteWebACLRequest
            {
                ChangeToken = "abcd12f2-46da-4fdb-b8d5-fbd4c466928f",
                WebACLId = "example-46da-4444-5555-example"
            });

            string changeToken = response.ChangeToken;

            #endregion
        }

        public void WAFRegionalDeleteXssMatchSet()
        {
            #region DeleteXssMatchSet-1

            var client = new AmazonWAFRegionalClient();
            var response = client.DeleteXssMatchSet(new DeleteXssMatchSetRequest
            {
                ChangeToken = "abcd12f2-46da-4fdb-b8d5-fbd4c466928f",
                XssMatchSetId = "example1ds3t-46da-4fdb-b8d5-abc321j569j5"
            });

            string changeToken = response.ChangeToken;

            #endregion
        }

        public void WAFRegionalGetByteMatchSet()
        {
            #region GetByteMatchSet-1

            var client = new AmazonWAFRegionalClient();
            var response = client.GetByteMatchSet(new GetByteMatchSetRequest
            {
                ByteMatchSetId = "exampleIDs3t-46da-4fdb-b8d5-abc321j569j5"
            });

            ByteMatchSet byteMatchSet = response.ByteMatchSet;

            #endregion
        }

        public void WAFRegionalGetChangeToken()
        {
            #region GetChangeToken-1

            var client = new AmazonWAFRegionalClient();
            var response = client.GetChangeToken(new GetChangeTokenRequest
            {
            });

            string changeToken = response.ChangeToken;

            #endregion
        }

        public void WAFRegionalGetChangeTokenStatus()
        {
            #region GetChangeTokenStatus-1

            var client = new AmazonWAFRegionalClient();
            var response = client.GetChangeTokenStatus(new GetChangeTokenStatusRequest
            {
                ChangeToken = "abcd12f2-46da-4fdb-b8d5-fbd4c466928f"
            });

            ChangeTokenStatus changeTokenStatus = response.ChangeTokenStatus;

            #endregion
        }

        public void WAFRegionalGetIPSet()
        {
            #region GetIPSet-1

            var client = new AmazonWAFRegionalClient();
            var response = client.GetIPSet(new GetIPSetRequest
            {
                IPSetId = "example1ds3t-46da-4fdb-b8d5-abc321j569j5"
            });

            IPSet ipSet = response.IPSet;

            #endregion
        }

        public void WAFRegionalGetRule()
        {
            #region GetRule-1

            var client = new AmazonWAFRegionalClient();
            var response = client.GetRule(new GetRuleRequest
            {
                RuleId = "example1ds3t-46da-4fdb-b8d5-abc321j569j5"
            });

            Rule rule = response.Rule;

            #endregion
        }

        public void WAFRegionalGetSizeConstraintSet()
        {
            #region GetSizeConstraintSet-1

            var client = new AmazonWAFRegionalClient();
            var response = client.GetSizeConstraintSet(new GetSizeConstraintSetRequest
            {
                SizeConstraintSetId = "example1ds3t-46da-4fdb-b8d5-abc321j569j5"
            });

            SizeConstraintSet sizeConstraintSet = response.SizeConstraintSet;

            #endregion
        }

        public void WAFRegionalGetSqlInjectionMatchSet()
        {
            #region GetSqlInjectionMatchSet-1

            var client = new AmazonWAFRegionalClient();
            var response = client.GetSqlInjectionMatchSet(new GetSqlInjectionMatchSetRequest
            {
                SqlInjectionMatchSetId = "example1ds3t-46da-4fdb-b8d5-abc321j569j5"
            });

            SqlInjectionMatchSet sqlInjectionMatchSet = response.SqlInjectionMatchSet;

            #endregion
        }

        public void WAFRegionalGetWebACL()
        {
            #region GetWebACL-1

            var client = new AmazonWAFRegionalClient();
            var response = client.GetWebACL(new GetWebACLRequest
            {
                WebACLId = "createwebacl-1472061481310"
            });

            WebACL webACL = response.WebACL;

            #endregion
        }

        public void WAFRegionalGetXssMatchSet()
        {
            #region GetXssMatchSet-1

            var client = new AmazonWAFRegionalClient();
            var response = client.GetXssMatchSet(new GetXssMatchSetRequest
            {
                XssMatchSetId = "example1ds3t-46da-4fdb-b8d5-abc321j569j5"
            });

            XssMatchSet xssMatchSet = response.XssMatchSet;

            #endregion
        }

        public void WAFRegionalListIPSets()
        {
            #region ListIPSets-1

            var client = new AmazonWAFRegionalClient();
            var response = client.ListIPSets(new ListIPSetsRequest
            {
                Limit = 100
            });

            List<IPSetSummary> ipSets = response.IPSets;

            #endregion
        }

        public void WAFRegionalListRules()
        {
            #region ListRules-1

            var client = new AmazonWAFRegionalClient();
            var response = client.ListRules(new ListRulesRequest
            {
                Limit = 100
            });

            List<RuleSummary> rules = response.Rules;

            #endregion
        }

        public void WAFRegionalListSizeConstraintSets()
        {
            #region ListSizeConstraintSets-1

            var client = new AmazonWAFRegionalClient();
            var response = client.ListSizeConstraintSets(new ListSizeConstraintSetsRequest
            {
                Limit = 100
            });

            List<SizeConstraintSetSummary> sizeConstraintSets = response.SizeConstraintSets;

            #endregion
        }

        public void WAFRegionalListSqlInjectionMatchSets()
        {
            #region ListSqlInjectionMatchSets-1

            var client = new AmazonWAFRegionalClient();
            var response = client.ListSqlInjectionMatchSets(new ListSqlInjectionMatchSetsRequest
            {
                Limit = 100
            });

            List<SqlInjectionMatchSetSummary> sqlInjectionMatchSets = response.SqlInjectionMatchSets;

            #endregion
        }

        public void WAFRegionalListWebACLs()
        {
            #region ListWebACLs-1

            var client = new AmazonWAFRegionalClient();
            var response = client.ListWebACLs(new ListWebACLsRequest
            {
                Limit = 100
            });

            List<WebACLSummary> webACLs = response.WebACLs;

            #endregion
        }

        public void WAFRegionalListXssMatchSets()
        {
            #region ListXssMatchSets-1

            var client = new AmazonWAFRegionalClient();
            var response = client.ListXssMatchSets(new ListXssMatchSetsRequest
            {
                Limit = 100
            });

            List<XssMatchSetSummary> xssMatchSets = response.XssMatchSets;

            #endregion
        }

        public void WAFRegionalUpdateByteMatchSet()
        {
            #region UpdateByteMatchSet-1

            var client = new AmazonWAFRegionalClient();
            var response = client.UpdateByteMatchSet(new UpdateByteMatchSetRequest
            {
                ByteMatchSetId = "exampleIDs3t-46da-4fdb-b8d5-abc321j569j5",
                ChangeToken = "abcd12f2-46da-4fdb-b8d5-fbd4c466928f",
                Updates = new List<ByteMatchSetUpdate> {
                    new ByteMatchSetUpdate {
                        Action = "DELETE",
                        ByteMatchTuple = new ByteMatchTuple {
                            FieldToMatch = new FieldToMatch {
                                Data = "referer",
                                Type = "HEADER"
                            },
                            PositionalConstraint = "CONTAINS",
                            TextTransformation = "NONE"
                        }
                    }
                }
            });

            string changeToken = response.ChangeToken;

            #endregion
        }

        public void WAFRegionalUpdateIPSet()
        {
            #region UpdateIPSet-1

            var client = new AmazonWAFRegionalClient();
            var response = client.UpdateIPSet(new UpdateIPSetRequest
            {
                ChangeToken = "abcd12f2-46da-4fdb-b8d5-fbd4c466928f",
                IPSetId = "example1ds3t-46da-4fdb-b8d5-abc321j569j5",
                Updates = new List<IPSetUpdate> {
                    new IPSetUpdate {
                        Action = "DELETE",
                        IPSetDescriptor = new IPSetDescriptor {
                            Type = "IPV4",
                            Value = "192.0.2.44/32"
                        }
                    }
                }
            });

            string changeToken = response.ChangeToken;

            #endregion
        }

        public void WAFRegionalUpdateRule()
        {
            #region UpdateRule-1

            var client = new AmazonWAFRegionalClient();
            var response = client.UpdateRule(new UpdateRuleRequest
            {
                ChangeToken = "abcd12f2-46da-4fdb-b8d5-fbd4c466928f",
                RuleId = "example1ds3t-46da-4fdb-b8d5-abc321j569j5",
                Updates = new List<RuleUpdate> {
                    new RuleUpdate {
                        Action = "DELETE",
                        Predicate = new Predicate {
                            DataId = "MyByteMatchSetID",
                            Negated = false,
                            Type = "ByteMatch"
                        }
                    }
                }
            });

            string changeToken = response.ChangeToken;

            #endregion
        }

        public void WAFRegionalUpdateSizeConstraintSet()
        {
            #region UpdateSizeConstraintSet-1

            var client = new AmazonWAFRegionalClient();
            var response = client.UpdateSizeConstraintSet(new UpdateSizeConstraintSetRequest
            {
                ChangeToken = "abcd12f2-46da-4fdb-b8d5-fbd4c466928f",
                SizeConstraintSetId = "example1ds3t-46da-4fdb-b8d5-abc321j569j5",
                Updates = new List<SizeConstraintSetUpdate> {
                    new SizeConstraintSetUpdate {
                        Action = "DELETE",
                        SizeConstraint = new SizeConstraint {
                            ComparisonOperator = "GT",
                            FieldToMatch = new FieldToMatch { Type = "QUERY_STRING" },
                            Size = 0,
                            TextTransformation = "NONE"
                        }
                    }
                }
            });

            string changeToken = response.ChangeToken;

            #endregion
        }

        public void WAFRegionalUpdateSqlInjectionMatchSet()
        {
            #region UpdateSqlInjectionMatchSet-1

            var client = new AmazonWAFRegionalClient();
            var response = client.UpdateSqlInjectionMatchSet(new UpdateSqlInjectionMatchSetRequest
            {
                ChangeToken = "abcd12f2-46da-4fdb-b8d5-fbd4c466928f",
                SqlInjectionMatchSetId = "example1ds3t-46da-4fdb-b8d5-abc321j569j5",
                Updates = new List<SqlInjectionMatchSetUpdate> {
                    new SqlInjectionMatchSetUpdate {
                        Action = "DELETE",
                        SqlInjectionMatchTuple = new SqlInjectionMatchTuple {
                            FieldToMatch = new FieldToMatch { Type = "QUERY_STRING" },
                            TextTransformation = "URL_DECODE"
                        }
                    }
                }
            });

            string changeToken = response.ChangeToken;

            #endregion
        }

        public void WAFRegionalUpdateWebACL()
        {
            #region UpdateWebACL-1

            var client = new AmazonWAFRegionalClient();
            var response = client.UpdateWebACL(new UpdateWebACLRequest
            {
                ChangeToken = "abcd12f2-46da-4fdb-b8d5-fbd4c466928f",
                DefaultAction = new WafAction { Type = "ALLOW" },
                Updates = new List<WebACLUpdate> {
                    new WebACLUpdate {
                        Action = "DELETE",
                        ActivatedRule = new ActivatedRule {
                            Action = new WafAction { Type = "ALLOW" },
                            Priority = 1,
                            RuleId = "WAFRule-1-Example"
                        }
                    }
                },
                WebACLId = "webacl-1472061481310"
            });

            string changeToken = response.ChangeToken;

            #endregion
        }

        public void WAFRegionalUpdateXssMatchSet()
        {
            #region UpdateXssMatchSet-1

            var client = new AmazonWAFRegionalClient();
            var response = client.UpdateXssMatchSet(new UpdateXssMatchSetRequest
            {
                ChangeToken = "abcd12f2-46da-4fdb-b8d5-fbd4c466928f",
                Updates = new List<XssMatchSetUpdate> {
                    new XssMatchSetUpdate {
                        Action = "DELETE",
                        XssMatchTuple = new XssMatchTuple {
                            FieldToMatch = new FieldToMatch { Type = "QUERY_STRING" },
                            TextTransformation = "URL_DECODE"
                        }
                    }
                },
                XssMatchSetId = "example1ds3t-46da-4fdb-b8d5-abc321j569j5"
            });

            string changeToken = response.ChangeToken;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
