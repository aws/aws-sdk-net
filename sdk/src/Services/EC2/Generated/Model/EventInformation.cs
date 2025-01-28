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
    /// Describes an EC2 Fleet or Spot Fleet event.
    /// </summary>
    public partial class EventInformation
    {
        private string _eventDescription;
        private string _eventSubType;
        private string _instanceId;

        /// <summary>
        /// Gets and sets the property EventDescription. 
        /// <para>
        /// The description of the event.
        /// </para>
        /// </summary>
        public string EventDescription
        {
            get { return this._eventDescription; }
            set { this._eventDescription = value; }
        }

        // Check to see if EventDescription property is set
        internal bool IsSetEventDescription()
        {
            return this._eventDescription != null;
        }

        /// <summary>
        /// Gets and sets the property EventSubType. 
        /// <para>
        /// The event.
        /// </para>
        ///  
        /// <para>
        ///  <c>error</c> events:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>iamFleetRoleInvalid</c> - The EC2 Fleet or Spot Fleet does not have the required
        /// permissions either to launch or terminate an instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>allLaunchSpecsTemporarilyBlacklisted</c> - None of the configurations are valid,
        /// and several attempts to launch instances have failed. For more information, see the
        /// description of the event.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>spotInstanceCountLimitExceeded</c> - You've reached the limit on the number of
        /// Spot Instances that you can launch.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>spotFleetRequestConfigurationInvalid</c> - The configuration is not valid. For
        /// more information, see the description of the event.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <c>fleetRequestChange</c> events:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>active</c> - The EC2 Fleet or Spot Fleet request has been validated and Amazon
        /// EC2 is attempting to maintain the target number of running instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleted</c> (EC2 Fleet) / <c>cancelled</c> (Spot Fleet) - The EC2 Fleet is deleted
        /// or the Spot Fleet request is canceled and has no running instances. The EC2 Fleet
        /// or Spot Fleet will be deleted two days after its instances are terminated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleted_running</c> (EC2 Fleet) / <c>cancelled_running</c> (Spot Fleet) - The
        /// EC2 Fleet is deleted or the Spot Fleet request is canceled and does not launch additional
        /// instances. Its existing instances continue to run until they are interrupted or terminated.
        /// The request remains in this state until all instances are interrupted or terminated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleted_terminating</c> (EC2 Fleet) / <c>cancelled_terminating</c> (Spot Fleet)
        /// - The EC2 Fleet is deleted or the Spot Fleet request is canceled and its instances
        /// are terminating. The request remains in this state until all instances are terminated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>expired</c> - The EC2 Fleet or Spot Fleet request has expired. If the request
        /// was created with <c>TerminateInstancesWithExpiration</c> set, a subsequent <c>terminated</c>
        /// event indicates that the instances are terminated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>modify_in_progress</c> - The EC2 Fleet or Spot Fleet request is being modified.
        /// The request remains in this state until the modification is fully processed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>modify_succeeded</c> - The EC2 Fleet or Spot Fleet request was modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>submitted</c> - The EC2 Fleet or Spot Fleet request is being evaluated and Amazon
        /// EC2 is preparing to launch the target number of instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>progress</c> - The EC2 Fleet or Spot Fleet request is in the process of being
        /// fulfilled.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <c>instanceChange</c> events:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>launched</c> - A new instance was launched.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>terminated</c> - An instance was terminated by the user.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>termination_notified</c> - An instance termination notification was sent when
        /// a Spot Instance was terminated by Amazon EC2 during scale-down, when the target capacity
        /// of the fleet was modified down, for example, from a target capacity of 4 to a target
        /// capacity of 3.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <c>Information</c> events:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>fleetProgressHalted</c> - The price in every launch specification is not valid
        /// because it is below the Spot price (all the launch specifications have produced <c>launchSpecUnusable</c>
        /// events). A launch specification might become valid if the Spot price changes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>launchSpecTemporarilyBlacklisted</c> - The configuration is not valid and several
        /// attempts to launch instances have failed. For more information, see the description
        /// of the event.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>launchSpecUnusable</c> - The price specified in a launch specification is not
        /// valid because it is below the Spot price for the requested Spot pools.
        /// </para>
        ///  
        /// <para>
        /// Note: Even if a fleet with the <c>maintain</c> request type is in the process of being
        /// canceled, it may still publish a <c>launchSpecUnusable</c> event. This does not mean
        /// that the canceled fleet is attempting to launch a new instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>registerWithLoadBalancersFailed</c> - An attempt to register instances with load
        /// balancers failed. For more information, see the description of the event.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string EventSubType
        {
            get { return this._eventSubType; }
            set { this._eventSubType = value; }
        }

        // Check to see if EventSubType property is set
        internal bool IsSetEventSubType()
        {
            return this._eventSubType != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance. This information is available only for <c>instanceChange</c>
        /// events.
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

    }
}