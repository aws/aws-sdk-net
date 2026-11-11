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
    /// Container for the parameters to the UpdateDestination operation. Updates the specified
    /// destination of the specified Firehose stream. <para> Use this operation to change
    /// the destination type (for example, to replace the Amazon S3 destination with Amazon
    /// Redshift) or change the parameters associated with a destination (for example, to
    /// change the bucket name of the Amazon S3 destination). The update might not occur immediately.
    /// The target Firehose stream remains active while the configurations are updated, so
    /// data writes to the Firehose stream can continue during this process. The updated configurations
    /// are usually effective within a few minutes. </para> <para> Switching between Amazon
    /// OpenSearch Service and other services is not supported. For an Amazon OpenSearch Service
    /// destination, you can only update to another Amazon OpenSearch Service destination.
    /// </para> <para> If the destination type is the same, Firehose merges the configuration
    /// parameters specified with the destination configuration that already exists on the
    /// delivery stream. If any of the parameters are not specified in the call, the existing
    /// values are retained. For example, in the Amazon S3 destination, if <a>EncryptionConfiguration</a>
    /// is not specified, then the existing <c>EncryptionConfiguration</c> is maintained on
    /// the destination. </para> <para> If the destination type is not the same, for example,
    /// changing the destination from Amazon S3 to Amazon Redshift, Firehose does not merge
    /// any parameters. In this case, all parameters must be specified. </para> <para> Firehose
    /// uses <c>CurrentDeliveryStreamVersionId</c> to avoid race conditions and conflicting
    /// merges. This is a required field, and the service updates the configuration only if
    /// the existing configuration has a version ID that matches. After the update is applied
    /// successfully, the version ID is updated, and can be retrieved using <a>DescribeDeliveryStream</a>.
    /// Use the new version ID to set <c>CurrentDeliveryStreamVersionId</c> in the next call.
    /// </para>
    /// </summary>
    public partial class UpdateDestinationRequest : AmazonKinesisFirehoseRequest
    {
        /// <summary>
        /// Gets and sets the property AmazonOpenSearchServerlessDestinationUpdate. 
        /// <para>
        /// Describes an update for a destination in the Serverless offering for Amazon OpenSearch
        /// Service.
        /// </para>
        /// </summary>
        public AmazonOpenSearchServerlessDestinationUpdate AmazonOpenSearchServerlessDestinationUpdate { get; set; }

        /// <summary>
        /// Checks to see if the AmazonOpenSearchServerlessDestinationUpdate property is set.
        /// </summary>
        internal bool IsSetAmazonOpenSearchServerlessDestinationUpdate() => this.AmazonOpenSearchServerlessDestinationUpdate != null;

        /// <summary>
        /// Gets and sets the property AmazonopensearchserviceDestinationUpdate. 
        /// <para>
        /// Describes an update for a destination in Amazon OpenSearch Service.
        /// </para>
        /// </summary>
        public AmazonopensearchserviceDestinationUpdate AmazonopensearchserviceDestinationUpdate { get; set; }

        /// <summary>
        /// Checks to see if the AmazonopensearchserviceDestinationUpdate property is set.
        /// </summary>
        internal bool IsSetAmazonopensearchserviceDestinationUpdate() => this.AmazonopensearchserviceDestinationUpdate != null;

        /// <summary>
        /// Gets and sets the property CurrentDeliveryStreamVersionId. 
        /// <para>
        /// Obtain this value from the <c>VersionId</c> result of <a>DeliveryStreamDescription</a>.
        /// This value is required, and helps the service perform conditional operations. For
        /// example, if there is an interleaving update and this value is null, then the update
        /// destination fails. After the update is successful, the <c>VersionId</c> value is updated.
        /// The service then performs a merge of the old configuration with the new configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public string CurrentDeliveryStreamVersionId { get; set; }

        /// <summary>
        /// Checks to see if the CurrentDeliveryStreamVersionId property is set.
        /// </summary>
        internal bool IsSetCurrentDeliveryStreamVersionId() => this.CurrentDeliveryStreamVersionId != null;

        /// <summary>
        /// Gets and sets the property DeliveryStreamName. 
        /// <para>
        /// The name of the Firehose stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string DeliveryStreamName { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryStreamName property is set.
        /// </summary>
        internal bool IsSetDeliveryStreamName() => this.DeliveryStreamName != null;

        /// <summary>
        /// Gets and sets the property DestinationId. 
        /// <para>
        /// The ID of the destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string DestinationId { get; set; }

        /// <summary>
        /// Checks to see if the DestinationId property is set.
        /// </summary>
        internal bool IsSetDestinationId() => this.DestinationId != null;

        /// <summary>
        /// Gets and sets the property ElasticsearchDestinationUpdate. 
        /// <para>
        /// Describes an update for a destination in Amazon OpenSearch Service.
        /// </para>
        /// </summary>
        public ElasticsearchDestinationUpdate ElasticsearchDestinationUpdate { get; set; }

        /// <summary>
        /// Checks to see if the ElasticsearchDestinationUpdate property is set.
        /// </summary>
        internal bool IsSetElasticsearchDestinationUpdate() => this.ElasticsearchDestinationUpdate != null;

        /// <summary>
        /// Gets and sets the property ExtendedS3DestinationUpdate. 
        /// <para>
        /// Describes an update for a destination in Amazon S3.
        /// </para>
        /// </summary>
        public ExtendedS3DestinationUpdate ExtendedS3DestinationUpdate { get; set; }

        /// <summary>
        /// Checks to see if the ExtendedS3DestinationUpdate property is set.
        /// </summary>
        internal bool IsSetExtendedS3DestinationUpdate() => this.ExtendedS3DestinationUpdate != null;

        /// <summary>
        /// Gets and sets the property HttpEndpointDestinationUpdate. 
        /// <para>
        /// Describes an update to the specified HTTP endpoint destination.
        /// </para>
        /// </summary>
        public HttpEndpointDestinationUpdate HttpEndpointDestinationUpdate { get; set; }

        /// <summary>
        /// Checks to see if the HttpEndpointDestinationUpdate property is set.
        /// </summary>
        internal bool IsSetHttpEndpointDestinationUpdate() => this.HttpEndpointDestinationUpdate != null;

        /// <summary>
        /// Gets and sets the property IcebergDestinationUpdate. 
        /// <para>
        ///  Describes an update for a destination in Apache Iceberg Tables. 
        /// </para>
        /// </summary>
        public IcebergDestinationUpdate IcebergDestinationUpdate { get; set; }

        /// <summary>
        /// Checks to see if the IcebergDestinationUpdate property is set.
        /// </summary>
        internal bool IsSetIcebergDestinationUpdate() => this.IcebergDestinationUpdate != null;

        /// <summary>
        /// Gets and sets the property RedshiftDestinationUpdate. 
        /// <para>
        /// Describes an update for a destination in Amazon Redshift.
        /// </para>
        /// </summary>
        public RedshiftDestinationUpdate RedshiftDestinationUpdate { get; set; }

        /// <summary>
        /// Checks to see if the RedshiftDestinationUpdate property is set.
        /// </summary>
        internal bool IsSetRedshiftDestinationUpdate() => this.RedshiftDestinationUpdate != null;

        /// <summary>
        /// Gets and sets the property S3DestinationUpdate. 
        /// <para>
        /// [Deprecated] Describes an update for a destination in Amazon S3.
        /// </para>
        /// </summary>
        [Obsolete("This property is deprecated. Use ExtendedS3DestinationUpdate instead.")]
        public S3DestinationUpdate S3DestinationUpdate { get; set; }

        /// <summary>
        /// Checks to see if the S3DestinationUpdate property is set.
        /// </summary>
        internal bool IsSetS3DestinationUpdate() => this.S3DestinationUpdate != null;

        /// <summary>
        /// Gets and sets the property SnowflakeDestinationUpdate. 
        /// <para>
        /// Update to the Snowflake destination configuration settings.
        /// </para>
        /// </summary>
        public SnowflakeDestinationUpdate SnowflakeDestinationUpdate { get; set; }

        /// <summary>
        /// Checks to see if the SnowflakeDestinationUpdate property is set.
        /// </summary>
        internal bool IsSetSnowflakeDestinationUpdate() => this.SnowflakeDestinationUpdate != null;

        /// <summary>
        /// Gets and sets the property SplunkDestinationUpdate. 
        /// <para>
        /// Describes an update for a destination in Splunk.
        /// </para>
        /// </summary>
        public SplunkDestinationUpdate SplunkDestinationUpdate { get; set; }

        /// <summary>
        /// Checks to see if the SplunkDestinationUpdate property is set.
        /// </summary>
        internal bool IsSetSplunkDestinationUpdate() => this.SplunkDestinationUpdate != null;
    }
}
