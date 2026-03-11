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
 * Do not modify this file. This file is generated from the license-manager-user-subscriptions-2018-05-10.normal.json service model.
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
namespace Amazon.LicenseManagerUserSubscriptions.Model
{
    /// <summary>
    /// Details about an Active Directory identity provider.
    /// </summary>
    public partial class ActiveDirectoryIdentityProvider
    {
        private ActiveDirectorySettings _activeDirectorySettings;
        private ActiveDirectoryType _activeDirectoryType;
        private string _directoryId;
        private bool? _isSharedActiveDirectory;

        /// <summary>
        /// Gets and sets the property ActiveDirectorySettings. 
        /// <para>
        /// The <c>ActiveDirectorySettings</c> resource contains details about the Active Directory,
        /// including network access details such as domain name and IP addresses, and the credential
        /// provider for user administration.
        /// </para>
        /// </summary>
        public ActiveDirectorySettings ActiveDirectorySettings
        {
            get { return this._activeDirectorySettings; }
            set { this._activeDirectorySettings = value; }
        }

        // Check to see if ActiveDirectorySettings property is set
        internal bool IsSetActiveDirectorySettings()
        {
            return this._activeDirectorySettings != null;
        }

        /// <summary>
        /// Gets and sets the property ActiveDirectoryType. 
        /// <para>
        /// The type of Active Directory – either a self-managed Active Directory or an Amazon
        /// Web Services Managed Active Directory.
        /// </para>
        /// </summary>
        public ActiveDirectoryType ActiveDirectoryType
        {
            get { return this._activeDirectoryType; }
            set { this._activeDirectoryType = value; }
        }

        // Check to see if ActiveDirectoryType property is set
        internal bool IsSetActiveDirectoryType()
        {
            return this._activeDirectoryType != null;
        }

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The directory ID for an Active Directory identity provider.
        /// </para>
        /// </summary>
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property IsSharedActiveDirectory. 
        /// <para>
        /// Whether this directory is shared from an Amazon Web Services Managed Active Directory.
        /// The default value is false.
        /// </para>
        /// </summary>
        public bool? IsSharedActiveDirectory
        {
            get { return this._isSharedActiveDirectory; }
            set { this._isSharedActiveDirectory = value; }
        }

        // Check to see if IsSharedActiveDirectory property is set
        internal bool IsSetIsSharedActiveDirectory()
        {
            return this._isSharedActiveDirectory.HasValue; 
        }

    }
}