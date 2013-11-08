/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.EC2.Model
{
    /// <summary>Spot Instance Request
    /// </summary>
    public class SpotInstanceRequest
    {
        
        private string spotInstanceRequestId;
        private string spotPrice;
        private SpotInstanceType type;
        private SpotInstanceState state;
        private SpotInstanceStateFault fault;
        private SpotInstanceStatus status;
        private DateTime? validFrom;
        private DateTime? validUntil;
        private string launchGroup;
        private string availabilityZoneGroup;
        private LaunchSpecification launchSpecification;
        private string instanceId;
        private DateTime? createTime;
        private RIProductDescription productDescription;
        private List<Tag> tags = new List<Tag>();
        private string launchedAvailabilityZone;

        public string SpotInstanceRequestId
        {
            get { return this.spotInstanceRequestId; }
            set { this.spotInstanceRequestId = value; }
        }

        // Check to see if SpotInstanceRequestId property is set
        internal bool IsSetSpotInstanceRequestId()
        {
            return this.spotInstanceRequestId != null;
        }
        public string SpotPrice
        {
            get { return this.spotPrice; }
            set { this.spotPrice = value; }
        }

        // Check to see if SpotPrice property is set
        internal bool IsSetSpotPrice()
        {
            return this.spotPrice != null;
        }
        public SpotInstanceType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this.type != null;
        }
        public SpotInstanceState State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this.state != null;
        }
        public SpotInstanceStateFault Fault
        {
            get { return this.fault; }
            set { this.fault = value; }
        }

        // Check to see if Fault property is set
        internal bool IsSetFault()
        {
            return this.fault != null;
        }
        public SpotInstanceStatus Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }
        public DateTime ValidFrom
        {
            get { return this.validFrom ?? default(DateTime); }
            set { this.validFrom = value; }
        }

        // Check to see if ValidFrom property is set
        internal bool IsSetValidFrom()
        {
            return this.validFrom.HasValue;
        }
        public DateTime ValidUntil
        {
            get { return this.validUntil ?? default(DateTime); }
            set { this.validUntil = value; }
        }

        // Check to see if ValidUntil property is set
        internal bool IsSetValidUntil()
        {
            return this.validUntil.HasValue;
        }
        public string LaunchGroup
        {
            get { return this.launchGroup; }
            set { this.launchGroup = value; }
        }

        // Check to see if LaunchGroup property is set
        internal bool IsSetLaunchGroup()
        {
            return this.launchGroup != null;
        }
        public string AvailabilityZoneGroup
        {
            get { return this.availabilityZoneGroup; }
            set { this.availabilityZoneGroup = value; }
        }

        // Check to see if AvailabilityZoneGroup property is set
        internal bool IsSetAvailabilityZoneGroup()
        {
            return this.availabilityZoneGroup != null;
        }

        /// <summary>
        /// The LaunchSpecificationType data type.
        ///  
        /// </summary>
        public LaunchSpecification LaunchSpecification
        {
            get { return this.launchSpecification; }
            set { this.launchSpecification = value; }
        }

        // Check to see if LaunchSpecification property is set
        internal bool IsSetLaunchSpecification()
        {
            return this.launchSpecification != null;
        }
        public string InstanceId
        {
            get { return this.instanceId; }
            set { this.instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this.instanceId != null;
        }
        public DateTime CreateTime
        {
            get { return this.createTime ?? default(DateTime); }
            set { this.createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this.createTime.HasValue;
        }
        public RIProductDescription ProductDescription
        {
            get { return this.productDescription; }
            set { this.productDescription = value; }
        }

        // Check to see if ProductDescription property is set
        internal bool IsSetProductDescription()
        {
            return this.productDescription != null;
        }

        /// <summary>
        /// A list of tags for this spot instance request.
        ///  
        /// </summary>
        public List<Tag> Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this.tags.Count > 0;
        }

        /// <summary>
        /// The Availability Zone in which the bid is launched.
        ///  
        /// </summary>
        public string LaunchedAvailabilityZone
        {
            get { return this.launchedAvailabilityZone; }
            set { this.launchedAvailabilityZone = value; }
        }

        // Check to see if LaunchedAvailabilityZone property is set
        internal bool IsSetLaunchedAvailabilityZone()
        {
            return this.launchedAvailabilityZone != null;
        }
    }
}
