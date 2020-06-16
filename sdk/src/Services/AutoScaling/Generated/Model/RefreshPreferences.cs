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
    /// Describes information used to start an instance refresh.
    /// </summary>
    public partial class RefreshPreferences
    {
        private int? _instanceWarmup;
        private int? _minHealthyPercentage;

        /// <summary>
        /// Gets and sets the property InstanceWarmup. 
        /// <para>
        /// The number of seconds until a newly launched instance is configured and ready to use.
        /// During this time, Amazon EC2 Auto Scaling does not immediately move on to the next
        /// replacement. The default is to use the value specified for the health check grace
        /// period for the group.
        /// </para>
        ///  
        /// <para>
        /// Note: While warming up, a newly launched instance is not counted toward the aggregated
        /// metrics of the Auto Scaling group. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int InstanceWarmup
        {
            get { return this._instanceWarmup.GetValueOrDefault(); }
            set { this._instanceWarmup = value; }
        }

        // Check to see if InstanceWarmup property is set
        internal bool IsSetInstanceWarmup()
        {
            return this._instanceWarmup.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinHealthyPercentage. 
        /// <para>
        /// The amount of capacity in the Auto Scaling group that must remain healthy during an
        /// instance refresh to allow the operation to continue, as a percentage of the desired
        /// capacity of the Auto Scaling group (rounded up to the nearest integer). The default
        /// is <code>90</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int MinHealthyPercentage
        {
            get { return this._minHealthyPercentage.GetValueOrDefault(); }
            set { this._minHealthyPercentage = value; }
        }

        // Check to see if MinHealthyPercentage property is set
        internal bool IsSetMinHealthyPercentage()
        {
            return this._minHealthyPercentage.HasValue; 
        }

    }
}