/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// Returns an array of <a>CaseDetails</a> objects and a <code>nextToken</code> that defines
    /// a point for pagination in the result set.
    /// </summary>
    public partial class DescribeCasesResponse : AmazonWebServiceResponse
    {
        private List<CaseDetails> _cases = new List<CaseDetails>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Cases. 
        /// <para>
        /// The details for the cases that match the request.
        /// </para>
        /// </summary>
        public List<CaseDetails> Cases
        {
            get { return this._cases; }
            set { this._cases = value; }
        }

        // Check to see if Cases property is set
        internal bool IsSetCases()
        {
            return this._cases != null && this._cases.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A resumption point for pagination.
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