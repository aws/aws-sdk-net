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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.ManagedGrafana.Model
{
    /// <summary>
    /// Container for the parameters to the ListPermissions operation. Lists the users and
    /// groups who have the Grafana <c>Admin</c> and <c>Editor</c> roles in this workspace.
    /// If you use this operation without specifying <c>userId</c> or <c>groupId</c>, the
    /// operation returns the roles of all users and groups. If you specify a <c>userId</c>
    /// or a <c>groupId</c>, only the roles for that user or group are returned. If you do
    /// this, you can specify only one <c>userId</c> or one <c>groupId</c>.
    /// </summary>
    public partial class ListPermissionsRequest : AmazonManagedGrafanaRequest
    {
        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// (Optional) Limits the results to only the group that matches this ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 47)]
        public string GroupId { get; set; }

        /// <summary>
        /// Checks to see if the GroupId property is set.
        /// </summary>
        internal bool IsSetGroupId() => this.GroupId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to include in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use when requesting the next set of results. You received this token
        /// from a previous <c>ListPermissions</c> operation.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// (Optional) Limits the results to only the user that matches this ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 47)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;

        /// <summary>
        /// Gets and sets the property UserType. 
        /// <para>
        /// (Optional) If you specify <c>SSO_USER</c>, then only the permissions of IAM Identity
        /// Center users are returned. If you specify <c>SSO_GROUP</c>, only the permissions of
        /// IAM Identity Center groups are returned.
        /// </para>
        /// </summary>
        public UserType UserType { get; set; }

        /// <summary>
        /// Checks to see if the UserType property is set.
        /// </summary>
        internal bool IsSetUserType() => this.UserType != null;

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The ID of the workspace to list permissions for. This parameter is required.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceId property is set.
        /// </summary>
        internal bool IsSetWorkspaceId() => this.WorkspaceId != null;
    }
}
