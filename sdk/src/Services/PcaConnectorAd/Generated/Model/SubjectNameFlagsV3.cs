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
 * Do not modify this file. This file is generated from the pca-connector-ad-2018-05-10.normal.json service model.
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
namespace Amazon.PcaConnectorAd.Model
{
    /// <summary>
    /// Information to include in the subject name and alternate subject name of the certificate.
    /// The subject name can be common name, directory path, DNS as common name, or left blank.
    /// You can optionally include email to the subject name for user templates. If you leave
    /// the subject name blank then you must set a subject alternate name. The subject alternate
    /// name (SAN) can include globally unique identifier (GUID), DNS, domain DNS, email,
    /// service principal name (SPN), and user principal name (UPN). You can leave the SAN
    /// blank. If you leave the SAN blank, then you must set a subject name.
    /// </summary>
    public partial class SubjectNameFlagsV3
    {
        private bool? _requireCommonName;
        private bool? _requireDirectoryPath;
        private bool? _requireDnsAsCn;
        private bool? _requireEmail;
        private bool? _sanRequireDirectoryGuid;
        private bool? _sanRequireDns;
        private bool? _sanRequireDomainDns;
        private bool? _sanRequireEmail;
        private bool? _sanRequireSpn;
        private bool? _sanRequireUpn;

        /// <summary>
        /// Gets and sets the property RequireCommonName. 
        /// <para>
        /// Include the common name in the subject name. 
        /// </para>
        /// </summary>
        public bool? RequireCommonName
        {
            get { return this._requireCommonName; }
            set { this._requireCommonName = value; }
        }

        // Check to see if RequireCommonName property is set
        internal bool IsSetRequireCommonName()
        {
            return this._requireCommonName.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequireDirectoryPath. 
        /// <para>
        /// Include the directory path in the subject name.
        /// </para>
        /// </summary>
        public bool? RequireDirectoryPath
        {
            get { return this._requireDirectoryPath; }
            set { this._requireDirectoryPath = value; }
        }

        // Check to see if RequireDirectoryPath property is set
        internal bool IsSetRequireDirectoryPath()
        {
            return this._requireDirectoryPath.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequireDnsAsCn. 
        /// <para>
        /// Include the DNS as common name in the subject name.
        /// </para>
        /// </summary>
        public bool? RequireDnsAsCn
        {
            get { return this._requireDnsAsCn; }
            set { this._requireDnsAsCn = value; }
        }

        // Check to see if RequireDnsAsCn property is set
        internal bool IsSetRequireDnsAsCn()
        {
            return this._requireDnsAsCn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequireEmail. 
        /// <para>
        /// Include the subject's email in the subject name.
        /// </para>
        /// </summary>
        public bool? RequireEmail
        {
            get { return this._requireEmail; }
            set { this._requireEmail = value; }
        }

        // Check to see if RequireEmail property is set
        internal bool IsSetRequireEmail()
        {
            return this._requireEmail.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SanRequireDirectoryGuid. 
        /// <para>
        /// Include the globally unique identifier (GUID) in the subject alternate name.
        /// </para>
        /// </summary>
        public bool? SanRequireDirectoryGuid
        {
            get { return this._sanRequireDirectoryGuid; }
            set { this._sanRequireDirectoryGuid = value; }
        }

        // Check to see if SanRequireDirectoryGuid property is set
        internal bool IsSetSanRequireDirectoryGuid()
        {
            return this._sanRequireDirectoryGuid.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SanRequireDns. 
        /// <para>
        /// Include the DNS in the subject alternate name.
        /// </para>
        /// </summary>
        public bool? SanRequireDns
        {
            get { return this._sanRequireDns; }
            set { this._sanRequireDns = value; }
        }

        // Check to see if SanRequireDns property is set
        internal bool IsSetSanRequireDns()
        {
            return this._sanRequireDns.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SanRequireDomainDns. 
        /// <para>
        /// Include the domain DNS in the subject alternate name.
        /// </para>
        /// </summary>
        public bool? SanRequireDomainDns
        {
            get { return this._sanRequireDomainDns; }
            set { this._sanRequireDomainDns = value; }
        }

        // Check to see if SanRequireDomainDns property is set
        internal bool IsSetSanRequireDomainDns()
        {
            return this._sanRequireDomainDns.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SanRequireEmail. 
        /// <para>
        /// Include the subject's email in the subject alternate name.
        /// </para>
        /// </summary>
        public bool? SanRequireEmail
        {
            get { return this._sanRequireEmail; }
            set { this._sanRequireEmail = value; }
        }

        // Check to see if SanRequireEmail property is set
        internal bool IsSetSanRequireEmail()
        {
            return this._sanRequireEmail.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SanRequireSpn. 
        /// <para>
        /// Include the service principal name (SPN) in the subject alternate name.
        /// </para>
        /// </summary>
        public bool? SanRequireSpn
        {
            get { return this._sanRequireSpn; }
            set { this._sanRequireSpn = value; }
        }

        // Check to see if SanRequireSpn property is set
        internal bool IsSetSanRequireSpn()
        {
            return this._sanRequireSpn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SanRequireUpn. 
        /// <para>
        /// Include the user principal name (UPN) in the subject alternate name.
        /// </para>
        /// </summary>
        public bool? SanRequireUpn
        {
            get { return this._sanRequireUpn; }
            set { this._sanRequireUpn = value; }
        }

        // Check to see if SanRequireUpn property is set
        internal bool IsSetSanRequireUpn()
        {
            return this._sanRequireUpn.HasValue; 
        }

    }
}