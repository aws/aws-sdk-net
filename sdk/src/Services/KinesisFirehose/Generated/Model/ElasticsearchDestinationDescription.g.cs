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
    /// The destination description in Amazon OpenSearch Service.
    /// </summary>
    public partial class ElasticsearchDestinationDescription
    {
        /// <summary>
        /// Gets and sets the property BufferingHints. 
        /// <para>
        /// The buffering options.
        /// </para>
        /// </summary>
        public ElasticsearchBufferingHints BufferingHints { get; set; }

        /// <summary>
        /// Checks to see if the BufferingHints property is set.
        /// </summary>
        internal bool IsSetBufferingHints() => this.BufferingHints != null;

        /// <summary>
        /// Gets and sets the property CloudWatchLoggingOptions. 
        /// <para>
        /// The Amazon CloudWatch logging options.
        /// </para>
        /// </summary>
        public CloudWatchLoggingOptions CloudWatchLoggingOptions { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchLoggingOptions property is set.
        /// </summary>
        internal bool IsSetCloudWatchLoggingOptions() => this.CloudWatchLoggingOptions != null;

        /// <summary>
        /// Gets and sets the property ClusterEndpoint. 
        /// <para>
        /// The endpoint to use when communicating with the cluster. Firehose uses either this
        /// <c>ClusterEndpoint</c> or the <c>DomainARN</c> field to send data to Amazon OpenSearch
        /// Service.
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
        /// The ARN of the Amazon OpenSearch Service domain. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and Amazon Web Services Service Namespaces</a>.
        /// </para>
        ///  
        /// <para>
        /// Firehose uses either <c>ClusterEndpoint</c> or <c>DomainARN</c> to send data to Amazon
        /// OpenSearch Service.
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
        /// The Elasticsearch index name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 80)]
        public string IndexName { get; set; }

        /// <summary>
        /// Checks to see if the IndexName property is set.
        /// </summary>
        internal bool IsSetIndexName() => this.IndexName != null;

        /// <summary>
        /// Gets and sets the property IndexRotationPeriod. 
        /// <para>
        /// The Elasticsearch index rotation period
        /// </para>
        /// </summary>
        public ElasticsearchIndexRotationPeriod IndexRotationPeriod { get; set; }

        /// <summary>
        /// Checks to see if the IndexRotationPeriod property is set.
        /// </summary>
        internal bool IsSetIndexRotationPeriod() => this.IndexRotationPeriod != null;

        /// <summary>
        /// Gets and sets the property ProcessingConfiguration. 
        /// <para>
        /// The data processing configuration.
        /// </para>
        /// </summary>
        public ProcessingConfiguration ProcessingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ProcessingConfiguration property is set.
        /// </summary>
        internal bool IsSetProcessingConfiguration() => this.ProcessingConfiguration != null;

        /// <summary>
        /// Gets and sets the property RetryOptions. 
        /// <para>
        /// The Amazon OpenSearch Service retry options.
        /// </para>
        /// </summary>
        public ElasticsearchRetryOptions RetryOptions { get; set; }

        /// <summary>
        /// Checks to see if the RetryOptions property is set.
        /// </summary>
        internal bool IsSetRetryOptions() => this.RetryOptions != null;

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services credentials. For more information,
        /// see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and Amazon Web Services Service Namespaces</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string RoleARN { get; set; }

        /// <summary>
        /// Checks to see if the RoleARN property is set.
        /// </summary>
        internal bool IsSetRoleARN() => this.RoleARN != null;

        /// <summary>
        /// Gets and sets the property S3BackupMode. 
        /// <para>
        /// The Amazon S3 backup mode.
        /// </para>
        /// </summary>
        public ElasticsearchS3BackupMode S3BackupMode { get; set; }

        /// <summary>
        /// Checks to see if the S3BackupMode property is set.
        /// </summary>
        internal bool IsSetS3BackupMode() => this.S3BackupMode != null;

        /// <summary>
        /// Gets and sets the property S3DestinationDescription. 
        /// <para>
        /// The Amazon S3 destination.
        /// </para>
        /// </summary>
        public S3DestinationDescription S3DestinationDescription { get; set; }

        /// <summary>
        /// Checks to see if the S3DestinationDescription property is set.
        /// </summary>
        internal bool IsSetS3DestinationDescription() => this.S3DestinationDescription != null;

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The Elasticsearch type name. This applies to Elasticsearch 6.x and lower versions.
        /// For Elasticsearch 7.x and OpenSearch Service 1.x, there's no value for <c>TypeName</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public string TypeName { get; set; }

        /// <summary>
        /// Checks to see if the TypeName property is set.
        /// </summary>
        internal bool IsSetTypeName() => this.TypeName != null;

        /// <summary>
        /// Gets and sets the property VpcConfigurationDescription. 
        /// <para>
        /// The details of the VPC of the Amazon OpenSearch or the Amazon OpenSearch Serverless
        /// destination.
        /// </para>
        /// </summary>
        public VpcConfigurationDescription VpcConfigurationDescription { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfigurationDescription property is set.
        /// </summary>
        internal bool IsSetVpcConfigurationDescription() => this.VpcConfigurationDescription != null;
    }
}
