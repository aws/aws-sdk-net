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
    /// This is the response object from the ListCasesForContact operation.
    /// </summary>
    public partial class ListCasesForContactResponse : AmazonWebServiceResponse
    {
        private List<CaseSummary> _cases = AWSConfigs.InitializeCollections ? new List<CaseSummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Cases. 
        /// <para>
        /// A list of Case summary information.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<CaseSummary> Cases
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