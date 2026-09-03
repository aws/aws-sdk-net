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
    /// Container for the parameters to the UpdateChannel operation.
    /// Updates the data freshness interval or the Amazon CloudWatch Logs configuration of
    /// an existing channel. You cannot change the destination, source stream, record format,
    /// schema, encryption configuration, or service execution role of an existing channel.
    /// To change any other setting, delete the channel and create a new one.
    /// 
    ///  
    /// <para>
    /// Updating a channel is an asynchronous operation. Upon receiving the request, Amazon
    /// Kinesis Data Streams sets the channel to the <c>UPDATING</c> state and returns immediately.
    /// After the change is applied, Amazon Kinesis Data Streams sets the channel back to
    /// the <c>ACTIVE</c> state.
    /// </para>
    ///  
    /// <para>
    /// This operation has a call limit of 5 transactions per second (TPS) for each Amazon
    /// Web Services account. Exceeding 5 TPS results in a <c>LimitExceededException</c>.
    /// </para>
    /// </summary>
    public partial class UpdateChannelRequest : AmazonKinesisRequest
    {
        private string _channelARN;
        private ChannelLoggingUpdateInput _loggingConfiguration;
        private S3DestinationUpdateInput _s3DestinationConfiguration;
        private S3TablesDestinationUpdateInput _s3TablesDestinationConfiguration;

        /// <summary>
        /// Gets and sets the property ChannelARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the channel to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ChannelARN
        {
            get { return this._channelARN; }
            set { this._channelARN = value; }
        }

        // Check to see if ChannelARN property is set
        internal bool IsSetChannelARN()
        {
            return this._channelARN != null;
        }

        /// <summary>
        /// Gets and sets the property LoggingConfiguration. 
        /// <para>
        /// The updated Amazon CloudWatch Logs configuration for the channel.
        /// </para>
        /// </summary>
        public ChannelLoggingUpdateInput LoggingConfiguration
        {
            get { return this._loggingConfiguration; }
            set { this._loggingConfiguration = value; }
        }

        // Check to see if LoggingConfiguration property is set
        internal bool IsSetLoggingConfiguration()
        {
            return this._loggingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property S3DestinationConfiguration. 
        /// <para>
        /// The updated configuration for a general purpose Amazon S3 destination. Only <c>DataFreshnessInSeconds</c>
        /// can be updated.
        /// </para>
        /// </summary>
        public S3DestinationUpdateInput S3DestinationConfiguration
        {
            get { return this._s3DestinationConfiguration; }
            set { this._s3DestinationConfiguration = value; }
        }

        // Check to see if S3DestinationConfiguration property is set
        internal bool IsSetS3DestinationConfiguration()
        {
            return this._s3DestinationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property S3TablesDestinationConfiguration. 
        /// <para>
        /// The updated configuration for a streaming table destination. Only <c>DataFreshnessInSeconds</c>
        /// can be updated.
        /// </para>
        /// </summary>
        public S3TablesDestinationUpdateInput S3TablesDestinationConfiguration
        {
            get { return this._s3TablesDestinationConfiguration; }
            set { this._s3TablesDestinationConfiguration = value; }
        }

        // Check to see if S3TablesDestinationConfiguration property is set
        internal bool IsSetS3TablesDestinationConfiguration()
        {
            return this._s3TablesDestinationConfiguration != null;
        }

    }
}