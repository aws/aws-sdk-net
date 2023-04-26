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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// A document ID doesn't exist but you have specified as a featured document. Amazon
    /// Kendra cannot feature the document if it doesn't exist in the index. You can check
    /// the status of a document and its ID or check for documents with status errors using
    /// the <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_BatchGetDocumentStatus.html">BatchGetDocumentStatus</a>
    /// API.
    /// </summary>
    public partial class FeaturedDocumentMissing
    {
        private string _id;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the document that doesn't exist but you have specified as a featured
        /// document.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

    }
}