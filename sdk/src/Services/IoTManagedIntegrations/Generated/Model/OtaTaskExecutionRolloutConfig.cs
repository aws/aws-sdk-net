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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
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
namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// Over-the-air (OTA) task rollout config.
    /// </summary>
    public partial class OtaTaskExecutionRolloutConfig
    {
        private ExponentialRolloutRate _exponentialRolloutRate;
        private int? _maximumPerMinute;

        /// <summary>
        /// Gets and sets the property ExponentialRolloutRate. 
        /// <para>
        /// Structure representing exponential rate of rollout for an over-the-air (OTA) task.
        /// </para>
        /// </summary>
        public ExponentialRolloutRate ExponentialRolloutRate
        {
            get { return this._exponentialRolloutRate; }
            set { this._exponentialRolloutRate = value; }
        }

        // Check to see if ExponentialRolloutRate property is set
        internal bool IsSetExponentialRolloutRate()
        {
            return this._exponentialRolloutRate != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumPerMinute. 
        /// <para>
        /// The maximum number of things that will be notified of a pending task, per minute.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MaximumPerMinute
        {
            get { return this._maximumPerMinute; }
            set { this._maximumPerMinute = value; }
        }

        // Check to see if MaximumPerMinute property is set
        internal bool IsSetMaximumPerMinute()
        {
            return this._maximumPerMinute.HasValue; 
        }

    }
}