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
    /// The auto repair configuration for an Amazon ECS Managed Instances capacity provider.
    /// When enabled, Amazon ECS automatically replaces container instances that are detected
    /// as unhealthy based on container instance health checks, including accelerated compute
    /// device and daemon health checks.
    /// </summary>
    public partial class AutoRepairConfiguration
    {
        private AutoRepairActionsStatus _actionsStatus;

        /// <summary>
        /// Gets and sets the property ActionsStatus. 
        /// <para>
        /// The status of auto repair actions for the capacity provider. When set to <c>ENABLED</c>,
        /// Amazon ECS automatically replaces container instances with an <c>IMPAIRED</c> health
        /// status. When set to <c>DISABLED</c>, Amazon ECS still monitors container instance
        /// health but does not automatically replace impaired instances.
        /// </para>
        /// </summary>
        public AutoRepairActionsStatus ActionsStatus
        {
            get { return this._actionsStatus; }
            set { this._actionsStatus = value; }
        }

        // Check to see if ActionsStatus property is set
        internal bool IsSetActionsStatus()
        {
            return this._actionsStatus != null;
        }

    }
}