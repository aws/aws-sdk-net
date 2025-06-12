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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDashboardPermissions operation.
    /// Updates read and write permissions on a dashboard.
    /// </summary>
    public partial class UpdateDashboardPermissionsRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private string _dashboardId;
        private List<ResourcePermission> _grantLinkPermissions = AWSConfigs.InitializeCollections ? new List<ResourcePermission>() : null;
        private List<ResourcePermission> _grantPermissions = AWSConfigs.InitializeCollections ? new List<ResourcePermission>() : null;
        private List<ResourcePermission> _revokeLinkPermissions = AWSConfigs.InitializeCollections ? new List<ResourcePermission>() : null;
        private List<ResourcePermission> _revokePermissions = AWSConfigs.InitializeCollections ? new List<ResourcePermission>() : null;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that contains the dashboard whose permissions
        /// you're updating.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property DashboardId. 
        /// <para>
        /// The ID for the dashboard.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string DashboardId
        {
            get { return this._dashboardId; }
            set { this._dashboardId = value; }
        }

        // Check to see if DashboardId property is set
        internal bool IsSetDashboardId()
        {
            return this._dashboardId != null;
        }

        /// <summary>
        /// Gets and sets the property GrantLinkPermissions. 
        /// <para>
        /// Grants link permissions to all users in a defined namespace.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=100)]
        public List<ResourcePermission> GrantLinkPermissions
        {
            get { return this._grantLinkPermissions; }
            set { this._grantLinkPermissions = value; }
        }

        // Check to see if GrantLinkPermissions property is set
        internal bool IsSetGrantLinkPermissions()
        {
            return this._grantLinkPermissions != null && (this._grantLinkPermissions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GrantPermissions. 
        /// <para>
        /// The permissions that you want to grant on this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=100)]
        public List<ResourcePermission> GrantPermissions
        {
            get { return this._grantPermissions; }
            set { this._grantPermissions = value; }
        }

        // Check to see if GrantPermissions property is set
        internal bool IsSetGrantPermissions()
        {
            return this._grantPermissions != null && (this._grantPermissions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RevokeLinkPermissions. 
        /// <para>
        /// Revokes link permissions from all users in a defined namespace.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=100)]
        public List<ResourcePermission> RevokeLinkPermissions
        {
            get { return this._revokeLinkPermissions; }
            set { this._revokeLinkPermissions = value; }
        }

        // Check to see if RevokeLinkPermissions property is set
        internal bool IsSetRevokeLinkPermissions()
        {
            return this._revokeLinkPermissions != null && (this._revokeLinkPermissions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RevokePermissions. 
        /// <para>
        /// The permissions that you want to revoke from this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=100)]
        public List<ResourcePermission> RevokePermissions
        {
            get { return this._revokePermissions; }
            set { this._revokePermissions = value; }
        }

        // Check to see if RevokePermissions property is set
        internal bool IsSetRevokePermissions()
        {
            return this._revokePermissions != null && (this._revokePermissions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}