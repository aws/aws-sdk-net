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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
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
    /// Container for the parameters to the UpdateStreamMode operation.
    /// Updates the capacity mode of the data stream. Currently, in Kinesis Data Streams,
    /// you can choose between an <b>on-demand</b> capacity mode and a <b>provisioned</b>
    /// capacity mode for your data stream. 
    /// 
    ///  
    /// <para>
    /// If you'd still like to proactively scale your on-demand data stream’s capacity, you
    /// can unlock the warm throughput feature for on-demand data streams by enabling <c>MinimumThroughputBillingCommitment</c>
    /// for your account. Once your account has <c>MinimumThroughputBillingCommitment</c>
    /// enabled, you can specify the warm throughput in MiB per second that your stream can
    /// support in writes.
    /// </para>
    /// </summary>
    public partial class UpdateStreamModeRequest : AmazonKinesisRequest
    {
        private string _streamARN;
        private string _streamId;
        private StreamModeDetails _streamModeDetails;
        private int? _warmThroughputMiBps;

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        ///  Specifies the ARN of the data stream whose capacity mode you want to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string StreamARN
        {
            get { return this._streamARN; }
            set { this._streamARN = value; }
        }

        // Check to see if StreamARN property is set
        internal bool IsSetStreamARN()
        {
            return this._streamARN != null;
        }

        /// <summary>
        /// Gets and sets the property StreamId. 
        /// <para>
        /// Not Implemented. Reserved for future use.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=24)]
        public string StreamId
        {
            get { return this._streamId; }
            set { this._streamId = value; }
        }

        // Check to see if StreamId property is set
        internal bool IsSetStreamId()
        {
            return this._streamId != null;
        }

        /// <summary>
        /// Gets and sets the property StreamModeDetails. 
        /// <para>
        ///  Specifies the capacity mode to which you want to set your data stream. Currently,
        /// in Kinesis Data Streams, you can choose between an <b>on-demand</b> capacity mode
        /// and a <b>provisioned</b> capacity mode for your data streams. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StreamModeDetails StreamModeDetails
        {
            get { return this._streamModeDetails; }
            set { this._streamModeDetails = value; }
        }

        // Check to see if StreamModeDetails property is set
        internal bool IsSetStreamModeDetails()
        {
            return this._streamModeDetails != null;
        }

        /// <summary>
        /// Gets and sets the property WarmThroughputMiBps. 
        /// <para>
        /// The target warm throughput in MB/s that the stream should be scaled to handle. This
        /// represents the throughput capacity that will be immediately available for write operations.
        /// This field is only valid when the stream mode is being updated to on-demand.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? WarmThroughputMiBps
        {
            get { return this._warmThroughputMiBps; }
            set { this._warmThroughputMiBps = value; }
        }

        // Check to see if WarmThroughputMiBps property is set
        internal bool IsSetWarmThroughputMiBps()
        {
            return this._warmThroughputMiBps.HasValue; 
        }

    }
}