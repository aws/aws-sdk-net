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

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// A ZIP archive that contains the contents of an <a href="https://docs.aws.amazon.com/lambda/latest/dg/configuration-layers.html">Lambda
    /// layer</a>. You can specify either an Amazon S3 location, or upload a layer archive
    /// directly.
    /// </summary>
    public partial class LayerVersionContentInput
    {
        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// The Amazon S3 bucket of the layer archive.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 63)]
        public string S3Bucket { get; set; }

        /// <summary>
        /// Checks to see if the S3Bucket property is set.
        /// </summary>
        internal bool IsSetS3Bucket() => this.S3Bucket != null;

        /// <summary>
        /// Gets and sets the property S3Key. 
        /// <para>
        /// The Amazon S3 key of the layer archive.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string S3Key { get; set; }

        /// <summary>
        /// Checks to see if the S3Key property is set.
        /// </summary>
        internal bool IsSetS3Key() => this.S3Key != null;

        /// <summary>
        /// Gets and sets the property S3ObjectStorageMode. 
        /// <para>
        /// Specifies how the layer archive is stored. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>COPY</c> (default) – Uploads a copy of your layer archive to Lambda.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REFERENCE</c> – Lambda references the layer archive from the specified Amazon
        /// S3 bucket.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public S3ObjectStorageMode S3ObjectStorageMode { get; set; }

        /// <summary>
        /// Checks to see if the S3ObjectStorageMode property is set.
        /// </summary>
        internal bool IsSetS3ObjectStorageMode() => this.S3ObjectStorageMode != null;

        /// <summary>
        /// Gets and sets the property S3ObjectVersion. 
        /// <para>
        /// For versioned objects, the version of the layer archive object to use.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string S3ObjectVersion { get; set; }

        /// <summary>
        /// Checks to see if the S3ObjectVersion property is set.
        /// </summary>
        internal bool IsSetS3ObjectVersion() => this.S3ObjectVersion != null;

        /// <summary>
        /// Gets and sets the property ZipFile. 
        /// <para>
        /// The base64-encoded contents of the layer archive. Amazon Web Services SDK and Amazon
        /// Web Services CLI clients handle the encoding for you.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public MemoryStream ZipFile { get; set; }

        /// <summary>
        /// Checks to see if the ZipFile property is set.
        /// </summary>
        internal bool IsSetZipFile() => this.ZipFile != null;
    }
}
