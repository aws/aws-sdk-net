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
    /// Container for the parameters to the CreateDeliveryStream operation. Creates a Firehose
    /// stream. <para> By default, you can create up to 5,000 Firehose streams per Amazon
    /// Web Services Region. </para> <para> This is an asynchronous operation that immediately
    /// returns. The initial status of the Firehose stream is <c>CREATING</c>. After the Firehose
    /// stream is created, its status is <c>ACTIVE</c> and it now accepts data. If the Firehose
    /// stream creation fails, the status transitions to <c>CREATING_FAILED</c>. Attempts
    /// to send data to a delivery stream that is not in the <c>ACTIVE</c> state cause an
    /// exception. To check the state of a Firehose stream, use <a>DescribeDeliveryStream</a>.
    /// </para> <para> If the status of a Firehose stream is <c>CREATING_FAILED</c>, this
    /// status doesn't change, and you can't invoke <c>CreateDeliveryStream</c> again on it.
    /// However, you can invoke the <a>DeleteDeliveryStream</a> operation to delete it. </para>
    /// <para> A Firehose stream can be configured to receive records directly from providers
    /// using <a>PutRecord</a> or <a>PutRecordBatch</a>, or it can be configured to use an
    /// existing Kinesis stream as its source. To specify a Kinesis data stream as input,
    /// set the <c>DeliveryStreamType</c> parameter to <c>KinesisStreamAsSource</c>, and provide
    /// the Kinesis stream Amazon Resource Name (ARN) and role ARN in the <c>KinesisStreamSourceConfiguration</c>
    /// parameter. </para> <para> To create a Firehose stream with server-side encryption
    /// (SSE) enabled, include <a>DeliveryStreamEncryptionConfigurationInput</a> in your request.
    /// This is optional. You can also invoke <a>StartDeliveryStreamEncryption</a> to turn
    /// on SSE for an existing Firehose stream that doesn't have SSE enabled. </para> <para>
    /// A Firehose stream is configured with a single destination, such as Amazon Simple Storage
    /// Service (Amazon S3), Amazon Redshift, Amazon OpenSearch Service, Amazon OpenSearch
    /// Serverless, Splunk, and any custom HTTP endpoint or HTTP endpoints owned by or supported
    /// by third-party service providers, including Datadog, Dynatrace, LogicMonitor, MongoDB,
    /// New Relic, and Sumo Logic. You must specify only one of the following destination
    /// configuration parameters: <c>ExtendedS3DestinationConfiguration</c>, <c>S3DestinationConfiguration</c>,
    /// <c>ElasticsearchDestinationConfiguration</c>, <c>RedshiftDestinationConfiguration</c>,
    /// or <c>SplunkDestinationConfiguration</c>. </para> <para> When you specify <c>S3DestinationConfiguration</c>,
    /// you can also provide the following optional values: BufferingHints, <c>EncryptionConfiguration</c>,
    /// and <c>CompressionFormat</c>. By default, if no <c>BufferingHints</c> value is provided,
    /// Firehose buffers data up to 5 MB or for 5 minutes, whichever condition is satisfied
    /// first. <c>BufferingHints</c> is a hint, so there are some cases where the service
    /// cannot adhere to these conditions strictly. For example, record boundaries might be
    /// such that the size is a little over or under the configured buffering size. By default,
    /// no encryption is performed. We strongly recommend that you enable encryption to ensure
    /// secure data storage in Amazon S3. </para> <para> A few notes about Amazon Redshift
    /// as a destination: </para> <ul> <li> <para> An Amazon Redshift destination requires
    /// an S3 bucket as intermediate location. Firehose first delivers data to Amazon S3 and
    /// then uses <c>COPY</c> syntax to load data into an Amazon Redshift table. This is specified
    /// in the <c>RedshiftDestinationConfiguration.S3Configuration</c> parameter. </para>
    /// </li> <li> <para> The compression formats <c>SNAPPY</c> or <c>ZIP</c> cannot be specified
    /// in <c>RedshiftDestinationConfiguration.S3Configuration</c> because the Amazon Redshift
    /// <c>COPY</c> operation that reads from the S3 bucket doesn't support these compression
    /// formats. </para> </li> <li> <para> We strongly recommend that you use the user name
    /// and password you provide exclusively with Firehose, and that the permissions for the
    /// account are restricted for Amazon Redshift <c>INSERT</c> permissions. </para> </li>
    /// </ul> <para> Firehose assumes the IAM role that is configured as part of the destination.
    /// The role should allow the Firehose principal to assume the role, and the role should
    /// have permissions that allow the service to deliver the data. For more information,
    /// see <a href="https://docs.aws.amazon.com/firehose/latest/dev/controlling-access.html#using-iam-s3">Grant
    /// Firehose Access to an Amazon S3 Destination</a> in the <i>Amazon Firehose Developer
    /// Guide</i>. </para>
    /// </summary>
    public partial class CreateDeliveryStreamRequest : AmazonKinesisFirehoseRequest
    {
        /// <summary>
        /// Gets and sets the property AmazonOpenSearchServerlessDestinationConfiguration. 
        /// <para>
        /// The destination in the Serverless offering for Amazon OpenSearch Service. You can
        /// specify only one destination.
        /// </para>
        /// </summary>
        public AmazonOpenSearchServerlessDestinationConfiguration AmazonOpenSearchServerlessDestinationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AmazonOpenSearchServerlessDestinationConfiguration property is set.
        /// </summary>
        internal bool IsSetAmazonOpenSearchServerlessDestinationConfiguration() => this.AmazonOpenSearchServerlessDestinationConfiguration != null;

        /// <summary>
        /// Gets and sets the property AmazonopensearchserviceDestinationConfiguration. 
        /// <para>
        /// The destination in Amazon OpenSearch Service. You can specify only one destination.
        /// </para>
        /// </summary>
        public AmazonopensearchserviceDestinationConfiguration AmazonopensearchserviceDestinationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AmazonopensearchserviceDestinationConfiguration property is set.
        /// </summary>
        internal bool IsSetAmazonopensearchserviceDestinationConfiguration() => this.AmazonopensearchserviceDestinationConfiguration != null;

        /// <summary>
        /// Gets and sets the property DatabaseSourceConfiguration. 
        /// <para>
        ///  The top level object for configuring streams with database as a source. 
        /// </para>
        ///  
        /// <para>
        /// Amazon Data Firehose is in preview release and is subject to change.
        /// </para>
        /// </summary>
        public DatabaseSourceConfiguration DatabaseSourceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseSourceConfiguration property is set.
        /// </summary>
        internal bool IsSetDatabaseSourceConfiguration() => this.DatabaseSourceConfiguration != null;

        /// <summary>
        /// Gets and sets the property DeliveryStreamEncryptionConfigurationInput. 
        /// <para>
        /// Used to specify the type and Amazon Resource Name (ARN) of the KMS key needed for
        /// Server-Side Encryption (SSE).
        /// </para>
        /// </summary>
        public DeliveryStreamEncryptionConfigurationInput DeliveryStreamEncryptionConfigurationInput { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryStreamEncryptionConfigurationInput property is set.
        /// </summary>
        internal bool IsSetDeliveryStreamEncryptionConfigurationInput() => this.DeliveryStreamEncryptionConfigurationInput != null;

        /// <summary>
        /// Gets and sets the property DeliveryStreamName. 
        /// <para>
        /// The name of the Firehose stream. This name must be unique per Amazon Web Services
        /// account in the same Amazon Web Services Region. If the Firehose streams are in different
        /// accounts or different Regions, you can have multiple Firehose streams with the same
        /// name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string DeliveryStreamName { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryStreamName property is set.
        /// </summary>
        internal bool IsSetDeliveryStreamName() => this.DeliveryStreamName != null;

        /// <summary>
        /// Gets and sets the property DeliveryStreamType. 
        /// <para>
        /// The Firehose stream type. This parameter can be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DirectPut</c>: Provider applications access the Firehose stream directly.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KinesisStreamAsSource</c>: The Firehose stream uses a Kinesis data stream as a
        /// source.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DeliveryStreamType DeliveryStreamType { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryStreamType property is set.
        /// </summary>
        internal bool IsSetDeliveryStreamType() => this.DeliveryStreamType != null;

        /// <summary>
        /// Gets and sets the property DirectPutSourceConfiguration. 
        /// <para>
        /// The structure that configures parameters such as <c>ThroughputHintInMBs</c> for a
        /// stream configured with Direct PUT as a source. 
        /// </para>
        /// </summary>
        public DirectPutSourceConfiguration DirectPutSourceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DirectPutSourceConfiguration property is set.
        /// </summary>
        internal bool IsSetDirectPutSourceConfiguration() => this.DirectPutSourceConfiguration != null;

        /// <summary>
        /// Gets and sets the property ElasticsearchDestinationConfiguration. 
        /// <para>
        /// The destination in Amazon OpenSearch Service. You can specify only one destination.
        /// </para>
        /// </summary>
        public ElasticsearchDestinationConfiguration ElasticsearchDestinationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ElasticsearchDestinationConfiguration property is set.
        /// </summary>
        internal bool IsSetElasticsearchDestinationConfiguration() => this.ElasticsearchDestinationConfiguration != null;

        /// <summary>
        /// Gets and sets the property ExtendedS3DestinationConfiguration. 
        /// <para>
        /// The destination in Amazon S3. You can specify only one destination.
        /// </para>
        /// </summary>
        public ExtendedS3DestinationConfiguration ExtendedS3DestinationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ExtendedS3DestinationConfiguration property is set.
        /// </summary>
        internal bool IsSetExtendedS3DestinationConfiguration() => this.ExtendedS3DestinationConfiguration != null;

        /// <summary>
        /// Gets and sets the property HttpEndpointDestinationConfiguration. 
        /// <para>
        /// Enables configuring Kinesis Firehose to deliver data to any HTTP endpoint destination.
        /// You can specify only one destination.
        /// </para>
        /// </summary>
        public HttpEndpointDestinationConfiguration HttpEndpointDestinationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the HttpEndpointDestinationConfiguration property is set.
        /// </summary>
        internal bool IsSetHttpEndpointDestinationConfiguration() => this.HttpEndpointDestinationConfiguration != null;

        /// <summary>
        /// Gets and sets the property IcebergDestinationConfiguration. 
        /// <para>
        ///  Configure Apache Iceberg Tables destination. 
        /// </para>
        /// </summary>
        public IcebergDestinationConfiguration IcebergDestinationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the IcebergDestinationConfiguration property is set.
        /// </summary>
        internal bool IsSetIcebergDestinationConfiguration() => this.IcebergDestinationConfiguration != null;

        /// <summary>
        /// Gets and sets the property KinesisStreamSourceConfiguration. 
        /// <para>
        /// When a Kinesis data stream is used as the source for the Firehose stream, a <a>KinesisStreamSourceConfiguration</a>
        /// containing the Kinesis data stream Amazon Resource Name (ARN) and the role ARN for
        /// the source stream.
        /// </para>
        /// </summary>
        public KinesisStreamSourceConfiguration KinesisStreamSourceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the KinesisStreamSourceConfiguration property is set.
        /// </summary>
        internal bool IsSetKinesisStreamSourceConfiguration() => this.KinesisStreamSourceConfiguration != null;

        /// <summary>
        /// Gets and sets the property MSKSourceConfiguration.
        /// </summary>
        public MSKSourceConfiguration MSKSourceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the MSKSourceConfiguration property is set.
        /// </summary>
        internal bool IsSetMSKSourceConfiguration() => this.MSKSourceConfiguration != null;

        /// <summary>
        /// Gets and sets the property RedshiftDestinationConfiguration. 
        /// <para>
        /// The destination in Amazon Redshift. You can specify only one destination.
        /// </para>
        /// </summary>
        public RedshiftDestinationConfiguration RedshiftDestinationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RedshiftDestinationConfiguration property is set.
        /// </summary>
        internal bool IsSetRedshiftDestinationConfiguration() => this.RedshiftDestinationConfiguration != null;

        /// <summary>
        /// Gets and sets the property S3DestinationConfiguration. 
        /// <para>
        /// [Deprecated] The destination in Amazon S3. You can specify only one destination.
        /// </para>
        /// </summary>
        [Obsolete("This property is deprecated. Use ExtendedS3DestinationConfiguration instead.")]
        public S3DestinationConfiguration S3DestinationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the S3DestinationConfiguration property is set.
        /// </summary>
        internal bool IsSetS3DestinationConfiguration() => this.S3DestinationConfiguration != null;

        /// <summary>
        /// Gets and sets the property SnowflakeDestinationConfiguration. 
        /// <para>
        /// Configure Snowflake destination
        /// </para>
        /// </summary>
        public SnowflakeDestinationConfiguration SnowflakeDestinationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SnowflakeDestinationConfiguration property is set.
        /// </summary>
        internal bool IsSetSnowflakeDestinationConfiguration() => this.SnowflakeDestinationConfiguration != null;

        /// <summary>
        /// Gets and sets the property SplunkDestinationConfiguration. 
        /// <para>
        /// The destination in Splunk. You can specify only one destination.
        /// </para>
        /// </summary>
        public SplunkDestinationConfiguration SplunkDestinationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SplunkDestinationConfiguration property is set.
        /// </summary>
        internal bool IsSetSplunkDestinationConfiguration() => this.SplunkDestinationConfiguration != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A set of tags to assign to the Firehose stream. A tag is a key-value pair that you
        /// can define and assign to Amazon Web Services resources. Tags are metadata. For example,
        /// you can add friendly names and descriptions or other types of information that can
        /// help you distinguish the Firehose stream. For more information about tags, see <a
        /// href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html">Using
        /// Cost Allocation Tags</a> in the Amazon Web Services Billing and Cost Management User
        /// Guide.
        /// </para>
        ///  
        /// <para>
        /// You can specify up to 50 tags when creating a Firehose stream.
        /// </para>
        ///  
        /// <para>
        /// If you specify tags in the <c>CreateDeliveryStream</c> action, Amazon Data Firehose
        /// performs an additional authorization on the <c>firehose:TagDeliveryStream</c> action
        /// to verify if users have permissions to create tags. If you do not provide this permission,
        /// requests to create new Firehose streams with IAM resource tags will fail with an <c>AccessDeniedException</c>
        /// such as following.
        /// </para>
        ///  
        /// <para>
        ///  <b>AccessDeniedException</b> 
        /// </para>
        ///  
        /// <para>
        /// User: arn:aws:sts::x:assumed-role/x/x is not authorized to perform: firehose:TagDeliveryStream
        /// on resource: arn:aws:firehose:us-east-1:x:deliverystream/x with an explicit deny in
        /// an identity-based policy.
        /// </para>
        ///  
        /// <para>
        /// For an example IAM policy, see <a href="https://docs.aws.amazon.com/firehose/latest/APIReference/API_CreateDeliveryStream.html#API_CreateDeliveryStream_Examples">Tag
        /// example.</a> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
