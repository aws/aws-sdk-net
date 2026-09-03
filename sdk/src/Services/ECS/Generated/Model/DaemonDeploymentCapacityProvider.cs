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
    /// Information about a capacity provider during a daemon deployment.
    /// </summary>
    public partial class DaemonDeploymentCapacityProvider
    {
        private string _arn;
        private int? _drainingInstanceCount;
        private int? _runningInstanceCount;
        private int? _withoutDaemonInstanceCount;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the capacity provider.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property DrainingInstanceCount. 
        /// <para>
        /// The number of instances being drained on this capacity provider during the deployment.
        /// </para>
        /// </summary>
        public int? DrainingInstanceCount
        {
            get { return this._drainingInstanceCount; }
            set { this._drainingInstanceCount = value; }
        }

        // Check to see if DrainingInstanceCount property is set
        internal bool IsSetDrainingInstanceCount()
        {
            return this._drainingInstanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RunningInstanceCount. 
        /// <para>
        /// The number of instances running daemon tasks on this capacity provider.
        /// </para>
        /// </summary>
        public int? RunningInstanceCount
        {
            get { return this._runningInstanceCount; }
            set { this._runningInstanceCount = value; }
        }

        // Check to see if RunningInstanceCount property is set
        internal bool IsSetRunningInstanceCount()
        {
            return this._runningInstanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WithoutDaemonInstanceCount. 
        /// <para>
        /// The number of instances on this capacity provider that are running without the daemon
        /// task. This applies to daemons that aren't critical, where the instance remains available
        /// for your other tasks even if the daemon task can't start or stops. These instances
        /// aren't included in <c>runningInstanceCount</c>.
        /// </para>
        /// </summary>
        public int? WithoutDaemonInstanceCount
        {
            get { return this._withoutDaemonInstanceCount; }
            set { this._withoutDaemonInstanceCount = value; }
        }

        // Check to see if WithoutDaemonInstanceCount property is set
        internal bool IsSetWithoutDaemonInstanceCount()
        {
            return this._withoutDaemonInstanceCount.HasValue; 
        }

    }
}