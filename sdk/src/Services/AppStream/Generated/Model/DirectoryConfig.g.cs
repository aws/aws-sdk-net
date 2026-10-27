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

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Describes the configuration information required to join fleets and image builders
    /// to Microsoft Active Directory domains.
    /// </summary>
    public partial class DirectoryConfig
    {
        /// <summary>
        /// Gets and sets the property CertificateBasedAuthProperties. 
        /// <para>
        /// The certificate-based authentication properties used to authenticate SAML 2.0 Identity
        /// Provider (IdP) user identities to Active Directory domain-joined streaming instances.
        /// Fallback is turned on by default when certificate-based authentication is <b>Enabled</b>
        /// . Fallback allows users to log in using their AD domain password if certificate-based
        /// authentication is unsuccessful, or to unlock a desktop lock screen. <b>Enabled_no_directory_login_fallback</b>
        /// enables certificate-based authentication, but does not allow users to log in using
        /// their AD domain password. Users will be disconnected to re-authenticate using certificates.
        /// </para>
        /// </summary>
        public CertificateBasedAuthProperties CertificateBasedAuthProperties { get; set; }

        /// <summary>
        /// Checks to see if the CertificateBasedAuthProperties property is set.
        /// </summary>
        internal bool IsSetCertificateBasedAuthProperties() => this.CertificateBasedAuthProperties != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time the directory configuration was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property DirectoryName. 
        /// <para>
        /// The fully qualified name of the directory (for example, corp.example.com).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DirectoryName { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryName property is set.
        /// </summary>
        internal bool IsSetDirectoryName() => this.DirectoryName != null;

        /// <summary>
        /// Gets and sets the property OrganizationalUnitDistinguishedNames. 
        /// <para>
        /// The distinguished names of the organizational units for computer accounts.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> OrganizationalUnitDistinguishedNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OrganizationalUnitDistinguishedNames property is set.
        /// </summary>
        internal bool IsSetOrganizationalUnitDistinguishedNames() => this.OrganizationalUnitDistinguishedNames != null && (this.OrganizationalUnitDistinguishedNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ServiceAccountCredentials. 
        /// <para>
        /// The credentials for the service account used by the fleet or image builder to connect
        /// to the directory.
        /// </para>
        /// </summary>
        public ServiceAccountCredentials ServiceAccountCredentials { get; set; }

        /// <summary>
        /// Checks to see if the ServiceAccountCredentials property is set.
        /// </summary>
        internal bool IsSetServiceAccountCredentials() => this.ServiceAccountCredentials != null;
    }
}
