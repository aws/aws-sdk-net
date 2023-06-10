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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// The configuration that Amazon FSx uses to join a FSx for Windows File Server file
    /// system or an ONTAP storage virtual machine (SVM) to a self-managed (including on-premises)
    /// Microsoft Active Directory (AD) directory. For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/self-managed-AD.html">
    /// Using Amazon FSx with your self-managed Microsoft Active Directory</a> or <a href="https://docs.aws.amazon.com/fsx/latest/ONTAPGuide/managing-svms.html">Managing
    /// SVMs</a>.
    /// </summary>
    public partial class SelfManagedActiveDirectoryConfiguration
    {
        private List<string> _dnsIps = new List<string>();
        private string _domainName;
        private string _fileSystemAdministratorsGroup;
        private string _organizationalUnitDistinguishedName;
        private string _password;
        private string _userName;

        /// <summary>
        /// Gets and sets the property DnsIps. 
        /// <para>
        /// A list of up to three IP addresses of DNS servers or domain controllers in the self-managed
        /// AD directory. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=3)]
        public List<string> DnsIps
        {
            get { return this._dnsIps; }
            set { this._dnsIps = value; }
        }

        // Check to see if DnsIps property is set
        internal bool IsSetDnsIps()
        {
            return this._dnsIps != null && this._dnsIps.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The fully qualified domain name of the self-managed AD directory, such as <code>corp.example.com</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// (Optional) The name of the domain group whose members are granted administrative privileges
        /// for the file system. Administrative privileges include taking ownership of files and
        /// folders, setting audit controls (audit ACLs) on files and folders, and administering
        /// the file system remotely by using the FSx Remote PowerShell. The group that you specify
        /// must already exist in your domain. If you don't provide one, your AD domain's Domain
        /// Admins group is used.
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
        /// (Optional) The fully qualified distinguished name of the organizational unit within
        /// your self-managed AD directory. Amazon FSx only accepts OU as the direct parent of
        /// the file system. An example is <code>OU=FSx,DC=yourdomain,DC=corp,DC=com</code>. To
        /// learn more, see <a href="https://tools.ietf.org/html/rfc2253">RFC 2253</a>. If none
        /// is provided, the FSx file system is created in the default location of your self-managed
        /// AD directory. 
        /// </para>
        ///  <important> 
        /// <para>
        /// Only Organizational Unit (OU) objects can be the direct parent of the file system
        /// that you're creating.
        /// </para>
        ///  </important>
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
        /// The password for the service account on your self-managed AD domain that Amazon FSx
        /// will use to join to your AD domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=256)]
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
        /// The user name for the service account on your self-managed AD domain that Amazon FSx
        /// will use to join to your AD domain. This account must have the permission to join
        /// computers to the domain in the organizational unit provided in <code>OrganizationalUnitDistinguishedName</code>,
        /// or in the default location of your AD domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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