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
    /// Configuration for workflow logging that specifies where you should store your workflow
    /// execution logs. Amazon Managed Workflows for Apache Airflow Serverless provides comprehensive
    /// logging capabilities that capture workflow execution details, task-level information,
    /// and system events. Logs are automatically exported to your specified CloudWatch log
    /// group using remote logging functionality, providing centralized observability across
    /// the distributed, multi-tenant execution environment. This enables effective debugging,
    /// monitoring, and compliance auditing of workflow executions.
    /// </summary>
    public partial class LoggingConfiguration
    {
        private string _logGroupName;

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The name of the CloudWatch log group where workflow execution logs are stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LogGroupName
        {
            get { return this._logGroupName; }
            set { this._logGroupName = value; }
        }

        // Check to see if LogGroupName property is set
        internal bool IsSetLogGroupName()
        {
            return this._logGroupName != null;
        }

    }
}