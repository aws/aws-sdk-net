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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Details about the connection between a Lambda function and an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-filesystem.html">Amazon
    /// EFS file system</a> or an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-filesystem.html">Amazon
    /// S3 file system</a>.
    /// </summary>
    public partial class FileSystemConfig
    {
        private string _arn;
        private string _localMountPath;
        private S3FilesConfig _s3FilesConfig;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon EFS or Amazon S3 Files access point that
        /// provides access to the file system.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property LocalMountPath. 
        /// <para>
        /// The path where the function can access the file system, starting with <c>/mnt/</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=160)]
        public string LocalMountPath
        {
            get { return this._localMountPath; }
            set { this._localMountPath = value; }
        }

        // Check to see if LocalMountPath property is set
        internal bool IsSetLocalMountPath()
        {
            return this._localMountPath != null;
        }

        /// <summary>
        /// Gets and sets the property S3FilesConfig. 
        /// <para>
        /// The configuration for how your function accesses data on an Amazon S3 file system.
        /// Valid only when the file system access point ARN is an Amazon S3 Files access point.
        /// If you specify a different access point type (for example, Amazon Elastic File System),
        /// the operation returns an <c>InvalidParameterException</c>.
        /// </para>
        /// </summary>
        public S3FilesConfig S3FilesConfig
        {
            get { return this._s3FilesConfig; }
            set { this._s3FilesConfig = value; }
        }

        // Check to see if S3FilesConfig property is set
        internal bool IsSetS3FilesConfig()
        {
            return this._s3FilesConfig != null;
        }

    }
}