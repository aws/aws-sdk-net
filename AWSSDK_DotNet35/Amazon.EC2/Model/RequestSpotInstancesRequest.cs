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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the RequestSpotInstances operation.
    /// <para>Creates a Spot Instance request. Spot Instances are instances that Amazon EC2 starts on your behalf when the maximum price that you
    /// specify exceeds the current Spot Price. Amazon EC2 periodically sets the Spot Price based on available Spot Instance capacity and current
    /// Spot Instance requests. For more information about Spot Instances, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html" >Spot Instances</a> in the <i>Amazon Elastic Compute
    /// Cloud User Guide</i> .</para>
    /// </summary>
    public partial class RequestSpotInstancesRequest : AmazonEC2Request
    {
        private string spotPrice;
        private int? instanceCount;
        private SpotInstanceType type;
        private DateTime? validFrom;
        private DateTime? validUntil;
        private string launchGroup;
        private string availabilityZoneGroup;
        private LaunchSpecification launchSpecification;


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
        /// The maximum number of Spot Instances to launch. Default: 1
        ///  
        /// </summary>
        public int InstanceCount
        {
            get { return this.instanceCount ?? default(int); }
            set { this.instanceCount = value; }
        }

        // Check to see if InstanceCount property is set
        internal bool IsSetInstanceCount()
        {
            return this.instanceCount.HasValue;
        }

        /// <summary>
        /// The Spot Instance request type. Default: <c>one-time</c>
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
        /// The start date of the request. If this is a one-time request, the request becomes active at this date and time and remains active until all
        /// instances launch, the request expires, or the request is canceled. If the request is persistent, the request becomes active at this date and
        /// time and remains active until it expires or is canceled. Default: The request is effective indefinitely.
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
        /// or this date is reached. If the request is persistent, it remains active until it is canceled or this date and time is reached. Default: The
        /// request is effective indefinitely.
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
        /// The instance launch group. Launch groups are Spot Instances that launch together and terminate together. Default: Instances are launched and
        /// terminated individually
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
        /// The user-specified name for a logical grouping of bids. When you specify an Availability Zone group in a Spot Instance request, all Spot
        /// Instances in the request are launched in the same Availability Zone. Instance proximity is maintained with this parameter, but the choice of
        /// Availability Zone is not. The group applies only to bids for Spot Instances of the same instance type. Any additional Spot Instance requests
        /// that are specified with the same Availability Zone group name are launched in that same Availability Zone, as long as at least one instance
        /// from the group is still active. If there is no active instance running in the Availability Zone group that you specify for a new Spot
        /// Instance request (all instances are terminated, the bid is expired, or the bid falls below current market), then Amazon EC2 launches the
        /// instance in any Availability Zone where the constraint can be met. Consequently, the subsequent set of Spot Instances could be placed in a
        /// different zone from the original request, even if you specified the same Availability Zone group. Default: Instances are launched in any
        /// available Availability Zone.
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
        /// The launch specification.
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

    }
}
    
