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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a set of DHCP options.
    /// </summary>
    public partial class DhcpOptions
    {
        private List<DhcpConfiguration> _dhcpConfigurations = new List<DhcpConfiguration>();
        private string _dhcpOptionsId;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property DhcpConfigurations. 
        /// <para>
        /// One or more DHCP options in the set.
        /// </para>
        /// </summary>
        public List<DhcpConfiguration> DhcpConfigurations
        {
            get { return this._dhcpConfigurations; }
            set { this._dhcpConfigurations = value; }
        }

        // Check to see if DhcpConfigurations property is set
        internal bool IsSetDhcpConfigurations()
        {
            return this._dhcpConfigurations != null && this._dhcpConfigurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DhcpOptionsId. 
        /// <para>
        /// The ID of the set of DHCP options.
        /// </para>
        /// </summary>
        public string DhcpOptionsId
        {
            get { return this._dhcpOptionsId; }
            set { this._dhcpOptionsId = value; }
        }

        // Check to see if DhcpOptionsId property is set
        internal bool IsSetDhcpOptionsId()
        {
            return this._dhcpOptionsId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the DHCP options set.
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