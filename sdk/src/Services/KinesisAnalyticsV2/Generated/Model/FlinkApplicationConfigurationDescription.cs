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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
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
namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Describes configuration parameters for a Managed Service for Apache Flink application.
    /// </summary>
    public partial class FlinkApplicationConfigurationDescription
    {
        private CheckpointConfigurationDescription _checkpointConfigurationDescription;
        private string _jobPlanDescription;
        private MonitoringConfigurationDescription _monitoringConfigurationDescription;
        private ParallelismConfigurationDescription _parallelismConfigurationDescription;

        /// <summary>
        /// Gets and sets the property CheckpointConfigurationDescription. 
        /// <para>
        /// Describes an application's checkpointing configuration. Checkpointing is the process
        /// of persisting application state for fault tolerance.
        /// </para>
        /// </summary>
        public CheckpointConfigurationDescription CheckpointConfigurationDescription
        {
            get { return this._checkpointConfigurationDescription; }
            set { this._checkpointConfigurationDescription = value; }
        }

        // Check to see if CheckpointConfigurationDescription property is set
        internal bool IsSetCheckpointConfigurationDescription()
        {
            return this._checkpointConfigurationDescription != null;
        }

        /// <summary>
        /// Gets and sets the property JobPlanDescription. 
        /// <para>
        /// The job plan for an application. For more information about the job plan, see <a href="https://nightlies.apache.org/flink/flink-docs-release-1.20/internals/job_scheduling.html">Jobs
        /// and Scheduling</a> in the <a href="https://nightlies.apache.org/flink/flink-docs-release-1.20/">Apache
        /// Flink Documentation</a>. To retrieve the job plan for the application, use the <a>DescribeApplicationRequest$IncludeAdditionalDetails</a>
        /// parameter of the <a>DescribeApplication</a> operation.
        /// </para>
        /// </summary>
        public string JobPlanDescription
        {
            get { return this._jobPlanDescription; }
            set { this._jobPlanDescription = value; }
        }

        // Check to see if JobPlanDescription property is set
        internal bool IsSetJobPlanDescription()
        {
            return this._jobPlanDescription != null;
        }

        /// <summary>
        /// Gets and sets the property MonitoringConfigurationDescription. 
        /// <para>
        /// Describes configuration parameters for Amazon CloudWatch logging for an application.
        /// </para>
        /// </summary>
        public MonitoringConfigurationDescription MonitoringConfigurationDescription
        {
            get { return this._monitoringConfigurationDescription; }
            set { this._monitoringConfigurationDescription = value; }
        }

        // Check to see if MonitoringConfigurationDescription property is set
        internal bool IsSetMonitoringConfigurationDescription()
        {
            return this._monitoringConfigurationDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ParallelismConfigurationDescription. 
        /// <para>
        /// Describes parameters for how an application executes multiple tasks simultaneously.
        /// </para>
        /// </summary>
        public ParallelismConfigurationDescription ParallelismConfigurationDescription
        {
            get { return this._parallelismConfigurationDescription; }
            set { this._parallelismConfigurationDescription = value; }
        }

        // Check to see if ParallelismConfigurationDescription property is set
        internal bool IsSetParallelismConfigurationDescription()
        {
            return this._parallelismConfigurationDescription != null;
        }

    }
}