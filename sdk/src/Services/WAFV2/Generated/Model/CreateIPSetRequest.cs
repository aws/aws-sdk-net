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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateIPSet operation.
    /// Creates an <a>IPSet</a>, which you use to identify web requests that originate from
    /// specific IP addresses or ranges of IP addresses. For example, if you're receiving
    /// a lot of requests from a ranges of IP addresses, you can configure WAF to block them
    /// using an IPSet that lists those IP addresses.
    /// </summary>
    public partial class CreateIPSetRequest : AmazonWAFV2Request
    {
        private List<string> _addresses = new List<string>();
        private string _description;
        private IPAddressVersion _ipAddressVersion;
        private string _name;
        private Scope _scope;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property Addresses. 
        /// <para>
        /// Contains an array of strings that specifies zero or more IP addresses or blocks of
        /// IP addresses. All addresses must be specified using Classless Inter-Domain Routing
        /// (CIDR) notation. WAF supports all IPv4 and IPv6 CIDR ranges except for <code>/0</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Example address strings: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To configure WAF to allow, block, or count requests that originated from the IP address
        /// 192.0.2.44, specify <code>192.0.2.44/32</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To configure WAF to allow, block, or count requests that originated from IP addresses
        /// from 192.0.2.0 to 192.0.2.255, specify <code>192.0.2.0/24</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To configure WAF to allow, block, or count requests that originated from the IP address
        /// 1111:0000:0000:0000:0000:0000:0000:0111, specify <code>1111:0000:0000:0000:0000:0000:0000:0111/128</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To configure WAF to allow, block, or count requests that originated from IP addresses
        /// 1111:0000:0000:0000:0000:0000:0000:0000 to 1111:0000:0000:0000:ffff:ffff:ffff:ffff,
        /// specify <code>1111:0000:0000:0000:0000:0000:0000:0000/64</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about CIDR notation, see the Wikipedia entry <a href="https://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Classless
        /// Inter-Domain Routing</a>.
        /// </para>
        ///  
        /// <para>
        /// Example JSON <code>Addresses</code> specifications: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Empty array: <code>"Addresses": []</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Array with one address: <code>"Addresses": ["192.0.2.44/32"]</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Array with three addresses: <code>"Addresses": ["192.0.2.44/32", "192.0.2.0/24", "192.0.0.0/16"]</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID specification: <code>"Addresses": [""]</code> INVALID 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Addresses
        {
            get { return this._addresses; }
            set { this._addresses = value; }
        }

        // Check to see if Addresses property is set
        internal bool IsSetAddresses()
        {
            return this._addresses != null && this._addresses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the IP set that helps with identification. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property IPAddressVersion. 
        /// <para>
        /// The version of the IP addresses, either <code>IPV4</code> or <code>IPV6</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IPAddressVersion IPAddressVersion
        {
            get { return this._ipAddressVersion; }
            set { this._ipAddressVersion = value; }
        }

        // Check to see if IPAddressVersion property is set
        internal bool IsSetIPAddressVersion()
        {
            return this._ipAddressVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the IP set. You cannot change the name of an <code>IPSet</code> after
        /// you create it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// Specifies whether this is for an Amazon CloudFront distribution or for a regional
        /// application. A regional application can be an Application Load Balancer (ALB), an
        /// Amazon API Gateway REST API, an AppSync GraphQL API, an Amazon Cognito user pool,
        /// or an App Runner service. 
        /// </para>
        ///  
        /// <para>
        /// To work with CloudFront, you must also specify the Region US East (N. Virginia) as
        /// follows: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CLI - Specify the Region when you use the CloudFront scope: <code>--scope=CLOUDFRONT
        /// --region=us-east-1</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// API and SDKs - For all calls, use the Region endpoint us-east-1. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public Scope Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key:value pairs to associate with the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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