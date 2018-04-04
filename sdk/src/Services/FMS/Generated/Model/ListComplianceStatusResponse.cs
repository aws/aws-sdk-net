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
    /// This is the response object from the ListComplianceStatus operation.
    /// </summary>
    public partial class ListComplianceStatusResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<PolicyComplianceStatus> _policyComplianceStatusList = new List<PolicyComplianceStatus>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If you have more <code>PolicyComplianceStatus</code> objects than the number that
        /// you specified for <code>MaxResults</code> in the request, the response includes a
        /// <code>NextToken</code> value. To list more <code>PolicyComplianceStatus</code> objects,
        /// submit another <code>ListComplianceStatus</code> request, and specify the <code>NextToken</code>
        /// value from the response in the <code>NextToken</code> value in the next request.
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
        /// Gets and sets the property PolicyComplianceStatusList. 
        /// <para>
        /// An array of <code>PolicyComplianceStatus</code> objects.
        /// </para>
        /// </summary>
        public List<PolicyComplianceStatus> PolicyComplianceStatusList
        {
            get { return this._policyComplianceStatusList; }
            set { this._policyComplianceStatusList = value; }
        }

        // Check to see if PolicyComplianceStatusList property is set
        internal bool IsSetPolicyComplianceStatusList()
        {
            return this._policyComplianceStatusList != null && this._policyComplianceStatusList.Count > 0; 
        }

    }
}