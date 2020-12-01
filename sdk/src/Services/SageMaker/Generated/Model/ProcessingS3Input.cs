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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Configuration for processing job inputs in Amazon S3.
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
        /// The local path to the Amazon S3 bucket where you want Amazon SageMaker to download
        /// the inputs to run a processing job. <code>LocalPath</code> is an absolute path to
        /// the input data. This is a required parameter when <code>AppManaged</code> is <code>False</code>
        /// (default).
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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
        /// Whether to use <code>Gzip</code> compression for Amazon S3 storage.
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
        /// Whether the data stored in Amazon S3 is <code>FullyReplicated</code> or <code>ShardedByS3Key</code>.
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
        /// Whether you use an <code>S3Prefix</code> or a <code>ManifestFile</code> for the data
        /// type. If you choose <code>S3Prefix</code>, <code>S3Uri</code> identifies a key name
        /// prefix. Amazon SageMaker uses all objects with the specified key name prefix for the
        /// processing job. If you choose <code>ManifestFile</code>, <code>S3Uri</code> identifies
        /// an object that is a manifest file containing a list of object keys that you want Amazon
        /// SageMaker to use for the processing job.
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
        /// Whether to use <code>File</code> or <code>Pipe</code> input mode. In <code>File</code>
        /// mode, Amazon SageMaker copies the data from the input source onto the local Amazon
        /// Elastic Block Store (Amazon EBS) volumes before starting your training algorithm.
        /// This is the most commonly used input mode. In <code>Pipe</code> mode, Amazon SageMaker
        /// streams input data from the source directly to your algorithm without using the EBS
        /// volume.This is a required parameter when <code>AppManaged</code> is <code>False</code>
        /// (default).
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
        /// The URI for the Amazon S3 storage where you want Amazon SageMaker to download the
        /// artifacts needed to run a processing job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
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