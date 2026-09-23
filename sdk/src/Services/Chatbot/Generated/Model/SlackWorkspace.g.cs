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
    /// A Slack workspace.
    /// </summary>
    public partial class SlackWorkspace
    {
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
        /// Gets and sets the property SlackTeamName. 
        /// <para>
        /// The name of the Slack workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string SlackTeamName { get; set; }

        /// <summary>
        /// Checks to see if the SlackTeamName property is set.
        /// </summary>
        internal bool IsSetSlackTeamName() => this.SlackTeamName != null;

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
    }
}
