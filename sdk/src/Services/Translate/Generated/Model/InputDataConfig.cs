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

namespace Amazon.Translate.Model
{
    /// <summary>
    /// The input configuration properties for requesting a batch translation job.
    /// </summary>
    public partial class InputDataConfig
    {
        private string _contentType;
        private string _s3Uri;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// Describes the format of the data that you submit to Amazon Translate as input. You
        /// can specify one of the following multipurpose internet mail extension (MIME) types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>text/html</code>: The input data consists of one or more HTML files. Amazon
        /// Translate translates only the text that resides in the <code>html</code> element in
        /// each file.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>text/plain</code>: The input data consists of one or more unformatted text
        /// files. Amazon Translate translates every character in this type of input.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>application/vnd.openxmlformats-officedocument.wordprocessingml.document</code>:
        /// The input data consists of one or more Word documents (.docx).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>application/vnd.openxmlformats-officedocument.presentationml.presentation</code>:
        /// The input data consists of one or more PowerPoint Presentation files (.pptx).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>application/vnd.openxmlformats-officedocument.spreadsheetml.sheet</code>: The
        /// input data consists of one or more Excel Workbook files (.xlsx).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>application/x-xliff+xml</code>: The input data consists of one or more XML
        /// Localization Interchange File Format (XLIFF) files (.xlf). Amazon Translate supports
        /// only XLIFF version 1.2.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// If you structure your input data as HTML, ensure that you set this parameter to <code>text/html</code>.
        /// By doing so, you cut costs by limiting the translation to the contents of the <code>html</code>
        /// element in each file. Otherwise, if you set this parameter to <code>text/plain</code>,
        /// your costs will cover the translation of every character.
        /// </para>
        ///  </important>
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

        /// <summary>
        /// Gets and sets the property S3Uri. 
        /// <para>
        /// The URI of the AWS S3 folder that contains the input files. Amazon Translate translates
        /// all the files in the folder and all its sub-folders. The folder must be in the same
        /// Region as the API endpoint you are calling.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
        public string S3Uri
        {
            get { return this._s3Uri; }
            set { this._s3Uri = value; }
        }

        // Check to see if S3Uri property is set
        internal bool IsSetS3Uri()
        {
            return this._s3Uri != null;
        }

    }
}