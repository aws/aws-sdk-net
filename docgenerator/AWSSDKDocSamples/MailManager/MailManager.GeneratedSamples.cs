using System;
using System.Collections.Generic;
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
            #region example-1

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
            #region example-2

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
            #region example-3

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
            #region example-1

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
            #region example-1

            var client = new AmazonMailManagerClient();
            var response = client.DeleteIngressPoint(new DeleteIngressPointRequest 
            {
                IngressPointId = "inp-12345"
            });


            #endregion
        }

        public void MailManagerDeleteTrafficPolicy()
        {
            #region example-1

            var client = new AmazonMailManagerClient();
            var response = client.DeleteTrafficPolicy(new DeleteTrafficPolicyRequest 
            {
                TrafficPolicyId = "tp-12345"
            });


            #endregion
        }

        public void MailManagerGetIngressPoint()
        {
            #region example-1

            var client = new AmazonMailManagerClient();
            var response = client.GetIngressPoint(new GetIngressPointRequest 
            {
                IngressPointId = "inp-12345"
            });

            string aRecord = response.ARecord;
            string ingressPointArn = response.IngressPointArn;
            string ingressPointId = response.IngressPointId;
            string ingressPointName = response.IngressPointName;
            string status = response.Status;
            string type = response.Type;

            #endregion
        }

        public void MailManagerGetIngressPoint()
        {
            #region example-2

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
            string status = response.Status;
            string type = response.Type;

            #endregion
        }

        public void MailManagerGetTrafficPolicy()
        {
            #region example-1

            var client = new AmazonMailManagerClient();
            var response = client.GetTrafficPolicy(new GetTrafficPolicyRequest 
            {
                TrafficPolicyId = "tp-12345"
            });

            string defaultAction = response.DefaultAction;
            int maxMessageSizeBytes = response.MaxMessageSizeBytes;
            List<PolicyStatement> policyStatements = response.PolicyStatements;
            string trafficPolicyArn = response.TrafficPolicyArn;
            string trafficPolicyId = response.TrafficPolicyId;
            string trafficPolicyName = response.TrafficPolicyName;

            #endregion
        }

        public void MailManagerListIngressPoints()
        {
            #region example-1

            var client = new AmazonMailManagerClient();
            var response = client.ListIngressPoints(new ListIngressPointsRequest 
            {
            });

            List<IngressPoint> ingressPoints = response.IngressPoints;

            #endregion
        }

        public void MailManagerListIngressPoints()
        {
            #region example-2

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
            #region example-3

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
            #region example-1

            var client = new AmazonMailManagerClient();
            var response = client.ListTrafficPolicies(new ListTrafficPoliciesRequest 
            {
            });

            List<TrafficPolicy> trafficPolicies = response.TrafficPolicies;

            #endregion
        }

        public void MailManagerListTrafficPolicies()
        {
            #region example-2

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
            #region example-3

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
            #region example-1

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
            #region example-2

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
            #region example-3

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
            #region example-4

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
            #region example-1

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
            #region example-2

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
            #region example-3

            var client = new AmazonMailManagerClient();
            var response = client.UpdateTrafficPolicy(new UpdateTrafficPolicyRequest 
            {
                DefaultAction = "ALLOW",
                TrafficPolicyId = "tp-12345"
            });


            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}