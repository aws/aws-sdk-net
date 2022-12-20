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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NimbleStudio.Model
{
    /// <summary>
    /// The launch profile initialization Active Directory contains information required for
    /// the launch profile to connect to the Active Directory.
    /// </summary>
    public partial class LaunchProfileInitializationActiveDirectory
    {
        private List<ActiveDirectoryComputerAttribute> _computerAttributes = new List<ActiveDirectoryComputerAttribute>();
        private string _directoryId;
        private string _directoryName;
        private List<string> _dnsIpAddresses = new List<string>();
        private string _organizationalUnitDistinguishedName;
        private string _studioComponentId;
        private string _studioComponentName;

        /// <summary>
        /// Gets and sets the property ComputerAttributes. 
        /// <para>
        /// A collection of custom attributes for an Active Directory computer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<ActiveDirectoryComputerAttribute> ComputerAttributes
        {
            get { return this._computerAttributes; }
            set { this._computerAttributes = value; }
        }

        // Check to see if ComputerAttributes property is set
        internal bool IsSetComputerAttributes()
        {
            return this._computerAttributes != null && this._computerAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The directory ID of the Directory Service for Microsoft Active Directory to access
        /// using this launch profile.
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
        /// Gets and sets the property DirectoryName. 
        /// <para>
        /// The directory name.
        /// </para>
        /// </summary>
        public string DirectoryName
        {
            get { return this._directoryName; }
            set { this._directoryName = value; }
        }

        // Check to see if DirectoryName property is set
        internal bool IsSetDirectoryName()
        {
            return this._directoryName != null;
        }

        /// <summary>
        /// Gets and sets the property DnsIpAddresses. 
        /// <para>
        /// The DNS IP address.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> DnsIpAddresses
        {
            get { return this._dnsIpAddresses; }
            set { this._dnsIpAddresses = value; }
        }

        // Check to see if DnsIpAddresses property is set
        internal bool IsSetDnsIpAddresses()
        {
            return this._dnsIpAddresses != null && this._dnsIpAddresses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OrganizationalUnitDistinguishedName. 
        /// <para>
        /// The name for the organizational unit distinguished name.
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
        /// Gets and sets the property StudioComponentId. 
        /// <para>
        /// The unique identifier for a studio component resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=22)]
        public string StudioComponentId
        {
            get { return this._studioComponentId; }
            set { this._studioComponentId = value; }
        }

        // Check to see if StudioComponentId property is set
        internal bool IsSetStudioComponentId()
        {
            return this._studioComponentId != null;
        }

        /// <summary>
        /// Gets and sets the property StudioComponentName. 
        /// <para>
        /// The name for the studio component.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string StudioComponentName
        {
            get { return this._studioComponentName; }
            set { this._studioComponentName = value; }
        }

        // Check to see if StudioComponentName property is set
        internal bool IsSetStudioComponentName()
        {
            return this._studioComponentName != null;
        }

    }
}