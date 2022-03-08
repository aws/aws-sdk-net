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
 * Do not modify this file. This file is generated from the finspace-data-2020-07-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FinSpaceData.Model
{
    /// <summary>
    /// This is the response object from the ListPermissionGroups operation.
    /// </summary>
    public partial class ListPermissionGroupsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<PermissionGroup> _permissionGroups = new List<PermissionGroup>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates where a results page should begin.
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
        /// Gets and sets the property PermissionGroups. 
        /// <para>
        /// A list of all the permission groups.
        /// </para>
        /// </summary>
        public List<PermissionGroup> PermissionGroups
        {
            get { return this._permissionGroups; }
            set { this._permissionGroups = value; }
        }

        // Check to see if PermissionGroups property is set
        internal bool IsSetPermissionGroups()
        {
            return this._permissionGroups != null && this._permissionGroups.Count > 0; 
        }

    }
}