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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateThemePermissions operation.
    /// Updates the resource permissions for a theme. Permissions apply to the action to grant
    /// or revoke permissions on, for example <code>"quicksight:DescribeTheme"</code>.
    /// 
    ///  
    /// <para>
    /// Theme permissions apply in groupings. Valid groupings include the following for the
    /// three levels of permissions, which are user, owner, or no permissions: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// User
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>"quicksight:DescribeTheme"</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>"quicksight:DescribeThemeAlias"</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>"quicksight:ListThemeAliases"</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>"quicksight:ListThemeVersions"</code> 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Owner
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>"quicksight:DescribeTheme"</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>"quicksight:DescribeThemeAlias"</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>"quicksight:ListThemeAliases"</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>"quicksight:ListThemeVersions"</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>"quicksight:DeleteTheme"</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>"quicksight:UpdateTheme"</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>"quicksight:CreateThemeAlias"</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>"quicksight:DeleteThemeAlias"</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>"quicksight:UpdateThemeAlias"</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>"quicksight:UpdateThemePermissions"</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>"quicksight:DescribeThemePermissions"</code> 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// To specify no permissions, omit the permissions list.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class UpdateThemePermissionsRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private List<ResourcePermission> _grantPermissions = new List<ResourcePermission>();
        private List<ResourcePermission> _revokePermissions = new List<ResourcePermission>();
        private string _themeId;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that contains the theme.
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
        /// Gets and sets the property GrantPermissions. 
        /// <para>
        /// A list of resource permissions to be granted for the theme.
        /// </para>
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
            return this._grantPermissions != null && this._grantPermissions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RevokePermissions. 
        /// <para>
        /// A list of resource permissions to be revoked from the theme.
        /// </para>
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
            return this._revokePermissions != null && this._revokePermissions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ThemeId. 
        /// <para>
        /// The ID for the theme.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string ThemeId
        {
            get { return this._themeId; }
            set { this._themeId = value; }
        }

        // Check to see if ThemeId property is set
        internal bool IsSetThemeId()
        {
            return this._themeId != null;
        }

    }
}