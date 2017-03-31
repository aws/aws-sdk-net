using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.CloudFormation;
using Amazon.CloudFormation.Model;

namespace AWSSDKDocSamples.Amazon.CloudFormation.Generated
{
    class CloudFormationSamples : ISample
    {
        static IAmazonCloudFormation client = new AmazonCloudFormationClient();
        public void CloudFormationCancelUpdateStack()
        {
            #region to-cancel-a-stack-update-that-is-in-progress-1472747085196

            var response = client.CancelUpdateStack(new CancelUpdateStackRequest 
            {
                StackName = "MyStack"
            });


            #endregion
        }

        public void CloudFormationUpdateStack()
        {
            #region to-update-an-aws-cloudformation-stack-1472841931621

            var response = client.UpdateStack(new UpdateStackRequest 
            {
                NotificationARNs = new List<string> {
                    
                },
                Parameters = new List<Parameter> {
                    new Parameter {
                        ParameterKey = "KeyPairName",
                        ParameterValue = "ExampleKeyPair"
                    },
                    new Parameter {
                        ParameterKey = "SubnetIDs",
                        ParameterValue = "ExampleSubnetID1, ExampleSubnetID2"
                    }
                },
                ResourceTypes = new List<string> {
                    
                },
                StackName = "MyStack",
                Tags = new List<Tag> {
                    
                },
                TemplateURL = "https://s3.amazonaws.com/example/updated.template"
            });

            string stackId = response.StackId;

            #endregion
        }

        public void CloudFormationUpdateStack()
        {
            #region to-update-an-aws-cloudformation-stack-1472841931621

            var response = client.UpdateStack(new UpdateStackRequest 
            {
                NotificationARNs = new List<string> {
                    
                },
                Parameters = new List<Parameter> {
                    new Parameter {
                        ParameterKey = "KeyPairName",
                        UsePreviousValue = true
                    },
                    new Parameter {
                        ParameterKey = "SubnetIDs",
                        ParameterValue = "SampleSubnetID1, UpdatedSampleSubnetID2"
                    }
                },
                ResourceTypes = new List<string> {
                    
                },
                StackName = "MyStack",
                Tags = new List<Tag> {
                    
                },
                TemplateURL = "https://s3.amazonaws.com/example/updated.template"
            });

            string stackId = response.StackId;

            #endregion
        }

        public void CloudFormationUpdateStack()
        {
            #region to-update-an-aws-cloudformation-stack-1472841931621

            var response = client.UpdateStack(new UpdateStackRequest 
            {
                Capabilities = new List<string> {
                    
                },
                NotificationARNs = new List<string> {
                    "arn:aws:sns:use-east-1:123456789012:mytopic1",
                    "arn:aws:sns:us-east-1:123456789012:mytopic2"
                },
                Parameters = new List<Parameter> {
                    
                },
                ResourceTypes = new List<string> {
                    
                },
                StackName = "MyStack",
                Tags = new List<Tag> {
                    
                },
                TemplateURL = "https://s3.amazonaws.com/example/updated.template",
                UsePreviousTemplate = true
            });

            string stackId = response.StackId;

            #endregion
        }

        public void CloudFormationValidateTemplate()
        {
            #region to-validate-an-aws-cloudformation-template-1472839072307

            var response = client.ValidateTemplate(new ValidateTemplateRequest 
            {
                TemplateBody = "MyTemplate.json"
            });

            List<string> capabilities = response.Capabilities;
            string capabilitiesReason = response.CapabilitiesReason;
            string description = response.Description;
            List<TemplateParameter> parameters = response.Parameters;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}