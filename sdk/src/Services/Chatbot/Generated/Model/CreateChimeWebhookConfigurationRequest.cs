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
    /// Container for the parameters to the CreateChimeWebhookConfiguration operation.
    /// Creates an AWS Chatbot configuration for Amazon Chime.
    /// </summary>
    public partial class CreateChimeWebhookConfigurationRequest : AmazonChatbotRequest
    {
        private string _configurationName;
        private string _iamRoleArn;
        private string _loggingLevel;
        private List<string> _snsTopicArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _webhookDescription;
        private string _webhookUrl;

        /// <summary>
        /// Gets and sets the property ConfigurationName. 
        /// <para>
        /// The name of the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// A user-defined role that AWS Chatbot assumes. This is not the service-linked role.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/chatbot/latest/adminguide/chatbot-iam-policies.html">IAM
        /// policies for AWS Chatbot</a> in the <i> AWS Chatbot Administrator Guide</i>. 
        /// </para>
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
        /// Gets and sets the property LoggingLevel. 
        /// <para>
        /// Logging levels include <c>ERROR</c>, <c>INFO</c>, or <c>NONE</c>.
        /// </para>
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
        /// Gets and sets the property SnsTopicArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the SNS topics that deliver notifications to AWS
        /// Chatbot.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of tags assigned to a resource. A tag is a string-to-string map of key-value
        /// pairs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WebhookDescription. 
        /// <para>
        /// A description of the webhook. We recommend using the convention <c>RoomName/WebhookName</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/chatbot/latest/adminguide/chime-setup.html">Tutorial:
        /// Get started with Amazon Chime</a> in the <i> AWS Chatbot Administrator Guide</i>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=255)]
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

        /// <summary>
        /// Gets and sets the property WebhookUrl. 
        /// <para>
        /// The URL for the Amazon Chime webhook.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=255)]
        public string WebhookUrl
        {
            get { return this._webhookUrl; }
            set { this._webhookUrl = value; }
        }

        // Check to see if WebhookUrl property is set
        internal bool IsSetWebhookUrl()
        {
            return this._webhookUrl != null;
        }

    }
}