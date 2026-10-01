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
    /// Attributes describing the details of an agentic retrieval trace event.
    /// </summary>
    public partial class AgenticRetrieveTraceEventAttributes
    {
        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The list of actions taken during this step.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AgenticRetrieveAction> Actions { get; set; } = AWSConfigs.InitializeCollections ? new List<AgenticRetrieveAction>() : null;

        /// <summary>
        /// Checks to see if the Actions property is set.
        /// </summary>
        internal bool IsSetActions() => this.Actions != null && (this.Actions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Failures. 
        /// <para>
        /// Failures that occurred during this step.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<AgenticRetrieveFailure> Failures { get; set; } = AWSConfigs.InitializeCollections ? new List<AgenticRetrieveFailure>() : null;

        /// <summary>
        /// Checks to see if the Failures property is set.
        /// </summary>
        internal bool IsSetFailures() => this.Failures != null && (this.Failures.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A human-readable message describing the trace event.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property RetrievalMetadata. 
        /// <para>
        /// Metadata about the retrieval sources used.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AgenticRetrieveSourceMetadata> RetrievalMetadata { get; set; } = AWSConfigs.InitializeCollections ? new List<AgenticRetrieveSourceMetadata>() : null;

        /// <summary>
        /// Checks to see if the RetrievalMetadata property is set.
        /// </summary>
        internal bool IsSetRetrievalMetadata() => this.RetrievalMetadata != null && (this.RetrievalMetadata.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RetrievalResponse. 
        /// <para>
        /// The retrieval results from this step.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AgenticRetrieveTraceResultItem> RetrievalResponse { get; set; } = AWSConfigs.InitializeCollections ? new List<AgenticRetrieveTraceResultItem>() : null;

        /// <summary>
        /// Checks to see if the RetrievalResponse property is set.
        /// </summary>
        internal bool IsSetRetrievalResponse() => this.RetrievalResponse != null && (this.RetrievalResponse.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the current step.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AgenticRetrieveStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Step. 
        /// <para>
        /// The current step in the retrieval process.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AgenticRetrieveStep Step { get; set; }

        /// <summary>
        /// Checks to see if the Step property is set.
        /// </summary>
        internal bool IsSetStep() => this.Step != null;

        /// <summary>
        /// Gets and sets the property Warnings. 
        /// <para>
        /// Warnings generated during this step.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<AgenticRetrieveWarning> Warnings { get; set; } = AWSConfigs.InitializeCollections ? new List<AgenticRetrieveWarning>() : null;

        /// <summary>
        /// Checks to see if the Warnings property is set.
        /// </summary>
        internal bool IsSetWarnings() => this.Warnings != null && (this.Warnings.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
