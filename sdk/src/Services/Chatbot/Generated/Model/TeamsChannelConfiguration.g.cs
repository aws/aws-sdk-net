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
    /// An AWS Chatbot configuration for Microsoft Teams.
    /// </summary>
    public partial class TeamsChannelConfiguration
    {
        /// <summary>
        /// Gets and sets the property ChannelId. 
        /// <para>
        /// The ID of the Microsoft Teams channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ChannelId { get; set; }

        /// <summary>
        /// Checks to see if the ChannelId property is set.
        /// </summary>
        internal bool IsSetChannelId() => this.ChannelId != null;

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name of the Microsoft Teams channel.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1000)]
        public string ChannelName { get; set; }

        /// <summary>
        /// Checks to see if the ChannelName property is set.
        /// </summary>
        internal bool IsSetChannelName() => this.ChannelName != null;

        /// <summary>
        /// Gets and sets the property ChatConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the MicrosoftTeamsChannelConfiguration associated
        /// with the user identity to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 19, Max = 1169)]
        public string ChatConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the ChatConfigurationArn property is set.
        /// </summary>
        internal bool IsSetChatConfigurationArn() => this.ChatConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property ConfigurationName. 
        /// <para>
        /// The name of the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ConfigurationName { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationName property is set.
        /// </summary>
        internal bool IsSetConfigurationName() => this.ConfigurationName != null;

        /// <summary>
        /// Gets and sets the property GuardrailPolicyArns. 
        /// <para>
        /// The list of IAM policy ARNs that are applied as channel guardrails. The AWS managed
        /// <c>AdministratorAccess</c> policy is applied by default if this is not set. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> GuardrailPolicyArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the GuardrailPolicyArns property is set.
        /// </summary>
        internal bool IsSetGuardrailPolicyArns() => this.GuardrailPolicyArns != null && (this.GuardrailPolicyArns.Count > 0 || !AWSConfigs.InitializeCollections);

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
        [AWSProperty(Required = true, Min = 12, Max = 1224)]
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
        /// The Amazon Resource Names (ARNs) of the SNS topics that deliver notifications to AWS
        /// Chatbot.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> SnsTopicArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SnsTopicArns property is set.
        /// </summary>
        internal bool IsSetSnsTopicArns() => this.SnsTopicArns != null && (this.SnsTopicArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Either <c>ENABLED</c> or <c>DISABLED</c>. The resource returns <c>DISABLED</c> if
        /// the organization's AWS Chatbot policy has explicitly denied that configuration. For
        /// example, if Amazon Chime is disabled.
        /// </para>
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// Provided if State is <c>DISABLED</c>. Provides context as to why the resource is disabled.
        /// </para>
        /// </summary>
        public string StateReason { get; set; }

        /// <summary>
        /// Checks to see if the StateReason property is set.
        /// </summary>
        internal bool IsSetStateReason() => this.StateReason != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of tags assigned to a resource. A tag is a string-to-string map of key-value
        /// pairs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TeamId. 
        /// <para>
        ///  The ID of the Microsoft Teams authorized with AWS Chatbot.
        /// </para>
        ///  
        /// <para>
        /// To get the team ID, you must perform the initial authorization flow with Microsoft
        /// Teams in the AWS Chatbot console. Then you can copy and paste the team ID from the
        /// console. For more information, see <a href="https://docs.aws.amazon.com/chatbot/latest/adminguide/teams-setup.html#teams-client-setup">Step
        /// 1: Configure a Microsoft Teams client</a> in the <i> AWS Chatbot Administrator Guide</i>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string TeamId { get; set; }

        /// <summary>
        /// Checks to see if the TeamId property is set.
        /// </summary>
        internal bool IsSetTeamId() => this.TeamId != null;

        /// <summary>
        /// Gets and sets the property TeamName. 
        /// <para>
        /// The name of the Microsoft Teams Team.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public string TeamName { get; set; }

        /// <summary>
        /// Checks to see if the TeamName property is set.
        /// </summary>
        internal bool IsSetTeamName() => this.TeamName != null;

        /// <summary>
        /// Gets and sets the property TenantId. 
        /// <para>
        /// The ID of the Microsoft Teams tenant.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string TenantId { get; set; }

        /// <summary>
        /// Checks to see if the TenantId property is set.
        /// </summary>
        internal bool IsSetTenantId() => this.TenantId != null;

        /// <summary>
        /// Gets and sets the property UserAuthorizationRequired. 
        /// <para>
        /// Enables use of a user role requirement in your chat configuration.
        /// </para>
        /// </summary>
        public bool? UserAuthorizationRequired { get; set; }

        /// <summary>
        /// Checks to see if the UserAuthorizationRequired property is set.
        /// </summary>
        internal bool IsSetUserAuthorizationRequired() => this.UserAuthorizationRequired.HasValue;
    }
}
