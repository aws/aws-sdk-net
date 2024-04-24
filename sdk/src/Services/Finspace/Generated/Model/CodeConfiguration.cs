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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
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
namespace Amazon.Finspace.Model
{
    /// <summary>
    /// The structure of the customer code available within the running cluster.
    /// </summary>
    public partial class CodeConfiguration
    {
        private string _s3Bucket;
        private string _s3Key;
        private string _s3ObjectVersion;

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// A unique name for the S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=255)]
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
        /// The full S3 path (excluding bucket) to the .zip file. This file contains the code
        /// that is loaded onto the cluster when it's started.
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
        /// Gets and sets the property S3ObjectVersion. 
        /// <para>
        /// The version of an S3 object.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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

    }
}