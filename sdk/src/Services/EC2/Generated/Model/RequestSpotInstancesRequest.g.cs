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
    /// Container for the parameters to the RequestSpotInstances operation. Creates a Spot
    /// Instance request. <para> For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-requests.html">Work
    /// with Spot Instance</a> in the <i>Amazon EC2 User Guide</i>. </para> <important> <para>
    /// We strongly discourage using the RequestSpotInstances API because it is a legacy API
    /// with no planned investment. For options for requesting Spot Instances, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-best-practices.html#which-spot-request-method-to-use">Which
    /// is the best Spot request method to use?</a> in the <i>Amazon EC2 User Guide</i>. </para>
    /// </important>
    /// </summary>
    public partial class RequestSpotInstancesRequest : AmazonEC2Request
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public RequestSpotInstancesRequest() { }

        /// <summary>
        /// Instantiates RequestSpotInstancesRequest with the parameterized properties
        /// </summary>
        /// <param name="spotPrice">The maximum price per unit hour that you are willing to pay for a Spot Instance. We do not recommend    using this parameter because it can lead to increased interruptions. If you do not specify this parameter, you will pay the current Spot price.   <important>   If you specify a maximum price, your instances will be interrupted more frequently than if you do not specify this parameter.   </important></param>
        public RequestSpotInstancesRequest(string spotPrice)
        {
            this.SpotPrice = spotPrice;
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Run_Instance_Idempotency.html">Ensuring
        /// idempotency in Amazon EC2 API requests</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

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
        public int? InstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the InstanceCount property is set.
        /// </summary>
        internal bool IsSetInstanceCount() => this.InstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceInterruptionBehavior. 
        /// <para>
        /// The behavior when a Spot Instance is interrupted. The default is <c>terminate</c>.
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
        ///  
        /// <para>
        /// Default: Instances are launched and terminated individually
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
        /// The launch specification.
        /// </para>
        /// </summary>
        public LaunchSpecification LaunchSpecification { get; set; }

        /// <summary>
        /// Checks to see if the LaunchSpecification property is set.
        /// </summary>
        internal bool IsSetLaunchSpecification() => this.LaunchSpecification != null;

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
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The key-value pair for tagging the Spot Instance request on creation. The value for
        /// <c>ResourceType</c> must be <c>spot-instances-request</c>, otherwise the Spot Instance
        /// request fails. To tag the Spot Instance request after it has been created, see <a
        /// href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateTags.html">CreateTags</a>.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Checks to see if the TagSpecifications property is set.
        /// </summary>
        internal bool IsSetTagSpecifications() => this.TagSpecifications != null && (this.TagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The Spot Instance request type.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>one-time</c> 
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
        /// The start date of the request. If this is a one-time request, the request becomes
        /// active at this date and time and remains active until all instances launch, the request
        /// expires, or the request is canceled. If the request is persistent, the request becomes
        /// active at this date and time and remains active until it expires or is canceled.
        /// </para>
        ///  
        /// <para>
        /// The specified start date and time cannot be equal to the current date and time. You
        /// must specify a start date and time that occurs after the current date and time.
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
        /// For a persistent request, the request remains active until the <c>ValidUntil</c> date
        /// and time is reached. Otherwise, the request remains active until you cancel it. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For a one-time request, the request remains active until all instances launch, the
        /// request is canceled, or the <c>ValidUntil</c> date and time is reached. By default,
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
