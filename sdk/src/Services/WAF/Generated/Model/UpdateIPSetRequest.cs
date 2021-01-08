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
    /// Container for the parameters to the UpdateIPSet operation.
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
    /// Inserts or deletes <a>IPSetDescriptor</a> objects in an <code>IPSet</code>. For each
    /// <code>IPSetDescriptor</code> object, you specify the following values: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Whether to insert or delete the object from the array. If you want to change an <code>IPSetDescriptor</code>
    /// object, you delete the existing object and add a new one.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The IP address version, <code>IPv4</code> or <code>IPv6</code>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The IP address in CIDR notation, for example, <code>192.0.2.0/24</code> (for the range
    /// of IP addresses from <code>192.0.2.0</code> to <code>192.0.2.255</code>) or <code>192.0.2.44/32</code>
    /// (for the individual IP address <code>192.0.2.44</code>). 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// AWS WAF supports IPv4 address ranges: /8 and any range between /16 through /32. AWS
    /// WAF supports IPv6 address ranges: /24, /32, /48, /56, /64, and /128. For more information
    /// about CIDR notation, see the Wikipedia entry <a href="https://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Classless
    /// Inter-Domain Routing</a>.
    /// </para>
    ///  
    /// <para>
    /// IPv6 addresses can be represented using any of the following formats:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// 1111:0000:0000:0000:0000:0000:0000:0111/128
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 1111:0:0:0:0:0:0:0111/128
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 1111::0111/128
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// 1111::111/128
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You use an <code>IPSet</code> to specify which web requests you want to allow or block
    /// based on the IP addresses that the requests originated from. For example, if you're
    /// receiving a lot of requests from one or a small number of IP addresses and you want
    /// to block the requests, you can create an <code>IPSet</code> that specifies those IP
    /// addresses, and then configure AWS WAF to block the requests. 
    /// </para>
    ///  
    /// <para>
    /// To create and configure an <code>IPSet</code>, perform the following steps:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Submit a <a>CreateIPSet</a> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <a>GetChangeToken</a> to get the change token that you provide in the <code>ChangeToken</code>
    /// parameter of an <a>UpdateIPSet</a> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Submit an <code>UpdateIPSet</code> request to specify the IP addresses that you want
    /// AWS WAF to watch for.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// When you update an <code>IPSet</code>, you specify the IP addresses that you want
    /// to add and/or the IP addresses that you want to delete. If you want to change an IP
    /// address, you delete the existing IP address and add the new one.
    /// </para>
    ///  
    /// <para>
    /// You can insert a maximum of 1000 addresses in a single request.
    /// </para>
    ///  
    /// <para>
    /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
    /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
    /// Guide</a>.
    /// </para>
    /// </summary>
    public partial class UpdateIPSetRequest : AmazonWAFRequest
    {
        private string _changeToken;
        private string _ipSetId;
        private List<IPSetUpdate> _updates = new List<IPSetUpdate>();

        /// <summary>
        /// Gets and sets the property ChangeToken. 
        /// <para>
        /// The value returned by the most recent call to <a>GetChangeToken</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ChangeToken
        {
            get { return this._changeToken; }
            set { this._changeToken = value; }
        }

        // Check to see if ChangeToken property is set
        internal bool IsSetChangeToken()
        {
            return this._changeToken != null;
        }

        /// <summary>
        /// Gets and sets the property IPSetId. 
        /// <para>
        /// The <code>IPSetId</code> of the <a>IPSet</a> that you want to update. <code>IPSetId</code>
        /// is returned by <a>CreateIPSet</a> and by <a>ListIPSets</a>.
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
        /// Gets and sets the property Updates. 
        /// <para>
        /// An array of <code>IPSetUpdate</code> objects that you want to insert into or delete
        /// from an <a>IPSet</a>. For more information, see the applicable data types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>IPSetUpdate</a>: Contains <code>Action</code> and <code>IPSetDescriptor</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>IPSetDescriptor</a>: Contains <code>Type</code> and <code>Value</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can insert a maximum of 1000 addresses in a single request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<IPSetUpdate> Updates
        {
            get { return this._updates; }
            set { this._updates = value; }
        }

        // Check to see if Updates property is set
        internal bool IsSetUpdates()
        {
            return this._updates != null && this._updates.Count > 0; 
        }

    }
}