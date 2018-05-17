/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the RequestSpotInstances operation.
    /// Creates a Spot Instance request.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-requests.html">Spot
    /// Instance Requests</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
    /// </para>
    /// </summary>
    public partial class RequestSpotInstancesRequest : AmazonEC2Request
    {
        private string _availabilityZoneGroup;
        private int? _blockDurationMinutes;
        private string _clientToken;
        private int? _instanceCount;
        private InstanceInterruptionBehavior _instanceInterruptionBehavior;
        private string _launchGroup;
        private LaunchSpecification _launchSpecification;
        private string _spotPrice;
        private SpotInstanceType _type;
        private DateTime? _validFrom;
        private DateTime? _validUntil;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public RequestSpotInstancesRequest() { }

        /// <summary>
        /// Instantiates RequestSpotInstancesRequest with the parameterized properties
        /// </summary>
        /// <param name="spotPrice">The maximum price per hour that you are willing to pay for a Spot Instance. The default is the On-Demand price.</param>
        public RequestSpotInstancesRequest(string spotPrice)
        {
            _spotPrice = spotPrice;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZoneGroup. 
        /// <para>
        /// The user-specified name for a logical grouping of requests.
        /// </para>
        ///  
        /// <para>
        /// When you specify an Availability Zone group in a Spot Instance request, all Spot Instances
        /// in the request are launched in the same Availability Zone. Instance proximity is maintained
        /// with this parameter, but the choice of Availability Zone is not. The group applies
        /// only to requests for Spot Instances of the same instance type. Any additional Spot
        /// Instance requests that are specified with the same Availability Zone group name are
        /// launched in that same Availability Zone, as long as at least one instance from the
        /// group is still active.
        /// </para>
        ///  
        /// <para>
        /// If there is no active instance running in the Availability Zone group that you specify
        /// for a new Spot Instance request (all instances are terminated, the request is expired,
        /// or the maximum price you specified falls below current Spot price), then Amazon EC2
        /// launches the instance in any Availability Zone where the constraint can be met. Consequently,
        /// the subsequent set of Spot Instances could be placed in a different zone from the
        /// original request, even if you specified the same Availability Zone group.
        /// </para>
        ///  
        /// <para>
        /// Default: Instances are launched in any available Availability Zone.
        /// </para>
        /// </summary>
        public string AvailabilityZoneGroup
        {
            get { return this._availabilityZoneGroup; }
            set { this._availabilityZoneGroup = value; }
        }

        // Check to see if AvailabilityZoneGroup property is set
        internal bool IsSetAvailabilityZoneGroup()
        {
            return this._availabilityZoneGroup != null;
        }

        /// <summary>
        /// Gets and sets the property BlockDurationMinutes. 
        /// <para>
        /// The required duration for the Spot Instances (also known as Spot blocks), in minutes.
        /// This value must be a multiple of 60 (60, 120, 180, 240, 300, or 360).
        /// </para>
        ///  
        /// <para>
        /// The duration period starts as soon as your Spot Instance receives its instance ID.
        /// At the end of the duration period, Amazon EC2 marks the Spot Instance for termination
        /// and provides a Spot Instance termination notice, which gives the instance a two-minute
        /// warning before it terminates.
        /// </para>
        ///  
        /// <para>
        /// You can't specify an Availability Zone group or a launch group if you specify a duration.
        /// </para>
        /// </summary>
        public int BlockDurationMinutes
        {
            get { return this._blockDurationMinutes.GetValueOrDefault(); }
            set { this._blockDurationMinutes = value; }
        }

        // Check to see if BlockDurationMinutes property is set
        internal bool IsSetBlockDurationMinutes()
        {
            return this._blockDurationMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Run_Instance_Idempotency.html">How
        /// to Ensure Idempotency</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
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
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The maximum number of Spot Instances to launch.
        /// </para>
        ///  
        /// <para>
        /// Default: 1
        /// </para>
        /// </summary>
        public int InstanceCount
        {
            get { return this._instanceCount.GetValueOrDefault(); }
            set { this._instanceCount = value; }
        }

        // Check to see if InstanceCount property is set
        internal bool IsSetInstanceCount()
        {
            return this._instanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceInterruptionBehavior. 
        /// <para>
        /// The behavior when a Spot Instance is interrupted. The default is <code>terminate</code>.
        /// </para>
        /// </summary>
        public InstanceInterruptionBehavior InstanceInterruptionBehavior
        {
            get { return this._instanceInterruptionBehavior; }
            set { this._instanceInterruptionBehavior = value; }
        }

        // Check to see if InstanceInterruptionBehavior property is set
        internal bool IsSetInstanceInterruptionBehavior()
        {
            return this._instanceInterruptionBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchGroup. 
        /// <para>
        /// The instance launch group. Launch groups are Spot Instances that launch together and
        /// terminate together.
        /// </para>
        ///  
        /// <para>
        /// Default: Instances are launched and terminated individually
        /// </para>
        /// </summary>
        public string LaunchGroup
        {
            get { return this._launchGroup; }
            set { this._launchGroup = value; }
        }

        // Check to see if LaunchGroup property is set
        internal bool IsSetLaunchGroup()
        {
            return this._launchGroup != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchSpecification. 
        /// <para>
        /// The launch specification.
        /// </para>
        /// </summary>
        public LaunchSpecification LaunchSpecification
        {
            get { return this._launchSpecification; }
            set { this._launchSpecification = value; }
        }

        // Check to see if LaunchSpecification property is set
        internal bool IsSetLaunchSpecification()
        {
            return this._launchSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property SpotPrice. 
        /// <para>
        /// The maximum price per hour that you are willing to pay for a Spot Instance. The default
        /// is the On-Demand price.
        /// </para>
        /// </summary>
        public string SpotPrice
        {
            get { return this._spotPrice; }
            set { this._spotPrice = value; }
        }

        // Check to see if SpotPrice property is set
        internal bool IsSetSpotPrice()
        {
            return this._spotPrice != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The Spot Instance request type.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>one-time</code> 
        /// </para>
        /// </summary>
        public SpotInstanceType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property ValidFrom. 
        /// <para>
        /// The start date of the request. If this is a one-time request, the request becomes
        /// active at this date and time and remains active until all instances launch, the request
        /// expires, or the request is canceled. If the request is persistent, the request becomes
        /// active at this date and time and remains active until it expires or is canceled.
        /// </para>
        /// </summary>
        public DateTime ValidFrom
        {
            get { return this._validFrom.GetValueOrDefault(); }
            set { this._validFrom = value; }
        }

        // Check to see if ValidFrom property is set
        internal bool IsSetValidFrom()
        {
            return this._validFrom.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ValidUntil. 
        /// <para>
        /// The end date of the request. If this is a one-time request, the request remains active
        /// until all instances launch, the request is canceled, or this date is reached. If the
        /// request is persistent, it remains active until it is canceled or this date is reached.
        /// The default end date is 7 days from the current date.
        /// </para>
        /// </summary>
        public DateTime ValidUntil
        {
            get { return this._validUntil.GetValueOrDefault(); }
            set { this._validUntil = value; }
        }

        // Check to see if ValidUntil property is set
        internal bool IsSetValidUntil()
        {
            return this._validUntil.HasValue; 
        }

    }
}