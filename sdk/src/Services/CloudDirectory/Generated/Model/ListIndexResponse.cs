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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// This is the response object from the ListIndex operation.
    /// </summary>
    public partial class ListIndexResponse : AmazonWebServiceResponse
    {
        private List<IndexAttachment> _indexAttachments = new List<IndexAttachment>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property IndexAttachments. 
        /// <para>
        /// The objects and indexed values attached to the index.
        /// </para>
        /// </summary>
        public List<IndexAttachment> IndexAttachments
        {
            get { return this._indexAttachments; }
            set { this._indexAttachments = value; }
        }

        // Check to see if IndexAttachments property is set
        internal bool IsSetIndexAttachments()
        {
            return this._indexAttachments != null && this._indexAttachments.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}