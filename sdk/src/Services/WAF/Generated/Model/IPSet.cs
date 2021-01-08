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
    /// Contains one or more IP addresses or blocks of IP addresses specified in Classless
    /// Inter-Domain Routing (CIDR) notation. AWS WAF supports IPv4 address ranges: /8 and
    /// any range between /16 through /32. AWS WAF supports IPv6 address ranges: /24, /32,
    /// /48, /56, /64, and /128.
    /// </para>
    ///  
    /// <para>
    /// To specify an individual IP address, you specify the four-part IP address followed
    /// by a <code>/32</code>, for example, 192.0.2.0/32. To block a range of IP addresses,
    /// you can specify /8 or any range between /16 through /32 (for IPv4) or /24, /32, /48,
    /// /56, /64, or /128 (for IPv6). For more information about CIDR notation, see the Wikipedia
    /// entry <a href="https://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Classless
    /// Inter-Domain Routing</a>. 
    /// </para>
    /// </summary>
    public partial class IPSet
    {
        private List<IPSetDescriptor> _ipSetDescriptors = new List<IPSetDescriptor>();
        private string _ipSetId;
        private string _name;

        /// <summary>
        /// Gets and sets the property IPSetDescriptors. 
        /// <para>
        /// The IP address type (<code>IPV4</code> or <code>IPV6</code>) and the IP address range
        /// (in CIDR notation) that web requests originate from. If the <code>WebACL</code> is
        /// associated with a CloudFront distribution and the viewer did not use an HTTP proxy
        /// or a load balancer to send the request, this is the value of the c-ip field in the
        /// CloudFront access logs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<IPSetDescriptor> IPSetDescriptors
        {
            get { return this._ipSetDescriptors; }
            set { this._ipSetDescriptors = value; }
        }

        // Check to see if IPSetDescriptors property is set
        internal bool IsSetIPSetDescriptors()
        {
            return this._ipSetDescriptors != null && this._ipSetDescriptors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IPSetId. 
        /// <para>
        /// The <code>IPSetId</code> for an <code>IPSet</code>. You use <code>IPSetId</code> to
        /// get information about an <code>IPSet</code> (see <a>GetIPSet</a>), update an <code>IPSet</code>
        /// (see <a>UpdateIPSet</a>), insert an <code>IPSet</code> into a <code>Rule</code> or
        /// delete one from a <code>Rule</code> (see <a>UpdateRule</a>), and delete an <code>IPSet</code>
        /// from AWS WAF (see <a>DeleteIPSet</a>).
        /// </para>
        ///  
        /// <para>
        ///  <code>IPSetId</code> is returned by <a>CreateIPSet</a> and by <a>ListIPSets</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string IPSetId
        {
            get { return this._ipSetId; }
            set { this._ipSetId = value; }
        }

        // Check to see if IPSetId property is set
        internal bool IsSetIPSetId()
        {
            return this._ipSetId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A friendly name or description of the <a>IPSet</a>. You can't change the name of an
        /// <code>IPSet</code> after you create it.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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

    }
}