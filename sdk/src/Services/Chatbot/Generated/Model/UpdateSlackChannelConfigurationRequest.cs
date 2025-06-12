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
    /// Container for the parameters to the UpdateSlackChannelConfiguration operation.
    /// Updates a Slack channel configuration.
    /// </summary>
    public partial class UpdateSlackChannelConfigurationRequest : AmazonChatbotRequest
    {
        private string _chatConfigurationArn;
        private List<string> _guardrailPolicyArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _iamRoleArn;
        private string _loggingLevel;
        private string _slackChannelId;
        private string _slackChannelName;
        private List<string> _snsTopicArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _userAuthorizationRequired;

        /// <summary>
        /// Gets and sets the property ChatConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SlackChannelConfiguration to update.
        /// </para>
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
        /// Gets and sets the property GuardrailPolicyArns. 
        /// <para>
        /// The list of IAM policy ARNs that are applied as channel guardrails. The AWS managed
        /// <c>AdministratorAccess</c> policy is applied by default if this is not set. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> GuardrailPolicyArns
        {
            get { return this._guardrailPolicyArns; }
            set { this._guardrailPolicyArns = value; }
        }

        // Check to see if GuardrailPolicyArns property is set
        internal bool IsSetGuardrailPolicyArns()
        {
            return this._guardrailPolicyArns != null && (this._guardrailPolicyArns.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        [AWSProperty(Min=12, Max=1224)]
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
        /// Gets and sets the property SlackChannelId. 
        /// <para>
        /// The ID of the Slack channel.
        /// </para>
        ///  
        /// <para>
        /// To get this ID, open Slack, right click on the channel name in the left pane, then
        /// choose Copy Link. The channel ID is the 9-character string at the end of the URL.
        /// For example, ABCBBLZZZ. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string SlackChannelId
        {
            get { return this._slackChannelId; }
            set { this._slackChannelId = value; }
        }

        // Check to see if SlackChannelId property is set
        internal bool IsSetSlackChannelId()
        {
            return this._slackChannelId != null;
        }

        /// <summary>
        /// Gets and sets the property SlackChannelName. 
        /// <para>
        /// The name of the Slack channel.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=255)]
        public string SlackChannelName
        {
            get { return this._slackChannelName; }
            set { this._slackChannelName = value; }
        }

        // Check to see if SlackChannelName property is set
        internal bool IsSetSlackChannelName()
        {
            return this._slackChannelName != null;
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
        /// Gets and sets the property UserAuthorizationRequired. 
        /// <para>
        /// Enables use of a user role requirement in your chat configuration.
        /// </para>
        /// </summary>
        public bool? UserAuthorizationRequired
        {
            get { return this._userAuthorizationRequired; }
            set { this._userAuthorizationRequired = value; }
        }

        // Check to see if UserAuthorizationRequired property is set
        internal bool IsSetUserAuthorizationRequired()
        {
            return this._userAuthorizationRequired.HasValue; 
        }

    }
}