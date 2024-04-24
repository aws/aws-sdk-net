/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the chatbot-2017-10-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Chatbot.Model
{
    /// <summary>
    /// An AWS Chatbot configuration for Amazon Chime.
    /// </summary>
    public partial class ChimeWebhookConfiguration
    {
        private string _chatConfigurationArn;
        private string _configurationName;
        private string _iamRoleArn;
        private string _loggingLevel;
        private List<string> _snsTopicArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _webhookDescription;

        /// <summary>
        /// Gets and sets the property ChatConfigurationArn. The ARN of the ChimeWebhookConfiguration.
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=1169)]
        public string ChatConfigurationArn
        {
            get { return this._chatConfigurationArn; }
            set { this._chatConfigurationArn = value; }
        }

        // Check to see if ChatConfigurationArn property is set
        internal bool IsSetChatConfigurationArn()
        {
            return this._chatConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationName. The name of the configuration.
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ConfigurationName
        {
            get { return this._configurationName; }
            set { this._configurationName = value; }
        }

        // Check to see if ConfigurationName property is set
        internal bool IsSetConfigurationName()
        {
            return this._configurationName != null;
        }

        /// <summary>
        /// Gets and sets the property IamRoleArn. The ARN of the IAM role that defines the permissions
        /// for AWS Chatbot. This is a user-defined role that AWS Chatbot will assume. This is
        /// not the service-linked role. For more information, see IAM Policies for AWS Chatbot.
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=1224)]
        public string IamRoleArn
        {
            get { return this._iamRoleArn; }
            set { this._iamRoleArn = value; }
        }

        // Check to see if IamRoleArn property is set
        internal bool IsSetIamRoleArn()
        {
            return this._iamRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property LoggingLevel. Specifies the logging level for this configuration.
        /// This property affects the log entries pushed to Amazon CloudWatch Logs.Logging levels
        /// include ERROR, INFO, or NONE.
        /// </summary>
        [AWSProperty(Min=4, Max=5)]
        public string LoggingLevel
        {
            get { return this._loggingLevel; }
            set { this._loggingLevel = value; }
        }

        // Check to see if LoggingLevel property is set
        internal bool IsSetLoggingLevel()
        {
            return this._loggingLevel != null;
        }

        /// <summary>
        /// Gets and sets the property SnsTopicArns. The ARNs of the SNS topics that deliver notifications
        /// to AWS Chatbot.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> SnsTopicArns
        {
            get { return this._snsTopicArns; }
            set { this._snsTopicArns = value; }
        }

        // Check to see if SnsTopicArns property is set
        internal bool IsSetSnsTopicArns()
        {
            return this._snsTopicArns != null && (this._snsTopicArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WebhookDescription. Description of the webhook. Recommend
        /// using the convention `RoomName/WebhookName`. See Chime setup tutorial for more details:
        /// https://docs.aws.amazon.com/chatbot/latest/adminguide/chime-setup.html.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string WebhookDescription
        {
            get { return this._webhookDescription; }
            set { this._webhookDescription = value; }
        }

        // Check to see if WebhookDescription property is set
        internal bool IsSetWebhookDescription()
        {
            return this._webhookDescription != null;
        }

    }
}