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

namespace Amazon.CodeCatalyst.Model
{
    /// <summary>
    /// Information about a workflow.
    /// </summary>
    public partial class WorkflowSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The date and time the workflow was created, in coordinated universal time (UTC) timestamp
        /// format as specified in <a href="https://www.rfc-editor.org/rfc/rfc3339#section-5.6">RFC
        /// 3339</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// Information about the workflow definition file.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WorkflowDefinitionSummary Definition { get; set; }

        /// <summary>
        /// Checks to see if the Definition property is set.
        /// </summary>
        internal bool IsSetDefinition() => this.Definition != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The system-generated unique ID of a workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The date and time the workflow was last updated, in coordinated universal time (UTC)
        /// timestamp format as specified in <a href="https://www.rfc-editor.org/rfc/rfc3339#section-5.6">RFC
        /// 3339</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RunMode. 
        /// <para>
        /// The run mode of the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WorkflowRunMode RunMode { get; set; }

        /// <summary>
        /// Checks to see if the RunMode property is set.
        /// </summary>
        internal bool IsSetRunMode() => this.RunMode != null;

        /// <summary>
        /// Gets and sets the property SourceBranchName. 
        /// <para>
        /// The name of the branch of the source repository where the workflow definition file
        /// is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string SourceBranchName { get; set; }

        /// <summary>
        /// Checks to see if the SourceBranchName property is set.
        /// </summary>
        internal bool IsSetSourceBranchName() => this.SourceBranchName != null;

        /// <summary>
        /// Gets and sets the property SourceRepositoryName. 
        /// <para>
        /// The name of the source repository where the workflow definition file is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string SourceRepositoryName { get; set; }

        /// <summary>
        /// Checks to see if the SourceRepositoryName property is set.
        /// </summary>
        internal bool IsSetSourceRepositoryName() => this.SourceRepositoryName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WorkflowStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
