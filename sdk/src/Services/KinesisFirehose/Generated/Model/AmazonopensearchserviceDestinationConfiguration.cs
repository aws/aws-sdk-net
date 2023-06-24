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
    /// Describes the configuration of a destination in Amazon OpenSearch Service
    /// </summary>
    public partial class AmazonopensearchserviceDestinationConfiguration
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
        private S3DestinationConfiguration _s3Configuration;
        private string _typeName;
        private VpcConfiguration _vpcConfiguration;

        /// <summary>
        /// Gets and sets the property BufferingHints. 
        /// <para>
        /// The buffering options. If no value is specified, the default values for AmazonopensearchserviceBufferingHints
        /// are used. 
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
        /// The endpoint to use when communicating with the cluster. Specify either this ClusterEndpoint
        /// or the DomainARN field. 
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
        /// The ARN of the Amazon OpenSearch Service domain. The IAM role must have permissions
        /// for DescribeElasticsearchDomain, DescribeElasticsearchDomains, and DescribeElasticsearchDomainConfig
        /// after assuming the role specified in RoleARN. 
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
        /// The ElasticsearAmazon OpenSearch Service index name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=80)]
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
        /// The Amazon OpenSearch Service index rotation period. Index rotation appends a timestamp
        /// to the IndexName to facilitate the expiration of old data.
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
        /// The retry behavior in case Kinesis Data Firehose is unable to deliver documents to
        /// Amazon OpenSearch Service. The default value is 300 (5 minutes). 
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
        /// The Amazon Resource Name (ARN) of the IAM role to be assumed by Kinesis Data Firehose
        /// for calling the Amazon OpenSearch Service Configuration API and for indexing documents.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
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
        /// Defines how documents should be delivered to Amazon S3. When it is set to FailedDocumentsOnly,
        /// Kinesis Data Firehose writes any documents that could not be indexed to the configured
        /// Amazon S3 destination, with AmazonOpenSearchService-failed/ appended to the key prefix.
        /// When set to AllDocuments, Kinesis Data Firehose delivers all incoming records to Amazon
        /// S3, and also writes failed documents with AmazonOpenSearchService-failed/ appended
        /// to the prefix. 
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
        /// Gets and sets the property S3Configuration.
        /// </summary>
        [AWSProperty(Required=true)]
        public S3DestinationConfiguration S3Configuration
        {
            get { return this._s3Configuration; }
            set { this._s3Configuration = value; }
        }

        // Check to see if S3Configuration property is set
        internal bool IsSetS3Configuration()
        {
            return this._s3Configuration != null;
        }

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The Amazon OpenSearch Service type name. For Elasticsearch 6.x, there can be only
        /// one type per index. If you try to specify a new type for an existing index that already
        /// has another type, Kinesis Data Firehose returns an error during run time. 
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
        /// Gets and sets the property VpcConfiguration.
        /// </summary>
        public VpcConfiguration VpcConfiguration
        {
            get { return this._vpcConfiguration; }
            set { this._vpcConfiguration = value; }
        }

        // Check to see if VpcConfiguration property is set
        internal bool IsSetVpcConfiguration()
        {
            return this._vpcConfiguration != null;
        }

    }
}