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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSecondarySubnet operation.
    /// Creates a secondary subnet in a secondary network.
    /// 
    ///  
    /// <para>
    /// A secondary subnet CIDR block must not overlap with the CIDR block of an existing
    /// secondary subnet in the secondary network. After you create a secondary subnet, you
    /// can't change its CIDR block.
    /// </para>
    ///  
    /// <para>
    /// The allowed size for a secondary subnet CIDR block is between /28 netmask (16 IP addresses)
    /// and /12 netmask (1,048,576 IP addresses). Amazon reserves the first four IP addresses
    /// and the last IP address in each secondary subnet for internal use.
    /// </para>
    /// </summary>
    public partial class CreateSecondarySubnetRequest : AmazonEC2Request
    {
        private string _availabilityZone;
        private string _availabilityZoneId;
        private string _clientToken;
        private string _ipv4CidrBlock;
        private string _secondaryNetworkId;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone for the secondary subnet. You cannot specify both <c>AvailabilityZone</c>
        /// and <c>AvailabilityZoneId</c> in the same request.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The ID of the Availability Zone for the secondary subnet. This option is preferred
        /// over <c>AvailabilityZone</c> as it provides a consistent identifier across Amazon
        /// Web Services accounts. You cannot specify both <c>AvailabilityZone</c> and <c>AvailabilityZoneId</c>
        /// in the same request.
        /// </para>
        /// </summary>
        public string AvailabilityZoneId
        {
            get { return this._availabilityZoneId; }
            set { this._availabilityZoneId = value; }
        }

        // Check to see if AvailabilityZoneId property is set
        internal bool IsSetAvailabilityZoneId()
        {
            return this._availabilityZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">Ensure
        /// Idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv4CidrBlock. 
        /// <para>
        /// The IPv4 CIDR block for the secondary subnet. The CIDR block size must be between
        /// /12 and /28.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Ipv4CidrBlock
        {
            get { return this._ipv4CidrBlock; }
            set { this._ipv4CidrBlock = value; }
        }

        // Check to see if Ipv4CidrBlock property is set
        internal bool IsSetIpv4CidrBlock()
        {
            return this._ipv4CidrBlock != null;
        }

        /// <summary>
        /// Gets and sets the property SecondaryNetworkId. 
        /// <para>
        /// The ID of the secondary network in which to create the secondary subnet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SecondaryNetworkId
        {
            get { return this._secondaryNetworkId; }
            set { this._secondaryNetworkId = value; }
        }

        // Check to see if SecondaryNetworkId property is set
        internal bool IsSetSecondaryNetworkId()
        {
            return this._secondaryNetworkId != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to assign to the secondary subnet.
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}