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

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// This is the response object from the DescribeLimits operation.
    /// </summary>
    public partial class DescribeLimitsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ChannelCount. 
        /// <para>
        /// The number of channels in the account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000000)]
        public int? ChannelCount { get; set; }

        /// <summary>
        /// Checks to see if the ChannelCount property is set.
        /// </summary>
        internal bool IsSetChannelCount() => this.ChannelCount.HasValue;

        /// <summary>
        /// Gets and sets the property ChannelCountLimit. 
        /// <para>
        /// The maximum number of channels allowed in the account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000000)]
        public int? ChannelCountLimit { get; set; }

        /// <summary>
        /// Checks to see if the ChannelCountLimit property is set.
        /// </summary>
        internal bool IsSetChannelCountLimit() => this.ChannelCountLimit.HasValue;

        /// <summary>
        /// Gets and sets the property OnDemandStreamCount. 
        /// <para>
        ///  Indicates the number of data streams with the on-demand capacity mode.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1000000)]
        public int? OnDemandStreamCount { get; set; }

        /// <summary>
        /// Checks to see if the OnDemandStreamCount property is set.
        /// </summary>
        internal bool IsSetOnDemandStreamCount() => this.OnDemandStreamCount.HasValue;

        /// <summary>
        /// Gets and sets the property OnDemandStreamCountLimit. 
        /// <para>
        ///  The maximum number of data streams with the on-demand capacity mode. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1000000)]
        public int? OnDemandStreamCountLimit { get; set; }

        /// <summary>
        /// Checks to see if the OnDemandStreamCountLimit property is set.
        /// </summary>
        internal bool IsSetOnDemandStreamCountLimit() => this.OnDemandStreamCountLimit.HasValue;

        /// <summary>
        /// Gets and sets the property OpenShardCount. 
        /// <para>
        /// The number of open shards.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1000000)]
        public int? OpenShardCount { get; set; }

        /// <summary>
        /// Checks to see if the OpenShardCount property is set.
        /// </summary>
        internal bool IsSetOpenShardCount() => this.OpenShardCount.HasValue;

        /// <summary>
        /// Gets and sets the property ShardLimit. 
        /// <para>
        /// The maximum number of shards.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1000000)]
        public int? ShardLimit { get; set; }

        /// <summary>
        /// Checks to see if the ShardLimit property is set.
        /// </summary>
        internal bool IsSetShardLimit() => this.ShardLimit.HasValue;
    }
}
