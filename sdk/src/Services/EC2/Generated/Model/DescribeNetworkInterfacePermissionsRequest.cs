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
    /// Container for the parameters to the DescribeNetworkInterfacePermissions operation.
    /// Describes the permissions for your network interfaces.
    /// </summary>
    public partial class DescribeNetworkInterfacePermissionsRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private int? _maxResults;
        private List<string> _networkInterfacePermissionIds = new List<string>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>network-interface-permission.network-interface-permission-id</code> - The ID
        /// of the permission.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface-permission.network-interface-id</code> - The ID of the network
        /// interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface-permission.aws-account-id</code> - The AWS account ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface-permission.aws-service</code> - The AWS service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface-permission.permission</code> - The type of permission (<code>INSTANCE-ATTACH</code>
        /// | <code>EIP-ASSOCIATE</code>).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call. To retrieve the remaining
        /// results, make another call with the returned <code>NextToken</code> value. If this
        /// parameter is not specified, up to 50 results are returned by default.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfacePermissionIds. 
        /// <para>
        /// One or more network interface permission IDs.
        /// </para>
        /// </summary>
        public List<string> NetworkInterfacePermissionIds
        {
            get { return this._networkInterfacePermissionIds; }
            set { this._networkInterfacePermissionIds = value; }
        }

        // Check to see if NetworkInterfacePermissionIds property is set
        internal bool IsSetNetworkInterfacePermissionIds()
        {
            return this._networkInterfacePermissionIds != null && this._networkInterfacePermissionIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to request the next page of results.
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