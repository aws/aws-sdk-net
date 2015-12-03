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
    /// <a>CreateDeliveryStream</a> is an asynchronous operation that immediately returns.
    /// The initial status of the delivery stream is <code>CREATING</code>. After the delivery
    /// stream is created, its status is <code>ACTIVE</code> and it now accepts data. Attempts
    /// to send data to a delivery stream that is not in the <code>ACTIVE</code> state cause
    /// an exception. To check the state of a delivery stream, use <a>DescribeDeliveryStream</a>.
    /// </para>
    ///  
    /// <para>
    /// The name of a delivery stream identifies it. You can't have two delivery streams with
    /// the same name in the same region. Two delivery streams in different AWS accounts or
    /// different regions in the same AWS account can have the same name.
    /// </para>
    ///  
    /// <para>
    /// By default, you can create up to 5 delivery streams per region.
    /// </para>
    ///  
    /// <para>
    /// A delivery stream can only be configured with a single destination, Amazon S3 or Amazon
    /// Redshift. For correct <a>CreateDeliveryStream</a> request syntax, specify only one
    /// destination configuration parameter: either <code>RedshiftDestinationConfiguration</code>
    /// or <code>S3DestinationConfiguration</code>
    /// </para>
    ///  
    /// <para>
    /// As part of <code>S3DestinationConfiguration</code>, optional values <code>BufferingHints</code>,
    /// <code>EncryptionConfiguration</code>, and <code>CompressionFormat</code> can be provided.
    /// By default, if no <code>BufferingHints</code> value is provided, Amazon Kinesis Firehose
    /// buffers data up to 5 MB or for 5 minutes, whichever condition is satisfied first.
    /// Note that <code>BufferingHints</code> is a hint, so there are some cases where the
    /// service cannot adhere to these conditions strictly; for example, record boundaries
    /// are such that the size is a little over or under the configured buffering size. By
    /// default, no encryption is performed. We strongly recommend that you enable encryption
    /// to ensure secure data storage in Amazon S3.
    /// </para>
    ///  
    /// <para>
    /// A few notes about <code>RedshiftDestinationConfiguration</code>:
    /// </para>
    ///  <ul> <li>An Amazon Redshift destination requires an S3 bucket as intermediate location,
    /// as Amazon Kinesis Firehose first delivers data to S3 and then uses <code>COPY</code>
    /// syntax to load data into an Amazon Redshift table. This is specified in the <code>RedshiftDestinationConfiguration.S3Configuration</code>
    /// parameter element.</li> <li>The compression formats <code>SNAPPY</code> or <code>ZIP</code>
    /// cannot be specified in <code>RedshiftDestinationConfiguration.S3Configuration</code>
    /// because the Amazon Redshift <code>COPY</code> operation that reads from the S3 bucket
    /// doesn't support these compression formats.</li> <li>We strongly recommend that the
    /// username and password provided is used exclusively for Amazon Kinesis Firehose purposes,
    /// and that the permissions for the account are restricted for Amazon Redshift <code>INSERT</code>
    /// permissions.</li> </ul> 
    /// <para>
    /// Amazon Kinesis Firehose assumes the IAM role that is configured as part of destinations.
    /// The IAM role should allow the Amazon Kinesis Firehose principal to assume the role,
    /// and the role should have permissions that allows the service to deliver the data.
    /// For more information, see <a href="http://docs.aws.amazon.com/firehose/latest/dev/controlling-access.html#using-iam-s3">Amazon
    /// S3 Bucket Access</a> in the <i>Amazon Kinesis Firehose Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateDeliveryStreamRequest : AmazonKinesisFirehoseRequest
    {
        private string _deliveryStreamName;
        private RedshiftDestinationConfiguration _redshiftDestinationConfiguration;
        private S3DestinationConfiguration _s3DestinationConfiguration;

        /// <summary>
        /// Gets and sets the property DeliveryStreamName. 
        /// <para>
        /// The name of the delivery stream.
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
        /// Gets and sets the property RedshiftDestinationConfiguration. 
        /// <para>
        /// The destination in Amazon Redshift. This value cannot be specified if Amazon S3 is
        /// the desired destination (see restrictions listed above).
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
        /// The destination in Amazon S3. This value must be specified if <code>RedshiftDestinationConfiguration</code>
        /// is specified (see restrictions listed above).
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