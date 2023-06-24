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
 * Do not modify this file. This file is generated from the billingconductor-2021-07-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.BillingConductor.Model
{
    /// <summary>
    /// This is the response object from the ListBillingGroups operation.
    /// </summary>
    public partial class ListBillingGroupsResponse : AmazonWebServiceResponse
    {
        private List<BillingGroupListElement> _billingGroups = new List<BillingGroupListElement>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property BillingGroups. 
        /// <para>
        /// A list of <code>BillingGroupListElement</code> retrieved. 
        /// </para>
        /// </summary>
        public List<BillingGroupListElement> BillingGroups
        {
            get { return this._billingGroups; }
            set { this._billingGroups = value; }
        }

        // Check to see if BillingGroups property is set
        internal bool IsSetBillingGroups()
        {
            return this._billingGroups != null && this._billingGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token that's used on subsequent calls to get billing groups. 
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