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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Contains information about an IoT job configuration.
    /// </summary>
    public partial class DeploymentIoTJobConfiguration
    {
        /// <summary>
        /// Gets and sets the property AbortConfig. 
        /// <para>
        /// The stop configuration for the job. This configuration defines when and how to stop
        /// a job rollout.
        /// </para>
        /// </summary>
        public IoTJobAbortConfig AbortConfig { get; set; }

        /// <summary>
        /// Checks to see if the AbortConfig property is set.
        /// </summary>
        internal bool IsSetAbortConfig() => this.AbortConfig != null;

        /// <summary>
        /// Gets and sets the property JobExecutionsRolloutConfig. 
        /// <para>
        /// The rollout configuration for the job. This configuration defines the rate at which
        /// the job rolls out to the fleet of target devices.
        /// </para>
        /// </summary>
        public IoTJobExecutionsRolloutConfig JobExecutionsRolloutConfig { get; set; }

        /// <summary>
        /// Checks to see if the JobExecutionsRolloutConfig property is set.
        /// </summary>
        internal bool IsSetJobExecutionsRolloutConfig() => this.JobExecutionsRolloutConfig != null;

        /// <summary>
        /// Gets and sets the property TimeoutConfig. 
        /// <para>
        /// The timeout configuration for the job. This configuration defines the amount of time
        /// each device has to complete the job.
        /// </para>
        /// </summary>
        public IoTJobTimeoutConfig TimeoutConfig { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutConfig property is set.
        /// </summary>
        internal bool IsSetTimeoutConfig() => this.TimeoutConfig != null;
    }
}
