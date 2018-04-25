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
    /// Information about how traffic is rerouted to instances in a replacement environment
    /// in a blue/green deployment.
    /// </summary>
    public partial class DeploymentReadyOption
    {
        private DeploymentReadyAction _actionOnTimeout;
        private int? _waitTimeInMinutes;

        /// <summary>
        /// Gets and sets the property ActionOnTimeout. 
        /// <para>
        /// Information about when to reroute traffic from an original environment to a replacement
        /// environment in a blue/green deployment.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CONTINUE_DEPLOYMENT: Register new instances with the load balancer immediately after
        /// the new application revision is installed on the instances in the replacement environment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// STOP_DEPLOYMENT: Do not register new instances with a load balancer unless traffic
        /// rerouting is started using <a>ContinueDeployment</a>. If traffic rerouting is not
        /// started before the end of the specified wait period, the deployment status is changed
        /// to Stopped.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DeploymentReadyAction ActionOnTimeout
        {
            get { return this._actionOnTimeout; }
            set { this._actionOnTimeout = value; }
        }

        // Check to see if ActionOnTimeout property is set
        internal bool IsSetActionOnTimeout()
        {
            return this._actionOnTimeout != null;
        }

        /// <summary>
        /// Gets and sets the property WaitTimeInMinutes. 
        /// <para>
        /// The number of minutes to wait before the status of a blue/green deployment changed
        /// to Stopped if rerouting is not started manually. Applies only to the STOP_DEPLOYMENT
        /// option for actionOnTimeout
        /// </para>
        /// </summary>
        public int WaitTimeInMinutes
        {
            get { return this._waitTimeInMinutes.GetValueOrDefault(); }
            set { this._waitTimeInMinutes = value; }
        }

        // Check to see if WaitTimeInMinutes property is set
        internal bool IsSetWaitTimeInMinutes()
        {
            return this._waitTimeInMinutes.HasValue; 
        }

    }
}