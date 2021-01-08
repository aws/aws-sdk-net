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
    /// Container for the parameters to the CreateAccelerator operation.
    /// Create an accelerator. An accelerator includes one or more listeners that process
    /// inbound connections and direct traffic to one or more endpoint groups, each of which
    /// includes endpoints, such as Network Load Balancers. 
    /// 
    ///  <important> 
    /// <para>
    /// Global Accelerator is a global service that supports endpoints in multiple AWS Regions
    /// but you must specify the US West (Oregon) Region to create or update accelerators.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateAcceleratorRequest : AmazonGlobalAcceleratorRequest
    {
        private bool? _enabled;
        private string _idempotencyToken;
        private List<string> _ipAddresses = new List<string>();
        private IpAddressType _ipAddressType;
        private string _name;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether an accelerator is enabled. The value is true or false. The default
        /// value is true. 
        /// </para>
        ///  
        /// <para>
        /// If the value is set to true, an accelerator cannot be deleted. If set to false, the
        /// accelerator can be deleted.
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
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency—that
        /// is, the uniqueness—of an accelerator.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string IdempotencyToken
        {
            get { return this._idempotencyToken; }
            set { this._idempotencyToken = value; }
        }

        // Check to see if IdempotencyToken property is set
        internal bool IsSetIdempotencyToken()
        {
            return this._idempotencyToken != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddresses. 
        /// <para>
        /// Optionally, if you've added your own IP address pool to Global Accelerator (BYOIP),
        /// you can choose IP addresses from your own pool to use for the accelerator's static
        /// IP addresses when you create an accelerator. You can specify one or two addresses,
        /// separated by a comma. Do not include the /32 suffix.
        /// </para>
        ///  
        /// <para>
        /// Only one IP address from each of your IP address ranges can be used for each accelerator.
        /// If you specify only one IP address from your IP address range, Global Accelerator
        /// assigns a second static IP address for the accelerator from the AWS IP address pool.
        /// </para>
        ///  
        /// <para>
        ///  Note that you can't update IP addresses for an existing accelerator. To change them,
        /// you must create a new accelerator with the new addresses.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/using-byoip.html">Bring
        /// Your Own IP Addresses (BYOIP)</a> in the <i>AWS Global Accelerator Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public List<string> IpAddresses
        {
            get { return this._ipAddresses; }
            set { this._ipAddresses = value; }
        }

        // Check to see if IpAddresses property is set
        internal bool IsSetIpAddresses()
        {
            return this._ipAddresses != null && this._ipAddresses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The value for the address type must be IPv4.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of an accelerator. The name can have a maximum of 32 characters, must contain
        /// only alphanumeric characters or hyphens (-), and must not begin or end with a hyphen.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Create tags for an accelerator.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/tagging-in-global-accelerator.html">Tagging
        /// in AWS Global Accelerator</a> in the <i>AWS Global Accelerator Developer Guide</i>.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}