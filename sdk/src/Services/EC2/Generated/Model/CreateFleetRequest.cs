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
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-fleet.html">EC2
    /// Fleet</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateFleetRequest : AmazonEC2Request
    {
        private string _clientToken;
        private string _context;
        private FleetExcessCapacityTerminationPolicy _excessCapacityTerminationPolicy;
        private List<FleetLaunchTemplateConfigRequest> _launchTemplateConfigs = new List<FleetLaunchTemplateConfigRequest>();
        private OnDemandOptionsRequest _onDemandOptions;
        private bool? _replaceUnhealthyInstances;
        private SpotOptionsRequest _spotOptions;
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();
        private TargetCapacitySpecificationRequest _targetCapacitySpecification;
        private bool? _terminateInstancesWithExpiration;
        private FleetType _type;
        private DateTime? _validFromUtc;
        private DateTime? _validUntilUtc;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a>.
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
        /// Gets and sets the property ExcessCapacityTerminationPolicy. 
        /// <para>
        /// Indicates whether running instances should be terminated if the total target capacity
        /// of the EC2 Fleet is decreased below the current size of the EC2 Fleet.
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
        /// Gets and sets the property LaunchTemplateConfigs. 
        /// <para>
        /// The configuration for the EC2 Fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
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
        /// Gets and sets the property OnDemandOptions. 
        /// <para>
        /// Describes the configuration of On-Demand Instances in an EC2 Fleet.
        /// </para>
        /// </summary>
        public OnDemandOptionsRequest OnDemandOptions
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
        /// Describes the configuration of Spot Instances in an EC2 Fleet.
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
        /// The key-value pair for tagging the EC2 Fleet request on creation. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html#tag-resources">Tagging
        /// your resources</a>.
        /// </para>
        ///  
        /// <para>
        /// If the fleet type is <code>instant</code>, specify a resource type of <code>fleet</code>
        /// to tag the fleet or <code>instance</code> to tag the instances at launch.
        /// </para>
        ///  
        /// <para>
        /// If the fleet type is <code>maintain</code> or <code>request</code>, specify a resource
        /// type of <code>fleet</code> to tag the fleet. You cannot specify a resource type of
        /// <code>instance</code>. To tag instances at launch, specify the tags in a <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-templates.html#create-launch-template">launch
        /// template</a>.
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
        /// The number of units to request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The fleet type. The default value is <code>maintain</code>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>maintain</code> - The EC2 Fleet places an asynchronous request for your desired
        /// capacity, and continues to maintain your desired Spot capacity by replenishing interrupted
        /// Spot Instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>request</code> - The EC2 Fleet places an asynchronous one-time request for
        /// your desired capacity, but does submit Spot requests in alternative capacity pools
        /// if Spot capacity is unavailable, and does not maintain Spot capacity if Spot Instances
        /// are interrupted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>instant</code> - The EC2 Fleet places a synchronous one-time request for your
        /// desired capacity, and returns errors for any instances that could not be launched.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-fleet-request-type.html">EC2
        /// Fleet request types</a> in the <i>Amazon EC2 User Guide</i>.
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
        /// Gets and sets the property ValidFromUtc. 
        /// <para>
        /// The start date and time of the request, in UTC format (for example, <i>YYYY</i>-<i>MM</i>-<i>DD</i>T<i>HH</i>:<i>MM</i>:<i>SS</i>Z).
        /// The default is to start fulfilling the request immediately.
        /// </para>
        /// </summary>
        public DateTime ValidFromUtc
        {
            get { return this._validFromUtc.GetValueOrDefault(); }
            set { this._validFrom = this._validFromUtc = value; }
        }

        // Check to see if ValidFromUtc property is set
        internal bool IsSetValidFromUtc()
        {
            return this._validFromUtc.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ValidUntilUtc. 
        /// <para>
        /// The end date and time of the request, in UTC format (for example, <i>YYYY</i>-<i>MM</i>-<i>DD</i>T<i>HH</i>:<i>MM</i>:<i>SS</i>Z).
        /// At this point, no new EC2 Fleet requests are placed or able to fulfill the request.
        /// If no value is specified, the request remains until you cancel it.
        /// </para>
        /// </summary>
        public DateTime ValidUntilUtc
        {
            get { return this._validUntilUtc.GetValueOrDefault(); }
            set { this._validUntil = this._validUntilUtc = value; }
        }

        // Check to see if ValidUntilUtc property is set
        internal bool IsSetValidUntilUtc()
        {
            return this._validUntilUtc.HasValue; 
        }

#region Backwards compatible properties
        private DateTime? _validFrom;
        private DateTime? _validUntil;

        /// <summary>
        /// Gets and sets the property ValidFromUtc. 
        /// <para>
        /// This property is deprecated. Setting this property results in non-UTC DateTimes not
        /// being marshalled correctly. Use ValidFromUtc instead. Setting either ValidFrom or
        /// ValidFromUtc results in both ValidFrom and ValidFromUtc being assigned, the latest
        /// assignment to either one of the two property is reflected in the value of both. ValidFrom
        /// is provided for backwards compatibility only and assigning a non-Utc DateTime to it
        /// results in the wrong timestamp being passed to the service.
        /// </para>
        ///  
        /// <para>
        /// The start date and time of the request, in UTC format (for example, <i>YYYY</i>-<i>MM</i>-<i>DD</i>T<i>HH</i>:<i>MM</i>:<i>SS</i>Z).
        /// The default is to start fulfilling the request immediately.
        /// </para>
        /// </summary>
        [Obsolete("Setting this property results in non-UTC DateTimes not being marshalled correctly. " +
            "Use ValidFromUtc instead. Setting either ValidFrom or ValidFromUtc results in both ValidFrom and " +
            "ValidFromUtc being assigned, the latest assignment to either one of the two property is " + 
            "reflected in the value of both. ValidFrom is provided for backwards compatibility only and " +
            "assigning a non-Utc DateTime to it results in the wrong timestamp being passed to the service.", false)]
        public DateTime ValidFrom
        {
            get { return this._validFrom.GetValueOrDefault(); }
            set
            {
                this._validFrom = value;
                this._validFromUtc = new DateTime(value.Ticks, DateTimeKind.Utc);
            }
        }
        /// <summary>
        /// Gets and sets the property ValidUntilUtc. 
        /// <para>
        /// This property is deprecated. Setting this property results in non-UTC DateTimes not
        /// being marshalled correctly. Use ValidUntilUtc instead. Setting either ValidUntil or
        /// ValidUntilUtc results in both ValidUntil and ValidUntilUtc being assigned, the latest
        /// assignment to either one of the two property is reflected in the value of both. ValidUntil
        /// is provided for backwards compatibility only and assigning a non-Utc DateTime to it
        /// results in the wrong timestamp being passed to the service.
        /// </para>
        ///  
        /// <para>
        /// The end date and time of the request, in UTC format (for example, <i>YYYY</i>-<i>MM</i>-<i>DD</i>T<i>HH</i>:<i>MM</i>:<i>SS</i>Z).
        /// At this point, no new EC2 Fleet requests are placed or able to fulfill the request.
        /// If no value is specified, the request remains until you cancel it.
        /// </para>
        /// </summary>
        [Obsolete("Setting this property results in non-UTC DateTimes not being marshalled correctly. " +
            "Use ValidUntilUtc instead. Setting either ValidUntil or ValidUntilUtc results in both ValidUntil and " +
            "ValidUntilUtc being assigned, the latest assignment to either one of the two property is " + 
            "reflected in the value of both. ValidUntil is provided for backwards compatibility only and " +
            "assigning a non-Utc DateTime to it results in the wrong timestamp being passed to the service.", false)]
        public DateTime ValidUntil
        {
            get { return this._validUntil.GetValueOrDefault(); }
            set
            {
                this._validUntil = value;
                this._validUntilUtc = new DateTime(value.Ticks, DateTimeKind.Utc);
            }
        }
#endregion
    }
}