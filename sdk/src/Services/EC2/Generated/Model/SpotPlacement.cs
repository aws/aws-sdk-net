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
    /// Describes Spot Instance placement.
    /// </summary>
    public partial class SpotPlacement
    {
        private string _availabilityZone;
        private string _availabilityZoneId;
        private string _groupName;
        private Tenancy _tenancy;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public SpotPlacement() { }

        /// <summary>
        /// Instantiates SpotPlacement with the parameterized properties
        /// </summary>
        /// <param name="availabilityZone">The Availability Zone. For example, <c>us-east-2a</c>. [Spot Fleet only] To specify multiple Availability Zones, separate them using commas; for example, "<c>us-east-2a</c>, <c>us-east-2b</c>". Either <c>AvailabilityZone</c> or <c>AvailabilityZoneId</c> must be specified in the request, but not both.</param>
        public SpotPlacement(string availabilityZone)
        {
            _availabilityZone = availabilityZone;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone. For example, <c>us-east-2a</c>.
        /// </para>
        ///  
        /// <para>
        /// [Spot Fleet only] To specify multiple Availability Zones, separate them using commas;
        /// for example, "<c>us-east-2a</c>, <c>us-east-2b</c>".
        /// </para>
        ///  
        /// <para>
        /// Either <c>AvailabilityZone</c> or <c>AvailabilityZoneId</c> must be specified in the
        /// request, but not both.
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
        /// The ID of the Availability Zone. For example, <c>use2-az1</c>.
        /// </para>
        ///  
        /// <para>
        /// [Spot Fleet only] To specify multiple Availability Zones, separate them using commas;
        /// for example, "<c>use2-az1</c>, <c>use2-bz1</c>".
        /// </para>
        ///  
        /// <para>
        /// Either <c>AvailabilityZone</c> or <c>AvailabilityZoneId</c> must be specified in the
        /// request, but not both.
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
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The name of the placement group.
        /// </para>
        /// </summary>
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

        /// <summary>
        /// Gets and sets the property Tenancy. 
        /// <para>
        /// The tenancy of the instance (if the instance is running in a VPC). An instance with
        /// a tenancy of <c>dedicated</c> runs on single-tenant hardware. The <c>host</c> tenancy
        /// is not supported for Spot Instances.
        /// </para>
        /// </summary>
        public Tenancy Tenancy
        {
            get { return this._tenancy; }
            set { this._tenancy = value; }
        }

        // Check to see if Tenancy property is set
        internal bool IsSetTenancy()
        {
            return this._tenancy != null;
        }

    }
}