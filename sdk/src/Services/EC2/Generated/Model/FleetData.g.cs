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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Describes an EC2 Fleet.
    /// </summary>
    public partial class FleetData
    {
        /// <summary>
        /// Gets and sets the property ActivityStatus. 
        /// <para>
        /// The progress of the EC2 Fleet.
        /// </para>
        ///  
        /// <para>
        /// For fleets of type <c>instant</c>, the status is <c>fulfilled</c> after all requests
        /// are placed, regardless of whether target capacity is met (this is the only possible
        /// status for <c>instant</c> fleets).
        /// </para>
        ///  
        /// <para>
        /// For fleets of type <c>request</c> or <c>maintain</c>, the status is <c>pending_fulfillment</c>
        /// after all requests are placed, <c>fulfilled</c> when the fleet size meets or exceeds
        /// target capacity, <c>pending_termination</c> while instances are terminating when fleet
        /// size is decreased, and <c>error</c> if there's an error.
        /// </para>
        /// </summary>
        public FleetActivityStatus ActivityStatus { get; set; }

        /// <summary>
        /// Checks to see if the ActivityStatus property is set.
        /// </summary>
        internal bool IsSetActivityStatus() => this.ActivityStatus != null;

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
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// Reserved.
        /// </para>
        /// </summary>
        public string Context { get; set; }

        /// <summary>
        /// Checks to see if the Context property is set.
        /// </summary>
        internal bool IsSetContext() => this.Context != null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The creation date and time of the EC2 Fleet.
        /// </para>
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// Information about the instances that could not be launched by the fleet. Valid only
        /// when <b>Type</b> is set to <c>instant</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DescribeFleetError> Errors { get; set; } = AWSConfigs.InitializeCollections ? new List<DescribeFleetError>() : null;

        /// <summary>
        /// Checks to see if the Errors property is set.
        /// </summary>
        internal bool IsSetErrors() => this.Errors != null && (this.Errors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExcessCapacityTerminationPolicy. 
        /// <para>
        /// Indicates whether running instances should be terminated if the target capacity of
        /// the EC2 Fleet is decreased below the current size of the EC2 Fleet.
        /// </para>
        ///  
        /// <para>
        /// Supported only for fleets of type <c>maintain</c>.
        /// </para>
        /// </summary>
        public FleetExcessCapacityTerminationPolicy ExcessCapacityTerminationPolicy { get; set; }

        /// <summary>
        /// Checks to see if the ExcessCapacityTerminationPolicy property is set.
        /// </summary>
        internal bool IsSetExcessCapacityTerminationPolicy() => this.ExcessCapacityTerminationPolicy != null;

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// The ID of the EC2 Fleet.
        /// </para>
        /// </summary>
        public string FleetId { get; set; }

        /// <summary>
        /// Checks to see if the FleetId property is set.
        /// </summary>
        internal bool IsSetFleetId() => this.FleetId != null;

        /// <summary>
        /// Gets and sets the property FleetState. 
        /// <para>
        /// The state of the EC2 Fleet.
        /// </para>
        /// </summary>
        public FleetStateCode FleetState { get; set; }

        /// <summary>
        /// Checks to see if the FleetState property is set.
        /// </summary>
        internal bool IsSetFleetState() => this.FleetState != null;

        /// <summary>
        /// Gets and sets the property FulfilledCapacity. 
        /// <para>
        /// The number of units fulfilled by this request compared to the set target capacity.
        /// </para>
        /// </summary>
        public double? FulfilledCapacity { get; set; }

        /// <summary>
        /// Checks to see if the FulfilledCapacity property is set.
        /// </summary>
        internal bool IsSetFulfilledCapacity() => this.FulfilledCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property FulfilledOnDemandCapacity. 
        /// <para>
        /// The number of units fulfilled by this request compared to the set target On-Demand
        /// capacity.
        /// </para>
        /// </summary>
        public double? FulfilledOnDemandCapacity { get; set; }

        /// <summary>
        /// Checks to see if the FulfilledOnDemandCapacity property is set.
        /// </summary>
        internal bool IsSetFulfilledOnDemandCapacity() => this.FulfilledOnDemandCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property Instances. 
        /// <para>
        /// Information about the instances that were launched by the fleet. Valid only when <b>Type</b>
        /// is set to <c>instant</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DescribeFleetsInstances> Instances { get; set; } = AWSConfigs.InitializeCollections ? new List<DescribeFleetsInstances>() : null;

        /// <summary>
        /// Checks to see if the Instances property is set.
        /// </summary>
        internal bool IsSetInstances() => this.Instances != null && (this.Instances.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LaunchTemplateConfigs. 
        /// <para>
        /// The launch template and overrides.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FleetLaunchTemplateConfig> LaunchTemplateConfigs { get; set; } = AWSConfigs.InitializeCollections ? new List<FleetLaunchTemplateConfig>() : null;

        /// <summary>
        /// Checks to see if the LaunchTemplateConfigs property is set.
        /// </summary>
        internal bool IsSetLaunchTemplateConfigs() => this.LaunchTemplateConfigs != null && (this.LaunchTemplateConfigs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OnDemandOptions. 
        /// <para>
        /// The allocation strategy of On-Demand Instances in an EC2 Fleet.
        /// </para>
        /// </summary>
        public OnDemandOptions OnDemandOptions { get; set; }

        /// <summary>
        /// Checks to see if the OnDemandOptions property is set.
        /// </summary>
        internal bool IsSetOnDemandOptions() => this.OnDemandOptions != null;

        /// <summary>
        /// Gets and sets the property ReplaceUnhealthyInstances. 
        /// <para>
        /// Indicates whether EC2 Fleet should replace unhealthy Spot Instances. Supported only
        /// for fleets of type <c>maintain</c>. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/manage-ec2-fleet.html#ec2-fleet-health-checks">EC2
        /// Fleet health checks</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public bool? ReplaceUnhealthyInstances { get; set; }

        /// <summary>
        /// Checks to see if the ReplaceUnhealthyInstances property is set.
        /// </summary>
        internal bool IsSetReplaceUnhealthyInstances() => this.ReplaceUnhealthyInstances.HasValue;

        /// <summary>
        /// Gets and sets the property ReservedCapacityOptions. 
        /// <para>
        /// Defines EC2 Fleet preferences for utilizing reserved capacity when DefaultTargetCapacityType
        /// is set to <c>reserved-capacity</c>.
        /// </para>
        /// </summary>
        public ReservedCapacityOptions ReservedCapacityOptions { get; set; }

        /// <summary>
        /// Checks to see if the ReservedCapacityOptions property is set.
        /// </summary>
        internal bool IsSetReservedCapacityOptions() => this.ReservedCapacityOptions != null;

        /// <summary>
        /// Gets and sets the property SpotOptions. 
        /// <para>
        /// The configuration of Spot Instances in an EC2 Fleet.
        /// </para>
        /// </summary>
        public SpotOptions SpotOptions { get; set; }

        /// <summary>
        /// Checks to see if the SpotOptions property is set.
        /// </summary>
        internal bool IsSetSpotOptions() => this.SpotOptions != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for an EC2 Fleet resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetCapacitySpecification. 
        /// <para>
        /// The number of units to request. You can choose to set the target capacity in terms
        /// of instances or a performance characteristic that is important to your application
        /// workload, such as vCPUs, memory, or I/O. If the request type is <c>maintain</c>, you
        /// can specify a target capacity of 0 and add capacity later.
        /// </para>
        /// </summary>
        public TargetCapacitySpecification TargetCapacitySpecification { get; set; }

        /// <summary>
        /// Checks to see if the TargetCapacitySpecification property is set.
        /// </summary>
        internal bool IsSetTargetCapacitySpecification() => this.TargetCapacitySpecification != null;

        /// <summary>
        /// Gets and sets the property TerminateInstancesWithExpiration. 
        /// <para>
        /// Indicates whether running instances should be terminated when the EC2 Fleet expires.
        /// 
        /// </para>
        /// </summary>
        public bool? TerminateInstancesWithExpiration { get; set; }

        /// <summary>
        /// Checks to see if the TerminateInstancesWithExpiration property is set.
        /// </summary>
        internal bool IsSetTerminateInstancesWithExpiration() => this.TerminateInstancesWithExpiration.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of request. Indicates whether the EC2 Fleet only <c>requests</c> the target
        /// capacity, or also attempts to <c>maintain</c> it. If you request a certain target
        /// capacity, EC2 Fleet only places the required requests; it does not attempt to replenish
        /// instances if capacity is diminished, and it does not submit requests in alternative
        /// capacity pools if capacity is unavailable. To maintain a certain target capacity,
        /// EC2 Fleet places the required requests to meet this target capacity. It also automatically
        /// replenishes any interrupted Spot Instances. Default: <c>maintain</c>.
        /// </para>
        /// </summary>
        public FleetType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property ValidFrom. 
        /// <para>
        /// The start date and time of the request, in UTC format (for example, <i>YYYY</i>-<i>MM</i>-<i>DD</i>T<i>HH</i>:<i>MM</i>:<i>SS</i>Z).
        /// The default is to start fulfilling the request immediately. 
        /// </para>
        /// </summary>
        public DateTime? ValidFrom { get; set; }

        /// <summary>
        /// Checks to see if the ValidFrom property is set.
        /// </summary>
        internal bool IsSetValidFrom() => this.ValidFrom.HasValue;

        /// <summary>
        /// Gets and sets the property ValidUntil. 
        /// <para>
        /// The end date and time of the request, in UTC format (for example, <i>YYYY</i>-<i>MM</i>-<i>DD</i>T<i>HH</i>:<i>MM</i>:<i>SS</i>Z).
        /// At this point, no new instance requests are placed or able to fulfill the request.
        /// The default end date is 7 days from the current date. 
        /// </para>
        /// </summary>
        public DateTime? ValidUntil { get; set; }

        /// <summary>
        /// Checks to see if the ValidUntil property is set.
        /// </summary>
        internal bool IsSetValidUntil() => this.ValidUntil.HasValue;
    }
}
