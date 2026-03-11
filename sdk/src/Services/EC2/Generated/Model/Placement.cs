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
    /// Describes the placement of an instance.
    /// </summary>
    public partial class Placement
    {
        private string _affinity;
        private string _availabilityZone;
        private string _availabilityZoneId;
        private string _groupId;
        private string _groupName;
        private string _hostId;
        private string _hostResourceGroupArn;
        private int? _partitionNumber;
        private string _spreadDomain;
        private Tenancy _tenancy;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public Placement() { }

        /// <summary>
        /// Instantiates Placement with the parameterized properties
        /// </summary>
        /// <param name="availabilityZone">The Availability Zone of the instance. On input, you can specify <c>AvailabilityZone</c> or <c>AvailabilityZoneId</c>, but not both. If you specify neither one, Amazon EC2 automatically selects an Availability Zone for you. This parameter is not supported for <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateFleet">CreateFleet</a>.</param>
        public Placement(string availabilityZone)
        {
            _availabilityZone = availabilityZone;
        }

        /// <summary>
        /// Gets and sets the property Affinity. 
        /// <para>
        /// The affinity setting for the instance on the Dedicated Host.
        /// </para>
        ///  
        /// <para>
        /// This parameter is not supported for <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateFleet">CreateFleet</a>
        /// or <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_ImportInstance.html">ImportInstance</a>.
        /// </para>
        /// </summary>
        public string Affinity
        {
            get { return this._affinity; }
            set { this._affinity = value; }
        }

        // Check to see if Affinity property is set
        internal bool IsSetAffinity()
        {
            return this._affinity != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone of the instance.
        /// </para>
        ///  
        /// <para>
        /// On input, you can specify <c>AvailabilityZone</c> or <c>AvailabilityZoneId</c>, but
        /// not both. If you specify neither one, Amazon EC2 automatically selects an Availability
        /// Zone for you.
        /// </para>
        ///  
        /// <para>
        /// This parameter is not supported for <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateFleet">CreateFleet</a>.
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
        /// The ID of the Availability Zone of the instance.
        /// </para>
        ///  
        /// <para>
        /// On input, you can specify <c>AvailabilityZone</c> or <c>AvailabilityZoneId</c>, but
        /// not both. If you specify neither one, Amazon EC2 automatically selects an Availability
        /// Zone for you.
        /// </para>
        ///  
        /// <para>
        /// This parameter is not supported for <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateFleet">CreateFleet</a>.
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
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The ID of the placement group that the instance is in.
        /// </para>
        ///  
        /// <para>
        /// On input, you can specify <c>GroupId</c> or <c>GroupName</c>, but not both.
        /// </para>
        /// </summary>
        public string GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this._groupId != null;
        }

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The name of the placement group that the instance is in.
        /// </para>
        ///  
        /// <para>
        /// On input, you can specify <c>GroupId</c> or <c>GroupName</c>, but not both.
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
        /// Gets and sets the property HostId. 
        /// <para>
        /// The ID of the Dedicated Host on which the instance resides.
        /// </para>
        ///  
        /// <para>
        /// This parameter is not supported for <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateFleet">CreateFleet</a>
        /// or <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_ImportInstance.html">ImportInstance</a>.
        /// </para>
        /// </summary>
        public string HostId
        {
            get { return this._hostId; }
            set { this._hostId = value; }
        }

        // Check to see if HostId property is set
        internal bool IsSetHostId()
        {
            return this._hostId != null;
        }

        /// <summary>
        /// Gets and sets the property HostResourceGroupArn. 
        /// <para>
        /// The ARN of the host resource group in which to launch the instances.
        /// </para>
        ///  
        /// <para>
        /// On input, if you specify this parameter, either omit the <b>Tenancy</b> parameter
        /// or set it to <c>host</c>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is not supported for <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateFleet">CreateFleet</a>.
        /// </para>
        /// </summary>
        public string HostResourceGroupArn
        {
            get { return this._hostResourceGroupArn; }
            set { this._hostResourceGroupArn = value; }
        }

        // Check to see if HostResourceGroupArn property is set
        internal bool IsSetHostResourceGroupArn()
        {
            return this._hostResourceGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property PartitionNumber. 
        /// <para>
        /// The number of the partition that the instance is in. Valid only if the placement group
        /// strategy is set to <c>partition</c>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is not supported for <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateFleet">CreateFleet</a>.
        /// </para>
        /// </summary>
        public int? PartitionNumber
        {
            get { return this._partitionNumber; }
            set { this._partitionNumber = value; }
        }

        // Check to see if PartitionNumber property is set
        internal bool IsSetPartitionNumber()
        {
            return this._partitionNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SpreadDomain. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public string SpreadDomain
        {
            get { return this._spreadDomain; }
            set { this._spreadDomain = value; }
        }

        // Check to see if SpreadDomain property is set
        internal bool IsSetSpreadDomain()
        {
            return this._spreadDomain != null;
        }

        /// <summary>
        /// Gets and sets the property Tenancy. 
        /// <para>
        /// The tenancy of the instance. An instance with a tenancy of <c>dedicated</c> runs on
        /// single-tenant hardware.
        /// </para>
        ///  
        /// <para>
        /// This parameter is not supported for <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateFleet">CreateFleet</a>.
        /// The <c>host</c> tenancy is not supported for <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_ImportInstance.html">ImportInstance</a>
        /// or for T3 instances that are configured for the <c>unlimited</c> CPU credit option.
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