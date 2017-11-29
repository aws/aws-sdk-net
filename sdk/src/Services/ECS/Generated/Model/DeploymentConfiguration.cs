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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Optional deployment parameters that control how many tasks run during the deployment
    /// and the ordering of stopping and starting tasks.
    /// </summary>
    public partial class DeploymentConfiguration
    {
        private int? _maximumPercent;
        private int? _minimumHealthyPercent;

        /// <summary>
        /// Gets and sets the property MaximumPercent. 
        /// <para>
        /// The upper limit (as a percentage of the service's <code>desiredCount</code>) of the
        /// number of tasks that are allowed in the <code>RUNNING</code> or <code>PENDING</code>
        /// state in a service during a deployment. The maximum number of tasks during a deployment
        /// is the <code>desiredCount</code> multiplied by <code>maximumPercent</code>/100, rounded
        /// down to the nearest integer value.
        /// </para>
        /// </summary>
        public int MaximumPercent
        {
            get { return this._maximumPercent.GetValueOrDefault(); }
            set { this._maximumPercent = value; }
        }

        // Check to see if MaximumPercent property is set
        internal bool IsSetMaximumPercent()
        {
            return this._maximumPercent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinimumHealthyPercent. 
        /// <para>
        /// The lower limit (as a percentage of the service's <code>desiredCount</code>) of the
        /// number of running tasks that must remain in the <code>RUNNING</code> state in a service
        /// during a deployment. The minimum number of healthy tasks during a deployment is the
        /// <code>desiredCount</code> multiplied by <code>minimumHealthyPercent</code>/100, rounded
        /// up to the nearest integer value.
        /// </para>
        /// </summary>
        public int MinimumHealthyPercent
        {
            get { return this._minimumHealthyPercent.GetValueOrDefault(); }
            set { this._minimumHealthyPercent = value; }
        }

        // Check to see if MinimumHealthyPercent property is set
        internal bool IsSetMinimumHealthyPercent()
        {
            return this._minimumHealthyPercent.HasValue; 
        }

    }
}