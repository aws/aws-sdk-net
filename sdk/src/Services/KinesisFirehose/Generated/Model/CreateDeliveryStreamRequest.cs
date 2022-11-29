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
    /// Container for the parameters to the CreateDeliveryStream operation.
    /// Creates a Kinesis Data Firehose delivery stream.
    /// 
    ///  
    /// <para>
    /// By default, you can create up to 50 delivery streams per Amazon Web Services Region.
    /// </para>
    ///  
    /// <para>
    /// This is an asynchronous operation that immediately returns. The initial status of
    /// the delivery stream is <code>CREATING</code>. After the delivery stream is created,
    /// its status is <code>ACTIVE</code> and it now accepts data. If the delivery stream
    /// creation fails, the status transitions to <code>CREATING_FAILED</code>. Attempts to
    /// send data to a delivery stream that is not in the <code>ACTIVE</code> state cause
    /// an exception. To check the state of a delivery stream, use <a>DescribeDeliveryStream</a>.
    /// </para>
    ///  
    /// <para>
    /// If the status of a delivery stream is <code>CREATING_FAILED</code>, this status doesn't
    /// change, and you can't invoke <code>CreateDeliveryStream</code> again on it. However,
    /// you can invoke the <a>DeleteDeliveryStream</a> operation to delete it.
    /// </para>
    ///  
    /// <para>
    /// A Kinesis Data Firehose delivery stream can be configured to receive records directly
    /// from providers using <a>PutRecord</a> or <a>PutRecordBatch</a>, or it can be configured
    /// to use an existing Kinesis stream as its source. To specify a Kinesis data stream
    /// as input, set the <code>DeliveryStreamType</code> parameter to <code>KinesisStreamAsSource</code>,
    /// and provide the Kinesis stream Amazon Resource Name (ARN) and role ARN in the <code>KinesisStreamSourceConfiguration</code>
    /// parameter.
    /// </para>
    ///  
    /// <para>
    /// To create a delivery stream with server-side encryption (SSE) enabled, include <a>DeliveryStreamEncryptionConfigurationInput</a>
    /// in your request. This is optional. You can also invoke <a>StartDeliveryStreamEncryption</a>
    /// to turn on SSE for an existing delivery stream that doesn't have SSE enabled.
    /// </para>
    ///  
    /// <para>
    /// A delivery stream is configured with a single destination: Amazon S3, Amazon ES, Amazon
    /// Redshift, or Splunk. You must specify only one of the following destination configuration
    /// parameters: <code>ExtendedS3DestinationConfiguration</code>, <code>S3DestinationConfiguration</code>,
    /// <code>ElasticsearchDestinationConfiguration</code>, <code>RedshiftDestinationConfiguration</code>,
    /// or <code>SplunkDestinationConfiguration</code>.
    /// </para>
    ///  
    /// <para>
    /// When you specify <code>S3DestinationConfiguration</code>, you can also provide the
    /// following optional values: BufferingHints, <code>EncryptionConfiguration</code>, and
    /// <code>CompressionFormat</code>. By default, if no <code>BufferingHints</code> value
    /// is provided, Kinesis Data Firehose buffers data up to 5 MB or for 5 minutes, whichever
    /// condition is satisfied first. <code>BufferingHints</code> is a hint, so there are
    /// some cases where the service cannot adhere to these conditions strictly. For example,
    /// record boundaries might be such that the size is a little over or under the configured
    /// buffering size. By default, no encryption is performed. We strongly recommend that
    /// you enable encryption to ensure secure data storage in Amazon S3.
    /// </para>
    ///  
    /// <para>
    /// A few notes about Amazon Redshift as a destination:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// An Amazon Redshift destination requires an S3 bucket as intermediate location. Kinesis
    /// Data Firehose first delivers data to Amazon S3 and then uses <code>COPY</code> syntax
    /// to load data into an Amazon Redshift table. This is specified in the <code>RedshiftDestinationConfiguration.S3Configuration</code>
    /// parameter.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The compression formats <code>SNAPPY</code> or <code>ZIP</code> cannot be specified
    /// in <code>RedshiftDestinationConfiguration.S3Configuration</code> because the Amazon
    /// Redshift <code>COPY</code> operation that reads from the S3 bucket doesn't support
    /// these compression formats.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// We strongly recommend that you use the user name and password you provide exclusively
    /// with Kinesis Data Firehose, and that the permissions for the account are restricted
    /// for Amazon Redshift <code>INSERT</code> permissions.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Kinesis Data Firehose assumes the IAM role that is configured as part of the destination.
    /// The role should allow the Kinesis Data Firehose principal to assume the role, and
    /// the role should have permissions that allow the service to deliver the data. For more
    /// information, see <a href="https://docs.aws.amazon.com/firehose/latest/dev/controlling-access.html#using-iam-s3">Grant
    /// Kinesis Data Firehose Access to an Amazon S3 Destination</a> in the <i>Amazon Kinesis
    /// Data Firehose Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateDeliveryStreamRequest : AmazonKinesisFirehoseRequest
    {
        private AmazonOpenSearchServerlessDestinationConfiguration _amazonOpenSearchServerlessDestinationConfiguration;
        private AmazonopensearchserviceDestinationConfiguration _amazonopensearchserviceDestinationConfiguration;
        private DeliveryStreamEncryptionConfigurationInput _deliveryStreamEncryptionConfigurationInput;
        private string _deliveryStreamName;
        private DeliveryStreamType _deliveryStreamType;
        private ElasticsearchDestinationConfiguration _elasticsearchDestinationConfiguration;
        private ExtendedS3DestinationConfiguration _extendedS3DestinationConfiguration;
        private HttpEndpointDestinationConfiguration _httpEndpointDestinationConfiguration;
        private KinesisStreamSourceConfiguration _kinesisStreamSourceConfiguration;
        private RedshiftDestinationConfiguration _redshiftDestinationConfiguration;
        private S3DestinationConfiguration _s3DestinationConfiguration;
        private SplunkDestinationConfiguration _splunkDestinationConfiguration;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property AmazonOpenSearchServerlessDestinationConfiguration. 
        /// <para>
        /// The destination in the Serverless offering for Amazon OpenSearch Service. You can
        /// specify only one destination.
        /// </para>
        /// </summary>
        public AmazonOpenSearchServerlessDestinationConfiguration AmazonOpenSearchServerlessDestinationConfiguration
        {
            get { return this._amazonOpenSearchServerlessDestinationConfiguration; }
            set { this._amazonOpenSearchServerlessDestinationConfiguration = value; }
        }

        // Check to see if AmazonOpenSearchServerlessDestinationConfiguration property is set
        internal bool IsSetAmazonOpenSearchServerlessDestinationConfiguration()
        {
            return this._amazonOpenSearchServerlessDestinationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property AmazonopensearchserviceDestinationConfiguration. 
        /// <para>
        /// The destination in Amazon OpenSearch Service. You can specify only one destination.
        /// </para>
        /// </summary>
        public AmazonopensearchserviceDestinationConfiguration AmazonopensearchserviceDestinationConfiguration
        {
            get { return this._amazonopensearchserviceDestinationConfiguration; }
            set { this._amazonopensearchserviceDestinationConfiguration = value; }
        }

        // Check to see if AmazonopensearchserviceDestinationConfiguration property is set
        internal bool IsSetAmazonopensearchserviceDestinationConfiguration()
        {
            return this._amazonopensearchserviceDestinationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property DeliveryStreamEncryptionConfigurationInput. 
        /// <para>
        /// Used to specify the type and Amazon Resource Name (ARN) of the KMS key needed for
        /// Server-Side Encryption (SSE).
        /// </para>
        /// </summary>
        public DeliveryStreamEncryptionConfigurationInput DeliveryStreamEncryptionConfigurationInput
        {
            get { return this._deliveryStreamEncryptionConfigurationInput; }
            set { this._deliveryStreamEncryptionConfigurationInput = value; }
        }

        // Check to see if DeliveryStreamEncryptionConfigurationInput property is set
        internal bool IsSetDeliveryStreamEncryptionConfigurationInput()
        {
            return this._deliveryStreamEncryptionConfigurationInput != null;
        }

        /// <summary>
        /// Gets and sets the property DeliveryStreamName. 
        /// <para>
        /// The name of the delivery stream. This name must be unique per Amazon Web Services
        /// account in the same Amazon Web Services Region. If the delivery streams are in different
        /// accounts or different Regions, you can have multiple delivery streams with the same
        /// name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string DeliveryStreamName
        {
            get { return this._deliveryStreamName; }
            set { this._deliveryStreamName = value; }
        }

        // Check to see if DeliveryStreamName property is set
        internal bool IsSetDeliveryStreamName()
        {
            return this._deliveryStreamName != null;
        }

        /// <summary>
        /// Gets and sets the property DeliveryStreamType. 
        /// <para>
        /// The delivery stream type. This parameter can be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DirectPut</code>: Provider applications access the delivery stream directly.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KinesisStreamAsSource</code>: The delivery stream uses a Kinesis data stream
        /// as a source.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DeliveryStreamType DeliveryStreamType
        {
            get { return this._deliveryStreamType; }
            set { this._deliveryStreamType = value; }
        }

        // Check to see if DeliveryStreamType property is set
        internal bool IsSetDeliveryStreamType()
        {
            return this._deliveryStreamType != null;
        }

        /// <summary>
        /// Gets and sets the property ElasticsearchDestinationConfiguration. 
        /// <para>
        /// The destination in Amazon ES. You can specify only one destination.
        /// </para>
        /// </summary>
        public ElasticsearchDestinationConfiguration ElasticsearchDestinationConfiguration
        {
            get { return this._elasticsearchDestinationConfiguration; }
            set { this._elasticsearchDestinationConfiguration = value; }
        }

        // Check to see if ElasticsearchDestinationConfiguration property is set
        internal bool IsSetElasticsearchDestinationConfiguration()
        {
            return this._elasticsearchDestinationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ExtendedS3DestinationConfiguration. 
        /// <para>
        /// The destination in Amazon S3. You can specify only one destination.
        /// </para>
        /// </summary>
        public ExtendedS3DestinationConfiguration ExtendedS3DestinationConfiguration
        {
            get { return this._extendedS3DestinationConfiguration; }
            set { this._extendedS3DestinationConfiguration = value; }
        }

        // Check to see if ExtendedS3DestinationConfiguration property is set
        internal bool IsSetExtendedS3DestinationConfiguration()
        {
            return this._extendedS3DestinationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property HttpEndpointDestinationConfiguration. 
        /// <para>
        /// Enables configuring Kinesis Firehose to deliver data to any HTTP endpoint destination.
        /// You can specify only one destination.
        /// </para>
        /// </summary>
        public HttpEndpointDestinationConfiguration HttpEndpointDestinationConfiguration
        {
            get { return this._httpEndpointDestinationConfiguration; }
            set { this._httpEndpointDestinationConfiguration = value; }
        }

        // Check to see if HttpEndpointDestinationConfiguration property is set
        internal bool IsSetHttpEndpointDestinationConfiguration()
        {
            return this._httpEndpointDestinationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property KinesisStreamSourceConfiguration. 
        /// <para>
        /// When a Kinesis data stream is used as the source for the delivery stream, a <a>KinesisStreamSourceConfiguration</a>
        /// containing the Kinesis data stream Amazon Resource Name (ARN) and the role ARN for
        /// the source stream.
        /// </para>
        /// </summary>
        public KinesisStreamSourceConfiguration KinesisStreamSourceConfiguration
        {
            get { return this._kinesisStreamSourceConfiguration; }
            set { this._kinesisStreamSourceConfiguration = value; }
        }

        // Check to see if KinesisStreamSourceConfiguration property is set
        internal bool IsSetKinesisStreamSourceConfiguration()
        {
            return this._kinesisStreamSourceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RedshiftDestinationConfiguration. 
        /// <para>
        /// The destination in Amazon Redshift. You can specify only one destination.
        /// </para>
        /// </summary>
        public RedshiftDestinationConfiguration RedshiftDestinationConfiguration
        {
            get { return this._redshiftDestinationConfiguration; }
            set { this._redshiftDestinationConfiguration = value; }
        }

        // Check to see if RedshiftDestinationConfiguration property is set
        internal bool IsSetRedshiftDestinationConfiguration()
        {
            return this._redshiftDestinationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property S3DestinationConfiguration. 
        /// <para>
        /// [Deprecated] The destination in Amazon S3. You can specify only one destination.
        /// </para>
        /// </summary>
        [Obsolete("This property is deprecated. Use ExtendedS3DestinationConfiguration instead.")]
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
        /// Gets and sets the property SplunkDestinationConfiguration. 
        /// <para>
        /// The destination in Splunk. You can specify only one destination.
        /// </para>
        /// </summary>
        public SplunkDestinationConfiguration SplunkDestinationConfiguration
        {
            get { return this._splunkDestinationConfiguration; }
            set { this._splunkDestinationConfiguration = value; }
        }

        // Check to see if SplunkDestinationConfiguration property is set
        internal bool IsSetSplunkDestinationConfiguration()
        {
            return this._splunkDestinationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A set of tags to assign to the delivery stream. A tag is a key-value pair that you
        /// can define and assign to Amazon Web Services resources. Tags are metadata. For example,
        /// you can add friendly names and descriptions or other types of information that can
        /// help you distinguish the delivery stream. For more information about tags, see <a
        /// href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html">Using
        /// Cost Allocation Tags</a> in the Amazon Web Services Billing and Cost Management User
        /// Guide.
        /// </para>
        ///  
        /// <para>
        /// You can specify up to 50 tags when creating a delivery stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}