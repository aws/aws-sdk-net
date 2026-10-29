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
    /// Describes the configuration of a destination in Amazon OpenSearch Service
    /// </summary>
    public partial class AmazonopensearchserviceDestinationConfiguration
    {
        /// <summary>
        /// Gets and sets the property BufferingHints. 
        /// <para>
        /// The buffering options. If no value is specified, the default values for AmazonopensearchserviceBufferingHints
        /// are used. 
        /// </para>
        /// </summary>
        public AmazonopensearchserviceBufferingHints BufferingHints { get; set; }

        /// <summary>
        /// Checks to see if the BufferingHints property is set.
        /// </summary>
        internal bool IsSetBufferingHints() => this.BufferingHints != null;

        /// <summary>
        /// Gets and sets the property CloudWatchLoggingOptions.
        /// </summary>
        public CloudWatchLoggingOptions CloudWatchLoggingOptions { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchLoggingOptions property is set.
        /// </summary>
        internal bool IsSetCloudWatchLoggingOptions() => this.CloudWatchLoggingOptions != null;

        /// <summary>
        /// Gets and sets the property ClusterEndpoint. 
        /// <para>
        /// The endpoint to use when communicating with the cluster. Specify either this ClusterEndpoint
        /// or the DomainARN field. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string ClusterEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the ClusterEndpoint property is set.
        /// </summary>
        internal bool IsSetClusterEndpoint() => this.ClusterEndpoint != null;

        /// <summary>
        /// Gets and sets the property DocumentIdOptions. 
        /// <para>
        /// Indicates the method for setting up document ID. The supported methods are Firehose
        /// generated document ID and OpenSearch Service generated document ID.
        /// </para>
        /// </summary>
        public DocumentIdOptions DocumentIdOptions { get; set; }

        /// <summary>
        /// Checks to see if the DocumentIdOptions property is set.
        /// </summary>
        internal bool IsSetDocumentIdOptions() => this.DocumentIdOptions != null;

        /// <summary>
        /// Gets and sets the property DomainARN. 
        /// <para>
        /// The ARN of the Amazon OpenSearch Service domain. The IAM role must have permissions
        /// for DescribeElasticsearchDomain, DescribeElasticsearchDomains, and DescribeElasticsearchDomainConfig
        /// after assuming the role specified in RoleARN. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string DomainARN { get; set; }

        /// <summary>
        /// Checks to see if the DomainARN property is set.
        /// </summary>
        internal bool IsSetDomainARN() => this.DomainARN != null;

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The ElasticsearAmazon OpenSearch Service index name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 80)]
        public string IndexName { get; set; }

        /// <summary>
        /// Checks to see if the IndexName property is set.
        /// </summary>
        internal bool IsSetIndexName() => this.IndexName != null;

        /// <summary>
        /// Gets and sets the property IndexRotationPeriod. 
        /// <para>
        /// The Amazon OpenSearch Service index rotation period. Index rotation appends a timestamp
        /// to the IndexName to facilitate the expiration of old data.
        /// </para>
        /// </summary>
        public AmazonopensearchserviceIndexRotationPeriod IndexRotationPeriod { get; set; }

        /// <summary>
        /// Checks to see if the IndexRotationPeriod property is set.
        /// </summary>
        internal bool IsSetIndexRotationPeriod() => this.IndexRotationPeriod != null;

        /// <summary>
        /// Gets and sets the property ProcessingConfiguration.
        /// </summary>
        public ProcessingConfiguration ProcessingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ProcessingConfiguration property is set.
        /// </summary>
        internal bool IsSetProcessingConfiguration() => this.ProcessingConfiguration != null;

        /// <summary>
        /// Gets and sets the property RetryOptions. 
        /// <para>
        /// The retry behavior in case Firehose is unable to deliver documents to Amazon OpenSearch
        /// Service. The default value is 300 (5 minutes). 
        /// </para>
        /// </summary>
        public AmazonopensearchserviceRetryOptions RetryOptions { get; set; }

        /// <summary>
        /// Checks to see if the RetryOptions property is set.
        /// </summary>
        internal bool IsSetRetryOptions() => this.RetryOptions != null;

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role to be assumed by Firehose for calling
        /// the Amazon OpenSearch Service Configuration API and for indexing documents.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string RoleARN { get; set; }

        /// <summary>
        /// Checks to see if the RoleARN property is set.
        /// </summary>
        internal bool IsSetRoleARN() => this.RoleARN != null;

        /// <summary>
        /// Gets and sets the property S3BackupMode. 
        /// <para>
        /// Defines how documents should be delivered to Amazon S3. When it is set to FailedDocumentsOnly,
        /// Firehose writes any documents that could not be indexed to the configured Amazon S3
        /// destination, with AmazonOpenSearchService-failed/ appended to the key prefix. When
        /// set to AllDocuments, Firehose delivers all incoming records to Amazon S3, and also
        /// writes failed documents with AmazonOpenSearchService-failed/ appended to the prefix.
        /// 
        /// </para>
        /// </summary>
        public AmazonopensearchserviceS3BackupMode S3BackupMode { get; set; }

        /// <summary>
        /// Checks to see if the S3BackupMode property is set.
        /// </summary>
        internal bool IsSetS3BackupMode() => this.S3BackupMode != null;

        /// <summary>
        /// Gets and sets the property S3Configuration.
        /// </summary>
        [AWSProperty(Required = true)]
        public S3DestinationConfiguration S3Configuration { get; set; }

        /// <summary>
        /// Checks to see if the S3Configuration property is set.
        /// </summary>
        internal bool IsSetS3Configuration() => this.S3Configuration != null;

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The Amazon OpenSearch Service type name. For Elasticsearch 6.x, there can be only
        /// one type per index. If you try to specify a new type for an existing index that already
        /// has another type, Firehose returns an error during run time. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public string TypeName { get; set; }

        /// <summary>
        /// Checks to see if the TypeName property is set.
        /// </summary>
        internal bool IsSetTypeName() => this.TypeName != null;

        /// <summary>
        /// Gets and sets the property VpcConfiguration.
        /// </summary>
        public VpcConfiguration VpcConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfiguration property is set.
        /// </summary>
        internal bool IsSetVpcConfiguration() => this.VpcConfiguration != null;
    }
}
