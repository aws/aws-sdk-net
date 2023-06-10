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

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// A ZIP archive that contains the contents of an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">Lambda
    /// layer</a>. You can specify either an Amazon S3 location, or upload a layer archive
    /// directly.
    /// </summary>
    public partial class LayerVersionContentInput
    {
        private string _s3Bucket;
        private string _s3Key;
        private string _s3ObjectVersion;
        private MemoryStream _zipFile;

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// The Amazon S3 bucket of the layer archive.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=63)]
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
        /// The Amazon S3 key of the layer archive.
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
        /// For versioned objects, the version of the layer archive object to use.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// The base64-encoded contents of the layer archive. Amazon Web Services SDK and Amazon
        /// Web Services CLI clients handle the encoding for you.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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