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
    /// Container for the parameters to the UpdateThemePermissions operation. Updates the
    /// resource permissions for a theme. Permissions apply to the action to grant or revoke
    /// permissions on, for example <c>"quicksight:DescribeTheme"</c>. <para> Theme permissions
    /// apply in groupings. Valid groupings include the following for the three levels of
    /// permissions, which are user, owner, or no permissions: </para> <ul> <li> <para> User
    /// </para> <ul> <li> <para> <c>"quicksight:DescribeTheme"</c> </para> </li> <li> <para>
    /// <c>"quicksight:DescribeThemeAlias"</c> </para> </li> <li> <para> <c>"quicksight:ListThemeAliases"</c>
    /// </para> </li> <li> <para> <c>"quicksight:ListThemeVersions"</c> </para> </li> </ul>
    /// </li> <li> <para> Owner </para> <ul> <li> <para> <c>"quicksight:DescribeTheme"</c>
    /// </para> </li> <li> <para> <c>"quicksight:DescribeThemeAlias"</c> </para> </li> <li>
    /// <para> <c>"quicksight:ListThemeAliases"</c> </para> </li> <li> <para> <c>"quicksight:ListThemeVersions"</c>
    /// </para> </li> <li> <para> <c>"quicksight:DeleteTheme"</c> </para> </li> <li> <para>
    /// <c>"quicksight:UpdateTheme"</c> </para> </li> <li> <para> <c>"quicksight:CreateThemeAlias"</c>
    /// </para> </li> <li> <para> <c>"quicksight:DeleteThemeAlias"</c> </para> </li> <li>
    /// <para> <c>"quicksight:UpdateThemeAlias"</c> </para> </li> <li> <para> <c>"quicksight:UpdateThemePermissions"</c>
    /// </para> </li> <li> <para> <c>"quicksight:DescribeThemePermissions"</c> </para> </li>
    /// </ul> </li> <li> <para> To specify no permissions, omit the permissions list. </para>
    /// </li> </ul>
    /// </summary>
    public partial class UpdateThemePermissionsRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that contains the theme.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property GrantPermissions. 
        /// <para>
        /// A list of resource permissions to be granted for the theme.
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
        /// Gets and sets the property RevokePermissions. 
        /// <para>
        /// A list of resource permissions to be revoked from the theme.
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

        /// <summary>
        /// Gets and sets the property ThemeId. 
        /// <para>
        /// The ID for the theme.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string ThemeId { get; set; }

        /// <summary>
        /// Checks to see if the ThemeId property is set.
        /// </summary>
        internal bool IsSetThemeId() => this.ThemeId != null;
    }
}
