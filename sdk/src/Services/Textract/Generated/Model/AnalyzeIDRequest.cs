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
    /// Container for the parameters to the AnalyzeID operation.
    /// Analyzes identity documents for relevant information. This information is extracted
    /// and returned as <code>IdentityDocumentFields</code>, which records both the normalized
    /// field and value of the extracted text. Unlike other Amazon Textract operations, <code>AnalyzeID</code>
    /// doesn't return any Geometry data.
    /// </summary>
    public partial class AnalyzeIDRequest : AmazonTextractRequest
    {
        private List<Document> _documentPages = new List<Document>();

        /// <summary>
        /// Gets and sets the property DocumentPages. 
        /// <para>
        /// The document being passed to AnalyzeID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2)]
        public List<Document> DocumentPages
        {
            get { return this._documentPages; }
            set { this._documentPages = value; }
        }

        // Check to see if DocumentPages property is set
        internal bool IsSetDocumentPages()
        {
            return this._documentPages != null && this._documentPages.Count > 0; 
        }

    }
}