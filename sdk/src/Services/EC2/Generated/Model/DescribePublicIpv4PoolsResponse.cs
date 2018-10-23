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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the DescribePublicIpv4Pools operation.
    /// </summary>
    public partial class DescribePublicIpv4PoolsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<PublicIpv4Pool> _publicIpv4Pools = new List<PublicIpv4Pool>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to retrieve the next page of results. This value is <code>null</code>
        /// when there are no more results to return.
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
        /// Gets and sets the property PublicIpv4Pools. 
        /// <para>
        /// Information about the address pools.
        /// </para>
        /// </summary>
        public List<PublicIpv4Pool> PublicIpv4Pools
        {
            get { return this._publicIpv4Pools; }
            set { this._publicIpv4Pools = value; }
        }

        // Check to see if PublicIpv4Pools property is set
        internal bool IsSetPublicIpv4Pools()
        {
            return this._publicIpv4Pools != null && this._publicIpv4Pools.Count > 0; 
        }

    }
}