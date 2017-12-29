/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Information about defaults used to create a WorkSpace.
    /// </summary>
    public partial class DefaultWorkspaceCreationProperties
    {
        private string _customSecurityGroupId;
        private string _defaultOu;
        private bool? _enableInternetAccess;
        private bool? _enableWorkDocs;
        private bool? _userEnabledAsLocalAdministrator;

        /// <summary>
        /// Gets and sets the property CustomSecurityGroupId. 
        /// <para>
        /// The identifier of any security groups to apply to WorkSpaces when they are created.
        /// </para>
        /// </summary>
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
        /// The organizational unit (OU) in the directory for the WorkSpace machine accounts.
        /// </para>
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
        /// The public IP address to attach to all WorkSpaces that are created or rebuilt.
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
        /// Gets and sets the property EnableWorkDocs. 
        /// <para>
        /// Indicates whether the directory is enabled for Amazon WorkDocs.
        /// </para>
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
        /// Indicates whether the WorkSpace user is an administrator on the WorkSpace.
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