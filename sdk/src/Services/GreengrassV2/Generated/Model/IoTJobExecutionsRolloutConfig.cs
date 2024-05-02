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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
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
namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Contains information about the rollout configuration for a job. This configuration
    /// defines the rate at which the job deploys a configuration to a fleet of target devices.
    /// </summary>
    public partial class IoTJobExecutionsRolloutConfig
    {
        private IoTJobExponentialRolloutRate _exponentialRate;
        private int? _maximumPerMinute;

        /// <summary>
        /// Gets and sets the property ExponentialRate. 
        /// <para>
        /// The exponential rate to increase the job rollout rate.
        /// </para>
        /// </summary>
        public IoTJobExponentialRolloutRate ExponentialRate
        {
            get { return this._exponentialRate; }
            set { this._exponentialRate = value; }
        }

        // Check to see if ExponentialRate property is set
        internal bool IsSetExponentialRate()
        {
            return this._exponentialRate != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumPerMinute. 
        /// <para>
        /// The maximum number of devices that receive a pending job notification, per minute.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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