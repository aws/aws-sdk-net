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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
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
namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// This is the response object from the SearchCases operation.
    /// </summary>
    public partial class SearchCasesResponse : AmazonWebServiceResponse
    {
        private List<SearchCasesResponseItem> _cases = AWSConfigs.InitializeCollections ? new List<SearchCasesResponseItem>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Cases. 
        /// <para>
        /// A list of case documents where each case contains the properties <c>CaseId</c> and
        /// <c>Fields</c> where each field is a complex union structure. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<SearchCasesResponseItem> Cases
        {
            get { return this._cases; }
            set { this._cases = value; }
        }

        // Check to see if Cases property is set
        internal bool IsSetCases()
        {
            return this._cases != null && (this._cases.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results. This is null if there are no more results to
        /// return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=9000)]
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