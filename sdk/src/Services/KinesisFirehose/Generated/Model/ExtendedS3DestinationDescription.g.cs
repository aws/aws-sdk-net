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
    /// Describes a destination in Amazon S3.
    /// </summary>
    public partial class ExtendedS3DestinationDescription
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
        /// The buffering option.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BufferingHints BufferingHints { get; set; }

        /// <summary>
        /// Checks to see if the BufferingHints property is set.
        /// </summary>
        internal bool IsSetBufferingHints() => this.BufferingHints != null;

        /// <summary>
        /// Gets and sets the property CloudWatchLoggingOptions. 
        /// <para>
        /// The Amazon CloudWatch logging options for your Firehose stream.
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
        /// </summary>
        [AWSProperty(Required = true)]
        public CompressionFormat CompressionFormat { get; set; }

        /// <summary>
        /// Checks to see if the CompressionFormat property is set.
        /// </summary>
        internal bool IsSetCompressionFormat() => this.CompressionFormat != null;

        /// <summary>
        /// Gets and sets the property CustomTimeZone. 
        /// <para>
        /// The time zone you prefer. UTC is the default.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public string CustomTimeZone { get; set; }

        /// <summary>
        /// Checks to see if the CustomTimeZone property is set.
        /// </summary>
        internal bool IsSetCustomTimeZone() => this.CustomTimeZone != null;

        /// <summary>
        /// Gets and sets the property DataFormatConversionConfiguration. 
        /// <para>
        /// The serializer, deserializer, and schema for converting data from the JSON format
        /// to the Parquet or ORC format before writing it to Amazon S3.
        /// </para>
        /// </summary>
        public DataFormatConversionConfiguration DataFormatConversionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DataFormatConversionConfiguration property is set.
        /// </summary>
        internal bool IsSetDataFormatConversionConfiguration() => this.DataFormatConversionConfiguration != null;

        /// <summary>
        /// Gets and sets the property DynamicPartitioningConfiguration. 
        /// <para>
        /// The configuration of the dynamic partitioning mechanism that creates smaller data
        /// sets from the streaming data by partitioning it based on partition keys. Currently,
        /// dynamic partitioning is only supported for Amazon S3 destinations. 
        /// </para>
        /// </summary>
        public DynamicPartitioningConfiguration DynamicPartitioningConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DynamicPartitioningConfiguration property is set.
        /// </summary>
        internal bool IsSetDynamicPartitioningConfiguration() => this.DynamicPartitioningConfiguration != null;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The encryption configuration. If no value is specified, the default is no encryption.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
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
        /// Gets and sets the property FileExtension. 
        /// <para>
        /// Specify a file extension. It will override the default file extension
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string FileExtension { get; set; }

        /// <summary>
        /// Checks to see if the FileExtension property is set.
        /// </summary>
        internal bool IsSetFileExtension() => this.FileExtension != null;

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

        /// <summary>
        /// Gets and sets the property S3BackupDescription. 
        /// <para>
        /// The configuration for backup in Amazon S3.
        /// </para>
        /// </summary>
        public S3DestinationDescription S3BackupDescription { get; set; }

        /// <summary>
        /// Checks to see if the S3BackupDescription property is set.
        /// </summary>
        internal bool IsSetS3BackupDescription() => this.S3BackupDescription != null;

        /// <summary>
        /// Gets and sets the property S3BackupMode. 
        /// <para>
        /// The Amazon S3 backup mode.
        /// </para>
        /// </summary>
        public S3BackupMode S3BackupMode { get; set; }

        /// <summary>
        /// Checks to see if the S3BackupMode property is set.
        /// </summary>
        internal bool IsSetS3BackupMode() => this.S3BackupMode != null;
    }
}
