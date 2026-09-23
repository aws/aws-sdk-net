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

namespace Amazon.IVS.Model
{
    /// <summary>
    /// Container for the parameters to the InsertAdBreak operation. Inserts an ad marker
    /// in the playlist for the specified channel and duration using the ad configuration
    /// associated with the channel. <para> <b>Note:</b> AWS Elemental MediaTailor (EMT),
    /// the service that handles ad requests, provides CloudWatch metrics to help you monitor
    /// the success or failure of each InsertAdBreak operation. See <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/monitoring-cloudwatch-metrics.html">Monitoring
    /// AWS Elemental MediaTailor with Amazon CloudWatch</a> metrics in the <i>AWS Elemental
    /// MediaTailor User Guide</i> for details on available metrics. </para>
    /// </summary>
    public partial class InsertAdBreakRequest : AmazonIVSRequest
    {
        /// <summary>
        /// Gets and sets the property ChannelArn. 
        /// <para>
        /// ARN of the channel into which the ad break is inserted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ChannelArn { get; set; }

        /// <summary>
        /// Checks to see if the ChannelArn property is set.
        /// </summary>
        internal bool IsSetChannelArn() => this.ChannelArn != null;

        /// <summary>
        /// Gets and sets the property DurationSeconds. 
        /// <para>
        /// Duration of the ad break, in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 300)]
        public int? DurationSeconds { get; set; }

        /// <summary>
        /// Checks to see if the DurationSeconds property is set.
        /// </summary>
        internal bool IsSetDurationSeconds() => this.DurationSeconds.HasValue;
    }
}
