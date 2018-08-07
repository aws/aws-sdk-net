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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// Container for the parameters to the DescribeDhcpOptions operation.
    /// Describes one or more of your DHCP options sets.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html">DHCP
    /// Options Sets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeDhcpOptionsRequest : AmazonEC2Request
    {
        private List<string> _dhcpOptionsIds = new List<string>();
        private List<Filter> _filters = new List<Filter>();

        /// <summary>
        /// Gets and sets the property DhcpOptionsIds. 
        /// <para>
        /// The IDs of one or more DHCP options sets.
        /// </para>
        ///  
        /// <para>
        /// Default: Describes all your DHCP options sets.
        /// </para>
        /// </summary>
        public List<string> DhcpOptionsIds
        {
            get { return this._dhcpOptionsIds; }
            set { this._dhcpOptionsIds = value; }
        }

        // Check to see if DhcpOptionsIds property is set
        internal bool IsSetDhcpOptionsIds()
        {
            return this._dhcpOptionsIds != null && this._dhcpOptionsIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>dhcp-options-id</code> - The ID of a set of DHCP options.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>key</code> - The key for one of the options (for example, <code>domain-name</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>value</code> - The value for one of the options.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag</code>:&lt;key&gt; - The key/value combination of a tag assigned to the
        /// resource. Use the tag key in the filter name and the tag value as the filter value.
        /// For example, to find all resources that have a tag with the key <code>Owner</code>
        /// and the value <code>TeamA</code>, specify <code>tag:Owner</code> for the filter name
        /// and <code>TeamA</code> for the filter value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag-key</code> - The key of a tag assigned to the resource. Use this filter
        /// to find all resources assigned a tag with a specific key, regardless of the tag value.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

    }
}