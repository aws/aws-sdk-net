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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Configuration for monitoring constraints and monitoring statistics. These baseline
    /// resources are compared against the results of the current job from the series of jobs
    /// scheduled to collect data periodically.
    /// </summary>
    public partial class MonitoringBaselineConfig
    {
        /// <summary>
        /// Gets and sets the property BaseliningJobName. 
        /// <para>
        /// The name of the job that performs baselining for the monitoring job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string BaseliningJobName { get; set; }

        /// <summary>
        /// Checks to see if the BaseliningJobName property is set.
        /// </summary>
        internal bool IsSetBaseliningJobName() => this.BaseliningJobName != null;

        /// <summary>
        /// Gets and sets the property ConstraintsResource. 
        /// <para>
        /// The baseline constraint file in Amazon S3 that the current monitoring job should validated
        /// against.
        /// </para>
        /// </summary>
        public MonitoringConstraintsResource ConstraintsResource { get; set; }

        /// <summary>
        /// Checks to see if the ConstraintsResource property is set.
        /// </summary>
        internal bool IsSetConstraintsResource() => this.ConstraintsResource != null;

        /// <summary>
        /// Gets and sets the property StatisticsResource. 
        /// <para>
        /// The baseline statistics file in Amazon S3 that the current monitoring job should be
        /// validated against.
        /// </para>
        /// </summary>
        public MonitoringStatisticsResource StatisticsResource { get; set; }

        /// <summary>
        /// Checks to see if the StatisticsResource property is set.
        /// </summary>
        internal bool IsSetStatisticsResource() => this.StatisticsResource != null;
    }
}
