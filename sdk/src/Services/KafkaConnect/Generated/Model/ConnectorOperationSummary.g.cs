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

namespace Amazon.KafkaConnect.Model
{
    /// <summary>
    /// Summary of a connector operation.
    /// </summary>
    public partial class ConnectorOperationSummary
    {
        /// <summary>
        /// Gets and sets the property ConnectorOperationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the connector operation.
        /// </para>
        /// </summary>
        public string ConnectorOperationArn { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorOperationArn property is set.
        /// </summary>
        internal bool IsSetConnectorOperationArn() => this.ConnectorOperationArn != null;

        /// <summary>
        /// Gets and sets the property ConnectorOperationState. 
        /// <para>
        /// The state of the connector operation.
        /// </para>
        /// </summary>
        public ConnectorOperationState ConnectorOperationState { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorOperationState property is set.
        /// </summary>
        internal bool IsSetConnectorOperationState() => this.ConnectorOperationState != null;

        /// <summary>
        /// Gets and sets the property ConnectorOperationType. 
        /// <para>
        /// The type of connector operation performed.
        /// </para>
        /// </summary>
        public ConnectorOperationType ConnectorOperationType { get; set; }

        /// <summary>
        /// Checks to see if the ConnectorOperationType property is set.
        /// </summary>
        internal bool IsSetConnectorOperationType() => this.ConnectorOperationType != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when operation was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time when operation ended.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;
    }
}
