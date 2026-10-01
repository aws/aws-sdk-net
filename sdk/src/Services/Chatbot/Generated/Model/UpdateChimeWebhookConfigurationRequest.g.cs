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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the UpdateChimeWebhookConfiguration operation. Updates
    /// a Amazon Chime webhook configuration.
    /// </summary>
    public partial class UpdateChimeWebhookConfigurationRequest : AmazonChatbotRequest
    {
        /// <summary>
        /// Gets and sets the property ChatConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ChimeWebhookConfiguration to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 19, Max = 1169)]
        public string ChatConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the ChatConfigurationArn property is set.
        /// </summary>
        internal bool IsSetChatConfigurationArn() => this.ChatConfigurationArn != null;

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
        [AWSProperty(Min = 12, Max = 1224)]
        public string IamRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the IamRoleArn property is set.
        /// </summary>
        internal bool IsSetIamRoleArn() => this.IamRoleArn != null;

        /// <summary>
        /// Gets and sets the property LoggingLevel. 
        /// <para>
        /// Logging levels include <c>ERROR</c>, <c>INFO</c>, or <c>NONE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 5)]
        public string LoggingLevel { get; set; }

        /// <summary>
        /// Checks to see if the LoggingLevel property is set.
        /// </summary>
        internal bool IsSetLoggingLevel() => this.LoggingLevel != null;

        /// <summary>
        /// Gets and sets the property SnsTopicArns. 
        /// <para>
        /// The ARNs of the SNS topics that deliver notifications to AWS Chatbot.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SnsTopicArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SnsTopicArns property is set.
        /// </summary>
        internal bool IsSetSnsTopicArns() => this.SnsTopicArns != null && (this.SnsTopicArns.Count > 0 || !AWSConfigs.InitializeCollections);

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
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public string WebhookDescription { get; set; }

        /// <summary>
        /// Checks to see if the WebhookDescription property is set.
        /// </summary>
        internal bool IsSetWebhookDescription() => this.WebhookDescription != null;

        /// <summary>
        /// Gets and sets the property WebhookUrl. 
        /// <para>
        /// The URL for the Amazon Chime webhook.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public string WebhookUrl { get; set; }

        /// <summary>
        /// Checks to see if the WebhookUrl property is set.
        /// </summary>
        internal bool IsSetWebhookUrl() => this.WebhookUrl != null;
    }
}
