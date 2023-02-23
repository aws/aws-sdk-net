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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// <note> 
    /// <para>
    /// The deployment circuit breaker can only be used for services using the rolling update
    /// (<code>ECS</code>) deployment type.
    /// </para>
    ///  </note> 
    /// <para>
    /// The <b>deployment circuit breaker</b> determines whether a service deployment will
    /// fail if the service can't reach a steady state. If enabled, a service deployment will
    /// transition to a failed state and stop launching new tasks. You can also configure
    /// Amazon ECS to roll back your service to the last completed deployment after a failure.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/deployment-type-ecs.html">Rolling
    /// update</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class DeploymentCircuitBreaker
    {
        private bool? _enable;
        private bool? _rollback;

        /// <summary>
        /// Gets and sets the property Enable. 
        /// <para>
        /// Determines whether to use the deployment circuit breaker logic for the service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool Enable
        {
            get { return this._enable.GetValueOrDefault(); }
            set { this._enable = value; }
        }

        // Check to see if Enable property is set
        internal bool IsSetEnable()
        {
            return this._enable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Rollback. 
        /// <para>
        /// Determines whether to configure Amazon ECS to roll back the service if a service deployment
        /// fails. If rollback is on, when a service deployment fails, the service is rolled back
        /// to the last deployment that completed successfully.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool Rollback
        {
            get { return this._rollback.GetValueOrDefault(); }
            set { this._rollback = value; }
        }

        // Check to see if Rollback property is set
        internal bool IsSetRollback()
        {
            return this._rollback.HasValue; 
        }

    }
}