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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Information about whether instances in the original environment are terminated when
    /// a blue/green deployment is successful.
    /// </summary>
    public partial class BlueInstanceTerminationOption
    {
        private InstanceAction _action;
        private int? _terminationWaitTimeInMinutes;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to take on instances in the original environment after a successful blue/green
        /// deployment.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// TERMINATE: Instances are terminated after a specified wait time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// KEEP_ALIVE: Instances are left running after they are deregistered from the load balancer
        /// and removed from the deployment group.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InstanceAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property TerminationWaitTimeInMinutes. 
        /// <para>
        /// The number of minutes to wait after a successful blue/green deployment before terminating
        /// instances from the original environment. The maximum setting is 2880 minutes (2 days).
        /// </para>
        /// </summary>
        public int TerminationWaitTimeInMinutes
        {
            get { return this._terminationWaitTimeInMinutes.GetValueOrDefault(); }
            set { this._terminationWaitTimeInMinutes = value; }
        }

        // Check to see if TerminationWaitTimeInMinutes property is set
        internal bool IsSetTerminationWaitTimeInMinutes()
        {
            return this._terminationWaitTimeInMinutes.HasValue; 
        }

    }
}