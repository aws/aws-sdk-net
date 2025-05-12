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
    /// Configuration for uploading output data to Amazon S3 from the processing container.
    /// </summary>
    public partial class ProcessingS3Output
    {
        private string _localPath;
        private ProcessingS3UploadMode _s3UploadMode;
        private string _s3Uri;

        /// <summary>
        /// Gets and sets the property LocalPath. 
        /// <para>
        /// The local path of a directory where you want Amazon SageMaker to upload its contents
        /// to Amazon S3. <c>LocalPath</c> is an absolute path to a directory containing output
        /// files. This directory will be created by the platform and exist when your container's
        /// entrypoint is invoked.
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
        /// Gets and sets the property S3UploadMode. 
        /// <para>
        /// Whether to upload the results of the processing job continuously or after the job
        /// completes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProcessingS3UploadMode S3UploadMode
        {
            get { return this._s3UploadMode; }
            set { this._s3UploadMode = value; }
        }

        // Check to see if S3UploadMode property is set
        internal bool IsSetS3UploadMode()
        {
            return this._s3UploadMode != null;
        }

        /// <summary>
        /// Gets and sets the property S3Uri. 
        /// <para>
        /// A URI that identifies the Amazon S3 bucket where you want Amazon SageMaker to save
        /// the results of a processing job.
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