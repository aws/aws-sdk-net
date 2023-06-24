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
 * Do not modify this file. This file is generated from the grafana-2020-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ManagedGrafana.Model
{
    /// <summary>
    /// Container for the parameters to the ListPermissions operation.
    /// Lists the users and groups who have the Grafana <code>Admin</code> and <code>Editor</code>
    /// roles in this workspace. If you use this operation without specifying <code>userId</code>
    /// or <code>groupId</code>, the operation returns the roles of all users and groups.
    /// If you specify a <code>userId</code> or a <code>groupId</code>, only the roles for
    /// that user or group are returned. If you do this, you can specify only one <code>userId</code>
    /// or one <code>groupId</code>.
    /// </summary>
    public partial class ListPermissionsRequest : AmazonManagedGrafanaRequest
    {
        private string _groupId;
        private int? _maxResults;
        private string _nextToken;
        private string _userId;
        private UserType _userType;
        private string _workspaceId;

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// (Optional) Limits the results to only the group that matches this ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=47)]
        public string GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this._groupId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to include in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// The token to use when requesting the next set of results. You received this token
        /// from a previous <code>ListPermissions</code> operation.
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
        /// Gets and sets the property UserId. 
        /// <para>
        /// (Optional) Limits the results to only the user that matches this ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=47)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

        /// <summary>
        /// Gets and sets the property UserType. 
        /// <para>
        /// (Optional) If you specify <code>SSO_USER</code>, then only the permissions of IAM
        /// Identity Center users are returned. If you specify <code>SSO_GROUP</code>, only the
        /// permissions of IAM Identity Center groups are returned.
        /// </para>
        /// </summary>
        public UserType UserType
        {
            get { return this._userType; }
            set { this._userType = value; }
        }

        // Check to see if UserType property is set
        internal bool IsSetUserType()
        {
            return this._userType != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The ID of the workspace to list permissions for. This parameter is required.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string WorkspaceId
        {
            get { return this._workspaceId; }
            set { this._workspaceId = value; }
        }

        // Check to see if WorkspaceId property is set
        internal bool IsSetWorkspaceId()
        {
            return this._workspaceId != null;
        }

    }
}