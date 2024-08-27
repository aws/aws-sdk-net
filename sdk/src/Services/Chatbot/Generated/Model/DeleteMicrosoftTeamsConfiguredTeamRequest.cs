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
    /// Container for the parameters to the DeleteMicrosoftTeamsConfiguredTeam operation.
    /// Deletes the Microsoft Teams team authorization allowing for channels to be configured
    /// in that Microsoft Teams team. Note that the Microsoft Teams team must have no channels
    /// configured to remove it.
    /// </summary>
    public partial class DeleteMicrosoftTeamsConfiguredTeamRequest : AmazonChatbotRequest
    {
        private string _teamId;

        /// <summary>
        /// Gets and sets the property TeamId. 
        /// <para>
        /// The ID of the Microsoft Teams team authorized with AWS Chatbot.
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

    }
}