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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Defines the traffic routing strategy during an endpoint deployment to shift traffic
    /// from the old fleet to the new fleet.
    /// </summary>
    public partial class TrafficRoutingConfig
    {
        private CapacitySize _canarySize;
        private CapacitySize _linearStepSize;
        private TrafficRoutingConfigType _type;
        private int? _waitIntervalInSeconds;

        /// <summary>
        /// Gets and sets the property CanarySize. 
        /// <para>
        /// Batch size for the first step to turn on traffic on the new endpoint fleet. <c>Value</c>
        /// must be less than or equal to 50% of the variant's total instance count.
        /// </para>
        /// </summary>
        public CapacitySize CanarySize
        {
            get { return this._canarySize; }
            set { this._canarySize = value; }
        }

        // Check to see if CanarySize property is set
        internal bool IsSetCanarySize()
        {
            return this._canarySize != null;
        }

        /// <summary>
        /// Gets and sets the property LinearStepSize. 
        /// <para>
        /// Batch size for each step to turn on traffic on the new endpoint fleet. <c>Value</c>
        /// must be 10-50% of the variant's total instance count.
        /// </para>
        /// </summary>
        public CapacitySize LinearStepSize
        {
            get { return this._linearStepSize; }
            set { this._linearStepSize = value; }
        }

        // Check to see if LinearStepSize property is set
        internal bool IsSetLinearStepSize()
        {
            return this._linearStepSize != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Traffic routing strategy type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALL_AT_ONCE</c>: Endpoint traffic shifts to the new fleet in a single step. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CANARY</c>: Endpoint traffic shifts to the new fleet in two steps. The first step
        /// is the canary, which is a small portion of the traffic. The second step is the remainder
        /// of the traffic. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LINEAR</c>: Endpoint traffic shifts to the new fleet in n steps of a configurable
        /// size. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public TrafficRoutingConfigType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property WaitIntervalInSeconds. 
        /// <para>
        /// The waiting time (in seconds) between incremental steps to turn on traffic on the
        /// new endpoint fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=3600)]
        public int? WaitIntervalInSeconds
        {
            get { return this._waitIntervalInSeconds; }
            set { this._waitIntervalInSeconds = value; }
        }

        // Check to see if WaitIntervalInSeconds property is set
        internal bool IsSetWaitIntervalInSeconds()
        {
            return this._waitIntervalInSeconds.HasValue; 
        }

    }
}