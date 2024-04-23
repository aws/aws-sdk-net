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

namespace Amazon.Chatbot.Model
{
    /// <summary>
    /// Container for the parameters to the CreateMicrosoftTeamsChannelConfiguration operation.
    /// Creates MS Teams Channel Configuration
    /// </summary>
    public partial class CreateMicrosoftTeamsChannelConfigurationRequest : AmazonChatbotRequest
    {
        private string _channelId;
        private string _channelName;
        private string _configurationName;
        private List<string> _guardrailPolicyArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _iamRoleArn;
        private string _loggingLevel;
        private List<string> _snsTopicArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _teamId;
        private string _teamName;
        private string _tenantId;
        private bool? _userAuthorizationRequired;

        /// <summary>
        /// Gets and sets the property ChannelId. The ID of the Microsoft Teams channel.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ChannelId
        {
            get { return this._channelId; }
            set { this._channelId = value; }
        }

        // Check to see if ChannelId property is set
        internal bool IsSetChannelId()
        {
            return this._channelId != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelName. The name of the Microsoft Teams channel.
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string ChannelName
        {
            get { return this._channelName; }
            set { this._channelName = value; }
        }

        // Check to see if ChannelName property is set
        internal bool IsSetChannelName()
        {
            return this._channelName != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationName. The name of the configuration.
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
        /// Gets and sets the property GuardrailPolicyArns. The list of IAM policy ARNs that are
        /// applied as channel guardrails. The AWS managed 'AdministratorAccess' policy is applied
        /// by default if this is not set.
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
        /// Gets and sets the property LoggingLevel. Logging levels include ERROR, INFO, or NONE.
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
        /// Gets and sets the property TeamId. The ID of the Microsoft Team authorized with AWS
        /// Chatbot. To get the team ID, you must perform the initial authorization flow with
        /// Microsoft Teams in the AWS Chatbot console. Then you can copy and paste the team ID
        /// from the console. For more details, see steps 1-4 in Get started with Microsoft Teams
        /// in the AWS Chatbot Administrator Guide.
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string TeamId
        {
            get { return this._teamId; }
            set { this._teamId = value; }
        }

        // Check to see if TeamId property is set
        internal bool IsSetTeamId()
        {
            return this._teamId != null;
        }

        /// <summary>
        /// Gets and sets the property TeamName. The name of the Microsoft Teams Team.
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string TeamName
        {
            get { return this._teamName; }
            set { this._teamName = value; }
        }

        // Check to see if TeamName property is set
        internal bool IsSetTeamName()
        {
            return this._teamName != null;
        }

        /// <summary>
        /// Gets and sets the property TenantId. The ID of the Microsoft Teams tenant.
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string TenantId
        {
            get { return this._tenantId; }
            set { this._tenantId = value; }
        }

        // Check to see if TenantId property is set
        internal bool IsSetTenantId()
        {
            return this._tenantId != null;
        }

        /// <summary>
        /// Gets and sets the property UserAuthorizationRequired. Enables use of a user role requirement
        /// in your chat configuration.
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