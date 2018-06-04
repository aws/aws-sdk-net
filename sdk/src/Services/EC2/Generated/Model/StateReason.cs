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
    /// Describes a state change.
    /// </summary>
    public partial class StateReason
    {
        private string _code;
        private string _message;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The reason code for the state change.
        /// </para>
        /// </summary>
        public string Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The message for the state change.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Server.InsufficientInstanceCapacity</code>: There was insufficient capacity
        /// available to satisfy the launch request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Server.InternalError</code>: An internal error caused the instance to terminate
        /// during launch.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Server.ScheduledStop</code>: The instance was stopped due to a scheduled retirement.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Server.SpotInstanceShutdown</code>: The instance was stopped because the number
        /// of Spot requests with a maximum price equal to or higher than the Spot price exceeded
        /// available capacity or because of an increase in the Spot price.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Server.SpotInstanceTermination</code>: The instance was terminated because
        /// the number of Spot requests with a maximum price equal to or higher than the Spot
        /// price exceeded available capacity or because of an increase in the Spot price.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Client.InstanceInitiatedShutdown</code>: The instance was shut down using the
        /// <code>shutdown -h</code> command from the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Client.InstanceTerminated</code>: The instance was terminated or rebooted during
        /// AMI creation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Client.InternalError</code>: A client error caused the instance to terminate
        /// during launch.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Client.InvalidSnapshot.NotFound</code>: The specified snapshot was not found.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Client.UserInitiatedShutdown</code>: The instance was shut down using the Amazon
        /// EC2 API.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Client.VolumeLimitExceeded</code>: The limit on the number of EBS volumes or
        /// total storage was exceeded. Decrease usage or request an increase in your account
        /// limits.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

    }
}