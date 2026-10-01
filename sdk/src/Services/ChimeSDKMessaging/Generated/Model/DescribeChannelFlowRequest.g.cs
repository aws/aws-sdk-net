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

namespace Amazon.ChimeSDKMessaging.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeChannelFlow operation. Returns the full
    /// details of a channel flow in an Amazon Chime <c>AppInstance</c>. This is a developer
    /// API.
    /// </summary>
    public partial class DescribeChannelFlowRequest : AmazonChimeSDKMessagingRequest
    {
        /// <summary>
        /// Gets and sets the property ChannelFlowArn. 
        /// <para>
        /// The ARN of the channel flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 1600)]
        public string ChannelFlowArn { get; set; }

        /// <summary>
        /// Checks to see if the ChannelFlowArn property is set.
        /// </summary>
        internal bool IsSetChannelFlowArn() => this.ChannelFlowArn != null;
    }
}
