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
 * Do not modify this file. This file is generated from the mwaa-2020-07-01.normal.json service model.
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
        private ModuleLoggingConfigurationInput _dagProcessingLogs;
        private ModuleLoggingConfigurationInput _schedulerLogs;
        private ModuleLoggingConfigurationInput _taskLogs;
        private ModuleLoggingConfigurationInput _webserverLogs;
        private ModuleLoggingConfigurationInput _workerLogs;

        /// <summary>
        /// Gets and sets the property DagProcessingLogs. 
        /// <para>
        /// Publishes Airflow DAG processing logs to CloudWatch Logs.
        /// </para>
        /// </summary>
        public ModuleLoggingConfigurationInput DagProcessingLogs
        {
            get { return this._dagProcessingLogs; }
            set { this._dagProcessingLogs = value; }
        }

        // Check to see if DagProcessingLogs property is set
        internal bool IsSetDagProcessingLogs()
        {
            return this._dagProcessingLogs != null;
        }

        /// <summary>
        /// Gets and sets the property SchedulerLogs. 
        /// <para>
        /// Publishes Airflow scheduler logs to CloudWatch Logs.
        /// </para>
        /// </summary>
        public ModuleLoggingConfigurationInput SchedulerLogs
        {
            get { return this._schedulerLogs; }
            set { this._schedulerLogs = value; }
        }

        // Check to see if SchedulerLogs property is set
        internal bool IsSetSchedulerLogs()
        {
            return this._schedulerLogs != null;
        }

        /// <summary>
        /// Gets and sets the property TaskLogs. 
        /// <para>
        /// Publishes Airflow task logs to CloudWatch Logs.
        /// </para>
        /// </summary>
        public ModuleLoggingConfigurationInput TaskLogs
        {
            get { return this._taskLogs; }
            set { this._taskLogs = value; }
        }

        // Check to see if TaskLogs property is set
        internal bool IsSetTaskLogs()
        {
            return this._taskLogs != null;
        }

        /// <summary>
        /// Gets and sets the property WebserverLogs. 
        /// <para>
        /// Publishes Airflow web server logs to CloudWatch Logs.
        /// </para>
        /// </summary>
        public ModuleLoggingConfigurationInput WebserverLogs
        {
            get { return this._webserverLogs; }
            set { this._webserverLogs = value; }
        }

        // Check to see if WebserverLogs property is set
        internal bool IsSetWebserverLogs()
        {
            return this._webserverLogs != null;
        }

        /// <summary>
        /// Gets and sets the property WorkerLogs. 
        /// <para>
        /// Publishes Airflow worker logs to CloudWatch Logs.
        /// </para>
        /// </summary>
        public ModuleLoggingConfigurationInput WorkerLogs
        {
            get { return this._workerLogs; }
            set { this._workerLogs = value; }
        }

        // Check to see if WorkerLogs property is set
        internal bool IsSetWorkerLogs()
        {
            return this._workerLogs != null;
        }

    }
}