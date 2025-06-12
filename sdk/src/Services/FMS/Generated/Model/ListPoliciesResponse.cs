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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
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
namespace Amazon.FMS.Model
{
    /// <summary>
    /// This is the response object from the ListPolicies operation.
    /// </summary>
    public partial class ListPoliciesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<PolicySummary> _policyList = AWSConfigs.InitializeCollections ? new List<PolicySummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If you have more <c>PolicySummary</c> objects than the number that you specified for
        /// <c>MaxResults</c> in the request, the response includes a <c>NextToken</c> value.
        /// To list more <c>PolicySummary</c> objects, submit another <c>ListPolicies</c> request,
        /// and specify the <c>NextToken</c> value from the response in the <c>NextToken</c> value
        /// in the next request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
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
        /// An array of <c>PolicySummary</c> objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PolicySummary> PolicyList
        {
            get { return this._policyList; }
            set { this._policyList = value; }
        }

        // Check to see if PolicyList property is set
        internal bool IsSetPolicyList()
        {
            return this._policyList != null && (this._policyList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}