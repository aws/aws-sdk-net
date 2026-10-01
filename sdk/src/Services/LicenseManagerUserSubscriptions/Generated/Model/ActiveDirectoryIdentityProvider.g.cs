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

namespace Amazon.LicenseManagerUserSubscriptions.Model
{
    /// <summary>
    /// Details about an Active Directory identity provider.
    /// </summary>
    public partial class ActiveDirectoryIdentityProvider
    {
        /// <summary>
        /// Gets and sets the property ActiveDirectorySettings. 
        /// <para>
        /// The <c>ActiveDirectorySettings</c> resource contains details about the Active Directory,
        /// including network access details such as domain name and IP addresses, and the credential
        /// provider for user administration.
        /// </para>
        /// </summary>
        public ActiveDirectorySettings ActiveDirectorySettings { get; set; }

        /// <summary>
        /// Checks to see if the ActiveDirectorySettings property is set.
        /// </summary>
        internal bool IsSetActiveDirectorySettings() => this.ActiveDirectorySettings != null;

        /// <summary>
        /// Gets and sets the property ActiveDirectoryType. 
        /// <para>
        /// The type of Active Directory – either a self-managed Active Directory or an Amazon
        /// Web Services Managed Active Directory.
        /// </para>
        /// </summary>
        public ActiveDirectoryType ActiveDirectoryType { get; set; }

        /// <summary>
        /// Checks to see if the ActiveDirectoryType property is set.
        /// </summary>
        internal bool IsSetActiveDirectoryType() => this.ActiveDirectoryType != null;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The directory ID for an Active Directory identity provider.
        /// </para>
        /// </summary>
        public string DirectoryId { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryId property is set.
        /// </summary>
        internal bool IsSetDirectoryId() => this.DirectoryId != null;

        /// <summary>
        /// Gets and sets the property IsSharedActiveDirectory. 
        /// <para>
        /// Whether this directory is shared from an Amazon Web Services Managed Active Directory.
        /// The default value is false.
        /// </para>
        /// </summary>
        public bool? IsSharedActiveDirectory { get; set; }

        /// <summary>
        /// Checks to see if the IsSharedActiveDirectory property is set.
        /// </summary>
        internal bool IsSetIsSharedActiveDirectory() => this.IsSharedActiveDirectory.HasValue;
    }
}
