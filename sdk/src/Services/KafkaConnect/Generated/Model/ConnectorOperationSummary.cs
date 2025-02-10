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
    /// Summary of a connector operation.
    /// </summary>
    public partial class ConnectorOperationSummary
    {
        private string _connectorOperationArn;
        private ConnectorOperationState _connectorOperationState;
        private ConnectorOperationType _connectorOperationType;
        private DateTime? _creationTime;
        private DateTime? _endTime;

        /// <summary>
        /// Gets and sets the property ConnectorOperationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the connector operation.
        /// </para>
        /// </summary>
        public string ConnectorOperationArn
        {
            get { return this._connectorOperationArn; }
            set { this._connectorOperationArn = value; }
        }

        // Check to see if ConnectorOperationArn property is set
        internal bool IsSetConnectorOperationArn()
        {
            return this._connectorOperationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorOperationState. 
        /// <para>
        /// The state of the connector operation.
        /// </para>
        /// </summary>
        public ConnectorOperationState ConnectorOperationState
        {
            get { return this._connectorOperationState; }
            set { this._connectorOperationState = value; }
        }

        // Check to see if ConnectorOperationState property is set
        internal bool IsSetConnectorOperationState()
        {
            return this._connectorOperationState != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorOperationType. 
        /// <para>
        /// The type of connector operation performed.
        /// </para>
        /// </summary>
        public ConnectorOperationType ConnectorOperationType
        {
            get { return this._connectorOperationType; }
            set { this._connectorOperationType = value; }
        }

        // Check to see if ConnectorOperationType property is set
        internal bool IsSetConnectorOperationType()
        {
            return this._connectorOperationType != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when operation was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time when operation ended.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

    }
}