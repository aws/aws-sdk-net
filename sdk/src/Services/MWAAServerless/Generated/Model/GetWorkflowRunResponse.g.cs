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

namespace Amazon.MWAAServerless.Model
{
    /// <summary>
    /// This is the response object from the GetWorkflowRun operation.
    /// </summary>
    public partial class GetWorkflowRunResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property OverrideParameters. 
        /// <para>
        /// Parameters that were overridden for this specific workflow run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, Amazon.Runtime.Documents.Document> OverrideParameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, Amazon.Runtime.Documents.Document>() : null;

        /// <summary>
        /// Checks to see if the OverrideParameters property is set.
        /// </summary>
        internal bool IsSetOverrideParameters() => this.OverrideParameters != null && (this.OverrideParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RunDetail. 
        /// <para>
        /// Detailed information about the workflow run execution, including timing, status, and
        /// task instances.
        /// </para>
        /// </summary>
        public WorkflowRunDetail RunDetail { get; set; }

        /// <summary>
        /// Checks to see if the RunDetail property is set.
        /// </summary>
        internal bool IsSetRunDetail() => this.RunDetail != null;

        /// <summary>
        /// Gets and sets the property RunId. 
        /// <para>
        /// The unique identifier of this workflow run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string RunId { get; set; }

        /// <summary>
        /// Checks to see if the RunId property is set.
        /// </summary>
        internal bool IsSetRunId() => this.RunId != null;

        /// <summary>
        /// Gets and sets the property RunType. 
        /// <para>
        /// The type of workflow run. Values are <c>ON_DEMAND</c> (manually triggered) or <c>SCHEDULED</c>
        /// (automatically triggered by schedule).
        /// </para>
        /// </summary>
        public RunType RunType { get; set; }

        /// <summary>
        /// Checks to see if the RunType property is set.
        /// </summary>
        internal bool IsSetRunType() => this.RunType != null;

        /// <summary>
        /// Gets and sets the property WorkflowArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the workflow that contains this run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string WorkflowArn { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowArn property is set.
        /// </summary>
        internal bool IsSetWorkflowArn() => this.WorkflowArn != null;

        /// <summary>
        /// Gets and sets the property WorkflowVersion. 
        /// <para>
        /// The version of the workflow that is used for this run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string WorkflowVersion { get; set; }

        /// <summary>
        /// Checks to see if the WorkflowVersion property is set.
        /// </summary>
        internal bool IsSetWorkflowVersion() => this.WorkflowVersion != null;
    }
}
