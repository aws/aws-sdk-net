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

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Describes the buffering to perform before delivering data to the Serverless offering
    /// for Amazon OpenSearch Service destination.
    /// </summary>
    public partial class AmazonOpenSearchServerlessBufferingHints
    {
        /// <summary>
        /// Gets and sets the property IntervalInSeconds. 
        /// <para>
        /// Buffer incoming data for the specified period of time, in seconds, before delivering
        /// it to the destination. The default value is 300 (5 minutes).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 900)]
        public int? IntervalInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the IntervalInSeconds property is set.
        /// </summary>
        internal bool IsSetIntervalInSeconds() => this.IntervalInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property SizeInMBs. 
        /// <para>
        /// Buffer incoming data to the specified size, in MBs, before delivering it to the destination.
        /// The default value is 5. 
        /// </para>
        ///  
        /// <para>
        /// We recommend setting this parameter to a value greater than the amount of data you
        /// typically ingest into the Firehose stream in 10 seconds. For example, if you typically
        /// ingest data at 1 MB/sec, the value should be 10 MB or higher.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? SizeInMBs { get; set; }

        /// <summary>
        /// Checks to see if the SizeInMBs property is set.
        /// </summary>
        internal bool IsSetSizeInMBs() => this.SizeInMBs.HasValue;
    }
}
