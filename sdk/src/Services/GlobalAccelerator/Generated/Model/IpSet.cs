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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.GlobalAccelerator.Model
{
    /// <summary>
    /// A complex type for the set of IP addresses for an accelerator.
    /// </summary>
    public partial class IpSet
    {
        private List<string> _ipAddresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private IpAddressFamily _ipAddressFamily;
        private string _ipFamily;

        /// <summary>
        /// Gets and sets the property IpAddresses. 
        /// <para>
        /// The array of IP addresses in the IP address set. An IP address set can have a maximum
        /// of two IP addresses.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._ipAddresses != null && (this._ipAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IpAddressFamily. 
        /// <para>
        /// The types of IP addresses included in this IP set. 
        /// </para>
        /// </summary>
        public IpAddressFamily IpAddressFamily
        {
            get { return this._ipAddressFamily; }
            set { this._ipAddressFamily = value; }
        }

        // Check to see if IpAddressFamily property is set
        internal bool IsSetIpAddressFamily()
        {
            return this._ipAddressFamily != null;
        }

        /// <summary>
        /// Gets and sets the property IpFamily. 
        /// <para>
        /// IpFamily is deprecated and has been replaced by IpAddressFamily.
        /// </para>
        /// </summary>
        [Obsolete("IpFamily has been replaced by IpAddressFamily")]
        [AWSProperty(Max=255)]
        public string IpFamily
        {
            get { return this._ipFamily; }
            set { this._ipFamily = value; }
        }

        // Check to see if IpFamily property is set
        internal bool IsSetIpFamily()
        {
            return this._ipFamily != null;
        }

    }
}