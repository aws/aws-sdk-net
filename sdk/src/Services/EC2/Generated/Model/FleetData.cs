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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes an EC2 Fleet.
    /// </summary>
    public partial class FleetData
    {
        private FleetActivityStatus _activityStatus;
        private string _clientToken;
        private string _context;
        private DateTime? _createTime;
        private List<DescribeFleetError> _errors = new List<DescribeFleetError>();
        private FleetExcessCapacityTerminationPolicy _excessCapacityTerminationPolicy;
        private string _fleetId;
        private FleetStateCode _fleetState;
        private double? _fulfilledCapacity;
        private double? _fulfilledOnDemandCapacity;
        private List<DescribeFleetsInstances> _instances = new List<DescribeFleetsInstances>();
        private List<FleetLaunchTemplateConfig> _launchTemplateConfigs = new List<FleetLaunchTemplateConfig>();
        private OnDemandOptions _onDemandOptions;
        private bool? _replaceUnhealthyInstances;
        private SpotOptions _spotOptions;
        private List<Tag> _tags = new List<Tag>();
        private TargetCapacitySpecification _targetCapacitySpecification;
        private bool? _terminateInstancesWithExpiration;
        private FleetType _type;
        private DateTime? _validFrom;
        private DateTime? _validUntil;

        /// <summary>
        /// Gets and sets the property ActivityStatus. 
        /// <para>
        /// The progress of the EC2 Fleet. If there is an error, the status is <code>error</code>.
        /// After all requests are placed, the status is <code>pending_fulfillment</code>. If
        /// the size of the EC2 Fleet is equal to or greater than its target capacity, the status
        /// is <code>fulfilled</code>. If the size of the EC2 Fleet is decreased, the status is
        /// <code>pending_termination</code> while instances are terminating.
        /// </para>
        /// </summary>
        public FleetActivityStatus ActivityStatus
        {
            get { return this._activityStatus; }
            set { this._activityStatus = value; }
        }

        // Check to see if ActivityStatus property is set
        internal bool IsSetActivityStatus()
        {
            return this._activityStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Maximum 64 ASCII characters
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
        /// Gets and sets the property Context. 
        /// <para>
        /// Reserved.
        /// </para>
        /// </summary>
        public string Context
        {
            get { return this._context; }
            set { this._context = value; }
        }

        // Check to see if Context property is set
        internal bool IsSetContext()
        {
            return this._context != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The creation date and time of the EC2 Fleet.
        /// </para>
        /// </summary>
        public DateTime CreateTime
        {
            get { return this._createTime.GetValueOrDefault(); }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// Information about the instances that could not be launched by the fleet. Valid only
        /// when <b>Type</b> is set to <code>instant</code>.
        /// </para>
        /// </summary>
        public List<DescribeFleetError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && this._errors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ExcessCapacityTerminationPolicy. 
        /// <para>
        /// Indicates whether running instances should be terminated if the target capacity of
        /// the EC2 Fleet is decreased below the current size of the EC2 Fleet.
        /// </para>
        ///  
        /// <para>
        /// Supported only for fleets of type <code>maintain</code>.
        /// </para>
        /// </summary>
        public FleetExcessCapacityTerminationPolicy ExcessCapacityTerminationPolicy
        {
            get { return this._excessCapacityTerminationPolicy; }
            set { this._excessCapacityTerminationPolicy = value; }
        }

        // Check to see if ExcessCapacityTerminationPolicy property is set
        internal bool IsSetExcessCapacityTerminationPolicy()
        {
            return this._excessCapacityTerminationPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// The ID of the EC2 Fleet.
        /// </para>
        /// </summary>
        public string FleetId
        {
            get { return this._fleetId; }
            set { this._fleetId = value; }
        }

        // Check to see if FleetId property is set
        internal bool IsSetFleetId()
        {
            return this._fleetId != null;
        }

        /// <summary>
        /// Gets and sets the property FleetState. 
        /// <para>
        /// The state of the EC2 Fleet.
        /// </para>
        /// </summary>
        public FleetStateCode FleetState
        {
            get { return this._fleetState; }
            set { this._fleetState = value; }
        }

        // Check to see if FleetState property is set
        internal bool IsSetFleetState()
        {
            return this._fleetState != null;
        }

        /// <summary>
        /// Gets and sets the property FulfilledCapacity. 
        /// <para>
        /// The number of units fulfilled by this request compared to the set target capacity.
        /// </para>
        /// </summary>
        public double FulfilledCapacity
        {
            get { return this._fulfilledCapacity.GetValueOrDefault(); }
            set { this._fulfilledCapacity = value; }
        }

        // Check to see if FulfilledCapacity property is set
        internal bool IsSetFulfilledCapacity()
        {
            return this._fulfilledCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FulfilledOnDemandCapacity. 
        /// <para>
        /// The number of units fulfilled by this request compared to the set target On-Demand
        /// capacity.
        /// </para>
        /// </summary>
        public double FulfilledOnDemandCapacity
        {
            get { return this._fulfilledOnDemandCapacity.GetValueOrDefault(); }
            set { this._fulfilledOnDemandCapacity = value; }
        }

        // Check to see if FulfilledOnDemandCapacity property is set
        internal bool IsSetFulfilledOnDemandCapacity()
        {
            return this._fulfilledOnDemandCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Instances. 
        /// <para>
        /// Information about the instances that were launched by the fleet. Valid only when <b>Type</b>
        /// is set to <code>instant</code>.
        /// </para>
        /// </summary>
        public List<DescribeFleetsInstances> Instances
        {
            get { return this._instances; }
            set { this._instances = value; }
        }

        // Check to see if Instances property is set
        internal bool IsSetInstances()
        {
            return this._instances != null && this._instances.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LaunchTemplateConfigs. 
        /// <para>
        /// The launch template and overrides.
        /// </para>
        /// </summary>
        public List<FleetLaunchTemplateConfig> LaunchTemplateConfigs
        {
            get { return this._launchTemplateConfigs; }
            set { this._launchTemplateConfigs = value; }
        }

        // Check to see if LaunchTemplateConfigs property is set
        internal bool IsSetLaunchTemplateConfigs()
        {
            return this._launchTemplateConfigs != null && this._launchTemplateConfigs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OnDemandOptions. 
        /// <para>
        /// The allocation strategy of On-Demand Instances in an EC2 Fleet.
        /// </para>
        /// </summary>
        public OnDemandOptions OnDemandOptions
        {
            get { return this._onDemandOptions; }
            set { this._onDemandOptions = value; }
        }

        // Check to see if OnDemandOptions property is set
        internal bool IsSetOnDemandOptions()
        {
            return this._onDemandOptions != null;
        }

        /// <summary>
        /// Gets and sets the property ReplaceUnhealthyInstances. 
        /// <para>
        /// Indicates whether EC2 Fleet should replace unhealthy Spot Instances. Supported only
        /// for fleets of type <code>maintain</code>. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/manage-ec2-fleet.html#ec2-fleet-health-checks">EC2
        /// Fleet health checks</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public bool ReplaceUnhealthyInstances
        {
            get { return this._replaceUnhealthyInstances.GetValueOrDefault(); }
            set { this._replaceUnhealthyInstances = value; }
        }

        // Check to see if ReplaceUnhealthyInstances property is set
        internal bool IsSetReplaceUnhealthyInstances()
        {
            return this._replaceUnhealthyInstances.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SpotOptions. 
        /// <para>
        /// The configuration of Spot Instances in an EC2 Fleet.
        /// </para>
        /// </summary>
        public SpotOptions SpotOptions
        {
            get { return this._spotOptions; }
            set { this._spotOptions = value; }
        }

        // Check to see if SpotOptions property is set
        internal bool IsSetSpotOptions()
        {
            return this._spotOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for an EC2 Fleet resource.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetCapacitySpecification. 
        /// <para>
        /// The number of units to request. You can choose to set the target capacity in terms
        /// of instances or a performance characteristic that is important to your application
        /// workload, such as vCPUs, memory, or I/O. If the request type is <code>maintain</code>,
        /// you can specify a target capacity of 0 and add capacity later.
        /// </para>
        /// </summary>
        public TargetCapacitySpecification TargetCapacitySpecification
        {
            get { return this._targetCapacitySpecification; }
            set { this._targetCapacitySpecification = value; }
        }

        // Check to see if TargetCapacitySpecification property is set
        internal bool IsSetTargetCapacitySpecification()
        {
            return this._targetCapacitySpecification != null;
        }

        /// <summary>
        /// Gets and sets the property TerminateInstancesWithExpiration. 
        /// <para>
        /// Indicates whether running instances should be terminated when the EC2 Fleet expires.
        /// 
        /// </para>
        /// </summary>
        public bool TerminateInstancesWithExpiration
        {
            get { return this._terminateInstancesWithExpiration.GetValueOrDefault(); }
            set { this._terminateInstancesWithExpiration = value; }
        }

        // Check to see if TerminateInstancesWithExpiration property is set
        internal bool IsSetTerminateInstancesWithExpiration()
        {
            return this._terminateInstancesWithExpiration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of request. Indicates whether the EC2 Fleet only <code>requests</code> the
        /// target capacity, or also attempts to <code>maintain</code> it. If you request a certain
        /// target capacity, EC2 Fleet only places the required requests; it does not attempt
        /// to replenish instances if capacity is diminished, and it does not submit requests
        /// in alternative capacity pools if capacity is unavailable. To maintain a certain target
        /// capacity, EC2 Fleet places the required requests to meet this target capacity. It
        /// also automatically replenishes any interrupted Spot Instances. Default: <code>maintain</code>.
        /// </para>
        /// </summary>
        public FleetType Type
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
        /// The start date and time of the request, in UTC format (for example, <i>YYYY</i>-<i>MM</i>-<i>DD</i>T<i>HH</i>:<i>MM</i>:<i>SS</i>Z).
        /// The default is to start fulfilling the request immediately. 
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
        /// The end date and time of the request, in UTC format (for example, <i>YYYY</i>-<i>MM</i>-<i>DD</i>T<i>HH</i>:<i>MM</i>:<i>SS</i>Z).
        /// At this point, no new instance requests are placed or able to fulfill the request.
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