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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// An object that represents a scaling policy for a compute environment.
    /// </summary>
    public partial class ComputeScalingPolicy
    {
        private int? _minScaleDownDelayMinutes;

        /// <summary>
        /// Gets and sets the property MinScaleDownDelayMinutes. 
        /// <para>
        /// The minimum time (in minutes) that Batch keeps instances running in the compute environment
        /// after their jobs complete. For each instance, the delay period begins when the last
        /// job finishes. If no new jobs are placed on the instance during this delay, Batch terminates
        /// the instance once the delay expires.
        /// </para>
        ///  
        /// <para>
        /// Valid Range: Minimum value of 20. Maximum value of 10080. Use 0 to unset and disable
        /// the scale down delay.
        /// </para>
        ///  <note> 
        /// <para>
        /// The scale down delay does not apply to:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Instances being replaced during infrastructure updates
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Newly launched instances that have not yet run any jobs
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Spot instances reclaimed due to interruption
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        public int MinScaleDownDelayMinutes
        {
            get { return this._minScaleDownDelayMinutes.GetValueOrDefault(); }
            set { this._minScaleDownDelayMinutes = value; }
        }

        // Check to see if MinScaleDownDelayMinutes property is set
        internal bool IsSetMinScaleDownDelayMinutes()
        {
            return this._minScaleDownDelayMinutes.HasValue; 
        }

    }
}