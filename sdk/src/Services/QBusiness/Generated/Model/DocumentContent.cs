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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// The contents of a document.
    /// 
    ///  <note> 
    /// <para>
    /// Documents have size limitations. The maximum file size for a document is 50 MB. The
    /// maximum amount of text that can be extracted from a single document is 5 MB. For more
    /// information, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/doc-types.html">Supported
    /// document formats in Amazon Q Business</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DocumentContent
    {
        private MemoryStream _blob;
        private S3 _s3;

        /// <summary>
        /// Gets and sets the property Blob. 
        /// <para>
        /// The contents of the document. Documents passed to the <c>blob</c> parameter must be
        /// base64 encoded. Your code might not need to encode the document file bytes if you're
        /// using an Amazon Web Services SDK to call Amazon Q Business APIs. If you are calling
        /// the Amazon Q Business endpoint directly using REST, you must base64 encode the contents
        /// before sending.
        /// </para>
        /// </summary>
        public MemoryStream Blob
        {
            get { return this._blob; }
            set { this._blob = value; }
        }

        // Check to see if Blob property is set
        internal bool IsSetBlob()
        {
            return this._blob != null;
        }

        /// <summary>
        /// Gets and sets the property S3. 
        /// <para>
        /// The path to the document in an Amazon S3 bucket.
        /// </para>
        /// </summary>
        public S3 S3
        {
            get { return this._s3; }
            set { this._s3 = value; }
        }

        // Check to see if S3 property is set
        internal bool IsSetS3()
        {
            return this._s3 != null;
        }

    }
}