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
 * Do not modify this file. This file is generated from the entitlement.marketplace-2017-01-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MarketplaceEntitlementService.Model
{
    /// <summary>
    /// The GetEntitlementsRequest contains results from the GetEntitlements operation.
    /// </summary>
    public partial class GetEntitlementsResponse : AmazonWebServiceResponse
    {
        private List<Entitlement> _entitlements = new List<Entitlement>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Entitlements. 
        /// <para>
        /// The set of entitlements found through the GetEntitlements operation. If the result
        /// contains an empty set of entitlements, NextToken might still be present and should
        /// be used.
        /// </para>
        /// </summary>
        public List<Entitlement> Entitlements
        {
            get { return this._entitlements; }
            set { this._entitlements = value; }
        }

        // Check to see if Entitlements property is set
        internal bool IsSetEntitlements()
        {
            return this._entitlements != null && this._entitlements.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// For paginated results, use NextToken in subsequent calls to GetEntitlements. If the
        /// result contains an empty set of entitlements, NextToken might still be present and
        /// should be used.
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