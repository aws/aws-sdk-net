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

#pragma warning disable CS0612,CS0618,CS1570
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
        private List<string> _addresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _description;
        private IPAddressVersion _ipAddressVersion;
        private string _name;
        private Scope _scope;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property Addresses. 
        /// <para>
        /// Contains an array of strings that specifies zero or more IP addresses or blocks of
        /// IP addresses that you want WAF to inspect for in incoming requests. All addresses
        /// must be specified using Classless Inter-Domain Routing (CIDR) notation. WAF supports
        /// all IPv4 and IPv6 CIDR ranges except for <c>/0</c>. 
        /// </para>
        ///  
        /// <para>
        /// Example address strings: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For requests that originated from the IP address 192.0.2.44, specify <c>192.0.2.44/32</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For requests that originated from IP addresses from 192.0.2.0 to 192.0.2.255, specify
        /// <c>192.0.2.0/24</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For requests that originated from the IP address 1111:0000:0000:0000:0000:0000:0000:0111,
        /// specify <c>1111:0000:0000:0000:0000:0000:0000:0111/128</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For requests that originated from IP addresses 1111:0000:0000:0000:0000:0000:0000:0000
        /// to 1111:0000:0000:0000:ffff:ffff:ffff:ffff, specify <c>1111:0000:0000:0000:0000:0000:0000:0000/64</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about CIDR notation, see the Wikipedia entry <a href="https://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Classless
        /// Inter-Domain Routing</a>.
        /// </para>
        ///  
        /// <para>
        /// Example JSON <c>Addresses</c> specifications: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Empty array: <c>"Addresses": []</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Array with one address: <c>"Addresses": ["192.0.2.44/32"]</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Array with three addresses: <c>"Addresses": ["192.0.2.44/32", "192.0.2.0/24", "192.0.0.0/16"]</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVALID specification: <c>"Addresses": [""]</c> INVALID 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._addresses != null && (this._addresses.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// The version of the IP addresses, either <c>IPV4</c> or <c>IPV6</c>. 
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
        /// The name of the IP set. You cannot change the name of an <c>IPSet</c> after you create
        /// it.
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
        /// Specifies whether this is for a global resource type, such as a Amazon CloudFront
        /// distribution. For an Amplify application, use <c>CLOUDFRONT</c>.
        /// </para>
        ///  
        /// <para>
        /// To work with CloudFront, you must also specify the Region US East (N. Virginia) as
        /// follows: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CLI - Specify the Region when you use the CloudFront scope: <c>--scope=CLOUDFRONT
        /// --region=us-east-1</c>. 
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}