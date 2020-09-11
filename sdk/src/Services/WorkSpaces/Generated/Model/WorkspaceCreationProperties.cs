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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Describes the default properties that are used for creating WorkSpaces. For more information,
    /// see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/update-directory-details.html">Update
    /// Directory Details for Your WorkSpaces</a>.
    /// </summary>
    public partial class WorkspaceCreationProperties
    {
        private string _customSecurityGroupId;
        private string _defaultOu;
        private bool? _enableInternetAccess;
        private bool? _enableMaintenanceMode;
        private bool? _enableWorkDocs;
        private bool? _userEnabledAsLocalAdministrator;

        /// <summary>
        /// Gets and sets the property CustomSecurityGroupId. 
        /// <para>
        /// The identifier of your custom security group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=11, Max=20)]
        public string CustomSecurityGroupId
        {
            get { return this._customSecurityGroupId; }
            set { this._customSecurityGroupId = value; }
        }

        // Check to see if CustomSecurityGroupId property is set
        internal bool IsSetCustomSecurityGroupId()
        {
            return this._customSecurityGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultOu. 
        /// <para>
        /// The default organizational unit (OU) for your WorkSpaces directories. This string
        /// must be the full Lightweight Directory Access Protocol (LDAP) distinguished name for
        /// the target domain and OU. It must be in the form <code>"OU=<i>value</i>,DC=<i>value</i>,DC=<i>value</i>"</code>,
        /// where <i>value</i> is any string of characters, and the number of domain components
        /// (DCs) is two or more. For example, <code>OU=WorkSpaces_machines,DC=machines,DC=example,DC=com</code>.
        /// 
        /// </para>
        ///  <important> <ul> <li> 
        /// <para>
        /// To avoid errors, certain characters in the distinguished name must be escaped. For
        /// more information, see <a href="https://docs.microsoft.com/previous-versions/windows/desktop/ldap/distinguished-names">
        /// Distinguished Names</a> in the Microsoft documentation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The API doesn't validate whether the OU exists.
        /// </para>
        ///  </li> </ul> </important>
        /// </summary>
        public string DefaultOu
        {
            get { return this._defaultOu; }
            set { this._defaultOu = value; }
        }

        // Check to see if DefaultOu property is set
        internal bool IsSetDefaultOu()
        {
            return this._defaultOu != null;
        }

        /// <summary>
        /// Gets and sets the property EnableInternetAccess. 
        /// <para>
        /// Indicates whether internet access is enabled for your WorkSpaces.
        /// </para>
        /// </summary>
        public bool EnableInternetAccess
        {
            get { return this._enableInternetAccess.GetValueOrDefault(); }
            set { this._enableInternetAccess = value; }
        }

        // Check to see if EnableInternetAccess property is set
        internal bool IsSetEnableInternetAccess()
        {
            return this._enableInternetAccess.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableMaintenanceMode. 
        /// <para>
        /// Indicates whether maintenance mode is enabled for your WorkSpaces. For more information,
        /// see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/workspace-maintenance.html">WorkSpace
        /// Maintenance</a>. 
        /// </para>
        /// </summary>
        public bool EnableMaintenanceMode
        {
            get { return this._enableMaintenanceMode.GetValueOrDefault(); }
            set { this._enableMaintenanceMode = value; }
        }

        // Check to see if EnableMaintenanceMode property is set
        internal bool IsSetEnableMaintenanceMode()
        {
            return this._enableMaintenanceMode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableWorkDocs. 
        /// <para>
        /// Indicates whether Amazon WorkDocs is enabled for your WorkSpaces.
        /// </para>
        ///  <note> 
        /// <para>
        /// If WorkDocs is already enabled for a WorkSpaces directory and you disable it, new
        /// WorkSpaces launched in the directory will not have WorkDocs enabled. However, WorkDocs
        /// remains enabled for any existing WorkSpaces, unless you either disable users' access
        /// to WorkDocs or you delete the WorkDocs site. To disable users' access to WorkDocs,
        /// see <a href="https://docs.aws.amazon.com/workdocs/latest/adminguide/inactive-user.html">Disabling
        /// Users</a> in the <i>Amazon WorkDocs Administration Guide</i>. To delete a WorkDocs
        /// site, see <a href="https://docs.aws.amazon.com/workdocs/latest/adminguide/manage-sites.html">Deleting
        /// a Site</a> in the <i>Amazon WorkDocs Administration Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you enable WorkDocs on a directory that already has existing WorkSpaces, the existing
        /// WorkSpaces and any new WorkSpaces that are launched in the directory will have WorkDocs
        /// enabled.
        /// </para>
        ///  </note>
        /// </summary>
        public bool EnableWorkDocs
        {
            get { return this._enableWorkDocs.GetValueOrDefault(); }
            set { this._enableWorkDocs = value; }
        }

        // Check to see if EnableWorkDocs property is set
        internal bool IsSetEnableWorkDocs()
        {
            return this._enableWorkDocs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserEnabledAsLocalAdministrator. 
        /// <para>
        /// Indicates whether users are local administrators of their WorkSpaces.
        /// </para>
        /// </summary>
        public bool UserEnabledAsLocalAdministrator
        {
            get { return this._userEnabledAsLocalAdministrator.GetValueOrDefault(); }
            set { this._userEnabledAsLocalAdministrator = value; }
        }

        // Check to see if UserEnabledAsLocalAdministrator property is set
        internal bool IsSetUserEnabledAsLocalAdministrator()
        {
            return this._userEnabledAsLocalAdministrator.HasValue; 
        }

    }
}