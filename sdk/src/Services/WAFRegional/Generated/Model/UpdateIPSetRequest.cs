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
 * Do not modify this file. This file is generated from the waf-regional-2016-11-28.normal.json service model.
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
namespace Amazon.WAFRegional.Model
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
    /// Inserts or deletes <a>IPSetDescriptor</a> objects in an <c>IPSet</c>. For each <c>IPSetDescriptor</c>
    /// object, you specify the following values: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Whether to insert or delete the object from the array. If you want to change an <c>IPSetDescriptor</c>
    /// object, you delete the existing object and add a new one.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The IP address version, <c>IPv4</c> or <c>IPv6</c>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The IP address in CIDR notation, for example, <c>192.0.2.0/24</c> (for the range of
    /// IP addresses from <c>192.0.2.0</c> to <c>192.0.2.255</c>) or <c>192.0.2.44/32</c>
    /// (for the individual IP address <c>192.0.2.44</c>). 
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
    /// You use an <c>IPSet</c> to specify which web requests you want to allow or block based
    /// on the IP addresses that the requests originated from. For example, if you're receiving
    /// a lot of requests from one or a small number of IP addresses and you want to block
    /// the requests, you can create an <c>IPSet</c> that specifies those IP addresses, and
    /// then configure AWS WAF to block the requests. 
    /// </para>
    ///  
    /// <para>
    /// To create and configure an <c>IPSet</c>, perform the following steps:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Submit a <a>CreateIPSet</a> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <a>GetChangeToken</a> to get the change token that you provide in the <c>ChangeToken</c>
    /// parameter of an <a>UpdateIPSet</a> request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Submit an <c>UpdateIPSet</c> request to specify the IP addresses that you want AWS
    /// WAF to watch for.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// When you update an <c>IPSet</c>, you specify the IP addresses that you want to add
    /// and/or the IP addresses that you want to delete. If you want to change an IP address,
    /// you delete the existing IP address and add the new one.
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
    public partial class UpdateIPSetRequest : AmazonWAFRegionalRequest
    {
        private string _changeToken;
        private string _ipSetId;
        private List<IPSetUpdate> _updates = AWSConfigs.InitializeCollections ? new List<IPSetUpdate>() : null;

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
        /// The <c>IPSetId</c> of the <a>IPSet</a> that you want to update. <c>IPSetId</c> is
        /// returned by <a>CreateIPSet</a> and by <a>ListIPSets</a>.
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
        /// An array of <c>IPSetUpdate</c> objects that you want to insert into or delete from
        /// an <a>IPSet</a>. For more information, see the applicable data types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>IPSetUpdate</a>: Contains <c>Action</c> and <c>IPSetDescriptor</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>IPSetDescriptor</a>: Contains <c>Type</c> and <c>Value</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can insert a maximum of 1000 addresses in a single request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._updates != null && (this._updates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}