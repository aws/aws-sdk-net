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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDashboardPermissions operation. Updates
    /// read and write permissions on a dashboard.
    /// </summary>
    public partial class UpdateDashboardPermissionsRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that contains the dashboard whose permissions
        /// you're updating.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property DashboardId. 
        /// <para>
        /// The ID for the dashboard.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string DashboardId { get; set; }

        /// <summary>
        /// Checks to see if the DashboardId property is set.
        /// </summary>
        internal bool IsSetDashboardId() => this.DashboardId != null;

        /// <summary>
        /// Gets and sets the property GrantLinkPermissions. 
        /// <para>
        /// Grants link permissions to all users in a defined namespace.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<ResourcePermission> GrantLinkPermissions { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourcePermission>() : null;

        /// <summary>
        /// Checks to see if the GrantLinkPermissions property is set.
        /// </summary>
        internal bool IsSetGrantLinkPermissions() => this.GrantLinkPermissions != null && (this.GrantLinkPermissions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GrantPermissions. 
        /// <para>
        /// The permissions that you want to grant on this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<ResourcePermission> GrantPermissions { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourcePermission>() : null;

        /// <summary>
        /// Checks to see if the GrantPermissions property is set.
        /// </summary>
        internal bool IsSetGrantPermissions() => this.GrantPermissions != null && (this.GrantPermissions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RevokeLinkPermissions. 
        /// <para>
        /// Revokes link permissions from all users in a defined namespace.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<ResourcePermission> RevokeLinkPermissions { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourcePermission>() : null;

        /// <summary>
        /// Checks to see if the RevokeLinkPermissions property is set.
        /// </summary>
        internal bool IsSetRevokeLinkPermissions() => this.RevokeLinkPermissions != null && (this.RevokeLinkPermissions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RevokePermissions. 
        /// <para>
        /// The permissions that you want to revoke from this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<ResourcePermission> RevokePermissions { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourcePermission>() : null;

        /// <summary>
        /// Checks to see if the RevokePermissions property is set.
        /// </summary>
        internal bool IsSetRevokePermissions() => this.RevokePermissions != null && (this.RevokePermissions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
