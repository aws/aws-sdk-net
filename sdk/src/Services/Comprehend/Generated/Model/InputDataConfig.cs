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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// The input properties for an inference job. The document reader config field applies
    /// only to non-text inputs for custom analysis.
    /// </summary>
    public partial class InputDataConfig
    {
        private DocumentReaderConfig _documentReaderConfig;
        private InputFormat _inputFormat;
        private string _s3Uri;

        /// <summary>
        /// Gets and sets the property DocumentReaderConfig. 
        /// <para>
        /// Provides configuration parameters to override the default actions for extracting text
        /// from PDF documents and image files.
        /// </para>
        /// </summary>
        public DocumentReaderConfig DocumentReaderConfig
        {
            get { return this._documentReaderConfig; }
            set { this._documentReaderConfig = value; }
        }

        // Check to see if DocumentReaderConfig property is set
        internal bool IsSetDocumentReaderConfig()
        {
            return this._documentReaderConfig != null;
        }

        /// <summary>
        /// Gets and sets the property InputFormat. 
        /// <para>
        /// Specifies how the text in an input file should be processed:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ONE_DOC_PER_FILE</code> - Each file is considered a separate document. Use
        /// this option when you are processing large documents, such as newspaper articles or
        /// scientific papers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ONE_DOC_PER_LINE</code> - Each line in a file is considered a separate document.
        /// Use this option when you are processing many short documents, such as text messages.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InputFormat InputFormat
        {
            get { return this._inputFormat; }
            set { this._inputFormat = value; }
        }

        // Check to see if InputFormat property is set
        internal bool IsSetInputFormat()
        {
            return this._inputFormat != null;
        }

        /// <summary>
        /// Gets and sets the property S3Uri. 
        /// <para>
        /// The Amazon S3 URI for the input data. The URI must be in same Region as the API endpoint
        /// that you are calling. The URI can point to a single input file or it can provide the
        /// prefix for a collection of data files. 
        /// </para>
        ///  
        /// <para>
        /// For example, if you use the URI <code>S3://bucketName/prefix</code>, if the prefix
        /// is a single file, Amazon Comprehend uses that file as input. If more than one file
        /// begins with the prefix, Amazon Comprehend uses all of them as input.
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