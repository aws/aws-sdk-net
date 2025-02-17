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
    /// An AWS Chatbot configuration for Slack.
    /// </summary>
    public partial class SlackChannelConfiguration
    {
        private string _chatConfigurationArn;
        private string _configurationName;
        private List<string> _guardrailPolicyArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _iamRoleArn;
        private string _loggingLevel;
        private string _slackChannelId;
        private string _slackChannelName;
        private string _slackTeamId;
        private string _slackTeamName;
        private List<string> _snsTopicArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _state;
        private string _stateReason;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private bool? _userAuthorizationRequired;

        /// <summary>
        /// Gets and sets the property ChatConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SlackChannelConfiguration.
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
        /// Gets and sets the property ConfigurationName. 
        /// <para>
        /// The name of the configuration.
        /// </para>
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
        /// Gets and sets the property GuardrailPolicyArns. 
        /// <para>
        /// The list of IAM policy ARNs that are applied as channel guardrails. The AWS managed
        /// <c>AdministratorAccess</c> policy is applied by default if this is not set. 
        /// </para>
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
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=255)]
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
        /// Gets and sets the property SlackTeamId. 
        /// <para>
        /// The ID of the Slack workspace authorized with Amazon Chime.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string SlackTeamId
        {
            get { return this._slackTeamId; }
            set { this._slackTeamId = value; }
        }

        // Check to see if SlackTeamId property is set
        internal bool IsSetSlackTeamId()
        {
            return this._slackTeamId != null;
        }

        /// <summary>
        /// Gets and sets the property SlackTeamName. 
        /// <para>
        /// Name of the Slack workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string SlackTeamName
        {
            get { return this._slackTeamName; }
            set { this._slackTeamName = value; }
        }

        // Check to see if SlackTeamName property is set
        internal bool IsSetSlackTeamName()
        {
            return this._slackTeamName != null;
        }

        /// <summary>
        /// Gets and sets the property SnsTopicArns. 
        /// <para>
        /// The ARNs of the SNS topics that deliver notifications to AWS Chatbot.
        /// </para>
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
        /// Gets and sets the property State. 
        /// <para>
        /// Either <c>ENABLED</c> or <c>DISABLED</c>. The resource returns <c>DISABLED</c> if
        /// the organization's AWS Chatbot policy has explicitly denied that configuration. For
        /// example, if Amazon Chime is disabled.
        /// </para>
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// Provided if State is <c>DISABLED</c>. Provides context as to why the resource is disabled.
        /// </para>
        /// </summary>
        public string StateReason
        {
            get { return this._stateReason; }
            set { this._stateReason = value; }
        }

        // Check to see if StateReason property is set
        internal bool IsSetStateReason()
        {
            return this._stateReason != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of tags assigned to a resource. A tag is a string-to-string map of key-value
        /// pairs.
        /// </para>
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
        /// Gets and sets the property UserAuthorizationRequired. 
        /// <para>
        /// Enables use of a user role requirement in your chat configuration.
        /// </para>
        /// </summary>
        public bool UserAuthorizationRequired
        {
            get { return this._userAuthorizationRequired.GetValueOrDefault(); }
            set { this._userAuthorizationRequired = value; }
        }

        // Check to see if UserAuthorizationRequired property is set
        internal bool IsSetUserAuthorizationRequired()
        {
            return this._userAuthorizationRequired.HasValue; 
        }

    }
}