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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAnycastIpList operation.
    /// Creates an Anycast static IP list.
    /// </summary>
    public partial class CreateAnycastIpListRequest : AmazonCloudFrontRequest
    {
        private IpAddressType _ipAddressType;
        private int? _ipCount;
        private string _name;
        private Tags _tags;

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type for the Anycast static IP list. You can specify one of the following
        /// options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ipv4</c> - Allocate a list of only IPv4 addresses
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ipv6</c> - Allocate a list of only IPv4 addresses
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>dualstack</c> - Allocate a list of both IPv4 and IPv6 addresses
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public IpAddressType IpAddressType
        {
            get { return this._ipAddressType; }
            set { this._ipAddressType = value; }
        }

        // Check to see if IpAddressType property is set
        internal bool IsSetIpAddressType()
        {
            return this._ipAddressType != null;
        }

        /// <summary>
        /// Gets and sets the property IpCount. 
        /// <para>
        /// The number of static IP addresses that are allocated to the Anycast static IP list.
        /// Valid values: 21 or 3.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int IpCount
        {
            get { return this._ipCount.GetValueOrDefault(); }
            set { this._ipCount = value; }
        }

        // Check to see if IpCount property is set
        internal bool IsSetIpCount()
        {
            return this._ipCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the Anycast static IP list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property Tags.
        /// </summary>
        public Tags Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null;
        }

    }
}