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

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Contains information about an action (operation) called by a node during execution.
    /// </summary>
    public partial class NodeActionEvent
    {
        /// <summary>
        /// Gets and sets the property NodeName. 
        /// <para>
        /// The name of the node that called the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NodeName { get; set; }

        /// <summary>
        /// Checks to see if the NodeName property is set.
        /// </summary>
        internal bool IsSetNodeName() => this.NodeName != null;

        /// <summary>
        /// Gets and sets the property OperationName. 
        /// <para>
        /// The name of the operation that the node called.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OperationName { get; set; }

        /// <summary>
        /// Checks to see if the OperationName property is set.
        /// </summary>
        internal bool IsSetOperationName() => this.OperationName != null;

        /// <summary>
        /// Gets and sets the property OperationRequest. 
        /// <para>
        /// The request payload sent to the downstream service.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document OperationRequest { get; set; }

        /// <summary>
        /// Checks to see if the OperationRequest property is set.
        /// </summary>
        internal bool IsSetOperationRequest() => !this.OperationRequest.IsNull();

        /// <summary>
        /// Gets and sets the property OperationResponse. 
        /// <para>
        /// The response payload received from the downstream service.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document OperationResponse { get; set; }

        /// <summary>
        /// Checks to see if the OperationResponse property is set.
        /// </summary>
        internal bool IsSetOperationResponse() => !this.OperationResponse.IsNull();

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The ID of the request that the node made to the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RequestId { get; set; }

        /// <summary>
        /// Checks to see if the RequestId property is set.
        /// </summary>
        internal bool IsSetRequestId() => this.RequestId != null;

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the service that the node called.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The date and time that the operation was called.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;
    }
}
