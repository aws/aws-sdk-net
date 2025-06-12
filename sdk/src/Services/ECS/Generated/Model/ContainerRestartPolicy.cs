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
    /// You can enable a restart policy for each container defined in your task definition,
    /// to overcome transient failures faster and maintain task availability. When you enable
    /// a restart policy for a container, Amazon ECS can restart the container if it exits,
    /// without needing to replace the task. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/container-restart-policy.html">Restart
    /// individual containers in Amazon ECS tasks with container restart policies</a> in the
    /// <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </summary>
    public partial class ContainerRestartPolicy
    {
        private bool? _enabled;
        private List<int> _ignoredExitCodes = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private int? _restartAttemptPeriod;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether a restart policy is enabled for the container.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IgnoredExitCodes. 
        /// <para>
        /// A list of exit codes that Amazon ECS will ignore and not attempt a restart on. You
        /// can specify a maximum of 50 container exit codes. By default, Amazon ECS does not
        /// ignore any exit codes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> IgnoredExitCodes
        {
            get { return this._ignoredExitCodes; }
            set { this._ignoredExitCodes = value; }
        }

        // Check to see if IgnoredExitCodes property is set
        internal bool IsSetIgnoredExitCodes()
        {
            return this._ignoredExitCodes != null && (this._ignoredExitCodes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RestartAttemptPeriod. 
        /// <para>
        /// A period of time (in seconds) that the container must run for before a restart can
        /// be attempted. A container can be restarted only once every <c>restartAttemptPeriod</c>
        /// seconds. If a container isn't able to run for this time period and exits early, it
        /// will not be restarted. You can set a minimum <c>restartAttemptPeriod</c> of 60 seconds
        /// and a maximum <c>restartAttemptPeriod</c> of 1800 seconds. By default, a container
        /// must run for 300 seconds before it can be restarted.
        /// </para>
        /// </summary>
        public int? RestartAttemptPeriod
        {
            get { return this._restartAttemptPeriod; }
            set { this._restartAttemptPeriod = value; }
        }

        // Check to see if RestartAttemptPeriod property is set
        internal bool IsSetRestartAttemptPeriod()
        {
            return this._restartAttemptPeriod.HasValue; 
        }

    }
}