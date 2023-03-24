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
    /// Describes the training documents submitted with an entity recognizer.
    /// </summary>
    public partial class EntityRecognizerDocuments
    {
        private InputFormat _inputFormat;
        private string _s3Uri;
        private string _testS3Uri;

        /// <summary>
        /// Gets and sets the property InputFormat. 
        /// <para>
        ///  Specifies how the text in an input file should be processed. This is optional, and
        /// the default is ONE_DOC_PER_LINE. ONE_DOC_PER_FILE - Each file is considered a separate
        /// document. Use this option when you are processing large documents, such as newspaper
        /// articles or scientific papers. ONE_DOC_PER_LINE - Each line in a file is considered
        /// a separate document. Use this option when you are processing many short documents,
        /// such as text messages.
        /// </para>
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
        ///  Specifies the Amazon S3 location where the training documents for an entity recognizer
        /// are located. The URI must be in the same Region as the API endpoint that you are calling.
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

        /// <summary>
        /// Gets and sets the property TestS3Uri. 
        /// <para>
        ///  Specifies the Amazon S3 location where the test documents for an entity recognizer
        /// are located. The URI must be in the same Amazon Web Services Region as the API endpoint
        /// that you are calling.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string TestS3Uri
        {
            get { return this._testS3Uri; }
            set { this._testS3Uri = value; }
        }

        // Check to see if TestS3Uri property is set
        internal bool IsSetTestS3Uri()
        {
            return this._testS3Uri != null;
        }

    }
}