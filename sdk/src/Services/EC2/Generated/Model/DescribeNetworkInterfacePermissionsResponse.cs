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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Contains the output for DescribeNetworkInterfacePermissions.
    /// </summary>
    public partial class DescribeNetworkInterfacePermissionsResponse : AmazonWebServiceResponse
    {
        private List<NetworkInterfacePermission> _networkInterfacePermissions = new List<NetworkInterfacePermission>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property NetworkInterfacePermissions. 
        /// <para>
        /// The network interface permissions.
        /// </para>
        /// </summary>
        public List<NetworkInterfacePermission> NetworkInterfacePermissions
        {
            get { return this._networkInterfacePermissions; }
            set { this._networkInterfacePermissions = value; }
        }

        // Check to see if NetworkInterfacePermissions property is set
        internal bool IsSetNetworkInterfacePermissions()
        {
            return this._networkInterfacePermissions != null && this._networkInterfacePermissions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to include in another request to get the next page of items. This value
        /// is <code>null</code> when there are no more items to return.
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