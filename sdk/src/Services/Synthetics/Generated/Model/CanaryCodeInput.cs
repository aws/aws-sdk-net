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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// Use this structure to input your script code for the canary. This structure contains
    /// the Lambda handler with the location where the canary should start running the script.
    /// If the script is stored in an S3 bucket, the bucket name, key, and version are also
    /// included. If the script was passed into the canary directly, the script code is contained
    /// in the value of <code>Zipfile</code>.
    /// </summary>
    public partial class CanaryCodeInput
    {
        private string _handler;
        private string _s3Bucket;
        private string _s3Key;
        private string _s3Version;
        private MemoryStream _zipFile;

        /// <summary>
        /// Gets and sets the property Handler. 
        /// <para>
        /// The entry point to use for the source code when running the canary. This value must
        /// end with the string <code>.handler</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string Handler
        {
            get { return this._handler; }
            set { this._handler = value; }
        }

        // Check to see if Handler property is set
        internal bool IsSetHandler()
        {
            return this._handler != null;
        }

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// If your canary script is located in S3, specify the full bucket name here. The bucket
        /// must already exist. Specify the full bucket name, including <code>s3://</code> as
        /// the start of the bucket name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// The S3 key of your script. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingObjects.html">Working
        /// with Amazon S3 Objects</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property S3Version. 
        /// <para>
        /// The S3 version ID of your script.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string S3Version
        {
            get { return this._s3Version; }
            set { this._s3Version = value; }
        }

        // Check to see if S3Version property is set
        internal bool IsSetS3Version()
        {
            return this._s3Version != null;
        }

        /// <summary>
        /// Gets and sets the property ZipFile. 
        /// <para>
        /// If you input your canary script directly into the canary instead of referring to an
        /// S3 location, the value of this parameter is the .zip file that contains the script.
        /// It can be up to 5 MB.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000000)]
        public MemoryStream ZipFile
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