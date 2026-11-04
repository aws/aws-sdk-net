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

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// A structure that represents a decision task. Decision tasks are sent to deciders in
    /// order for them to make decisions.
    /// </summary>
    public partial class DecisionTask
    {
        /// <summary>
        /// Gets and sets the property Events. 
        /// <para>
        /// A paginated list of history events of the workflow execution. The decider uses this
        /// during the processing of the decision task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<HistoryEvent> Events { get; set; } = AWSConfigs.InitializeCollections ? new List<HistoryEvent>() : null;

        /// <summary>
        /// Checks to see if the Events property is set.
        /// </summary>
        internal bool IsSetEvents() => this.Events != null && (this.Events.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// If a <c>NextPageToken</c> was returned by a previous call, there are more results
        /// available. To retrieve the next page of results, make the call again using the returned
        /// token in <c>nextPageToken</c>. Keep all other arguments unchanged.
        /// </para>
        ///  
        /// <para>
        /// The configured <c>maximumPageSize</c> determines how many results can be returned
        /// in a single call.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// Checks to see if the NextPageToken property is set.
        /// </summary>
        internal bool IsSetNextPageToken() => this.NextPageToken != null;

        /// <summary>
        /// Gets and sets the property PreviousStartedEventId. 
        /// <para>
        /// The ID of the DecisionTaskStarted event of the previous decision task of this workflow
        /// execution that was processed by the decider. This can be used to determine the events
        /// in the history new since the last decision task received by the decider.
        /// </para>
        /// </summary>
        public long? PreviousStartedEventId { get; set; }

        /// <summary>
        /// Checks to see if the PreviousStartedEventId property is set.
        /// </summary>
        internal bool IsSetPreviousStartedEventId() => this.PreviousStartedEventId.HasValue;

        /// <summary>
        /// Gets and sets the property StartedEventId. 
        /// <para>
        /// The ID of the <c>DecisionTaskStarted</c> event recorded in the history.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? StartedEventId { get; set; }

        /// <summary>
        /// Checks to see if the StartedEventId property is set.
        /// </summary>
        internal bool IsSetStartedEventId() => this.StartedEventId.HasValue;

        /// <summary>
        /// Gets and sets the property TaskToken. 
        /// <para>
        /// The opaque string used as a handle on the task. This token is used by workers to communicate
        /// progress and response information back to the system about the task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string TaskToken { get; set; }

        /// <summary>
        /// Checks to see if the TaskToken property is set.
        /// </summary>
        internal bool IsSetTaskToken() => this.TaskToken != null;

        /// <summary>
        /// Gets and sets the property WorkflowExecution. 
        /// <para>
        /// The workflow execution for which this decision task was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WorkflowExecution WorkflowExecution { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowExecution property is set.
        /// </summary>
        internal bool IsSetWorkflowExecution() => this.WorkflowExecution != null;

        /// <summary>
        /// Gets and sets the property WorkflowType. 
        /// <para>
        /// The type of the workflow execution for which this decision task was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WorkflowType WorkflowType { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowType property is set.
        /// </summary>
        internal bool IsSetWorkflowType() => this.WorkflowType != null;
    }
}
