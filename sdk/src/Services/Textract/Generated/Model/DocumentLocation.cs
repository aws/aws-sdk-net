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

namespace Amazon.Textract.Model
{
    /// <summary>
    /// The Amazon S3 bucket that contains the document to be processed. It's used by asynchronous
    /// operations.
    /// 
    ///  
    /// <para>
    /// The input document can be an image file in JPEG or PNG format. It can also be a file
    /// in PDF format.
    /// </para>
    /// </summary>
    public partial class DocumentLocation
    {
        private S3Object _s3Object;

        /// <summary>
        /// Gets and sets the property S3Object. 
        /// <para>
        /// The Amazon S3 bucket that contains the input document.
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