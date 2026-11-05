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

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Information about whether instances in the original environment are terminated when
    /// a blue/green deployment is successful. <c>BlueInstanceTerminationOption</c> does not
    /// apply to Lambda deployments.
    /// </summary>
    public partial class BlueInstanceTerminationOption
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to take on instances in the original environment after a successful blue/green
        /// deployment.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>TERMINATE</c>: Instances are terminated after a specified wait time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KEEP_ALIVE</c>: Instances are left running after they are deregistered from the
        /// load balancer and removed from the deployment group.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InstanceAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property TerminationWaitTimeInMinutes. 
        /// <para>
        /// For an Amazon EC2 deployment, the number of minutes to wait after a successful blue/green
        /// deployment before terminating instances from the original environment.
        /// </para>
        ///  
        /// <para>
        ///  For an Amazon ECS deployment, the number of minutes before deleting the original
        /// (blue) task set. During an Amazon ECS deployment, CodeDeploy shifts traffic from the
        /// original (blue) task set to a replacement (green) task set. 
        /// </para>
        ///  
        /// <para>
        ///  The maximum setting is 2880 minutes (2 days). 
        /// </para>
        /// </summary>
        public int? TerminationWaitTimeInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the TerminationWaitTimeInMinutes property is set.
        /// </summary>
        internal bool IsSetTerminationWaitTimeInMinutes() => this.TerminationWaitTimeInMinutes.HasValue;
    }
}
