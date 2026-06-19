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
    /// Attributes describing the details of an agentic retrieval trace event.
    /// </summary>
    public partial class AgenticRetrieveTraceEventAttributes
    {
        private List<AgenticRetrieveAction> _actions = AWSConfigs.InitializeCollections ? new List<AgenticRetrieveAction>() : null;
        private List<AgenticRetrieveFailure> _failures = AWSConfigs.InitializeCollections ? new List<AgenticRetrieveFailure>() : null;
        private string _message;
        private List<AgenticRetrieveSourceMetadata> _retrievalMetadata = AWSConfigs.InitializeCollections ? new List<AgenticRetrieveSourceMetadata>() : null;
        private List<AgenticRetrieveTraceResultItem> _retrievalResponse = AWSConfigs.InitializeCollections ? new List<AgenticRetrieveTraceResultItem>() : null;
        private AgenticRetrieveStatus _status;
        private AgenticRetrieveStep _step;
        private List<AgenticRetrieveWarning> _warnings = AWSConfigs.InitializeCollections ? new List<AgenticRetrieveWarning>() : null;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The list of actions taken during this step.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AgenticRetrieveAction> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && (this._actions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Failures. 
        /// <para>
        /// Failures that occurred during this step.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<AgenticRetrieveFailure> Failures
        {
            get { return this._failures; }
            set { this._failures = value; }
        }

        // Check to see if Failures property is set
        internal bool IsSetFailures()
        {
            return this._failures != null && (this._failures.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A human-readable message describing the trace event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property RetrievalMetadata. 
        /// <para>
        /// Metadata about the retrieval sources used.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AgenticRetrieveSourceMetadata> RetrievalMetadata
        {
            get { return this._retrievalMetadata; }
            set { this._retrievalMetadata = value; }
        }

        // Check to see if RetrievalMetadata property is set
        internal bool IsSetRetrievalMetadata()
        {
            return this._retrievalMetadata != null && (this._retrievalMetadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RetrievalResponse. 
        /// <para>
        /// The retrieval results from this step.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AgenticRetrieveTraceResultItem> RetrievalResponse
        {
            get { return this._retrievalResponse; }
            set { this._retrievalResponse = value; }
        }

        // Check to see if RetrievalResponse property is set
        internal bool IsSetRetrievalResponse()
        {
            return this._retrievalResponse != null && (this._retrievalResponse.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the current step.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AgenticRetrieveStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Step. 
        /// <para>
        /// The current step in the retrieval process.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AgenticRetrieveStep Step
        {
            get { return this._step; }
            set { this._step = value; }
        }

        // Check to see if Step property is set
        internal bool IsSetStep()
        {
            return this._step != null;
        }

        /// <summary>
        /// Gets and sets the property Warnings. 
        /// <para>
        /// Warnings generated during this step.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<AgenticRetrieveWarning> Warnings
        {
            get { return this._warnings; }
            set { this._warnings = value; }
        }

        // Check to see if Warnings property is set
        internal bool IsSetWarnings()
        {
            return this._warnings != null && (this._warnings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}