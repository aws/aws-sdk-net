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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
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
namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// This is the response object from the SetSubnets operation.
    /// </summary>
    public partial class SetSubnetsResponse : AmazonWebServiceResponse
    {
        private List<AvailabilityZone> _availabilityZones = AWSConfigs.InitializeCollections ? new List<AvailabilityZone>() : null;
        private EnablePrefixForIpv6SourceNatEnum _enablePrefixForIpv6SourceNat;
        private IpAddressType _ipAddressType;

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// Information about the subnets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AvailabilityZone> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && (this._availabilityZones.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EnablePrefixForIpv6SourceNat. 
        /// <para>
        /// [Network Load Balancers] Indicates whether to use an IPv6 prefix from each subnet
        /// for source NAT.
        /// </para>
        /// </summary>
        public EnablePrefixForIpv6SourceNatEnum EnablePrefixForIpv6SourceNat
        {
            get { return this._enablePrefixForIpv6SourceNat; }
            set { this._enablePrefixForIpv6SourceNat = value; }
        }

        // Check to see if EnablePrefixForIpv6SourceNat property is set
        internal bool IsSetEnablePrefixForIpv6SourceNat()
        {
            return this._enablePrefixForIpv6SourceNat != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type.
        /// </para>
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

    }
}