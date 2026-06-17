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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// The timeout configuration for a deployment lifecycle hook. This determines how long
    /// Amazon ECS waits for the hook to complete before taking the specified timeout action.
    /// </summary>
    public partial class DeploymentLifecycleHookTimeoutConfiguration
    {
        private DeploymentLifecycleHookAction _action;
        private int? _timeoutInMinutes;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action Amazon ECS takes when the lifecycle hook times out. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CONTINUE</c> - Proceeds the deployment to the next lifecycle stage.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ROLLBACK</c> - Rolls back the deployment to the previous service revision.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: <c>ROLLBACK</c> 
        /// </para>
        /// </summary>
        public DeploymentLifecycleHookAction Action
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
        /// Gets and sets the property TimeoutInMinutes. 
        /// <para>
        /// The number of minutes Amazon ECS waits for the lifecycle hook to complete before taking
        /// the timeout action.
        /// </para>
        ///  
        /// <para>
        /// Default: 1440 (24 hours)
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20160)]
        public int? TimeoutInMinutes
        {
            get { return this._timeoutInMinutes; }
            set { this._timeoutInMinutes = value; }
        }

        // Check to see if TimeoutInMinutes property is set
        internal bool IsSetTimeoutInMinutes()
        {
            return this._timeoutInMinutes.HasValue; 
        }

    }
}