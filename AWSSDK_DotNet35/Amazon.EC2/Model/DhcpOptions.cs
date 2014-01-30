/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para>Describes a set of DHCP options.</para>
    /// </summary>
    public class DhcpOptions
    {
        
        private string dhcpOptionsId;
        private List<DhcpConfiguration> dhcpConfigurations = new List<DhcpConfiguration>();
        private List<Tag> tags = new List<Tag>();


        /// <summary>
        /// The ID of the set of DHCP options.
        ///  
        /// </summary>
        public string DhcpOptionsId
        {
            get { return this.dhcpOptionsId; }
            set { this.dhcpOptionsId = value; }
        }

        // Check to see if DhcpOptionsId property is set
        internal bool IsSetDhcpOptionsId()
        {
            return this.dhcpOptionsId != null;
        }

        /// <summary>
        /// One or more DHCP options in the set.
        ///  
        /// </summary>
        public List<DhcpConfiguration> DhcpConfigurations
        {
            get { return this.dhcpConfigurations; }
            set { this.dhcpConfigurations = value; }
        }

        // Check to see if DhcpConfigurations property is set
        internal bool IsSetDhcpConfigurations()
        {
            return this.dhcpConfigurations.Count > 0;
        }

        /// <summary>
        /// Any tags assigned to the DHCP options set.
        ///  
        /// </summary>
        public List<Tag> Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this.tags.Count > 0;
        }
    }
}
