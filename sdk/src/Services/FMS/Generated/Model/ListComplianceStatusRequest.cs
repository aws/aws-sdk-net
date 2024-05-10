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
    /// Container for the parameters to the ListComplianceStatus operation.
    /// Returns an array of <c>PolicyComplianceStatus</c> objects. Use <c>PolicyComplianceStatus</c>
    /// to get a summary of which member accounts are protected by the specified policy.
    /// </summary>
    public partial class ListComplianceStatusRequest : AmazonFMSRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _policyId;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specifies the number of <c>PolicyComplianceStatus</c> objects that you want Firewall
        /// Manager to return for this request. If you have more <c>PolicyComplianceStatus</c>
        /// objects than the number that you specify for <c>MaxResults</c>, the response includes
        /// a <c>NextToken</c> value that you can use to get another batch of <c>PolicyComplianceStatus</c>
        /// objects.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If you specify a value for <c>MaxResults</c> and you have more <c>PolicyComplianceStatus</c>
        /// objects than the number that you specify for <c>MaxResults</c>, Firewall Manager returns
        /// a <c>NextToken</c> value in the response that allows you to list another group of
        /// <c>PolicyComplianceStatus</c> objects. For the second and subsequent <c>ListComplianceStatus</c>
        /// requests, specify the value of <c>NextToken</c> from the previous response to get
        /// information about another batch of <c>PolicyComplianceStatus</c> objects.
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
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// The ID of the Firewall Manager policy that you want the details for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string PolicyId
        {
            get { return this._policyId; }
            set { this._policyId = value; }
        }

        // Check to see if PolicyId property is set
        internal bool IsSetPolicyId()
        {
            return this._policyId != null;
        }

    }
}