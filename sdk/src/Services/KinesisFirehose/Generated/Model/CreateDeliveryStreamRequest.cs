/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDeliveryStream operation.
    /// Creates a delivery stream.
    /// 
    ///  
    /// <para>
    /// By default, you can create up to 20 delivery streams per region.
    /// </para>
    ///  
    /// <para>
    /// This is an asynchronous operation that immediately returns. The initial status of
    /// the delivery stream is <code>CREATING</code>. After the delivery stream is created,
    /// its status is <code>ACTIVE</code> and it now accepts data. Attempts to send data to
    /// a delivery stream that is not in the <code>ACTIVE</code> state cause an exception.
    /// To check the state of a delivery stream, use <a>DescribeDeliveryStream</a>.
    /// </para>
    ///  
    /// <para>
    /// A delivery stream is configured with a single destination: Amazon S3, Amazon Elasticsearch
    /// Service, or Amazon Redshift. You must specify only one of the following destination
    /// configuration parameters: <b>ExtendedS3DestinationConfiguration</b>, <b>S3DestinationConfiguration</b>,
    /// <b>ElasticsearchDestinationConfiguration</b>, or <b>RedshiftDestinationConfiguration</b>.
    /// </para>
    ///  
    /// <para>
    /// When you specify <b>S3DestinationConfiguration</b>, you can also provide the following
    /// optional values: <b>BufferingHints</b>, <b>EncryptionConfiguration</b>, and <b>CompressionFormat</b>.
    /// By default, if no <b>BufferingHints</b> value is provided, Firehose buffers data up
    /// to 5 MB or for 5 minutes, whichever condition is satisfied first. Note that <b>BufferingHints</b>
    /// is a hint, so there are some cases where the service cannot adhere to these conditions
    /// strictly; for example, record boundaries are such that the size is a little over or
    /// under the configured buffering size. By default, no encryption is performed. We strongly
    /// recommend that you enable encryption to ensure secure data storage in Amazon S3.
    /// </para>
    ///  
    /// <para>
    /// A few notes about Amazon Redshift as a destination:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// An Amazon Redshift destination requires an S3 bucket as intermediate location, as
    /// Firehose first delivers data to S3 and then uses <code>COPY</code> syntax to load
    /// data into an Amazon Redshift table. This is specified in the <b>RedshiftDestinationConfiguration.S3Configuration</b>
    /// parameter.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The compression formats <code>SNAPPY</code> or <code>ZIP</code> cannot be specified
    /// in <b>RedshiftDestinationConfiguration.S3Configuration</b> because the Amazon Redshift
    /// <code>COPY</code> operation that reads from the S3 bucket doesn't support these compression
    /// formats.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// We strongly recommend that you use the user name and password you provide exclusively
    /// with Firehose, and that the permissions for the account are restricted for Amazon
    /// Redshift <code>INSERT</code> permissions.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Firehose assumes the IAM role that is configured as part of the destination. The role
    /// should allow the Firehose principal to assume the role, and the role should have permissions
    /// that allows the service to deliver the data. For more information, see <a href="http://docs.aws.amazon.com/firehose/latest/dev/controlling-access.html#using-iam-s3">Amazon
    /// S3 Bucket Access</a> in the <i>Amazon Kinesis Firehose Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateDeliveryStreamRequest : AmazonKinesisFirehoseRequest
    {
        private string _deliveryStreamName;
        private ElasticsearchDestinationConfiguration _elasticsearchDestinationConfiguration;
        private ExtendedS3DestinationConfiguration _extendedS3DestinationConfiguration;
        private RedshiftDestinationConfiguration _redshiftDestinationConfiguration;
        private S3DestinationConfiguration _s3DestinationConfiguration;

        /// <summary>
        /// Gets and sets the property DeliveryStreamName. 
        /// <para>
        /// The name of the delivery stream. This name must be unique per AWS account in the same
        /// region. You can have multiple delivery streams with the same name if they are in different
        /// accounts or different regions.
        /// </para>
        /// </summary>
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

    }
}