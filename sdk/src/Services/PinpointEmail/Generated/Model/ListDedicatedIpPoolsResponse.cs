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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// A list of dedicated IP pools.
    /// </summary>
    public partial class ListDedicatedIpPoolsResponse : AmazonWebServiceResponse
    {
        private List<string> _dedicatedIpPools = new List<string>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DedicatedIpPools. 
        /// <para>
        /// A list of all of the dedicated IP pools that are associated with your Amazon Pinpoint
        /// account.
        /// </para>
        /// </summary>
        public List<string> DedicatedIpPools
        {
            get { return this._dedicatedIpPools; }
            set { this._dedicatedIpPools = value; }
        }

        // Check to see if DedicatedIpPools property is set
        internal bool IsSetDedicatedIpPools()
        {
            return this._dedicatedIpPools != null && this._dedicatedIpPools.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates that there are additional IP pools to list. To view additional
        /// IP pools, issue another request to <code>ListDedicatedIpPools</code>, passing this
        /// token in the <code>NextToken</code> parameter.
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