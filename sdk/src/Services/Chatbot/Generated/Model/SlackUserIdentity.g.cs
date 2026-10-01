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
    /// Identifes a user level permission for a channel configuration.
    /// </summary>
    public partial class SlackUserIdentity
    {
        /// <summary>
        /// Gets and sets the property AwsUserIdentity. 
        /// <para>
        /// The AWS user identity ARN used to associate a Slack user ID with an IAM Role.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 15, Max = 1101)]
        public string AwsUserIdentity { get; set; }

        /// <summary>
        /// Checks to see if the AwsUserIdentity property is set.
        /// </summary>
        internal bool IsSetAwsUserIdentity() => this.AwsUserIdentity != null;

        /// <summary>
        /// Gets and sets the property ChatConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SlackChannelConfiguration associated with the
        /// user identity to delete.
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
        [AWSProperty(Required = true, Min = 12, Max = 1224)]
        public string IamRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the IamRoleArn property is set.
        /// </summary>
        internal bool IsSetIamRoleArn() => this.IamRoleArn != null;

        /// <summary>
        /// Gets and sets the property SlackTeamId. 
        /// <para>
        /// The ID of the Slack workspace authorized with AWS Chatbot.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string SlackTeamId { get; set; }

        /// <summary>
        /// Checks to see if the SlackTeamId property is set.
        /// </summary>
        internal bool IsSetSlackTeamId() => this.SlackTeamId != null;

        /// <summary>
        /// Gets and sets the property SlackUserId. 
        /// <para>
        /// The ID of the user in Slack
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string SlackUserId { get; set; }

        /// <summary>
        /// Checks to see if the SlackUserId property is set.
        /// </summary>
        internal bool IsSetSlackUserId() => this.SlackUserId != null;
    }
}
