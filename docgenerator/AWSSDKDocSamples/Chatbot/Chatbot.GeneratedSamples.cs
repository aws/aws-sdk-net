using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Chatbot;
using Amazon.Chatbot.Model;

namespace AWSSDKDocSamples.Amazon.Chatbot.Generated
{
    class ChatbotSamples : ISample
    {
        public void ChatbotAssociateToConfiguration()
        {
            #region example-1

            var client = new AmazonChatbotClient();
            var response = client.AssociateToConfiguration(new AssociateToConfigurationRequest 
            {
                ChatConfiguration = "arn:aws:chatbot::1234567890:chat-configuration/slack-channel/my-channel",
                Resource = "arn:aws:chatbot::1234567890:custom-action/my-custom-action"
            });


            #endregion
        }

        public void ChatbotCreateCustomAction()
        {
            #region example-1

            var client = new AmazonChatbotClient();
            var response = client.CreateCustomAction(new CreateCustomActionRequest 
            {
                ActionName = "my-custom-action",
                AliasName = "invoke",
                Definition = new CustomActionDefinition { CommandText = "lambda invoke $functionName" }
            });

            string customActionArn = response.CustomActionArn;

            #endregion
        }

        public void ChatbotCreateCustomAction()
        {
            #region example-2

            var client = new AmazonChatbotClient();
            var response = client.CreateCustomAction(new CreateCustomActionRequest 
            {
                ActionName = "describe-alarms",
                Attachments = new List<CustomActionAttachment> {
                    new CustomActionAttachment {
                        ButtonText = "List alarms",
                        NotificationType = "CloudWatch"
                    }
                },
                Definition = new CustomActionDefinition { CommandText = "cloudwatch describe-alarms --state-value ALARM" }
            });

            string customActionArn = response.CustomActionArn;

            #endregion
        }

        public void ChatbotDeleteCustomAction()
        {
            #region example-1

            var client = new AmazonChatbotClient();
            var response = client.DeleteCustomAction(new DeleteCustomActionRequest 
            {
                CustomActionArn = "arn:aws:chatbot::1234567890:custom-action/my-custom-action"
            });


            #endregion
        }

        public void ChatbotDisassociateFromConfiguration()
        {
            #region example-1

            var client = new AmazonChatbotClient();
            var response = client.DisassociateFromConfiguration(new DisassociateFromConfigurationRequest 
            {
                ChatConfiguration = "arn:aws:chatbot::1234567890:chat-configuration/slack-channel/my-channel",
                Resource = "arn:aws:chatbot::1234567890:custom-action/my-custom-action"
            });


            #endregion
        }

        public void ChatbotGetCustomAction()
        {
            #region example-1

            var client = new AmazonChatbotClient();
            var response = client.GetCustomAction(new GetCustomActionRequest 
            {
                CustomActionArn = "arn:aws:chatbot::1234567890:custom-action/my-custom-action"
            });

            CustomAction customAction = response.CustomAction;

            #endregion
        }

        public void ChatbotListAssociations()
        {
            #region example-1

            var client = new AmazonChatbotClient();
            var response = client.ListAssociations(new ListAssociationsRequest 
            {
                ChatConfiguration = "arn:aws:chatbot::1234567890:chat-configuration/slack-channel/my-channel"
            });

            List<AssociationListing> associations = response.Associations;

            #endregion
        }

        public void ChatbotListCustomActions()
        {
            #region example-1

            var client = new AmazonChatbotClient();
            var response = client.ListCustomActions(new ListCustomActionsRequest 
            {
            });

            List<string> customActions = response.CustomActions;

            #endregion
        }

        public void ChatbotUpdateCustomAction()
        {
            #region example-1

            var client = new AmazonChatbotClient();
            var response = client.UpdateCustomAction(new UpdateCustomActionRequest 
            {
                CustomActionArn = "arn:aws:chatbot::1234567890:custom-action/my-custom-action",
                Definition = new CustomActionDefinition { CommandText = "lambda invoke MyNewFunction" }
            });

            string customActionArn = response.CustomActionArn;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}