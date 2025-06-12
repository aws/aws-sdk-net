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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
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
namespace Amazon.FSx.Model
{
    /// <summary>
    /// Specifies changes you are making to the self-managed Microsoft Active Directory configuration
    /// to which an FSx for Windows File Server file system or an FSx for ONTAP SVM is joined.
    /// </summary>
    public partial class SelfManagedActiveDirectoryConfigurationUpdates
    {
        private List<string> _dnsIps = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _domainName;
        private string _fileSystemAdministratorsGroup;
        private string _organizationalUnitDistinguishedName;
        private string _password;
        private string _userName;

        /// <summary>
        /// Gets and sets the property DnsIps. 
        /// <para>
        /// A list of up to three DNS server or domain controller IP addresses in your self-managed
        /// Active Directory domain.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=3)]
        public List<string> DnsIps
        {
            get { return this._dnsIps; }
            set { this._dnsIps = value; }
        }

        // Check to see if DnsIps property is set
        internal bool IsSetDnsIps()
        {
            return this._dnsIps != null && (this._dnsIps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// Specifies an updated fully qualified domain name of your self-managed Active Directory
        /// configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property FileSystemAdministratorsGroup. 
        /// <para>
        /// For FSx for ONTAP file systems only - Specifies the updated name of the self-managed
        /// Active Directory domain group whose members are granted administrative privileges
        /// for the Amazon FSx resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string FileSystemAdministratorsGroup
        {
            get { return this._fileSystemAdministratorsGroup; }
            set { this._fileSystemAdministratorsGroup = value; }
        }

        // Check to see if FileSystemAdministratorsGroup property is set
        internal bool IsSetFileSystemAdministratorsGroup()
        {
            return this._fileSystemAdministratorsGroup != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationalUnitDistinguishedName. 
        /// <para>
        /// Specifies an updated fully qualified distinguished name of the organization unit within
        /// your self-managed Active Directory.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string OrganizationalUnitDistinguishedName
        {
            get { return this._organizationalUnitDistinguishedName; }
            set { this._organizationalUnitDistinguishedName = value; }
        }

        // Check to see if OrganizationalUnitDistinguishedName property is set
        internal bool IsSetOrganizationalUnitDistinguishedName()
        {
            return this._organizationalUnitDistinguishedName != null;
        }

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// Specifies the updated password for the service account on your self-managed Active
        /// Directory domain. Amazon FSx uses this account to join to your self-managed Active
        /// Directory domain.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=256)]
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        // Check to see if Password property is set
        internal bool IsSetPassword()
        {
            return this._password != null;
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// Specifies the updated user name for the service account on your self-managed Active
        /// Directory domain. Amazon FSx uses this account to join to your self-managed Active
        /// Directory domain.
        /// </para>
        ///  
        /// <para>
        /// This account must have the permissions required to join computers to the domain in
        /// the organizational unit provided in <c>OrganizationalUnitDistinguishedName</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

    }
}