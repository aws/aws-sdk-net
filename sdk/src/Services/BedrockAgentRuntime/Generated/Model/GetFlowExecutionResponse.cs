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
    /// This is the response object from the GetFlowExecution operation.
    /// </summary>
    public partial class GetFlowExecutionResponse : AmazonWebServiceResponse
    {
        private DateTime? _endedAt;
        private List<FlowExecutionError> _errors = AWSConfigs.InitializeCollections ? new List<FlowExecutionError>() : null;
        private string _executionArn;
        private string _flowAliasIdentifier;
        private string _flowIdentifier;
        private string _flowVersion;
        private DateTime? _startedAt;
        private FlowExecutionStatus _status;

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The timestamp when the flow execution ended. This field is only populated when the
        /// execution has completed, failed, timed out, or been aborted.
        /// </para>
        /// </summary>
        public DateTime? EndedAt
        {
            get { return this._endedAt; }
            set { this._endedAt = value; }
        }

        // Check to see if EndedAt property is set
        internal bool IsSetEndedAt()
        {
            return this._endedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// A list of errors that occurred during the flow execution. Each error includes an error
        /// code, message, and the node where the error occurred, if applicable.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FlowExecutionError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && (this._errors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExecutionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the flow execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string ExecutionArn
        {
            get { return this._executionArn; }
            set { this._executionArn = value; }
        }

        // Check to see if ExecutionArn property is set
        internal bool IsSetExecutionArn()
        {
            return this._executionArn != null;
        }

        /// <summary>
        /// Gets and sets the property FlowAliasIdentifier. 
        /// <para>
        /// The unique identifier of the flow alias used for the execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string FlowAliasIdentifier
        {
            get { return this._flowAliasIdentifier; }
            set { this._flowAliasIdentifier = value; }
        }

        // Check to see if FlowAliasIdentifier property is set
        internal bool IsSetFlowAliasIdentifier()
        {
            return this._flowAliasIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property FlowIdentifier. 
        /// <para>
        /// The unique identifier of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string FlowIdentifier
        {
            get { return this._flowIdentifier; }
            set { this._flowIdentifier = value; }
        }

        // Check to see if FlowIdentifier property is set
        internal bool IsSetFlowIdentifier()
        {
            return this._flowIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property FlowVersion. 
        /// <para>
        /// The version of the flow used for the execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public string FlowVersion
        {
            get { return this._flowVersion; }
            set { this._flowVersion = value; }
        }

        // Check to see if FlowVersion property is set
        internal bool IsSetFlowVersion()
        {
            return this._flowVersion != null;
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The timestamp when the flow execution started.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartedAt
        {
            get { return this._startedAt; }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the flow execution.
        /// </para>
        ///  
        /// <para>
        /// Flow executions time out after 24 hours.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FlowExecutionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}