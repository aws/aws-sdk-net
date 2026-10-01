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

namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// Container for the parameters to the ListSignalingChannels operation. Returns an array
    /// of <c>ChannelInfo</c> objects. Each object describes a signaling channel. To retrieve
    /// only those channels that satisfy a specific condition, you can specify a <c>ChannelNameCondition</c>.
    /// </summary>
    public partial class ListSignalingChannelsRequest : AmazonKinesisVideoRequest
    {
        /// <summary>
        /// Gets and sets the property ChannelNameCondition. 
        /// <para>
        /// Optional: Returns only the channels that satisfy a specific condition.
        /// </para>
        /// </summary>
        public ChannelNameCondition ChannelNameCondition { get; set; }

        /// <summary>
        /// Checks to see if the ChannelNameCondition property is set.
        /// </summary>
        internal bool IsSetChannelNameCondition() => this.ChannelNameCondition != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of channels to return in the response. The default is 500.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If you specify this parameter, when the result of a <c>ListSignalingChannels</c> operation
        /// is truncated, the call returns the <c>NextToken</c> in the response. To get another
        /// batch of channels, provide this token in your next request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
