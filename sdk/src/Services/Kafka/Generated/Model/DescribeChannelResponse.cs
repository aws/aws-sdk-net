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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
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
namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Contains the current configuration and state of a channel.
    /// </summary>
    public partial class DescribeChannelResponse : AmazonWebServiceResponse
    {
        private string _channelArn;
        private string _channelName;
        private string _clusterOperationArn;
        private DateTime? _creationTime;
        private ChannelDestinationType _destinationType;
        private EncryptionConfiguration _encryptionConfiguration;
        private IcebergDestinationConfiguration _icebergDestinationConfiguration;
        private ChannelLoggingInfo _loggingInfo;
        private S3DestinationConfiguration _s3DestinationConfiguration;
        private ChannelStateInfo _stateInfo;
        private ChannelStatus _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<TopicConfiguration> _topicConfigurationList = AWSConfigs.InitializeCollections ? new List<TopicConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property ChannelArn.             
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ChannelArn
        {
            get { return this._channelArn; }
            set { this._channelArn = value; }
        }

        // Check to see if ChannelArn property is set
        internal bool IsSetChannelArn()
        {
            return this._channelArn != null;
        }

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name of the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ClusterOperationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the in-flight cluster operation. Returned only while
        /// the channel is in CREATING, UPDATING, or DELETING.
        /// </para>
        /// </summary>
        public string ClusterOperationArn
        {
            get { return this._clusterOperationArn; }
            set { this._clusterOperationArn = value; }
        }

        // Check to see if ClusterOperationArn property is set
        internal bool IsSetClusterOperationArn()
        {
            return this._clusterOperationArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime.             
        /// <para>
        /// The time when the channel was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DestinationType. 
        /// <para>
        /// The type of destination configured for the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ChannelDestinationType DestinationType
        {
            get { return this._destinationType; }
            set { this._destinationType = value; }
        }

        // Check to see if DestinationType property is set
        internal bool IsSetDestinationType()
        {
            return this._destinationType != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The encryption configuration applied to the channel.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration
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
        /// Gets and sets the property IcebergDestinationConfiguration. 
        /// <para>
        /// The Apache Iceberg destination for the channel, if configured.
        /// </para>
        /// </summary>
        public IcebergDestinationConfiguration IcebergDestinationConfiguration
        {
            get { return this._icebergDestinationConfiguration; }
            set { this._icebergDestinationConfiguration = value; }
        }

        // Check to see if IcebergDestinationConfiguration property is set
        internal bool IsSetIcebergDestinationConfiguration()
        {
            return this._icebergDestinationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property LoggingInfo. 
        /// <para>
        /// The destinations to which the channel publishes operational logs.
        /// </para>
        /// </summary>
        public ChannelLoggingInfo LoggingInfo
        {
            get { return this._loggingInfo; }
            set { this._loggingInfo = value; }
        }

        // Check to see if LoggingInfo property is set
        internal bool IsSetLoggingInfo()
        {
            return this._loggingInfo != null;
        }

        /// <summary>
        /// Gets and sets the property S3DestinationConfiguration. 
        /// <para>
        /// The Amazon S3 destination for the channel, if configured.
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
        /// Gets and sets the property StateInfo. 
        /// <para>
        /// Additional context for the current channel state, populated when the channel is in
        /// FAILED.
        /// </para>
        /// </summary>
        public ChannelStateInfo StateInfo
        {
            get { return this._stateInfo; }
            set { this._stateInfo = value; }
        }

        // Check to see if StateInfo property is set
        internal bool IsSetStateInfo()
        {
            return this._stateInfo != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current lifecycle state of the channel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ChannelStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags attached to the channel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property TopicConfigurationList. 
        /// <para>
        /// The list of topic configurations for the channel.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<TopicConfiguration> TopicConfigurationList
        {
            get { return this._topicConfigurationList; }
            set { this._topicConfigurationList = value; }
        }

        // Check to see if TopicConfigurationList property is set
        internal bool IsSetTopicConfigurationList()
        {
            return this._topicConfigurationList != null && (this._topicConfigurationList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}