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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The code for the Lambda function. You can specify either an object in Amazon S3, or
    /// upload a deployment package directly.
    /// </summary>
    public partial class AwsLambdaFunctionCode
    {
        private string _s3Bucket;
        private string _s3Key;
        private string _s3ObjectVersion;
        private string _zipFile;

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// An Amazon S3 bucket in the same Amazon Web Services Region as your function. The bucket
        /// can be in a different Amazon Web Services account.
        /// </para>
        /// </summary>
        public string S3Bucket
        {
            get { return this._s3Bucket; }
            set { this._s3Bucket = value; }
        }

        // Check to see if S3Bucket property is set
        internal bool IsSetS3Bucket()
        {
            return this._s3Bucket != null;
        }

        /// <summary>
        /// Gets and sets the property S3Key. 
        /// <para>
        /// The Amazon S3 key of the deployment package.
        /// </para>
        /// </summary>
        public string S3Key
        {
            get { return this._s3Key; }
            set { this._s3Key = value; }
        }

        // Check to see if S3Key property is set
        internal bool IsSetS3Key()
        {
            return this._s3Key != null;
        }

        /// <summary>
        /// Gets and sets the property S3ObjectVersion. 
        /// <para>
        /// For versioned objects, the version of the deployment package object to use.
        /// </para>
        /// </summary>
        public string S3ObjectVersion
        {
            get { return this._s3ObjectVersion; }
            set { this._s3ObjectVersion = value; }
        }

        // Check to see if S3ObjectVersion property is set
        internal bool IsSetS3ObjectVersion()
        {
            return this._s3ObjectVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ZipFile. 
        /// <para>
        /// The base64-encoded contents of the deployment package. Amazon Web Services SDK and
        /// Amazon Web Services CLI clients handle the encoding for you.
        /// </para>
        /// </summary>
        public string ZipFile
        {
            get { return this._zipFile; }
            set { this._zipFile = value; }
        }

        // Check to see if ZipFile property is set
        internal bool IsSetZipFile()
        {
            return this._zipFile != null;
        }

    }
}