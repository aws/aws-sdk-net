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

namespace Amazon.MWAA.Model
{
    /// <summary>
    /// Defines the Apache Airflow log types to send to CloudWatch Logs.
    /// </summary>
    public partial class LoggingConfigurationInput
    {
        /// <summary>
        /// Gets and sets the property DagProcessingLogs. 
        /// <para>
        /// Publishes Airflow DAG processing logs to CloudWatch Logs.
        /// </para>
        /// </summary>
        public ModuleLoggingConfigurationInput DagProcessingLogs { get; set; }

        /// <summary>
        /// Checks to see if the DagProcessingLogs property is set.
        /// </summary>
        internal bool IsSetDagProcessingLogs() => this.DagProcessingLogs != null;

        /// <summary>
        /// Gets and sets the property SchedulerLogs. 
        /// <para>
        /// Publishes Airflow scheduler logs to CloudWatch Logs.
        /// </para>
        /// </summary>
        public ModuleLoggingConfigurationInput SchedulerLogs { get; set; }

        /// <summary>
        /// Checks to see if the SchedulerLogs property is set.
        /// </summary>
        internal bool IsSetSchedulerLogs() => this.SchedulerLogs != null;

        /// <summary>
        /// Gets and sets the property TaskLogs. 
        /// <para>
        /// Publishes Airflow task logs to CloudWatch Logs.
        /// </para>
        /// </summary>
        public ModuleLoggingConfigurationInput TaskLogs { get; set; }

        /// <summary>
        /// Checks to see if the TaskLogs property is set.
        /// </summary>
        internal bool IsSetTaskLogs() => this.TaskLogs != null;

        /// <summary>
        /// Gets and sets the property WebserverLogs. 
        /// <para>
        /// Publishes Airflow web server logs to CloudWatch Logs.
        /// </para>
        /// </summary>
        public ModuleLoggingConfigurationInput WebserverLogs { get; set; }

        /// <summary>
        /// Checks to see if the WebserverLogs property is set.
        /// </summary>
        internal bool IsSetWebserverLogs() => this.WebserverLogs != null;

        /// <summary>
        /// Gets and sets the property WorkerLogs. 
        /// <para>
        /// Publishes Airflow worker logs to CloudWatch Logs.
        /// </para>
        /// </summary>
        public ModuleLoggingConfigurationInput WorkerLogs { get; set; }

        /// <summary>
        /// Checks to see if the WorkerLogs property is set.
        /// </summary>
        internal bool IsSetWorkerLogs() => this.WorkerLogs != null;
    }
}
