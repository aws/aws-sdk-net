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
    /// Describes a destination in Amazon S3.
    /// </summary>
    public partial class ExtendedS3DestinationDescription
    {
        private string _bucketARN;
        private BufferingHints _bufferingHints;
        private CloudWatchLoggingOptions _cloudWatchLoggingOptions;
        private CompressionFormat _compressionFormat;
        private DataFormatConversionConfiguration _dataFormatConversionConfiguration;
        private DynamicPartitioningConfiguration _dynamicPartitioningConfiguration;
        private EncryptionConfiguration _encryptionConfiguration;
        private string _errorOutputPrefix;
        private string _prefix;
        private ProcessingConfiguration _processingConfiguration;
        private string _roleARN;
        private S3DestinationDescription _s3BackupDescription;
        private S3BackupMode _s3BackupMode;

        /// <summary>
        /// Gets and sets the property BucketARN. 
        /// <para>
        /// The ARN of the S3 bucket. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and Amazon Web Services Service Namespaces</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string BucketARN
        {
            get { return this._bucketARN; }
            set { this._bucketARN = value; }
        }

        // Check to see if BucketARN property is set
        internal bool IsSetBucketARN()
        {
            return this._bucketARN != null;
        }

        /// <summary>
        /// Gets and sets the property BufferingHints. 
        /// <para>
        /// The buffering option.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BufferingHints BufferingHints
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
        /// <para>
        /// The Amazon CloudWatch logging options for your delivery stream.
        /// </para>
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
        /// Gets and sets the property CompressionFormat. 
        /// <para>
        /// The compression format. If no value is specified, the default is <code>UNCOMPRESSED</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CompressionFormat CompressionFormat
        {
            get { return this._compressionFormat; }
            set { this._compressionFormat = value; }
        }

        // Check to see if CompressionFormat property is set
        internal bool IsSetCompressionFormat()
        {
            return this._compressionFormat != null;
        }

        /// <summary>
        /// Gets and sets the property DataFormatConversionConfiguration. 
        /// <para>
        /// The serializer, deserializer, and schema for converting data from the JSON format
        /// to the Parquet or ORC format before writing it to Amazon S3.
        /// </para>
        /// </summary>
        public DataFormatConversionConfiguration DataFormatConversionConfiguration
        {
            get { return this._dataFormatConversionConfiguration; }
            set { this._dataFormatConversionConfiguration = value; }
        }

        // Check to see if DataFormatConversionConfiguration property is set
        internal bool IsSetDataFormatConversionConfiguration()
        {
            return this._dataFormatConversionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property DynamicPartitioningConfiguration. 
        /// <para>
        /// The configuration of the dynamic partitioning mechanism that creates smaller data
        /// sets from the streaming data by partitioning it based on partition keys. Currently,
        /// dynamic partitioning is only supported for Amazon S3 destinations. 
        /// </para>
        /// </summary>
        public DynamicPartitioningConfiguration DynamicPartitioningConfiguration
        {
            get { return this._dynamicPartitioningConfiguration; }
            set { this._dynamicPartitioningConfiguration = value; }
        }

        // Check to see if DynamicPartitioningConfiguration property is set
        internal bool IsSetDynamicPartitioningConfiguration()
        {
            return this._dynamicPartitioningConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The encryption configuration. If no value is specified, the default is no encryption.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EncryptionConfiguration EncryptionConfiguration
        {
            get { return this._encryptionConfiguration; }
            set { this._encryptionConfiguration = value; }
        }

        // Check to see if EncryptionConfiguration property is set
        internal bool IsSetEncryptionConfiguration()
        {
            return this._encryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorOutputPrefix. 
        /// <para>
        /// A prefix that Kinesis Data Firehose evaluates and adds to failed records before writing
        /// them to S3. This prefix appears immediately following the bucket name. For information
        /// about how to specify this prefix, see <a href="https://docs.aws.amazon.com/firehose/latest/dev/s3-prefixes.html">Custom
        /// Prefixes for Amazon S3 Objects</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ErrorOutputPrefix
        {
            get { return this._errorOutputPrefix; }
            set { this._errorOutputPrefix = value; }
        }

        // Check to see if ErrorOutputPrefix property is set
        internal bool IsSetErrorOutputPrefix()
        {
            return this._errorOutputPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The "YYYY/MM/DD/HH" time format prefix is automatically used for delivered Amazon
        /// S3 files. You can also specify a custom prefix, as described in <a href="https://docs.aws.amazon.com/firehose/latest/dev/s3-prefixes.html">Custom
        /// Prefixes for Amazon S3 Objects</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

        /// <summary>
        /// Gets and sets the property ProcessingConfiguration. 
        /// <para>
        /// The data processing configuration.
        /// </para>
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
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services credentials. For more information,
        /// see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and Amazon Web Services Service Namespaces</a>.
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
        /// Gets and sets the property S3BackupDescription. 
        /// <para>
        /// The configuration for backup in Amazon S3.
        /// </para>
        /// </summary>
        public S3DestinationDescription S3BackupDescription
        {
            get { return this._s3BackupDescription; }
            set { this._s3BackupDescription = value; }
        }

        // Check to see if S3BackupDescription property is set
        internal bool IsSetS3BackupDescription()
        {
            return this._s3BackupDescription != null;
        }

        /// <summary>
        /// Gets and sets the property S3BackupMode. 
        /// <para>
        /// The Amazon S3 backup mode.
        /// </para>
        /// </summary>
        public S3BackupMode S3BackupMode
        {
            get { return this._s3BackupMode; }
            set { this._s3BackupMode = value; }
        }

        // Check to see if S3BackupMode property is set
        internal bool IsSetS3BackupMode()
        {
            return this._s3BackupMode != null;
        }

    }
}