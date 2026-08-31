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
    /// Describes the configuration and current status of a channel.
    /// </summary>
    public partial class ChannelDescription
    {
        private string _channelARN;
        private DateTime? _channelCreationTimestamp;
        private string _channelId;
        private string _channelName;
        private ChannelStatus _channelStatus;
        private string _channelStatusReason;
        private ChannelEncryptionConfiguration _encryptionConfiguration;
        private ChannelLoggingConfiguration _loggingConfiguration;
        private S3DestinationDescription _s3DestinationConfiguration;
        private S3TablesDestinationDescription _s3TablesDestinationConfiguration;
        private string _serviceExecutionRoleARN;
        private List<ChannelStreamDescription> _streamConfigurationList = AWSConfigs.InitializeCollections ? new List<ChannelStreamDescription>() : null;

        /// <summary>
        /// Gets and sets the property ChannelARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the channel.
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
        /// Gets and sets the property ChannelCreationTimestamp. 
        /// <para>
        /// The time at which the channel was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? ChannelCreationTimestamp
        {
            get { return this._channelCreationTimestamp; }
            set { this._channelCreationTimestamp = value; }
        }

        // Check to see if ChannelCreationTimestamp property is set
        internal bool IsSetChannelCreationTimestamp()
        {
            return this._channelCreationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ChannelId. 
        /// <para>
        /// The unique identifier of the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ChannelId
        {
            get { return this._channelId; }
            set { this._channelId = value; }
        }

        // Check to see if ChannelId property is set
        internal bool IsSetChannelId()
        {
            return this._channelId != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name of the channel.
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
        /// Gets and sets the property ChannelStatus. 
        /// <para>
        /// The current status of the channel. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - See <c>ChannelStatusReason</c> for the failure cause.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ChannelStatus ChannelStatus
        {
            get { return this._channelStatus; }
            set { this._channelStatus = value; }
        }

        // Check to see if ChannelStatus property is set
        internal bool IsSetChannelStatus()
        {
            return this._channelStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelStatusReason. 
        /// <para>
        /// A message describing the reason for a <c>FAILED</c> status.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ChannelStatusReason
        {
            get { return this._channelStatusReason; }
            set { this._channelStatusReason = value; }
        }

        // Check to see if ChannelStatusReason property is set
        internal bool IsSetChannelStatusReason()
        {
            return this._channelStatusReason != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The server-side encryption configuration for the channel.
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
        [AWSProperty(Required=true)]
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
        /// The configuration for delivery to a general purpose Amazon S3 bucket. Present only
        /// when the channel destination is a general purpose Amazon S3 bucket.
        /// </para>
        /// </summary>
        public S3DestinationDescription S3DestinationConfiguration
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
        /// Tables. Present only when the channel destination is a streaming table.
        /// </para>
        /// </summary>
        public S3TablesDestinationDescription S3TablesDestinationConfiguration
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
        /// The source stream configuration for the channel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10000)]
        public List<ChannelStreamDescription> StreamConfigurationList
        {
            get { return this._streamConfigurationList; }
            set { this._streamConfigurationList = value; }
        }

        // Check to see if StreamConfigurationList property is set
        internal bool IsSetStreamConfigurationList()
        {
            return this._streamConfigurationList != null && (this._streamConfigurationList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}