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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Configuration for downloading input data from Amazon S3 into the processing container.
    /// </summary>
    public partial class ProcessingS3Input
    {
        private string _localPath;
        private ProcessingS3CompressionType _s3CompressionType;
        private ProcessingS3DataDistributionType _s3DataDistributionType;
        private ProcessingS3DataType _s3DataType;
        private ProcessingS3InputMode _s3InputMode;
        private string _s3Uri;

        /// <summary>
        /// Gets and sets the property LocalPath. 
        /// <para>
        /// The local path in your container where you want Amazon SageMaker to write input data
        /// to. <c>LocalPath</c> is an absolute path to the input data and must begin with <c>/opt/ml/processing/</c>.
        /// <c>LocalPath</c> is a required parameter when <c>AppManaged</c> is <c>False</c> (default).
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string LocalPath
        {
            get { return this._localPath; }
            set { this._localPath = value; }
        }

        // Check to see if LocalPath property is set
        internal bool IsSetLocalPath()
        {
            return this._localPath != null;
        }

        /// <summary>
        /// Gets and sets the property S3CompressionType. 
        /// <para>
        /// Whether to GZIP-decompress the data in Amazon S3 as it is streamed into the processing
        /// container. <c>Gzip</c> can only be used when <c>Pipe</c> mode is specified as the
        /// <c>S3InputMode</c>. In <c>Pipe</c> mode, Amazon SageMaker streams input data from
        /// the source directly to your container without using the EBS volume.
        /// </para>
        /// </summary>
        public ProcessingS3CompressionType S3CompressionType
        {
            get { return this._s3CompressionType; }
            set { this._s3CompressionType = value; }
        }

        // Check to see if S3CompressionType property is set
        internal bool IsSetS3CompressionType()
        {
            return this._s3CompressionType != null;
        }

        /// <summary>
        /// Gets and sets the property S3DataDistributionType. 
        /// <para>
        /// Whether to distribute the data from Amazon S3 to all processing instances with <c>FullyReplicated</c>,
        /// or whether the data from Amazon S3 is shared by Amazon S3 key, downloading one shard
        /// of data to each processing instance.
        /// </para>
        /// </summary>
        public ProcessingS3DataDistributionType S3DataDistributionType
        {
            get { return this._s3DataDistributionType; }
            set { this._s3DataDistributionType = value; }
        }

        // Check to see if S3DataDistributionType property is set
        internal bool IsSetS3DataDistributionType()
        {
            return this._s3DataDistributionType != null;
        }

        /// <summary>
        /// Gets and sets the property S3DataType. 
        /// <para>
        /// Whether you use an <c>S3Prefix</c> or a <c>ManifestFile</c> for the data type. If
        /// you choose <c>S3Prefix</c>, <c>S3Uri</c> identifies a key name prefix. Amazon SageMaker
        /// uses all objects with the specified key name prefix for the processing job. If you
        /// choose <c>ManifestFile</c>, <c>S3Uri</c> identifies an object that is a manifest file
        /// containing a list of object keys that you want Amazon SageMaker to use for the processing
        /// job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProcessingS3DataType S3DataType
        {
            get { return this._s3DataType; }
            set { this._s3DataType = value; }
        }

        // Check to see if S3DataType property is set
        internal bool IsSetS3DataType()
        {
            return this._s3DataType != null;
        }

        /// <summary>
        /// Gets and sets the property S3InputMode. 
        /// <para>
        /// Whether to use <c>File</c> or <c>Pipe</c> input mode. In File mode, Amazon SageMaker
        /// copies the data from the input source onto the local ML storage volume before starting
        /// your processing container. This is the most commonly used input mode. In <c>Pipe</c>
        /// mode, Amazon SageMaker streams input data from the source directly to your processing
        /// container into named pipes without using the ML storage volume.
        /// </para>
        /// </summary>
        public ProcessingS3InputMode S3InputMode
        {
            get { return this._s3InputMode; }
            set { this._s3InputMode = value; }
        }

        // Check to see if S3InputMode property is set
        internal bool IsSetS3InputMode()
        {
            return this._s3InputMode != null;
        }

        /// <summary>
        /// Gets and sets the property S3Uri. 
        /// <para>
        /// The URI of the Amazon S3 prefix Amazon SageMaker downloads data required to run a
        /// processing job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string S3Uri
        {
            get { return this._s3Uri; }
            set { this._s3Uri = value; }
        }

        // Check to see if S3Uri property is set
        internal bool IsSetS3Uri()
        {
            return this._s3Uri != null;
        }

    }
}