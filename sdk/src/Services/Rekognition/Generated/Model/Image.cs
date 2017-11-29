/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Provides the input image either as bytes or an S3 object.
    /// 
    ///  
    /// <para>
    /// You pass image bytes to a Rekognition API operation by using the <code>Bytes</code>
    /// property. For example, you would use the <code>Bytes</code> property to pass an image
    /// loaded from a local file system. Image bytes passed by using the <code>Bytes</code>
    /// property must be base64-encoded. Your code may not need to encode image bytes if you
    /// are using an AWS SDK to call Rekognition API operations. For more information, see
    /// <a>images-bytes</a>.
    /// </para>
    ///  
    /// <para>
    ///  You pass images stored in an S3 bucket to a Rekognition API operation by using the
    /// <code>S3Object</code> property. Images stored in an S3 bucket do not need to be base64-encoded.
    /// </para>
    ///  
    /// <para>
    /// The region for the S3 bucket containing the S3 object must match the region you use
    /// for Amazon Rekognition operations.
    /// </para>
    ///  
    /// <para>
    /// If you use the Amazon CLI to call Amazon Rekognition operations, passing image bytes
    /// using the Bytes property is not supported. You must first upload the image to an Amazon
    /// S3 bucket and then call the operation using the S3Object property.
    /// </para>
    ///  
    /// <para>
    /// For Amazon Rekognition to process an S3 object, the user must have permission to access
    /// the S3 object. For more information, see <a>manage-access-resource-policies</a>. 
    /// </para>
    /// </summary>
    public partial class Image
    {
        private MemoryStream _bytes;
        private S3Object _s3Object;

        /// <summary>
        /// Gets and sets the property Bytes. 
        /// <para>
        /// Blob of image bytes up to 5 MBs.
        /// </para>
        /// </summary>
        public MemoryStream Bytes
        {
            get { return this._bytes; }
            set { this._bytes = value; }
        }

        // Check to see if Bytes property is set
        internal bool IsSetBytes()
        {
            return this._bytes != null;
        }

        /// <summary>
        /// Gets and sets the property S3Object. 
        /// <para>
        /// Identifies an S3 object as the image source.
        /// </para>
        /// </summary>
        public S3Object S3Object
        {
            get { return this._s3Object; }
            set { this._s3Object = value; }
        }

        // Check to see if S3Object property is set
        internal bool IsSetS3Object()
        {
            return this._s3Object != null;
        }

    }
}