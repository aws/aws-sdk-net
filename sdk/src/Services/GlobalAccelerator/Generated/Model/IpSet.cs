/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GlobalAccelerator.Model
{
    /// <summary>
    /// A complex type for the set of IP addresses for an accelerator.
    /// </summary>
    public partial class IpSet
    {
        private List<string> _ipAddresses = new List<string>();
        private string _ipFamily;

        /// <summary>
        /// Gets and sets the property IpAddresses. 
        /// <para>
        /// The array of IP addresses in the IP address set. An IP address set can have a maximum
        /// of two IP addresses.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property IpFamily. 
        /// <para>
        /// The types of IP addresses included in this IP set.
        /// </para>
        /// </summary>
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