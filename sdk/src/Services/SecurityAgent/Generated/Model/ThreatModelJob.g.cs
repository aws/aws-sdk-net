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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Represents a threat model job, which is an execution instance of a threat model.
    /// </summary>
    public partial class ThreatModelJob
    {
        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The unique identifier of the agent space.
        /// </para>
        /// </summary>
        public string AgentSpaceId { get; set; }

        /// <summary>
        /// Checks to see if the AgentSpaceId property is set.
        /// </summary>
        internal bool IsSetAgentSpaceId() => this.AgentSpaceId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the threat model job was created, in UTC format.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Documents. 
        /// <para>
        /// The list of documents used for threat modeling.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DocumentInfo> Documents { get; set; } = AWSConfigs.InitializeCollections ? new List<DocumentInfo>() : null;

        /// <summary>
        /// Checks to see if the Documents property is set.
        /// </summary>
        internal bool IsSetDocuments() => this.Documents != null && (this.Documents.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ErrorInformation. 
        /// <para>
        /// Error information if the threat model job encountered an error.
        /// </para>
        /// </summary>
        public ErrorInformation ErrorInformation { get; set; }

        /// <summary>
        /// Checks to see if the ErrorInformation property is set.
        /// </summary>
        internal bool IsSetErrorInformation() => this.ErrorInformation != null;

        /// <summary>
        /// Gets and sets the property ExecutionEndTime. 
        /// <para>
        /// The date and time the threat model job execution ended, in UTC format.
        /// </para>
        /// </summary>
        public DateTime? ExecutionEndTime { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionEndTime property is set.
        /// </summary>
        internal bool IsSetExecutionEndTime() => this.ExecutionEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ExecutionStartTime. 
        /// <para>
        /// The date and time the threat model job execution started, in UTC format.
        /// </para>
        /// </summary>
        public DateTime? ExecutionStartTime { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionStartTime property is set.
        /// </summary>
        internal bool IsSetExecutionStartTime() => this.ExecutionStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property IntegratedRepositories. 
        /// <para>
        /// The list of integrated repositories used for threat modeling.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IntegratedRepository> IntegratedRepositories { get; set; } = AWSConfigs.InitializeCollections ? new List<IntegratedRepository>() : null;

        /// <summary>
        /// Checks to see if the IntegratedRepositories property is set.
        /// </summary>
        internal bool IsSetIntegratedRepositories() => this.IntegratedRepositories != null && (this.IntegratedRepositories.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScopeDocs. 
        /// <para>
        /// The scoped documents for the agent to focus on during threat modeling.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DocumentInfo> ScopeDocs { get; set; } = AWSConfigs.InitializeCollections ? new List<DocumentInfo>() : null;

        /// <summary>
        /// Checks to see if the ScopeDocs property is set.
        /// </summary>
        internal bool IsSetScopeDocs() => this.ScopeDocs != null && (this.ScopeDocs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceCode. 
        /// <para>
        /// The list of source code repositories used for threat modeling.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SourceCodeRepository> SourceCode { get; set; } = AWSConfigs.InitializeCollections ? new List<SourceCodeRepository>() : null;

        /// <summary>
        /// Checks to see if the SourceCode property is set.
        /// </summary>
        internal bool IsSetSourceCode() => this.SourceCode != null && (this.SourceCode.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the threat model job.
        /// </para>
        /// </summary>
        public JobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SystemOverview. 
        /// <para>
        /// The system overview generated during threat modeling.
        /// </para>
        /// </summary>
        public string SystemOverview { get; set; }

        /// <summary>
        /// Checks to see if the SystemOverview property is set.
        /// </summary>
        internal bool IsSetSystemOverview() => this.SystemOverview != null;

        /// <summary>
        /// Gets and sets the property ThreatModelId. 
        /// <para>
        /// The unique identifier of the threat model associated with the job.
        /// </para>
        /// </summary>
        public string ThreatModelId { get; set; }

        /// <summary>
        /// Checks to see if the ThreatModelId property is set.
        /// </summary>
        internal bool IsSetThreatModelId() => this.ThreatModelId != null;

        /// <summary>
        /// Gets and sets the property ThreatModelJobId. 
        /// <para>
        /// The unique identifier of the threat model job.
        /// </para>
        /// </summary>
        public string ThreatModelJobId { get; set; }

        /// <summary>
        /// Checks to see if the ThreatModelJobId property is set.
        /// </summary>
        internal bool IsSetThreatModelJobId() => this.ThreatModelJobId != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the threat model job.
        /// </para>
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time the threat model job was last updated, in UTC format.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
