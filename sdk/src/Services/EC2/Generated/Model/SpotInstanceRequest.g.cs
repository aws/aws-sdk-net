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
    /// Describes a Spot Instance request.
    /// </summary>
    public partial class SpotInstanceRequest
    {
        /// <summary>
        /// Gets and sets the property ActualBlockHourlyPrice. 
        /// <para>
        /// Deprecated.
        /// </para>
        /// </summary>
        public string ActualBlockHourlyPrice { get; set; }

        /// <summary>
        /// Checks to see if the ActualBlockHourlyPrice property is set.
        /// </summary>
        internal bool IsSetActualBlockHourlyPrice() => this.ActualBlockHourlyPrice != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneGroup. 
        /// <para>
        /// The Availability Zone group. If you specify the same Availability Zone group for all
        /// Spot Instance requests, all Spot Instances are launched in the same Availability Zone.
        /// </para>
        /// </summary>
        public string AvailabilityZoneGroup { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneGroup property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneGroup() => this.AvailabilityZoneGroup != null;

        /// <summary>
        /// Gets and sets the property BlockDurationMinutes. 
        /// <para>
        /// Deprecated.
        /// </para>
        /// </summary>
        public int? BlockDurationMinutes { get; set; }

        /// <summary>
        /// Checks to see if the BlockDurationMinutes property is set.
        /// </summary>
        internal bool IsSetBlockDurationMinutes() => this.BlockDurationMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The date and time when the Spot Instance request was created, in UTC format (for example,
        /// <i>YYYY</i>-<i>MM</i>-<i>DD</i>T<i>HH</i>:<i>MM</i>:<i>SS</i>Z).
        /// </para>
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Fault. 
        /// <para>
        /// The fault codes for the Spot Instance request, if any.
        /// </para>
        /// </summary>
        public SpotInstanceStateFault Fault { get; set; }

        /// <summary>
        /// Checks to see if the Fault property is set.
        /// </summary>
        internal bool IsSetFault() => this.Fault != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The instance ID, if an instance has been launched to fulfill the Spot Instance request.
        /// </para>
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property InstanceInterruptionBehavior. 
        /// <para>
        /// The behavior when a Spot Instance is interrupted.
        /// </para>
        /// </summary>
        public InstanceInterruptionBehavior InstanceInterruptionBehavior { get; set; }

        /// <summary>
        /// Checks to see if the InstanceInterruptionBehavior property is set.
        /// </summary>
        internal bool IsSetInstanceInterruptionBehavior() => this.InstanceInterruptionBehavior != null;

        /// <summary>
        /// Gets and sets the property LaunchGroup. 
        /// <para>
        /// The instance launch group. Launch groups are Spot Instances that launch together and
        /// terminate together.
        /// </para>
        /// </summary>
        public string LaunchGroup { get; set; }

        /// <summary>
        /// Checks to see if the LaunchGroup property is set.
        /// </summary>
        internal bool IsSetLaunchGroup() => this.LaunchGroup != null;

        /// <summary>
        /// Gets and sets the property LaunchSpecification. 
        /// <para>
        /// Additional information for launching instances.
        /// </para>
        /// </summary>
        public LaunchSpecification LaunchSpecification { get; set; }

        /// <summary>
        /// Checks to see if the LaunchSpecification property is set.
        /// </summary>
        internal bool IsSetLaunchSpecification() => this.LaunchSpecification != null;

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
        public string LaunchedAvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the LaunchedAvailabilityZone property is set.
        /// </summary>
        internal bool IsSetLaunchedAvailabilityZone() => this.LaunchedAvailabilityZone != null;

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
        public string LaunchedAvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the LaunchedAvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetLaunchedAvailabilityZoneId() => this.LaunchedAvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property ProductDescription. 
        /// <para>
        /// The product description associated with the Spot Instance.
        /// </para>
        /// </summary>
        public RIProductDescription ProductDescription { get; set; }

        /// <summary>
        /// Checks to see if the ProductDescription property is set.
        /// </summary>
        internal bool IsSetProductDescription() => this.ProductDescription != null;

        /// <summary>
        /// Gets and sets the property SpotInstanceRequestId. 
        /// <para>
        /// The ID of the Spot Instance request.
        /// </para>
        /// </summary>
        public string SpotInstanceRequestId { get; set; }

        /// <summary>
        /// Checks to see if the SpotInstanceRequestId property is set.
        /// </summary>
        internal bool IsSetSpotInstanceRequestId() => this.SpotInstanceRequestId != null;

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
        public string SpotPrice { get; set; }

        /// <summary>
        /// Checks to see if the SpotPrice property is set.
        /// </summary>
        internal bool IsSetSpotPrice() => this.SpotPrice != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the Spot Instance request. Spot request status information helps track
        /// your Spot Instance requests. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-request-status.html">Spot
        /// request status</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public SpotInstanceState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status code and status message describing the Spot Instance request.
        /// </para>
        /// </summary>
        public SpotInstanceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the resource.
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The Spot Instance request type.
        /// </para>
        /// </summary>
        public SpotInstanceType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property ValidFrom. 
        /// <para>
        /// The start date of the request, in UTC format (for example, <i>YYYY</i>-<i>MM</i>-<i>DD</i>T<i>HH</i>:<i>MM</i>:<i>SS</i>Z).
        /// The request becomes active at this date and time.
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
        public DateTime? ValidUntil { get; set; }

        /// <summary>
        /// Checks to see if the ValidUntil property is set.
        /// </summary>
        internal bool IsSetValidUntil() => this.ValidUntil.HasValue;
    }
}
