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
    /// Container for the parameters to the CreateFleet operation.
    /// Launches an EC2 Fleet.
    /// 
    ///  
    /// <para>
    /// You can create a single EC2 Fleet that includes multiple launch specifications that
    /// vary by instance type, AMI, Availability Zone, or subnet.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-fleet.html">Launching
    /// an EC2 Fleet</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateFleetRequest : AmazonEC2Request
    {
        private string _clientToken;
        private FleetExcessCapacityTerminationPolicy _excessCapacityTerminationPolicy;
        private List<FleetLaunchTemplateConfigRequest> _launchTemplateConfigs = new List<FleetLaunchTemplateConfigRequest>();
        private bool? _replaceUnhealthyInstances;
        private SpotOptionsRequest _spotOptions;
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();
        private TargetCapacitySpecificationRequest _targetCapacitySpecification;
        private bool? _terminateInstancesWithExpiration;
        private FleetType _type;
        private DateTime? _validFrom;
        private DateTime? _validUntil;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier you provide to ensure the idempotency of the request.
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// Idempotency</a>.
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
        /// Gets and sets the property ExcessCapacityTerminationPolicy. 
        /// <para>
        /// Indicates whether running instances should be terminated if the total target capacity
        /// of the EC2 Fleet is decreased below the current size of the EC2 Fleet.
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
        /// Gets and sets the property LaunchTemplateConfigs. 
        /// <para>
        /// The configuration for the EC2 Fleet.
        /// </para>
        /// </summary>
        public List<FleetLaunchTemplateConfigRequest> LaunchTemplateConfigs
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
        /// Gets and sets the property ReplaceUnhealthyInstances. 
        /// <para>
        /// Indicates whether EC2 Fleet should replace unhealthy instances.
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
        /// Includes <code>SpotAllocationStrategy</code> and <code>SpotInstanceInterruptionBehavior</code>
        /// inside this structure.
        /// </para>
        /// </summary>
        public SpotOptionsRequest SpotOptions
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
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags for an EC2 Fleet resource.
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && this._tagSpecifications.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetCapacitySpecification. 
        /// <para>
        /// The <code>TotalTargetCapacity</code>, <code>OnDemandTargetCapacity</code>, <code>SpotTargetCapacity</code>,
        /// and <code>DefaultCapacityType</code> structure.
        /// </para>
        /// </summary>
        public TargetCapacitySpecificationRequest TargetCapacitySpecification
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
        /// target capacity, EC2 Fleet only places the required requests. It does not attempt
        /// to replenish instances if capacity is diminished, and does not submit requests in
        /// alternative capacity pools if capacity is unavailable. To maintain a certain target
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
        /// At this point, no new EC2 Fleet requests are placed or able to fulfill the request.
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