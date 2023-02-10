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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Reports progress on replacing instances that are in the warm pool.
    /// </summary>
    public partial class InstanceRefreshWarmPoolProgress
    {
        private int? _instancesToUpdate;
        private int? _percentageComplete;

        /// <summary>
        /// Gets and sets the property InstancesToUpdate. 
        /// <para>
        /// The number of instances remaining to update.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int InstancesToUpdate
        {
            get { return this._instancesToUpdate.GetValueOrDefault(); }
            set { this._instancesToUpdate = value; }
        }

        // Check to see if InstancesToUpdate property is set
        internal bool IsSetInstancesToUpdate()
        {
            return this._instancesToUpdate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PercentageComplete. 
        /// <para>
        /// The percentage of instances in the warm pool that have been replaced. For each instance
        /// replacement, Amazon EC2 Auto Scaling tracks the instance's health status and warm-up
        /// time. When the instance's health status changes to healthy and the specified warm-up
        /// time passes, the instance is considered updated and is added to the percentage complete.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int PercentageComplete
        {
            get { return this._percentageComplete.GetValueOrDefault(); }
            set { this._percentageComplete = value; }
        }

        // Check to see if PercentageComplete property is set
        internal bool IsSetPercentageComplete()
        {
            return this._percentageComplete.HasValue; 
        }

    }
}