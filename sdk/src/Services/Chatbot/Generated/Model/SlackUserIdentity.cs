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
    /// Identifes a user level permission for a channel configuration.
    /// </summary>
    public partial class SlackUserIdentity
    {
        private string _awsUserIdentity;
        private string _chatConfigurationArn;
        private string _iamRoleArn;
        private string _slackTeamId;
        private string _slackUserId;

        /// <summary>
        /// Gets and sets the property AwsUserIdentity. 
        /// <para>
        /// The AWS user identity ARN used to associate a Slack user ID with an IAM Role.
        /// </para>
        /// </summary>
        [AWSProperty(Min=15, Max=1101)]
        public string AwsUserIdentity
        {
            get { return this._awsUserIdentity; }
            set { this._awsUserIdentity = value; }
        }

        // Check to see if AwsUserIdentity property is set
        internal bool IsSetAwsUserIdentity()
        {
            return this._awsUserIdentity != null;
        }

        /// <summary>
        /// Gets and sets the property ChatConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SlackChannelConfiguration associated with the
        /// user identity to delete.
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
        /// Gets and sets the property SlackTeamId. 
        /// <para>
        /// The ID of the Slack workspace authorized with AWS Chatbot.
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
        /// Gets and sets the property SlackUserId. 
        /// <para>
        /// The ID of the user in Slack
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string SlackUserId
        {
            get { return this._slackUserId; }
            set { this._slackUserId = value; }
        }

        // Check to see if SlackUserId property is set
        internal bool IsSetSlackUserId()
        {
            return this._slackUserId != null;
        }

    }
}