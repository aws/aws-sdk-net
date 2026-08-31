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
    /// Container for the parameters to the CreateChannel operation.
    /// Creates a channel that delivers records from a Kinesis data stream to a destination.
    /// A channel reads records from the specified stream and writes them to streaming tables
    /// on Apache Iceberg (Amazon S3 Tables) or to a general purpose Amazon S3 bucket.
    /// 
    ///  
    /// <para>
    /// You must specify either <c>S3DestinationConfiguration</c> or <c>S3TablesDestinationConfiguration</c>,
    /// but not both.
    /// </para>
    ///  
    /// <para>
    /// Creating a channel is an asynchronous operation. Upon receiving the request, Amazon
    /// Kinesis Data Streams returns immediately with the channel in the <c>CREATING</c> state.
    /// After provisioning is complete, Amazon Kinesis Data Streams sets the state to <c>ACTIVE</c>.
    /// You can use <a>DescribeChannel</a> to check the current state.
    /// </para>
    ///  
    /// <para>
    /// This operation is only supported for data streams with the on-demand capacity mode.
    /// </para>
    ///  
    /// <para>
    /// This API has a call limit of 5 transactions per second (TPS) for each Amazon Web Services
    /// account. Exceeding 5 TPS results in a <c>LimitExceededException</c>.
    /// </para>
    /// </summary>
    public partial class CreateChannelRequest : AmazonKinesisRequest
    {
        private string _channelName;
        private ChannelEncryptionConfiguration _encryptionConfiguration;
        private ChannelLoggingConfiguration _loggingConfiguration;
        private S3DestinationConfiguration _s3DestinationConfiguration;
        private S3TablesDestinationConfiguration _s3TablesDestinationConfiguration;
        private string _serviceExecutionRoleARN;
        private List<ChannelStreamConfiguration> _streamConfigurationList = AWSConfigs.InitializeCollections ? new List<ChannelStreamConfiguration>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name of the channel. The name is unique within your Amazon Web Services account
        /// and Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ChannelName
        {
            get { return this._channelName; }
            set { this._channelName = value; }
        }

        // Check to see if ChannelName property is set
        internal bool IsSetChannelName()
        {
            return this._channelName != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The server-side encryption configuration that uses an Amazon Web Services KMS key
        /// to encrypt data delivered to the destination.
        /// </para>
        /// </summary>
        public ChannelEncryptionConfiguration EncryptionConfiguration
        {
            get { return this._encryptionConfiguration; }
            set { this._encryptionConfiguration = value; }
        }

        // Check to see if EncryptionConfiguration property is set
        internal bool IsSetEncryptionConfiguration()
        {
            return this._encryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property LoggingConfiguration. 
        /// <para>
        /// The Amazon CloudWatch Logs configuration for the channel.
        /// </para>
        /// </summary>
        public ChannelLoggingConfiguration LoggingConfiguration
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
        /// The configuration for delivery to a general purpose Amazon S3 bucket. You must specify
        /// either <c>S3DestinationConfiguration</c> or <c>S3TablesDestinationConfiguration</c>,
        /// but not both.
        /// </para>
        /// </summary>
        public S3DestinationConfiguration S3DestinationConfiguration
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
        /// The configuration for delivery to streaming tables on Apache Iceberg in Amazon S3
        /// Tables. You must specify either <c>S3DestinationConfiguration</c> or <c>S3TablesDestinationConfiguration</c>,
        /// but not both.
        /// </para>
        /// </summary>
        public S3TablesDestinationConfiguration S3TablesDestinationConfiguration
        {
            get { return this._s3TablesDestinationConfiguration; }
            set { this._s3TablesDestinationConfiguration = value; }
        }

        // Check to see if S3TablesDestinationConfiguration property is set
        internal bool IsSetS3TablesDestinationConfiguration()
        {
            return this._s3TablesDestinationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceExecutionRoleARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that Amazon Kinesis Data Streams assumes
        /// to write records to the destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string ServiceExecutionRoleARN
        {
            get { return this._serviceExecutionRoleARN; }
            set { this._serviceExecutionRoleARN = value; }
        }

        // Check to see if ServiceExecutionRoleARN property is set
        internal bool IsSetServiceExecutionRoleARN()
        {
            return this._serviceExecutionRoleARN != null;
        }

        /// <summary>
        /// Gets and sets the property StreamConfigurationList. 
        /// <para>
        /// The source stream configuration for the channel. Currently, one stream is supported
        /// per channel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10000)]
        public List<ChannelStreamConfiguration> StreamConfigurationList
        {
            get { return this._streamConfigurationList; }
            set { this._streamConfigurationList = value; }
        }

        // Check to see if StreamConfigurationList property is set
        internal bool IsSetStreamConfigurationList()
        {
            return this._streamConfigurationList != null && (this._streamConfigurationList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A set of key-value pairs to assign to the channel. A tag consists of a required key
        /// and an optional value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}