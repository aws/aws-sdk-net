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
 * Do not modify this file. This file is generated from the translate-2017-07-01.normal.json service model.
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
namespace Amazon.Translate.Model
{
    /// <summary>
    /// The content and content type of a document.
    /// </summary>
    public partial class Document
    {
        private MemoryStream _content;
        private string _contentType;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The <c>Content</c>field type is Binary large object (blob). This object contains the
        /// document content converted into base64-encoded binary data. If you use one of the
        /// AWS SDKs, the SDK performs the Base64-encoding on this field before sending the request.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Max=102400)]
        public MemoryStream Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// Describes the format of the document. You can specify one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>text/html</c> - The input data consists of HTML content. Amazon Translate translates
        /// only the text in the HTML element.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>text/plain</c> - The input data consists of unformatted text. Amazon Translate
        /// translates every character in the content. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>application/vnd.openxmlformats-officedocument.wordprocessingml.document</c> -
        /// The input data consists of a Word document (.docx).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

    }
}