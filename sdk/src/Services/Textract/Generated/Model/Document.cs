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
 * Do not modify this file. This file is generated from the textract-2018-06-27.normal.json service model.
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
namespace Amazon.Textract.Model
{
    /// <summary>
    /// The input document, either as bytes or as an S3 object.
    /// 
    ///  
    /// <para>
    /// You pass image bytes to an Amazon Textract API operation by using the <c>Bytes</c>
    /// property. For example, you would use the <c>Bytes</c> property to pass a document
    /// loaded from a local file system. Image bytes passed by using the <c>Bytes</c> property
    /// must be base64 encoded. Your code might not need to encode document file bytes if
    /// you're using an AWS SDK to call Amazon Textract API operations. 
    /// </para>
    ///  
    /// <para>
    /// You pass images stored in an S3 bucket to an Amazon Textract API operation by using
    /// the <c>S3Object</c> property. Documents stored in an S3 bucket don't need to be base64
    /// encoded.
    /// </para>
    ///  
    /// <para>
    /// The AWS Region for the S3 bucket that contains the S3 object must match the AWS Region
    /// that you use for Amazon Textract operations.
    /// </para>
    ///  
    /// <para>
    /// If you use the AWS CLI to call Amazon Textract operations, passing image bytes using
    /// the Bytes property isn't supported. You must first upload the document to an Amazon
    /// S3 bucket, and then call the operation using the S3Object property.
    /// </para>
    ///  
    /// <para>
    /// For Amazon Textract to process an S3 object, the user must have permission to access
    /// the S3 object. 
    /// </para>
    /// </summary>
    public partial class Document
    {
        private MemoryStream _bytes;
        private S3Object _s3Object;

        /// <summary>
        /// Gets and sets the property Bytes. 
        /// <para>
        /// A blob of base64-encoded document bytes. The maximum size of a document that's provided
        /// in a blob of bytes is 5 MB. The document bytes must be in PNG or JPEG format.
        /// </para>
        ///  
        /// <para>
        /// If you're using an AWS SDK to call Amazon Textract, you might not need to base64-encode
        /// image bytes passed using the <c>Bytes</c> field. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10485760)]
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
        /// Identifies an S3 object as the document source. The maximum size of a document that's
        /// stored in an S3 bucket is 5 MB.
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