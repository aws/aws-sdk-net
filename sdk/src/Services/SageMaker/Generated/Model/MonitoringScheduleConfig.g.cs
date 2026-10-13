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
    /// Configures the monitoring schedule and defines the monitoring job.
    /// </summary>
    public partial class MonitoringScheduleConfig
    {
        /// <summary>
        /// Gets and sets the property MonitoringJobDefinition. 
        /// <para>
        /// Defines the monitoring job.
        /// </para>
        /// </summary>
        public MonitoringJobDefinition MonitoringJobDefinition { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringJobDefinition property is set.
        /// </summary>
        internal bool IsSetMonitoringJobDefinition() => this.MonitoringJobDefinition != null;

        /// <summary>
        /// Gets and sets the property MonitoringJobDefinitionName. 
        /// <para>
        /// The name of the monitoring job definition to schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string MonitoringJobDefinitionName { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringJobDefinitionName property is set.
        /// </summary>
        internal bool IsSetMonitoringJobDefinitionName() => this.MonitoringJobDefinitionName != null;

        /// <summary>
        /// Gets and sets the property MonitoringType. 
        /// <para>
        /// The type of the monitoring job definition to schedule.
        /// </para>
        /// </summary>
        public MonitoringType MonitoringType { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringType property is set.
        /// </summary>
        internal bool IsSetMonitoringType() => this.MonitoringType != null;

        /// <summary>
        /// Gets and sets the property ScheduleConfig. 
        /// <para>
        /// Configures the monitoring schedule.
        /// </para>
        /// </summary>
        public ScheduleConfig ScheduleConfig { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleConfig property is set.
        /// </summary>
        internal bool IsSetScheduleConfig() => this.ScheduleConfig != null;
    }
}
