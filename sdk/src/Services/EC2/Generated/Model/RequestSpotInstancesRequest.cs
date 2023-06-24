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
    /// Container for the parameters to the RequestSpotInstances operation.
    /// Creates a Spot Instance request.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-requests.html">Spot
    /// Instance requests</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
    /// </para>
    ///  <important> 
    /// <para>
    /// We strongly discourage using the RequestSpotInstances API because it is a legacy API
    /// with no planned investment. For options for requesting Spot Instances, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-best-practices.html#which-spot-request-method-to-use">Which
    /// is the best Spot request method to use?</a> in the <i>Amazon EC2 User Guide for Linux
    /// Instances</i>.
    /// </para>
    ///  </important>
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
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();
        private SpotInstanceType _type;
        private DateTime? _validFromUtc;
        private DateTime? _validUntilUtc;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public RequestSpotInstancesRequest() { }

        /// <summary>
        /// Instantiates RequestSpotInstancesRequest with the parameterized properties
        /// </summary>
        /// <param name="spotPrice">The maximum price per unit hour that you are willing to pay for a Spot Instance. We do not recommend using this parameter because it can lead to increased interruptions. If you do not specify this parameter, you will pay the current Spot price. <important> If you specify a maximum price, your instances will be interrupted more frequently than if you do not specify this parameter. </important></param>
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
        /// Deprecated.
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
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Run_Instance_Idempotency.html">How
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
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The key-value pair for tagging the Spot Instance request on creation. The value for
        /// <code>ResourceType</code> must be <code>spot-instances-request</code>, otherwise the
        /// Spot Instance request fails. To tag the Spot Instance request after it has been created,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateTags.html">CreateTags</a>.
        /// 
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
        /// Gets and sets the property ValidFromUtc. 
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
        /// The end date of the request, in UTC format (<i>YYYY</i>-<i>MM</i>-<i>DD</i>T<i>HH</i>:<i>MM</i>:<i>SS</i>Z).
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For a persistent request, the request remains active until the <code>ValidUntil</code>
        /// date and time is reached. Otherwise, the request remains active until you cancel it.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For a one-time request, the request remains active until all instances launch, the
        /// request is canceled, or the <code>ValidUntil</code> date and time is reached. By default,
        /// the request is valid for 7 days from the date the request was created.
        /// </para>
        ///  </li> </ul>
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
        /// The end date of the request, in UTC format (<i>YYYY</i>-<i>MM</i>-<i>DD</i>T<i>HH</i>:<i>MM</i>:<i>SS</i>Z).
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For a persistent request, the request remains active until the <code>ValidUntil</code>
        /// date and time is reached. Otherwise, the request remains active until you cancel it.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For a one-time request, the request remains active until all instances launch, the
        /// request is canceled, or the <code>ValidUntil</code> date and time is reached. By default,
        /// the request is valid for 7 days from the date the request was created.
        /// </para>
        ///  </li> </ul>
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