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
    /// Container for the parameters to the CreateSubnetCidrReservation operation.
    /// Creates a subnet CIDR reservation. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/subnet-cidr-reservation.html">Subnet
    /// CIDR reservations</a> in the <i>Amazon VPC User Guide</i> and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/work-with-prefixes.html">Manage
    /// prefixes for your network interfaces</a> in the <i>Amazon EC2 User Guide</i>.
    /// </summary>
    public partial class CreateSubnetCidrReservationRequest : AmazonEC2Request
    {
        private string _cidr;
        private string _description;
        private bool? _dryRun;
        private SubnetCidrReservationType _reservationType;
        private string _subnetId;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// The IPv4 or IPV6 CIDR range to reserve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Cidr
        {
            get { return this._cidr; }
            set { this._cidr = value; }
        }

        // Check to see if Cidr property is set
        internal bool IsSetCidr()
        {
            return this._cidr != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description to assign to the subnet CIDR reservation.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReservationType. 
        /// <para>
        /// The type of reservation. The reservation type determines how the reserved IP addresses
        /// are assigned to resources.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>prefix</c> - Amazon Web Services assigns the reserved IP addresses to network
        /// interfaces.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>explicit</c> - You assign the reserved IP addresses to network interfaces.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public SubnetCidrReservationType ReservationType
        {
            get { return this._reservationType; }
            set { this._reservationType = value; }
        }

        // Check to see if ReservationType property is set
        internal bool IsSetReservationType()
        {
            return this._reservationType != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this._subnetId != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to assign to the subnet CIDR reservation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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