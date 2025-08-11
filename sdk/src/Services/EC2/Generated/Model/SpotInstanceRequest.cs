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
    /// Describes a Spot Instance request.
    /// </summary>
    public partial class SpotInstanceRequest
    {
        private string _actualBlockHourlyPrice;
        private string _availabilityZoneGroup;
        private int? _blockDurationMinutes;
        private DateTime? _createTime;
        private SpotInstanceStateFault _fault;
        private string _instanceId;
        private InstanceInterruptionBehavior _instanceInterruptionBehavior;
        private string _launchedAvailabilityZone;
        private string _launchedAvailabilityZoneId;
        private string _launchGroup;
        private LaunchSpecification _launchSpecification;
        private RIProductDescription _productDescription;
        private string _spotInstanceRequestId;
        private string _spotPrice;
        private SpotInstanceState _state;
        private SpotInstanceStatus _status;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private SpotInstanceType _type;
        private DateTime? _validFrom;
        private DateTime? _validUntil;

        /// <summary>
        /// Gets and sets the property ActualBlockHourlyPrice. 
        /// <para>
        /// Deprecated.
        /// </para>
        /// </summary>
        public string ActualBlockHourlyPrice
        {
            get { return this._actualBlockHourlyPrice; }
            set { this._actualBlockHourlyPrice = value; }
        }

        // Check to see if ActualBlockHourlyPrice property is set
        internal bool IsSetActualBlockHourlyPrice()
        {
            return this._actualBlockHourlyPrice != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZoneGroup. 
        /// <para>
        /// The Availability Zone group. If you specify the same Availability Zone group for all
        /// Spot Instance requests, all Spot Instances are launched in the same Availability Zone.
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
        /// Deprecated.
        /// </para>
        /// </summary>
        public int? BlockDurationMinutes
        {
            get { return this._blockDurationMinutes; }
            set { this._blockDurationMinutes = value; }
        }

        // Check to see if BlockDurationMinutes property is set
        internal bool IsSetBlockDurationMinutes()
        {
            return this._blockDurationMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The date and time when the Spot Instance request was created, in UTC format (for example,
        /// <i>YYYY</i>-<i>MM</i>-<i>DD</i>T<i>HH</i>:<i>MM</i>:<i>SS</i>Z).
        /// </para>
        /// </summary>
        public DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Fault. 
        /// <para>
        /// The fault codes for the Spot Instance request, if any.
        /// </para>
        /// </summary>
        public SpotInstanceStateFault Fault
        {
            get { return this._fault; }
            set { this._fault = value; }
        }

        // Check to see if Fault property is set
        internal bool IsSetFault()
        {
            return this._fault != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The instance ID, if an instance has been launched to fulfill the Spot Instance request.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceInterruptionBehavior. 
        /// <para>
        /// The behavior when a Spot Instance is interrupted.
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
        /// Gets and sets the property LaunchedAvailabilityZone. 
        /// <para>
        /// The Availability Zone in which the request is launched.
        /// </para>
        ///  
        /// <para>
        /// Either <c>launchedAvailabilityZone</c> or <c>launchedAvailabilityZoneId</c> can be
        /// specified, but not both
        /// </para>
        /// </summary>
        public string LaunchedAvailabilityZone
        {
            get { return this._launchedAvailabilityZone; }
            set { this._launchedAvailabilityZone = value; }
        }

        // Check to see if LaunchedAvailabilityZone property is set
        internal bool IsSetLaunchedAvailabilityZone()
        {
            return this._launchedAvailabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchedAvailabilityZoneId. 
        /// <para>
        /// The ID of the Availability Zone in which the request is launched.
        /// </para>
        ///  
        /// <para>
        /// Either <c>launchedAvailabilityZone</c> or <c>launchedAvailabilityZoneId</c> can be
        /// specified, but not both
        /// </para>
        /// </summary>
        public string LaunchedAvailabilityZoneId
        {
            get { return this._launchedAvailabilityZoneId; }
            set { this._launchedAvailabilityZoneId = value; }
        }

        // Check to see if LaunchedAvailabilityZoneId property is set
        internal bool IsSetLaunchedAvailabilityZoneId()
        {
            return this._launchedAvailabilityZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchGroup. 
        /// <para>
        /// The instance launch group. Launch groups are Spot Instances that launch together and
        /// terminate together.
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
        /// Additional information for launching instances.
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
        /// Gets and sets the property ProductDescription. 
        /// <para>
        /// The product description associated with the Spot Instance.
        /// </para>
        /// </summary>
        public RIProductDescription ProductDescription
        {
            get { return this._productDescription; }
            set { this._productDescription = value; }
        }

        // Check to see if ProductDescription property is set
        internal bool IsSetProductDescription()
        {
            return this._productDescription != null;
        }

        /// <summary>
        /// Gets and sets the property SpotInstanceRequestId. 
        /// <para>
        /// The ID of the Spot Instance request.
        /// </para>
        /// </summary>
        public string SpotInstanceRequestId
        {
            get { return this._spotInstanceRequestId; }
            set { this._spotInstanceRequestId = value; }
        }

        // Check to see if SpotInstanceRequestId property is set
        internal bool IsSetSpotInstanceRequestId()
        {
            return this._spotInstanceRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property SpotPrice. 
        /// <para>
        /// The maximum price per unit hour that you are willing to pay for a Spot Instance. We
        /// do not recommend using this parameter because it can lead to increased interruptions.
        /// If you do not specify this parameter, you will pay the current Spot price.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you specify a maximum price, your instances will be interrupted more frequently
        /// than if you do not specify this parameter.
        /// </para>
        ///  </important>
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
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the Spot Instance request. Spot request status information helps track
        /// your Spot Instance requests. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-request-status.html">Spot
        /// request status</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public SpotInstanceState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status code and status message describing the Spot Instance request.
        /// </para>
        /// </summary>
        public SpotInstanceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The Spot Instance request type.
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
        /// The start date of the request, in UTC format (for example, <i>YYYY</i>-<i>MM</i>-<i>DD</i>T<i>HH</i>:<i>MM</i>:<i>SS</i>Z).
        /// The request becomes active at this date and time.
        /// </para>
        /// </summary>
        public DateTime? ValidFrom
        {
            get { return this._validFrom; }
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
        /// The end date of the request, in UTC format (<i>YYYY</i>-<i>MM</i>-<i>DD</i>T<i>HH</i>:<i>MM</i>:<i>SS</i>Z).
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For a persistent request, the request remains active until the <c>validUntil</c> date
        /// and time is reached. Otherwise, the request remains active until you cancel it. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For a one-time request, the request remains active until all instances launch, the
        /// request is canceled, or the <c>validUntil</c> date and time is reached. By default,
        /// the request is valid for 7 days from the date the request was created.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DateTime? ValidUntil
        {
            get { return this._validUntil; }
            set { this._validUntil = value; }
        }

        // Check to see if ValidUntil property is set
        internal bool IsSetValidUntil()
        {
            return this._validUntil.HasValue; 
        }

    }
}