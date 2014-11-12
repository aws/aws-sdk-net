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
    /// 
    /// </summary>
    public partial class DescribeDhcpOptionsResult : AmazonWebServiceResponse
    {
        private List<DhcpOptions> _dhcpOptions = new List<DhcpOptions>();

        /// <summary>
        /// Gets and sets the property DhcpOptions. 
        /// <para>
        /// Information about one or more DHCP options sets.
        /// </para>
        /// </summary>
        public List<DhcpOptions> DhcpOptions
        {
            get { return this._dhcpOptions; }
            set { this._dhcpOptions = value; }
        }

        // Check to see if DhcpOptions property is set
        internal bool IsSetDhcpOptions()
        {
            return this._dhcpOptions != null && this._dhcpOptions.Count > 0; 
        }

    }
}