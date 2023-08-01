using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.WAF;
using Amazon.WAF.Model;

namespace AWSSDKDocSamples.Amazon.WAF.Generated
{
    class WAFSamples : ISample
    {
        public void WAFCreateIPSet()
        {
            #region createipset-1472501003122

            var client = new AmazonWAFClient();
            var response = client.CreateIPSet(new CreateIPSetRequest 
            {
                ChangeToken = "abcd12f2-46da-4fdb-b8d5-fbd4c466928f",
                Name = "MyIPSetFriendlyName"
            });

            string changeToken = response.ChangeToken;
            IPSet ipSet = response.IPSet;

            #endregion
        }

        public void WAFCreateRule()
        {
            #region createrule-1474072675555

            var client = new AmazonWAFClient();
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

        public void WAFCreateSizeConstraintSet()
        {
            #region createsizeconstraint-1474299140754

            var client = new AmazonWAFClient();
            var response = client.CreateSizeConstraintSet(new CreateSizeConstraintSetRequest 
            {
                ChangeToken = "abcd12f2-46da-4fdb-b8d5-fbd4c466928f",
                Name = "MySampleSizeConstraintSet"
            });

            string changeToken = response.ChangeToken;
            SizeConstraintSet sizeConstraintSet = response.SizeConstraintSet;

            #endregion
        }

        public void WAFCreateSqlInjectionMatchSet()
        {
            #region createsqlinjectionmatchset-1474492796105

            var client = new AmazonWAFClient();
            var response = client.CreateSqlInjectionMatchSet(new CreateSqlInjectionMatchSetRequest 
            {
                ChangeToken = "abcd12f2-46da-4fdb-b8d5-fbd4c466928f",
                Name = "MySQLInjectionMatchSet"
            });

            string changeToken = response.ChangeToken;
            SqlInjectionMatchSet sqlInjectionMatchSet = response.SqlInjectionMatchSet;

            #endregion
        }

        public void WAFCreateWebACL()
        {
            #region createwebacl-1472061481310

            var client = new AmazonWAFClient();
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

        public void WAFCreateXssMatchSet()
        {
            #region createxssmatchset-1474560868500

            var client = new AmazonWAFClient();
            var response = client.CreateXssMatchSet(new CreateXssMatchSetRequest 
            {
                ChangeToken = "abcd12f2-46da-4fdb-b8d5-fbd4c466928f",
                Name = "MySampleXssMatchSet"
            });

            string changeToken = response.ChangeToken;
            XssMatchSet xssMatchSet = response.XssMatchSet;

            #endregion
        }

        public void WAFDeleteByteMatchSet()
        {
            #region deletebytematchset-1473367566229

            var client = new AmazonWAFClient();
            var response = client.DeleteByteMatchSet(new DeleteByteMatchSetRequest 
            {
                ByteMatchSetId = "exampleIDs3t-46da-4fdb-b8d5-abc321j569j5",
                ChangeToken = "abcd12f2-46da-4fdb-b8d5-fbd4c466928f"
            });

            string changeToken = response.ChangeToken;

            #endregion
        }

        public void WAFDeleteIPSet()
        {
            #region deleteipset-1472767434306

            var client = new AmazonWAFClient();
            var response = client.DeleteIPSet(new DeleteIPSetRequest 
            {
                ChangeToken = "abcd12f2-46da-4fdb-b8d5-fbd4c466928f",
                IPSetId = "example1ds3t-46da-4fdb-b8d5-abc321j569j5"
            });

            string changeToken = response.ChangeToken;

            #endregion
        }

        public void WAFDeleteRule()
        {
            #region deleterule-1474073108749

            var client = new AmazonWAFClient();
            var response = client.DeleteRule(new DeleteRuleRequest 
            {
                ChangeToken = "abcd12f2-46da-4fdb-b8d5-fbd4c466928f",
                RuleId = "WAFRule-1-Example"
            });

            string changeToken = response.ChangeToken;

            #endregion
        }

        public void WAFDeleteSizeConstraintSet()
        {
            #region deletesizeconstraintset-1474299857905

            var client = new AmazonWAFClient();
            var response = client.DeleteSizeConstraintSet(new DeleteSizeConstraintSetRequest 
            {
                ChangeToken = "abcd12f2-46da-4fdb-b8d5-fbd4c466928f",
                SizeConstraintSetId = "example1ds3t-46da-4fdb-b8d5-abc321j569j5"
            });

            string changeToken = response.ChangeToken;

            #endregion
        }

        public void WAFDeleteSqlInjectionMatchSet()
        {
            #region deletesqlinjectionmatchset-1474493373197

            var client = new AmazonWAFClient();
            var response = client.DeleteSqlInjectionMatchSet(new DeleteSqlInjectionMatchSetRequest 
            {
                ChangeToken = "abcd12f2-46da-4fdb-b8d5-fbd4c466928f",
                SqlInjectionMatchSetId = "example1ds3t-46da-4fdb-b8d5-abc321j569j5"
            });

            string changeToken = response.ChangeToken;

            #endregion
        }

        public void WAFDeleteWebACL()
        {
            #region deletewebacl-1472767755931

            var client = new AmazonWAFClient();
            var response = client.DeleteWebACL(new DeleteWebACLRequest 
            {
                ChangeToken = "abcd12f2-46da-4fdb-b8d5-fbd4c466928f",
                WebACLId = "example-46da-4444-5555-example"
            });

            string changeToken = response.ChangeToken;

            #endregion
        }

        public void WAFDeleteXssMatchSet()
        {
            #region deletexssmatchset-1474561302618

            var client = new AmazonWAFClient();
            var response = client.DeleteXssMatchSet(new DeleteXssMatchSetRequest 
            {
                ChangeToken = "abcd12f2-46da-4fdb-b8d5-fbd4c466928f",
                XssMatchSetId = "example1ds3t-46da-4fdb-b8d5-abc321j569j5"
            });

            string changeToken = response.ChangeToken;

            #endregion
        }

        public void WAFGetByteMatchSet()
        {
            #region getbytematchset-1473273311532

            var client = new AmazonWAFClient();
            var response = client.GetByteMatchSet(new GetByteMatchSetRequest 
            {
                ByteMatchSetId = "exampleIDs3t-46da-4fdb-b8d5-abc321j569j5"
            });

            ByteMatchSet byteMatchSet = response.ByteMatchSet;

            #endregion
        }

        public void WAFGetChangeToken()
        {
            #region get-change-token-example-1471635120794

            var client = new AmazonWAFClient();
            var response = client.GetChangeToken(new GetChangeTokenRequest 
            {
            });

            string changeToken = response.ChangeToken;

            #endregion
        }

        public void WAFGetChangeTokenStatus()
        {
            #region getchangetokenstatus-1474658417107

            var client = new AmazonWAFClient();
            var response = client.GetChangeTokenStatus(new GetChangeTokenStatusRequest 
            {
                ChangeToken = "abcd12f2-46da-4fdb-b8d5-fbd4c466928f"
            });

            string changeTokenStatus = response.ChangeTokenStatus;

            #endregion
        }

        public void WAFGetIPSet()
        {
            #region getipset-1474658688675

            var client = new AmazonWAFClient();
            var response = client.GetIPSet(new GetIPSetRequest 
            {
                IPSetId = "example1ds3t-46da-4fdb-b8d5-abc321j569j5"
            });

            IPSet ipSet = response.IPSet;

            #endregion
        }

        public void WAFGetRule()
        {
            #region getrule-1474659238790

            var client = new AmazonWAFClient();
            var response = client.GetRule(new GetRuleRequest 
            {
                RuleId = "example1ds3t-46da-4fdb-b8d5-abc321j569j5"
            });

            Rule rule = response.Rule;

            #endregion
        }

        public void WAFGetSampledRequests()
        {
            #region getsampledrequests-1474927997195

            var client = new AmazonWAFClient();
            var response = client.GetSampledRequests(new GetSampledRequestsRequest 
            {
                MaxItems = 100,
                RuleId = "WAFRule-1-Example",
                TimeWindow = new TimeWindow {
                    EndTime = new DateTime(2016, 9, 27, 3, 50, 0, DateTimeKind.Utc),
                    StartTime = new DateTime(2016, 9, 27, 3, 50, 0, DateTimeKind.Utc)
                },
                WebAclId = "createwebacl-1472061481310"
            });

            long populationSize = response.PopulationSize;
            List<SampledHTTPRequest> sampledRequests = response.SampledRequests;
            TimeWindow timeWindow = response.TimeWindow;

            #endregion
        }

        public void WAFGetSizeConstraintSet()
        {
            #region getsizeconstraintset-1475005422493

            var client = new AmazonWAFClient();
            var response = client.GetSizeConstraintSet(new GetSizeConstraintSetRequest 
            {
                SizeConstraintSetId = "example1ds3t-46da-4fdb-b8d5-abc321j569j5"
            });

            SizeConstraintSet sizeConstraintSet = response.SizeConstraintSet;

            #endregion
        }

        public void WAFGetSqlInjectionMatchSet()
        {
            #region getsqlinjectionmatchset-1475005940137

            var client = new AmazonWAFClient();
            var response = client.GetSqlInjectionMatchSet(new GetSqlInjectionMatchSetRequest 
            {
                SqlInjectionMatchSetId = "example1ds3t-46da-4fdb-b8d5-abc321j569j5"
            });

            SqlInjectionMatchSet sqlInjectionMatchSet = response.SqlInjectionMatchSet;

            #endregion
        }

        public void WAFGetWebACL()
        {
            #region getwebacl-1475006348525

            var client = new AmazonWAFClient();
            var response = client.GetWebACL(new GetWebACLRequest 
            {
                WebACLId = "createwebacl-1472061481310"
            });

            WebACL webACL = response.WebACL;

            #endregion
        }

        public void WAFGetXssMatchSet()
        {
            #region getxssmatchset-1475187879017

            var client = new AmazonWAFClient();
            var response = client.GetXssMatchSet(new GetXssMatchSetRequest 
            {
                XssMatchSetId = "example1ds3t-46da-4fdb-b8d5-abc321j569j5"
            });

            XssMatchSet xssMatchSet = response.XssMatchSet;

            #endregion
        }

        public void WAFListIPSets()
        {
            #region listipsets-1472235676229

            var client = new AmazonWAFClient();
            var response = client.ListIPSets(new ListIPSetsRequest 
            {
                Limit = 100
            });

            List<IPSetSummary> ipSets = response.IPSets;

            #endregion
        }

        public void WAFListRules()
        {
            #region listrules-1475258406433

            var client = new AmazonWAFClient();
            var response = client.ListRules(new ListRulesRequest 
            {
                Limit = 100
            });

            List<RuleSummary> rules = response.Rules;

            #endregion
        }

        public void WAFListSizeConstraintSets()
        {
            #region listsizeconstraintsets-1474300067597

            var client = new AmazonWAFClient();
            var response = client.ListSizeConstraintSets(new ListSizeConstraintSetsRequest 
            {
                Limit = 100
            });

            List<SizeConstraintSetSummary> sizeConstraintSets = response.SizeConstraintSets;

            #endregion
        }

        public void WAFListSqlInjectionMatchSets()
        {
            #region listsqlinjectionmatchset-1474493560103

            var client = new AmazonWAFClient();
            var response = client.ListSqlInjectionMatchSets(new ListSqlInjectionMatchSetsRequest 
            {
                Limit = 100
            });

            List<SqlInjectionMatchSetSummary> sqlInjectionMatchSets = response.SqlInjectionMatchSets;

            #endregion
        }

        public void WAFListWebACLs()
        {
            #region listwebacls-1475258732691

            var client = new AmazonWAFClient();
            var response = client.ListWebACLs(new ListWebACLsRequest 
            {
                Limit = 100
            });

            List<WebACLSummary> webACLs = response.WebACLs;

            #endregion
        }

        public void WAFListXssMatchSets()
        {
            #region listxssmatchsets-1474561481168

            var client = new AmazonWAFClient();
            var response = client.ListXssMatchSets(new ListXssMatchSetsRequest 
            {
                Limit = 100
            });

            List<XssMatchSetSummary> xssMatchSets = response.XssMatchSets;

            #endregion
        }

        public void WAFUpdateByteMatchSet()
        {
            #region updatebytematchset-1475259074558

            var client = new AmazonWAFClient();
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

        public void WAFUpdateIPSet()
        {
            #region updateipset-1475259733625

            var client = new AmazonWAFClient();
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

        public void WAFUpdateRule()
        {
            #region updaterule-1475260064720

            var client = new AmazonWAFClient();
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

        public void WAFUpdateSizeConstraintSet()
        {
            #region updatesizeconstraintset-1475531697891

            var client = new AmazonWAFClient();
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

        public void WAFUpdateSqlInjectionMatchSet()
        {
            #region updatesqlinjectionmatchset-1475532094686

            var client = new AmazonWAFClient();
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

        public void WAFUpdateWebACL()
        {
            #region updatewebacl-1475533627385

            var client = new AmazonWAFClient();
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

        public void WAFUpdateXssMatchSet()
        {
            #region updatexssmatchset-1475534098881

            var client = new AmazonWAFClient();
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

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}