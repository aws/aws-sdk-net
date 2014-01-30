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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeDhcpOptions operation.
    /// <para>Describes one or more of your DHCP options sets.</para> <para>For more information about DHCP options sets, see <a
    /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html" >DHCP Options Sets</a> in the <i>Amazon Virtual Private
    /// Cloud User Guide</i> .</para>
    /// </summary>
    public partial class DescribeDhcpOptionsRequest : AmazonEC2Request
    {
        private List<string> dhcpOptionsIds = new List<string>();
        private List<Filter> filters = new List<Filter>();


        /// <summary>
        /// The IDs of one or more DHCP options sets. Default: Describes all your DHCP options sets.
        ///  
        /// </summary>
        public List<string> DhcpOptionsIds
        {
            get { return this.dhcpOptionsIds; }
            set { this.dhcpOptionsIds = value; }
        }

        // Check to see if DhcpOptionsIds property is set
        internal bool IsSetDhcpOptionsIds()
        {
            return this.dhcpOptionsIds.Count > 0;
        }

        /// <summary>
        /// One or more filters. <ul> <li> <c>dhcp-options-id</c> - The ID of a set of DHCP options. </li> <li> <c>key</c> - The key for one of the
        /// options (for example, <c>domain-name</c>). </li> <li> <c>value</c> - The value for one of the options. </li> <li>
        /// <c>tag</c>:<i>key</i>=<i>value</i> - The key/value combination of a tag assigned to the resource. </li> <li> <c>tag-key</c> - The key of a
        /// tag assigned to the resource. This filter is independent of the <c>tag-value</c> filter. For example, if you use both the filter
        /// "tag-key=Purpose" and the filter "tag-value=X", you get any resources assigned both the tag key Purpose (regardless of what the tag's value
        /// is), and the tag value X (regardless of what the tag's key is). If you want to list only resources where Purpose is X, see the
        /// <c>tag</c>:<i>key</i>=<i>value</i> filter. </li> <li> <c>tag-value</c> - The value of a tag assigned to the resource. This filter is
        /// independent of the <c>tag-key</c> filter. </li> </ul>
        ///  
        /// </summary>
        public List<Filter> Filters
        {
            get { return this.filters; }
            set { this.filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this.filters.Count > 0;
        }

    }
}
    
