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
 * Do not modify this file. This file is generated from the ec2-2016-04-01.normal.json service model.
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
    /// Describes a Spot fleet event.
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
        /// The following are the <code>error</code> events.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>iamFleetRoleInvalid</code> - The Spot fleet did not have the required permissions
        /// either to launch or terminate an instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>launchSpecTemporarilyBlacklisted</code> - The configuration is not valid and
        /// several attempts to launch instances have failed. For more information, see the description
        /// of the event.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>spotFleetRequestConfigurationInvalid</code> - The configuration is not valid.
        /// For more information, see the description of the event.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>spotInstanceCountLimitExceeded</code> - You've reached the limit on the number
        /// of Spot instances that you can launch.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following are the <code>fleetRequestChange</code> events.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>active</code> - The Spot fleet has been validated and Amazon EC2 is attempting
        /// to maintain the target number of running Spot instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>cancelled</code> - The Spot fleet is canceled and has no running Spot instances.
        /// The Spot fleet will be deleted two days after its instances were terminated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>cancelled_running</code> - The Spot fleet is canceled and will not launch additional
        /// Spot instances, but its existing Spot instances continue to run until they are interrupted
        /// or terminated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>cancelled_terminating</code> - The Spot fleet is canceled and its Spot instances
        /// are terminating.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>expired</code> - The Spot fleet request has expired. A subsequent event indicates
        /// that the instances were terminated, if the request was created with <code>TerminateInstancesWithExpiration</code>
        /// set.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>modify_in_progress</code> - A request to modify the Spot fleet request was
        /// accepted and is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>modify_successful</code> - The Spot fleet request was modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>price_update</code> - The bid price for a launch configuration was adjusted
        /// because it was too high. This change is permanent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>submitted</code> - The Spot fleet request is being evaluated and Amazon EC2
        /// is preparing to launch the target number of Spot instances.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following are the <code>instanceChange</code> events.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>launched</code> - A bid was fulfilled and a new instance was launched.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>terminated</code> - An instance was terminated by the user.
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
        /// The ID of the instance. This information is available only for <code>instanceChange</code>
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