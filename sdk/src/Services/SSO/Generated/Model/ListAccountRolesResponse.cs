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
 * Do not modify this file. This file is generated from the sso-2019-06-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SSO.Model
{
    /// <summary>
    /// This is the response object from the ListAccountRoles operation.
    /// </summary>
    public partial class ListAccountRolesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<RoleInfo> _roleList = new List<RoleInfo>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The page token client that is used to retrieve the list of accounts.
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
        /// Gets and sets the property RoleList. 
        /// <para>
        /// A paginated response with the list of roles and the next token if more results are
        /// available.
        /// </para>
        /// </summary>
        public List<RoleInfo> RoleList
        {
            get { return this._roleList; }
            set { this._roleList = value; }
        }

        // Check to see if RoleList property is set
        internal bool IsSetRoleList()
        {
            return this._roleList != null && this._roleList.Count > 0; 
        }

    }
}