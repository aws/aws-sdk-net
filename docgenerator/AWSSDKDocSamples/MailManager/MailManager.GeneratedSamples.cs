using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.MailManager;
using Amazon.MailManager.Model;

namespace AWSSDKDocSamples.Amazon.MailManager.Generated
{
    class MailManagerSamples : ISample
    {
        public void MailManagerCreateIngressPoint()
        {
            #region CreateIngressPoint-1

            var client = new AmazonMailManagerClient();
            var response = client.CreateIngressPoint(new CreateIngressPointRequest
            {
                IngressPointName = "ingressPointName",
                RuleSetId = "rs-12345",
                Tags = new List<Tag> {
                    new Tag {
                        Key = "key",
                        Value = "value"
                    }
                },
                TrafficPolicyId = "tp-12345",
                Type = "OPEN"
            });

            string ingressPointId = response.IngressPointId;

            #endregion
        }

        public void MailManagerCreateIngressPoint()
        {
            #region CreateIngressPoint-2

            var client = new AmazonMailManagerClient();
            var response = client.CreateIngressPoint(new CreateIngressPointRequest
            {
                IngressPointConfiguration = new IngressPointConfiguration { SmtpPassword = "smtpPassword" },
                IngressPointName = "ingressPointName",
                RuleSetId = "rs-12345",
                Tags = new List<Tag> {
                    new Tag {
                        Key = "key",
                        Value = "value"
                    }
                },
                TrafficPolicyId = "tp-12345",
                Type = "AUTH"
            });

            string ingressPointId = response.IngressPointId;

            #endregion
        }

        public void MailManagerCreateIngressPoint()
        {
            #region CreateIngressPoint-3

            var client = new AmazonMailManagerClient();
            var response = client.CreateIngressPoint(new CreateIngressPointRequest
            {
                IngressPointConfiguration = new IngressPointConfiguration { SecretArn = "arn:aws:secretsmanager:us-west-2:123456789012:secret:abcde" },
                IngressPointName = "ingressPointName",
                RuleSetId = "rs-12345",
                Tags = new List<Tag> {
                    new Tag {
                        Key = "key",
                        Value = "value"
                    }
                },
                TrafficPolicyId = "tp-12345",
                Type = "AUTH"
            });

            string ingressPointId = response.IngressPointId;

            #endregion
        }

        public void MailManagerCreateTrafficPolicy()
        {
            #region CreateTrafficPolicy-1

            var client = new AmazonMailManagerClient();
            var response = client.CreateTrafficPolicy(new CreateTrafficPolicyRequest
            {
                DefaultAction = "DENY",
                PolicyStatements = new List<PolicyStatement> {
                    new PolicyStatement {
                        Action = "ALLOW",
                        Conditions = new List<PolicyCondition> {
                            new PolicyCondition { IpExpression = new IngressIpv4Expression {
                                Evaluate = new IngressIpToEvaluate { Attribute = "SENDER_IP" },
                                Operator = "CIDR_MATCHES",
                                Values = new List<string> {
                                    "0.0.0.0/12"
                                }
                            } }
                        }
                    }
                },
                TrafficPolicyName = "trafficPolicyName"
            });

            string trafficPolicyId = response.TrafficPolicyId;

            #endregion
        }

        public void MailManagerDeleteIngressPoint()
        {
            #region DeleteIngressPoint-1

            var client = new AmazonMailManagerClient();
            var response = client.DeleteIngressPoint(new DeleteIngressPointRequest
            {
                IngressPointId = "inp-12345"
            });


            #endregion
        }

        public void MailManagerDeleteTrafficPolicy()
        {
            #region DeleteTrafficPolicy-1

            var client = new AmazonMailManagerClient();
            var response = client.DeleteTrafficPolicy(new DeleteTrafficPolicyRequest
            {
                TrafficPolicyId = "tp-12345"
            });


            #endregion
        }

        public void MailManagerGetIngressPoint()
        {
            #region GetIngressPoint-1

            var client = new AmazonMailManagerClient();
            var response = client.GetIngressPoint(new GetIngressPointRequest
            {
                IngressPointId = "inp-12345"
            });

            string aRecord = response.ARecord;
            string ingressPointArn = response.IngressPointArn;
            string ingressPointId = response.IngressPointId;
            string ingressPointName = response.IngressPointName;
            IngressPointStatus status = response.Status;
            IngressPointType type = response.Type;

            #endregion
        }

        public void MailManagerGetIngressPoint()
        {
            #region GetIngressPoint-2

            var client = new AmazonMailManagerClient();
            var response = client.GetIngressPoint(new GetIngressPointRequest
            {
                IngressPointId = "inp-12345"
            });

            string aRecord = response.ARecord;
            string ingressPointArn = response.IngressPointArn;
            IngressPointAuthConfiguration ingressPointAuthConfiguration = response.IngressPointAuthConfiguration;
            string ingressPointId = response.IngressPointId;
            string ingressPointName = response.IngressPointName;
            IngressPointStatus status = response.Status;
            IngressPointType type = response.Type;

            #endregion
        }

        public void MailManagerGetTrafficPolicy()
        {
            #region GetTrafficPolicy-1

            var client = new AmazonMailManagerClient();
            var response = client.GetTrafficPolicy(new GetTrafficPolicyRequest
            {
                TrafficPolicyId = "tp-12345"
            });

            AcceptAction defaultAction = response.DefaultAction;
            int? maxMessageSizeBytes = response.MaxMessageSizeBytes;
            List<PolicyStatement> policyStatements = response.PolicyStatements;
            string trafficPolicyArn = response.TrafficPolicyArn;
            string trafficPolicyId = response.TrafficPolicyId;
            string trafficPolicyName = response.TrafficPolicyName;

            #endregion
        }

        public void MailManagerListIngressPoints()
        {
            #region ListIngressPoints-1

            var client = new AmazonMailManagerClient();
            var response = client.ListIngressPoints(new ListIngressPointsRequest
            {
            });

            List<IngressPoint> ingressPoints = response.IngressPoints;

            #endregion
        }

        public void MailManagerListIngressPoints()
        {
            #region ListIngressPoints-2

            var client = new AmazonMailManagerClient();
            var response = client.ListIngressPoints(new ListIngressPointsRequest
            {
                PageSize = 10
            });

            List<IngressPoint> ingressPoints = response.IngressPoints;

            #endregion
        }

        public void MailManagerListIngressPoints()
        {
            #region ListIngressPoints-3

            var client = new AmazonMailManagerClient();
            var response = client.ListIngressPoints(new ListIngressPointsRequest
            {
                NextToken = "nextToken"
            });

            List<IngressPoint> ingressPoints = response.IngressPoints;

            #endregion
        }

        public void MailManagerListTrafficPolicies()
        {
            #region ListTrafficPolicies-1

            var client = new AmazonMailManagerClient();
            var response = client.ListTrafficPolicies(new ListTrafficPoliciesRequest
            {
            });

            List<TrafficPolicy> trafficPolicies = response.TrafficPolicies;

            #endregion
        }

        public void MailManagerListTrafficPolicies()
        {
            #region ListTrafficPolicies-2

            var client = new AmazonMailManagerClient();
            var response = client.ListTrafficPolicies(new ListTrafficPoliciesRequest
            {
                PageSize = 10
            });

            List<TrafficPolicy> trafficPolicies = response.TrafficPolicies;

            #endregion
        }

        public void MailManagerListTrafficPolicies()
        {
            #region ListTrafficPolicies-3

            var client = new AmazonMailManagerClient();
            var response = client.ListTrafficPolicies(new ListTrafficPoliciesRequest
            {
                NextToken = "nextToken"
            });

            List<TrafficPolicy> trafficPolicies = response.TrafficPolicies;

            #endregion
        }

        public void MailManagerUpdateIngressPoint()
        {
            #region UpdateIngressPoint-1

            var client = new AmazonMailManagerClient();
            var response = client.UpdateIngressPoint(new UpdateIngressPointRequest
            {
                IngressPointId = "inp-12345",
                IngressPointName = "ingressPointNewName"
            });


            #endregion
        }

        public void MailManagerUpdateIngressPoint()
        {
            #region UpdateIngressPoint-2

            var client = new AmazonMailManagerClient();
            var response = client.UpdateIngressPoint(new UpdateIngressPointRequest
            {
                IngressPointId = "inp-12345",
                RuleSetId = "rs-12345",
                TrafficPolicyId = "tp-12345"
            });


            #endregion
        }

        public void MailManagerUpdateIngressPoint()
        {
            #region UpdateIngressPoint-3

            var client = new AmazonMailManagerClient();
            var response = client.UpdateIngressPoint(new UpdateIngressPointRequest
            {
                IngressPointConfiguration = new IngressPointConfiguration { SmtpPassword = "newSmtpPassword" },
                IngressPointId = "inp-12345"
            });


            #endregion
        }

        public void MailManagerUpdateIngressPoint()
        {
            #region UpdateIngressPoint-4

            var client = new AmazonMailManagerClient();
            var response = client.UpdateIngressPoint(new UpdateIngressPointRequest
            {
                IngressPointConfiguration = new IngressPointConfiguration { SecretArn = "arn:aws:secretsmanager:us-west-2:123456789012:secret:abcde" },
                IngressPointId = "inp-12345"
            });


            #endregion
        }

        public void MailManagerUpdateTrafficPolicy()
        {
            #region UpdateTrafficPolicy-1

            var client = new AmazonMailManagerClient();
            var response = client.UpdateTrafficPolicy(new UpdateTrafficPolicyRequest
            {
                TrafficPolicyId = "tp-12345",
                TrafficPolicyName = "trafficPolicyNewName"
            });


            #endregion
        }

        public void MailManagerUpdateTrafficPolicy()
        {
            #region UpdateTrafficPolicy-2

            var client = new AmazonMailManagerClient();
            var response = client.UpdateTrafficPolicy(new UpdateTrafficPolicyRequest
            {
                PolicyStatements = new List<PolicyStatement> {
                    new PolicyStatement {
                        Action = "ALLOW",
                        Conditions = new List<PolicyCondition> {
                            new PolicyCondition { StringExpression = new IngressStringExpression {
                                Evaluate = new IngressStringToEvaluate { Attribute = "RECIPIENT" },
                                Operator = "EQUALS",
                                Values = new List<string> {
                                    "example@amazon.com",
                                    "example@gmail.com"
                                }
                            } }
                        }
                    }
                },
                TrafficPolicyId = "tp-12345"
            });


            #endregion
        }

        public void MailManagerUpdateTrafficPolicy()
        {
            #region UpdateTrafficPolicy-3

            var client = new AmazonMailManagerClient();
            var response = client.UpdateTrafficPolicy(new UpdateTrafficPolicyRequest
            {
                DefaultAction = "ALLOW",
                TrafficPolicyId = "tp-12345"
            });


            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
