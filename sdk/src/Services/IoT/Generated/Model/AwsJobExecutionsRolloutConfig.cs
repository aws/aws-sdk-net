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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Configuration for the rollout of OTA updates.
    /// </summary>
    public partial class AwsJobExecutionsRolloutConfig
    {
        private AwsJobExponentialRolloutRate _exponentialRate;
        private int? _maximumPerMinute;

        /// <summary>
        /// Gets and sets the property ExponentialRate. 
        /// <para>
        /// The rate of increase for a job rollout. This parameter allows you to define an exponential
        /// rate increase for a job rollout.
        /// </para>
        /// </summary>
        public AwsJobExponentialRolloutRate ExponentialRate
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
        /// The maximum number of OTA update job executions started per minute.
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