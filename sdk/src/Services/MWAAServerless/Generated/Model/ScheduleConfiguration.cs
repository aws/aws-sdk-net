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
 * Do not modify this file. This file is generated from the mwaa-serverless-2024-07-26.normal.json service model.
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
namespace Amazon.MWAAServerless.Model
{
    /// <summary>
    /// The configuration to use to schedule automated workflow execution using cron expressions.
    /// Amazon Managed Workflows for Apache Airflow Serverless integrates with EventBridge
    /// Scheduler to provide cost-effective, timezone-aware scheduling capabilities. The service
    /// supports both time-based and event-based scheduling (event-based scheduling available
    /// post-GA). When a workflow definition includes scheduling information, Amazon Managed
    /// Workflows for Apache Airflow Serverless automatically configures the appropriate triggers
    /// and ensures only one version of a workflow has an active schedule at any time.
    /// </summary>
    public partial class ScheduleConfiguration
    {
        private string _cronExpression;

        /// <summary>
        /// Gets and sets the property CronExpression. 
        /// <para>
        /// A cron expression that defines when the workflow is automatically executed. Uses standard
        /// cron syntax.
        /// </para>
        /// </summary>
        public string CronExpression
        {
            get { return this._cronExpression; }
            set { this._cronExpression = value; }
        }

        // Check to see if CronExpression property is set
        internal bool IsSetCronExpression()
        {
            return this._cronExpression != null;
        }

    }
}