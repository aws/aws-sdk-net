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
 * Do not modify this file. This file is generated from the kafkaconnect-2021-09-14.normal.json service model.
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
namespace Amazon.KafkaConnect.Model
{
    /// <summary>
    /// Container for the parameters to the RestartConnector operation.
    /// Restarts the specified connector. By default, this operation restarts the connector
    /// and all of its tasks. This operation is asynchronous and returns a connector operation
    /// ARN that you can pass to <c>DescribeConnectorOperation</c> to track the state of the
    /// restart.
    /// </summary>
    public partial class RestartConnectorRequest : AmazonKafkaConnectRequest
    {
        private string _connectorArn;
        private bool? _onlyFailedTasks;

        /// <summary>
        /// Gets and sets the property ConnectorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the connector that you want to restart.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConnectorArn
        {
            get { return this._connectorArn; }
            set { this._connectorArn = value; }
        }

        // Check to see if ConnectorArn property is set
        internal bool IsSetConnectorArn()
        {
            return this._connectorArn != null;
        }

        /// <summary>
        /// Gets and sets the property OnlyFailedTasks. 
        /// <para>
        /// Specifies whether to restart only the connector's failed tasks. If <c>true</c>, the
        /// operation restarts only the tasks that are currently in a failed state, and healthy
        /// tasks continue running. If <c>false</c> or not specified, the operation restarts the
        /// connector and all of its tasks.
        /// </para>
        /// </summary>
        public bool? OnlyFailedTasks
        {
            get { return this._onlyFailedTasks; }
            set { this._onlyFailedTasks = value; }
        }

        // Check to see if OnlyFailedTasks property is set
        internal bool IsSetOnlyFailedTasks()
        {
            return this._onlyFailedTasks.HasValue; 
        }

    }
}