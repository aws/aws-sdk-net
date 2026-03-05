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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
    /// Configuration settings for after contact work (ACW) timeout for a specific channel.
    /// </summary>
    public partial class AfterContactWorkConfigPerChannel
    {
        private AfterContactWorkConfig _afterContactWorkConfig;
        private AfterContactWorkConfig _agentFirstCallbackAfterContactWorkConfig;
        private Channel _channel;

        /// <summary>
        /// Gets and sets the property AfterContactWorkConfig. 
        /// <para>
        /// The ACW timeout settings for this channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AfterContactWorkConfig AfterContactWorkConfig
        {
            get { return this._afterContactWorkConfig; }
            set { this._afterContactWorkConfig = value; }
        }

        // Check to see if AfterContactWorkConfig property is set
        internal bool IsSetAfterContactWorkConfig()
        {
            return this._afterContactWorkConfig != null;
        }

        /// <summary>
        /// Gets and sets the property AgentFirstCallbackAfterContactWorkConfig. 
        /// <para>
        /// The ACW timeout settings for agent-first callbacks. This setting only applies to the
        /// VOICE channel.
        /// </para>
        /// </summary>
        public AfterContactWorkConfig AgentFirstCallbackAfterContactWorkConfig
        {
            get { return this._agentFirstCallbackAfterContactWorkConfig; }
            set { this._agentFirstCallbackAfterContactWorkConfig = value; }
        }

        // Check to see if AgentFirstCallbackAfterContactWorkConfig property is set
        internal bool IsSetAgentFirstCallbackAfterContactWorkConfig()
        {
            return this._agentFirstCallbackAfterContactWorkConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Channel. 
        /// <para>
        /// The channel for this ACW timeout configuration. Valid values: VOICE, CHAT, TASK, EMAIL.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Channel Channel
        {
            get { return this._channel; }
            set { this._channel = value; }
        }

        // Check to see if Channel property is set
        internal bool IsSetChannel()
        {
            return this._channel != null;
        }

    }
}