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
    public partial class TeamsUserIdentity
    {
        private string _awsUserIdentity;
        private string _chatConfigurationArn;
        private string _iamRoleArn;
        private string _teamId;
        private string _teamsChannelId;
        private string _teamsTenantId;
        private string _userId;

        /// <summary>
        /// Gets and sets the property AwsUserIdentity. The AWS user identity ARN used to associate
        /// a Microsoft Teams User Identity with an IAM Role.
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
        /// Gets and sets the property ChatConfigurationArn. The ARN of the MicrosoftTeamsChannelConfiguration
        /// associated with the user identity.
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
        /// Gets and sets the property TeamsChannelId. The ID of the Microsoft Teams channel.
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string TeamsChannelId
        {
            get { return this._teamsChannelId; }
            set { this._teamsChannelId = value; }
        }

        // Check to see if TeamsChannelId property is set
        internal bool IsSetTeamsChannelId()
        {
            return this._teamsChannelId != null;
        }

        /// <summary>
        /// Gets and sets the property TeamsTenantId. The ID of the Microsoft Teams tenant.
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string TeamsTenantId
        {
            get { return this._teamsTenantId; }
            set { this._teamsTenantId = value; }
        }

        // Check to see if TeamsTenantId property is set
        internal bool IsSetTeamsTenantId()
        {
            return this._teamsTenantId != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. Id from Microsoft Teams for user.
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}