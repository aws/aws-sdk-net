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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Configuration settings for auto-accept for a specific channel.
    /// </summary>
    public partial class AutoAcceptConfig
    {
        /// <summary>
        /// Gets and sets the property AgentFirstCallbackAutoAccept. 
        /// <para>
        /// Indicates whether auto-accept is enabled for agent-first callbacks. This setting only
        /// applies to the VOICE channel.
        /// </para>
        /// </summary>
        public bool? AgentFirstCallbackAutoAccept { get; set; }

        /// <summary>
        /// Checks to see if the AgentFirstCallbackAutoAccept property is set.
        /// </summary>
        internal bool IsSetAgentFirstCallbackAutoAccept() => this.AgentFirstCallbackAutoAccept.HasValue;

        /// <summary>
        /// Gets and sets the property AutoAccept. 
        /// <para>
        /// Indicates whether auto-accept is enabled for this channel. When enabled, available
        /// agents are automatically connected to contacts from this channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? AutoAccept { get; set; }

        /// <summary>
        /// Checks to see if the AutoAccept property is set.
        /// </summary>
        internal bool IsSetAutoAccept() => this.AutoAccept.HasValue;

        /// <summary>
        /// Gets and sets the property Channel. 
        /// <para>
        /// The channel for this auto-accept configuration. Valid values: VOICE, CHAT, TASK, EMAIL.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Channel Channel { get; set; }

        /// <summary>
        /// Checks to see if the Channel property is set.
        /// </summary>
        internal bool IsSetChannel() => this.Channel != null;
    }
}
