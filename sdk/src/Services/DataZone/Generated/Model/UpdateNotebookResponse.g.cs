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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// This is the response object from the UpdateNotebook operation.
    /// </summary>
    public partial class UpdateNotebookResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CellOrder. 
        /// <para>
        /// The ordered list of cells in the notebook.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 200)]
        public List<CellInformation> CellOrder { get; set; } = AWSConfigs.InitializeCollections ? new List<CellInformation>() : null;

        /// <summary>
        /// Checks to see if the CellOrder property is set.
        /// </summary>
        internal bool IsSetCellOrder() => this.CellOrder != null && (this.CellOrder.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ComputeId. 
        /// <para>
        /// The identifier of the compute associated with the notebook.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 64)]
        public string ComputeId { get; set; }

        /// <summary>
        /// Checks to see if the ComputeId property is set.
        /// </summary>
        internal bool IsSetComputeId() => this.ComputeId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the notebook was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The identifier of the user who created the notebook.
        /// </para>
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the notebook.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The identifier of the Amazon SageMaker Unified Studio domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property EnvironmentConfiguration. 
        /// <para>
        /// The environment configuration of the notebook.
        /// </para>
        /// </summary>
        public EnvironmentConfig EnvironmentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentConfiguration property is set.
        /// </summary>
        internal bool IsSetEnvironmentConfiguration() => this.EnvironmentConfiguration != null;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// The error details if the notebook is in a failed state.
        /// </para>
        /// </summary>
        public NotebookError Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

        /// <summary>
        /// Gets and sets the property GitMetadata. 
        /// <para>
        /// The Git metadata associated with the notebook.
        /// </para>
        /// </summary>
        public GitMetadata GitMetadata { get; set; }

        /// <summary>
        /// Checks to see if the GitMetadata property is set.
        /// </summary>
        internal bool IsSetGitMetadata() => this.GitMetadata != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the notebook.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LockExpiresAt. 
        /// <para>
        /// The timestamp of when the notebook lock expires.
        /// </para>
        /// </summary>
        public DateTime? LockExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the LockExpiresAt property is set.
        /// </summary>
        internal bool IsSetLockExpiresAt() => this.LockExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property LockedAt. 
        /// <para>
        /// The timestamp of when the notebook was locked.
        /// </para>
        /// </summary>
        public DateTime? LockedAt { get; set; }

        /// <summary>
        /// Checks to see if the LockedAt property is set.
        /// </summary>
        internal bool IsSetLockedAt() => this.LockedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LockedBy. 
        /// <para>
        /// The identifier of the user who locked the notebook.
        /// </para>
        /// </summary>
        public string LockedBy { get; set; }

        /// <summary>
        /// Checks to see if the LockedBy property is set.
        /// </summary>
        internal bool IsSetLockedBy() => this.LockedBy != null;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The metadata of the notebook.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public Dictionary<string, string> Metadata { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null && (this.Metadata.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the notebook.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OwningProjectId. 
        /// <para>
        /// The identifier of the project that owns the notebook.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OwningProjectId { get; set; }

        /// <summary>
        /// Checks to see if the OwningProjectId property is set.
        /// </summary>
        internal bool IsSetOwningProjectId() => this.OwningProjectId != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The sensitive parameters of the notebook.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 50)]
        public Dictionary<string, string> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the notebook.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NotebookStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the notebook.
        /// </para>
        /// </summary>
        public NotebookType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when the notebook was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedBy. 
        /// <para>
        /// The identifier of the user who last updated the notebook.
        /// </para>
        /// </summary>
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedBy property is set.
        /// </summary>
        internal bool IsSetUpdatedBy() => this.UpdatedBy != null;
    }
}
