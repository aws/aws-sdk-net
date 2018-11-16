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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Container for the parameters to the ListAvailableManagementCidrRanges operation.
    /// Retrieves a list of IP address ranges, specified as IPv4 CIDR blocks, that you can
    /// use for the network management interface when you enable bring your own license (BYOL).
    /// 
    /// 
    ///  
    /// <para>
    /// The management network interface is connected to a secure Amazon WorkSpaces management
    /// network. It is used for interactive streaming of the WorkSpace desktop to Amazon WorkSpaces
    /// clients, and to allow Amazon WorkSpaces to manage the WorkSpace.
    /// </para>
    /// </summary>
    public partial class ListAvailableManagementCidrRangesRequest : AmazonWorkSpacesRequest
    {
        private string _managementCidrRangeConstraint;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ManagementCidrRangeConstraint. 
        /// <para>
        /// The IP address range to search. Specify an IP address range that is compatible with
        /// your network and in CIDR notation (that is, specify the range as an IPv4 CIDR block).
        /// </para>
        /// </summary>
        public string ManagementCidrRangeConstraint
        {
            get { return this._managementCidrRangeConstraint; }
            set { this._managementCidrRangeConstraint = value; }
        }

        // Check to see if ManagementCidrRangeConstraint property is set
        internal bool IsSetManagementCidrRangeConstraint()
        {
            return this._managementCidrRangeConstraint != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return.
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If you received a <code>NextToken</code> from a previous call that was paginated,
        /// provide this token to receive the next set of results.
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