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
    /// Describes the configuration of a destination in Amazon S3.
    /// </summary>
    public partial class S3DestinationConfiguration
    {
        /// <summary>
        /// Gets and sets the property BucketARN. 
        /// <para>
        /// The ARN of the S3 bucket. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and Amazon Web Services Service Namespaces</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string BucketARN { get; set; }

        /// <summary>
        /// Checks to see if the BucketARN property is set.
        /// </summary>
        internal bool IsSetBucketARN() => this.BucketARN != null;

        /// <summary>
        /// Gets and sets the property BufferingHints. 
        /// <para>
        /// The buffering option. If no value is specified, <c>BufferingHints</c> object default
        /// values are used.
        /// </para>
        /// </summary>
        public BufferingHints BufferingHints { get; set; }

        /// <summary>
        /// Checks to see if the BufferingHints property is set.
        /// </summary>
        internal bool IsSetBufferingHints() => this.BufferingHints != null;

        /// <summary>
        /// Gets and sets the property CloudWatchLoggingOptions. 
        /// <para>
        /// The CloudWatch logging options for your Firehose stream.
        /// </para>
        /// </summary>
        public CloudWatchLoggingOptions CloudWatchLoggingOptions { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchLoggingOptions property is set.
        /// </summary>
        internal bool IsSetCloudWatchLoggingOptions() => this.CloudWatchLoggingOptions != null;

        /// <summary>
        /// Gets and sets the property CompressionFormat. 
        /// <para>
        /// The compression format. If no value is specified, the default is <c>UNCOMPRESSED</c>.
        /// </para>
        ///  
        /// <para>
        /// The compression formats <c>SNAPPY</c> or <c>ZIP</c> cannot be specified for Amazon
        /// Redshift destinations because they are not supported by the Amazon Redshift <c>COPY</c>
        /// operation that reads from the S3 bucket.
        /// </para>
        /// </summary>
        public CompressionFormat CompressionFormat { get; set; }

        /// <summary>
        /// Checks to see if the CompressionFormat property is set.
        /// </summary>
        internal bool IsSetCompressionFormat() => this.CompressionFormat != null;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The encryption configuration. If no value is specified, the default is no encryption.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property ErrorOutputPrefix. 
        /// <para>
        /// A prefix that Firehose evaluates and adds to failed records before writing them to
        /// S3. This prefix appears immediately following the bucket name. For information about
        /// how to specify this prefix, see <a href="https://docs.aws.amazon.com/firehose/latest/dev/s3-prefixes.html">Custom
        /// Prefixes for Amazon S3 Objects</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ErrorOutputPrefix { get; set; }

        /// <summary>
        /// Checks to see if the ErrorOutputPrefix property is set.
        /// </summary>
        internal bool IsSetErrorOutputPrefix() => this.ErrorOutputPrefix != null;

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The "YYYY/MM/DD/HH" time format prefix is automatically used for delivered Amazon
        /// S3 files. You can also specify a custom prefix, as described in <a href="https://docs.aws.amazon.com/firehose/latest/dev/s3-prefixes.html">Custom
        /// Prefixes for Amazon S3 Objects</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Prefix { get; set; }

        /// <summary>
        /// Checks to see if the Prefix property is set.
        /// </summary>
        internal bool IsSetPrefix() => this.Prefix != null;

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services credentials. For more information,
        /// see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and Amazon Web Services Service Namespaces</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string RoleARN { get; set; }

        /// <summary>
        /// Checks to see if the RoleARN property is set.
        /// </summary>
        internal bool IsSetRoleARN() => this.RoleARN != null;
    }
}
