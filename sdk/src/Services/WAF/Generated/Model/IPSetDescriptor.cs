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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
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
namespace Amazon.WAF.Model
{
    /// <summary>
    /// <note> 
    /// <para>
    /// This is <b>AWS WAF Classic</b> documentation. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/classic-waf-chapter.html">AWS
    /// WAF Classic</a> in the developer guide.
    /// </para>
    ///  
    /// <para>
    ///  <b>For the latest version of AWS WAF</b>, use the AWS WAFV2 API and see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
    /// WAF Developer Guide</a>. With the latest version, AWS WAF has a single set of endpoints
    /// for regional and global use. 
    /// </para>
    ///  </note> 
    /// <para>
    /// Specifies the IP address type (<c>IPV4</c> or <c>IPV6</c>) and the IP address range
    /// (in CIDR format) that web requests originate from.
    /// </para>
    /// </summary>
    public partial class IPSetDescriptor
    {
        private IPSetDescriptorType _type;
        private string _value;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Specify <c>IPV4</c> or <c>IPV6</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IPSetDescriptorType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// Specify an IPv4 address by using CIDR notation. For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To configure AWS WAF to allow, block, or count requests that originated from the IP
        /// address 192.0.2.44, specify <c>192.0.2.44/32</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To configure AWS WAF to allow, block, or count requests that originated from IP addresses
        /// from 192.0.2.0 to 192.0.2.255, specify <c>192.0.2.0/24</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about CIDR notation, see the Wikipedia entry <a href="https://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Classless
        /// Inter-Domain Routing</a>.
        /// </para>
        ///  
        /// <para>
        /// Specify an IPv6 address by using CIDR notation. For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To configure AWS WAF to allow, block, or count requests that originated from the IP
        /// address 1111:0000:0000:0000:0000:0000:0000:0111, specify <c>1111:0000:0000:0000:0000:0000:0000:0111/128</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To configure AWS WAF to allow, block, or count requests that originated from IP addresses
        /// 1111:0000:0000:0000:0000:0000:0000:0000 to 1111:0000:0000:0000:ffff:ffff:ffff:ffff,
        /// specify <c>1111:0000:0000:0000:0000:0000:0000:0000/64</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}