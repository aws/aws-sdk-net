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
    /// Container for the parameters to the DeleteSlackWorkspaceAuthorization operation.
    /// Deletes the Slack workspace authorization that allows channels to be configured in
    /// that workspace. This requires all configured channels in the workspace to be deleted.
    /// </summary>
    public partial class DeleteSlackWorkspaceAuthorizationRequest : AmazonChatbotRequest
    {
        private string _slackTeamId;

        /// <summary>
        /// Gets and sets the property SlackTeamId. The ID of the Slack workspace authorized with
        /// AWS Chatbot.
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

    }
}