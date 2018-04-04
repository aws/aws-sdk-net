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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FMS.Model
{
    /// <summary>
    /// This is the response object from the ListPolicies operation.
    /// </summary>
    public partial class ListPoliciesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<PolicySummary> _policyList = new List<PolicySummary>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If you have more <code>PolicySummary</code> objects than the number that you specified
        /// for <code>MaxResults</code> in the request, the response includes a <code>NextToken</code>
        /// value. To list more <code>PolicySummary</code> objects, submit another <code>ListPolicies</code>
        /// request, and specify the <code>NextToken</code> value from the response in the <code>NextToken</code>
        /// value in the next request.
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

        /// <summary>
        /// Gets and sets the property PolicyList. 
        /// <para>
        /// An array of <code>PolicySummary</code> objects.
        /// </para>
        /// </summary>
        public List<PolicySummary> PolicyList
        {
            get { return this._policyList; }
            set { this._policyList = value; }
        }

        // Check to see if PolicyList property is set
        internal bool IsSetPolicyList()
        {
            return this._policyList != null && this._policyList.Count > 0; 
        }

    }
}