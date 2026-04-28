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
    /// Container for the parameters to the UpdateAnycastIpList operation.
    /// Updates an Anycast static IP list.
    /// </summary>
    public partial class UpdateAnycastIpListRequest : AmazonCloudFrontRequest
    {
        private string _id;
        private string _ifMatch;
        private IpAddressType _ipAddressType;
        private List<IpamCidrConfig> _ipamCidrConfigs = AWSConfigs.InitializeCollections ? new List<IpamCidrConfig>() : null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the Anycast static IP list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property IfMatch. 
        /// <para>
        /// The current version (ETag value) of the Anycast static IP list that you are updating.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IfMatch
        {
            get { return this._ifMatch; }
            set { this._ifMatch = value; }
        }

        // Check to see if IfMatch property is set
        internal bool IsSetIfMatch()
        {
            return this._ifMatch != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type for the Anycast static IP list. You can specify one of the following
        /// options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ipv4</c> only
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ipv6</c> only
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
        /// Gets and sets the property IpamCidrConfigs. 
        /// <para>
        ///  A list of IPAM CIDR configurations that specify the IP address ranges and IPAM pool
        /// settings for updating the Anycast static IP list. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IpamCidrConfig> IpamCidrConfigs
        {
            get { return this._ipamCidrConfigs; }
            set { this._ipamCidrConfigs = value; }
        }

        // Check to see if IpamCidrConfigs property is set
        internal bool IsSetIpamCidrConfigs()
        {
            return this._ipamCidrConfigs != null && (this._ipamCidrConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}