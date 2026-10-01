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
    /// Container for the parameters to the DeleteSlackUserIdentity operation. Deletes a user
    /// level permission for a Slack channel configuration.
    /// </summary>
    public partial class DeleteSlackUserIdentityRequest : AmazonChatbotRequest
    {
        /// <summary>
        /// Gets and sets the property ChatConfigurationArn. 
        /// <para>
        /// The ARN of the SlackChannelConfiguration associated with the user identity to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 19, Max = 1169)]
        public string ChatConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the ChatConfigurationArn property is set.
        /// </summary>
        internal bool IsSetChatConfigurationArn() => this.ChatConfigurationArn != null;

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
