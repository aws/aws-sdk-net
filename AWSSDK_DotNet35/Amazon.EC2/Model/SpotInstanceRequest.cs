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
    /// <summary>
    /// <para>Describe a Spot Instance request.</para>
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


        /// <summary>
        /// The ID of the Spot Instance request.
        ///  
        /// </summary>
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

        /// <summary>
        /// The maximum hourly price for any Spot Instance launched to fulfill the request.
        ///  
        /// </summary>
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

        /// <summary>
        /// The Spot Instance request type.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>one-time, persistent</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
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

        /// <summary>
        /// The state of the Spot Instance request. Spot bid status information can help you track your Spot Instance requests. For information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances-bid-status.html">Tracking Spot Requests with Bid Status
        /// Codes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>open, active, closed, cancelled, failed</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
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

        /// <summary>
        /// The fault codes for the Spot Instance request, if any.
        ///  
        /// </summary>
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

        /// <summary>
        /// The status code and status message describing the Spot Instance request.
        ///  
        /// </summary>
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

        /// <summary>
        /// The start date of the request. If this is a one-time request, the request becomes active at this date and time and remains active until all
        /// instances launch, the request expires, or the request is canceled. If the request is persistent, the request becomes active at this date and
        /// time and remains active until it expires or is canceled.
        ///  
        /// </summary>
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

        /// <summary>
        /// The end date of the request. If this is a one-time request, the request remains active until all instances launch, the request is canceled,
        /// or this date is reached. If the request is persistent, it remains active until it is canceled or this date is reached.
        ///  
        /// </summary>
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

        /// <summary>
        /// The instance launch group. Launch groups are Spot Instances that launch together and terminate together.
        ///  
        /// </summary>
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

        /// <summary>
        /// The Availability Zone group. If you specify the same Availability Zone group for all Spot Instance requests, all Spot Instances are launched
        /// in the same Availability Zone.
        ///  
        /// </summary>
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
        /// Additional information for launching instances.
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

        /// <summary>
        /// The instance ID, if an instance has been launched to fulfill the Spot Instance request.
        ///  
        /// </summary>
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

        /// <summary>
        /// The time stamp when the Spot Instance request was created.
        ///  
        /// </summary>
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

        /// <summary>
        /// The product description associated with the Spot Instance.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>Linux/UNIX, Linux/UNIX (Amazon VPC), Windows, Windows (Amazon VPC)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
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
        /// Any tags assigned to the resource.
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
