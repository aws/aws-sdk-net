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
 * Do not modify this file. This file is generated from the chime-sdk-messaging-2021-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKMessaging.Model
{
    /// <summary>
    /// Summary of details of a channel flow.
    /// </summary>
    public partial class ChannelFlowSummary
    {
        private string _channelFlowArn;
        private string _name;
        private List<Processor> _processors = new List<Processor>();

        /// <summary>
        /// Gets and sets the property ChannelFlowArn. 
        /// <para>
        /// The ARN of the channel flow.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=1600)]
        public string ChannelFlowArn
        {
            get { return this._channelFlowArn; }
            set { this._channelFlowArn = value; }
        }

        // Check to see if ChannelFlowArn property is set
        internal bool IsSetChannelFlowArn()
        {
            return this._channelFlowArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the channel flow.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Processors. 
        /// <para>
        /// Information about the processor Lambda functions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3)]
        public List<Processor> Processors
        {
            get { return this._processors; }
            set { this._processors = value; }
        }

        // Check to see if Processors property is set
        internal bool IsSetProcessors()
        {
            return this._processors != null && this._processors.Count > 0; 
        }

    }
}