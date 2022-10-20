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
 * Do not modify this file. This file is generated from the globalaccelerator-2018-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GlobalAccelerator.Model
{
    /// <summary>
    /// Attributes of a custom routing accelerator.
    /// </summary>
    public partial class CustomRoutingAccelerator
    {
        private string _acceleratorArn;
        private DateTime? _createdTime;
        private string _dnsName;
        private bool? _enabled;
        private IpAddressType _ipAddressType;
        private List<IpSet> _ipSets = new List<IpSet>();
        private DateTime? _lastModifiedTime;
        private string _name;
        private CustomRoutingAcceleratorStatus _status;

        /// <summary>
        /// Gets and sets the property AcceleratorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the custom routing accelerator.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string AcceleratorArn
        {
            get { return this._acceleratorArn; }
            set { this._acceleratorArn = value; }
        }

        // Check to see if AcceleratorArn property is set
        internal bool IsSetAcceleratorArn()
        {
            return this._acceleratorArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The date and time that the accelerator was created.
        /// </para>
        /// </summary>
        public DateTime CreatedTime
        {
            get { return this._createdTime.GetValueOrDefault(); }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DnsName. 
        /// <para>
        /// The Domain Name System (DNS) name that Global Accelerator creates that points to an
        /// accelerator's static IPv4 addresses. 
        /// </para>
        ///  
        /// <para>
        /// The naming convention for the DNS name is the following: A lowercase letter a, followed
        /// by a 16-bit random hex string, followed by .awsglobalaccelerator.com. For example:
        /// a1234567890abcdef.awsglobalaccelerator.com.
        /// </para>
        ///  
        /// <para>
        /// If you have a dual-stack accelerator, you also have a second DNS name, <code>DualStackDnsName</code>,
        /// that points to both the A record and the AAAA record for all four static addresses
        /// for the accelerator: two IPv4 addresses and two IPv6 addresses.
        /// </para>
        ///  
        /// <para>
        /// For more information about the default DNS name, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/dns-addressing-custom-domains.dns-addressing.html">
        /// Support for DNS addressing in Global Accelerator</a> in the <i>Global Accelerator
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string DnsName
        {
            get { return this._dnsName; }
            set { this._dnsName = value; }
        }

        // Check to see if DnsName property is set
        internal bool IsSetDnsName()
        {
            return this._dnsName != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether the accelerator is enabled. The value is true or false. The default
        /// value is true. 
        /// </para>
        ///  
        /// <para>
        /// If the value is set to true, the accelerator cannot be deleted. If set to false, accelerator
        /// can be deleted.
        /// </para>
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type that an accelerator supports. For a custom routing accelerator,
        /// the value must be IPV4.
        /// </para>
        /// </summary>
        public IpAddressType IpAddressType
        {
            get { return this._ipAddressType; }
            set { this._ipAddressType = value; }
        }

        // Check to see if IpAddressType property is set
        internal bool IsSetIpAddressType()
        {
            return this._ipAddressType != null;
        }

        /// <summary>
        /// Gets and sets the property IpSets. 
        /// <para>
        /// The static IP addresses that Global Accelerator associates with the accelerator.
        /// </para>
        /// </summary>
        public List<IpSet> IpSets
        {
            get { return this._ipSets; }
            set { this._ipSets = value; }
        }

        // Check to see if IpSets property is set
        internal bool IsSetIpSets()
        {
            return this._ipSets != null && this._ipSets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time that the accelerator was last modified.
        /// </para>
        /// </summary>
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the accelerator. The name must contain only alphanumeric characters or
        /// hyphens (-), and must not begin or end with a hyphen.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Describes the deployment status of the accelerator.
        /// </para>
        /// </summary>
        public CustomRoutingAcceleratorStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}