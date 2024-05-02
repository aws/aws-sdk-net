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
 * Do not modify this file. This file is generated from the rolesanywhere-2018-05-10.normal.json service model.
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
namespace Amazon.IAMRolesAnywhere.Model
{
    /// <summary>
    /// Container for the parameters to the ListProfiles operation.
    /// Lists all profiles in the authenticated account and Amazon Web Services Region.
    /// 
    ///  
    /// <para>
    ///  <b>Required permissions: </b> <c>rolesanywhere:ListProfiles</c>. 
    /// </para>
    /// </summary>
    public partial class ListProfilesRequest : AmazonIAMRolesAnywhereRequest
    {
        private string _nextToken;
        private int? _pageSize;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates where the output should continue from, if a previous request
        /// did not show all results. To get the next results, make the request again with this
        /// value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
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
        /// Gets and sets the property PageSize. 
        /// <para>
        /// The number of resources in the paginated list. 
        /// </para>
        /// </summary>
        public int? PageSize
        {
            get { return this._pageSize; }
            set { this._pageSize = value; }
        }

        // Check to see if PageSize property is set
        internal bool IsSetPageSize()
        {
            return this._pageSize.HasValue; 
        }

    }
}