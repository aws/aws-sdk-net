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

namespace Amazon.MediaPackageV2.Model
{
    /// <summary>
    /// Container for the parameters to the CancelHarvestJob operation. Cancels an in-progress
    /// harvest job.
    /// </summary>
    public partial class CancelHarvestJobRequest : AmazonMediaPackageV2Request
    {
        /// <summary>
        /// Gets and sets the property ChannelGroupName. 
        /// <para>
        /// The name of the channel group containing the channel from which the harvest job is
        /// running.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ChannelGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ChannelGroupName property is set.
        /// </summary>
        internal bool IsSetChannelGroupName() => this.ChannelGroupName != null;

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name of the channel from which the harvest job is running.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ChannelName { get; set; }

        /// <summary>
        /// Checks to see if the ChannelName property is set.
        /// </summary>
        internal bool IsSetChannelName() => this.ChannelName != null;

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// The current Entity Tag (ETag) associated with the harvest job. Used for concurrency
        /// control.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ETag { get; set; }

        /// <summary>
        /// Checks to see if the ETag property is set.
        /// </summary>
        internal bool IsSetETag() => this.ETag != null;

        /// <summary>
        /// Gets and sets the property HarvestJobName. 
        /// <para>
        /// The name of the harvest job to cancel. This name must be unique within the channel
        /// and cannot be changed after the harvest job is submitted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string HarvestJobName { get; set; }

        /// <summary>
        /// Checks to see if the HarvestJobName property is set.
        /// </summary>
        internal bool IsSetHarvestJobName() => this.HarvestJobName != null;

        /// <summary>
        /// Gets and sets the property OriginEndpointName. 
        /// <para>
        /// The name of the origin endpoint that the harvest job is harvesting from. This cannot
        /// be changed after the harvest job is submitted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string OriginEndpointName { get; set; }

        /// <summary>
        /// Checks to see if the OriginEndpointName property is set.
        /// </summary>
        internal bool IsSetOriginEndpointName() => this.OriginEndpointName != null;
    }
}
