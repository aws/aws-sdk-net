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
    /// A Slack Workspace.
    /// </summary>
    public partial class SlackWorkspace
    {
        private string _slackTeamId;
        private string _slackTeamName;

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

        /// <summary>
        /// Gets and sets the property SlackTeamName. Name of the Slack Workspace.
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

    }
}