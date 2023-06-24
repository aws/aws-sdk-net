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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// This is the response object from the ListClassificationScopes operation.
    /// </summary>
    public partial class ListClassificationScopesResponse : AmazonWebServiceResponse
    {
        private List<ClassificationScopeSummary> _classificationScopes = new List<ClassificationScopeSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ClassificationScopes. 
        /// <para>
        /// An array that specifies the unique identifier and name of the classification scope
        /// for the account.
        /// </para>
        /// </summary>
        public List<ClassificationScopeSummary> ClassificationScopes
        {
            get { return this._classificationScopes; }
            set { this._classificationScopes = value; }
        }

        // Check to see if ClassificationScopes property is set
        internal bool IsSetClassificationScopes()
        {
            return this._classificationScopes != null && this._classificationScopes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The string to use in a subsequent request to get the next page of results in a paginated
        /// response. This value is null if there are no additional pages.
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