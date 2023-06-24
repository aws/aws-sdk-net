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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// The destination description in Amazon OpenSearch Service.
    /// </summary>
    public partial class AmazonopensearchserviceDestinationDescription
    {
        private AmazonopensearchserviceBufferingHints _bufferingHints;
        private CloudWatchLoggingOptions _cloudWatchLoggingOptions;
        private string _clusterEndpoint;
        private string _domainARN;
        private string _indexName;
        private AmazonopensearchserviceIndexRotationPeriod _indexRotationPeriod;
        private ProcessingConfiguration _processingConfiguration;
        private AmazonopensearchserviceRetryOptions _retryOptions;
        private string _roleARN;
        private AmazonopensearchserviceS3BackupMode _s3BackupMode;
        private S3DestinationDescription _s3DestinationDescription;
        private string _typeName;
        private VpcConfigurationDescription _vpcConfigurationDescription;

        /// <summary>
        /// Gets and sets the property BufferingHints. 
        /// <para>
        /// The buffering options.
        /// </para>
        /// </summary>
        public AmazonopensearchserviceBufferingHints BufferingHints
        {
            get { return this._bufferingHints; }
            set { this._bufferingHints = value; }
        }

        // Check to see if BufferingHints property is set
        internal bool IsSetBufferingHints()
        {
            return this._bufferingHints != null;
        }

        /// <summary>
        /// Gets and sets the property CloudWatchLoggingOptions.
        /// </summary>
        public CloudWatchLoggingOptions CloudWatchLoggingOptions
        {
            get { return this._cloudWatchLoggingOptions; }
            set { this._cloudWatchLoggingOptions = value; }
        }

        // Check to see if CloudWatchLoggingOptions property is set
        internal bool IsSetCloudWatchLoggingOptions()
        {
            return this._cloudWatchLoggingOptions != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterEndpoint. 
        /// <para>
        /// The endpoint to use when communicating with the cluster. Kinesis Data Firehose uses
        /// either this ClusterEndpoint or the DomainARN field to send data to Amazon OpenSearch
        /// Service. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string ClusterEndpoint
        {
            get { return this._clusterEndpoint; }
            set { this._clusterEndpoint = value; }
        }

        // Check to see if ClusterEndpoint property is set
        internal bool IsSetClusterEndpoint()
        {
            return this._clusterEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property DomainARN. 
        /// <para>
        /// The ARN of the Amazon OpenSearch Service domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string DomainARN
        {
            get { return this._domainARN; }
            set { this._domainARN = value; }
        }

        // Check to see if DomainARN property is set
        internal bool IsSetDomainARN()
        {
            return this._domainARN != null;
        }

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The Amazon OpenSearch Service index name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=80)]
        public string IndexName
        {
            get { return this._indexName; }
            set { this._indexName = value; }
        }

        // Check to see if IndexName property is set
        internal bool IsSetIndexName()
        {
            return this._indexName != null;
        }

        /// <summary>
        /// Gets and sets the property IndexRotationPeriod. 
        /// <para>
        /// The Amazon OpenSearch Service index rotation period
        /// </para>
        /// </summary>
        public AmazonopensearchserviceIndexRotationPeriod IndexRotationPeriod
        {
            get { return this._indexRotationPeriod; }
            set { this._indexRotationPeriod = value; }
        }

        // Check to see if IndexRotationPeriod property is set
        internal bool IsSetIndexRotationPeriod()
        {
            return this._indexRotationPeriod != null;
        }

        /// <summary>
        /// Gets and sets the property ProcessingConfiguration.
        /// </summary>
        public ProcessingConfiguration ProcessingConfiguration
        {
            get { return this._processingConfiguration; }
            set { this._processingConfiguration = value; }
        }

        // Check to see if ProcessingConfiguration property is set
        internal bool IsSetProcessingConfiguration()
        {
            return this._processingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RetryOptions. 
        /// <para>
        /// The Amazon OpenSearch Service retry options.
        /// </para>
        /// </summary>
        public AmazonopensearchserviceRetryOptions RetryOptions
        {
            get { return this._retryOptions; }
            set { this._retryOptions = value; }
        }

        // Check to see if RetryOptions property is set
        internal bool IsSetRetryOptions()
        {
            return this._retryOptions != null;
        }

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services credentials. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string RoleARN
        {
            get { return this._roleARN; }
            set { this._roleARN = value; }
        }

        // Check to see if RoleARN property is set
        internal bool IsSetRoleARN()
        {
            return this._roleARN != null;
        }

        /// <summary>
        /// Gets and sets the property S3BackupMode. 
        /// <para>
        /// The Amazon S3 backup mode.
        /// </para>
        /// </summary>
        public AmazonopensearchserviceS3BackupMode S3BackupMode
        {
            get { return this._s3BackupMode; }
            set { this._s3BackupMode = value; }
        }

        // Check to see if S3BackupMode property is set
        internal bool IsSetS3BackupMode()
        {
            return this._s3BackupMode != null;
        }

        /// <summary>
        /// Gets and sets the property S3DestinationDescription.
        /// </summary>
        public S3DestinationDescription S3DestinationDescription
        {
            get { return this._s3DestinationDescription; }
            set { this._s3DestinationDescription = value; }
        }

        // Check to see if S3DestinationDescription property is set
        internal bool IsSetS3DestinationDescription()
        {
            return this._s3DestinationDescription != null;
        }

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The Amazon OpenSearch Service type name. This applies to Elasticsearch 6.x and lower
        /// versions. For Elasticsearch 7.x and OpenSearch Service 1.x, there's no value for TypeName.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public string TypeName
        {
            get { return this._typeName; }
            set { this._typeName = value; }
        }

        // Check to see if TypeName property is set
        internal bool IsSetTypeName()
        {
            return this._typeName != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfigurationDescription.
        /// </summary>
        public VpcConfigurationDescription VpcConfigurationDescription
        {
            get { return this._vpcConfigurationDescription; }
            set { this._vpcConfigurationDescription = value; }
        }

        // Check to see if VpcConfigurationDescription property is set
        internal bool IsSetVpcConfigurationDescription()
        {
            return this._vpcConfigurationDescription != null;
        }

    }
}