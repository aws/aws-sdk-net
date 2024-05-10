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
    /// An Amazon FSx for NetApp ONTAP storage virtual machine (SVM) has four endpoints that
    /// are used to access data or to manage the SVM using the NetApp ONTAP CLI, REST API,
    /// or NetApp CloudManager. They are the <c>Iscsi</c>, <c>Management</c>, <c>Nfs</c>,
    /// and <c>Smb</c> endpoints.
    /// </summary>
    public partial class SvmEndpoint
    {
        private string _dnsName;
        private List<string> _ipAddresses = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DNSName.
        /// </summary>
        [AWSProperty(Min=16, Max=275)]
        public string DNSName
        {
            get { return this._dnsName; }
            set { this._dnsName = value; }
        }

        // Check to see if DNSName property is set
        internal bool IsSetDNSName()
        {
            return this._dnsName != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddresses. 
        /// <para>
        /// The SVM endpoint's IP addresses.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=24)]
        public List<string> IpAddresses
        {
            get { return this._ipAddresses; }
            set { this._ipAddresses = value; }
        }

        // Check to see if IpAddresses property is set
        internal bool IsSetIpAddresses()
        {
            return this._ipAddresses != null && (this._ipAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}