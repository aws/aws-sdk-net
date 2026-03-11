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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
    /// Contains information about an action (operation) called by a node in an Amazon Bedrock
    /// flow. The service generates action events for calls made by prompt nodes, agent nodes,
    /// and Amazon Web Services Lambda nodes.
    /// </summary>
    public partial class FlowTraceNodeActionEvent
    {
        private string _nodeName;
        private string _operationName;
        private Amazon.Runtime.Documents.Document _operationRequest;
        private Amazon.Runtime.Documents.Document _operationResponse;
        private string _requestId;
        private string _serviceName;
        private DateTime? _timestamp;

        /// <summary>
        /// Gets and sets the property NodeName. 
        /// <para>
        /// The name of the node that called the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NodeName
        {
            get { return this._nodeName; }
            set { this._nodeName = value; }
        }

        // Check to see if NodeName property is set
        internal bool IsSetNodeName()
        {
            return this._nodeName != null;
        }

        /// <summary>
        /// Gets and sets the property OperationName. 
        /// <para>
        /// The name of the operation that the node called.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OperationName
        {
            get { return this._operationName; }
            set { this._operationName = value; }
        }

        // Check to see if OperationName property is set
        internal bool IsSetOperationName()
        {
            return this._operationName != null;
        }

        /// <summary>
        /// Gets and sets the property OperationRequest. 
        /// <para>
        /// The request payload sent to the downstream service.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document OperationRequest
        {
            get { return this._operationRequest; }
            set { this._operationRequest = value; }
        }

        // Check to see if OperationRequest property is set
        internal bool IsSetOperationRequest()
        {
            return !this._operationRequest.IsNull();
        }

        /// <summary>
        /// Gets and sets the property OperationResponse. 
        /// <para>
        /// The response payload received from the downstream service.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document OperationResponse
        {
            get { return this._operationResponse; }
            set { this._operationResponse = value; }
        }

        // Check to see if OperationResponse property is set
        internal bool IsSetOperationResponse()
        {
            return !this._operationResponse.IsNull();
        }

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The ID of the request that the node made to the operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the service that the node called.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The date and time that the operation was called.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

    }
}