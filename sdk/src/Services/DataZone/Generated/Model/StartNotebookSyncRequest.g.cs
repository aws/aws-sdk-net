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
    /// Container for the parameters to the StartNotebookSync operation. Starts a notebook
    /// sync in Amazon SageMaker Unified Studio. This operation syncs a notebook from a Git
    /// repository into a project.
    /// </summary>
    public partial class StartNotebookSyncRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure idempotency of the request. This field
        /// is automatically populated if not provided.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

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
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The identifier of the Amazon SageMaker Unified Studio domain in which to sync the
        /// notebook.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DomainIdentifier property is set.
        /// </summary>
        internal bool IsSetDomainIdentifier() => this.DomainIdentifier != null;

        /// <summary>
        /// Gets and sets the property GitMetadata. 
        /// <para>
        /// The Git metadata for the notebook sync, including repository, branch, and commit information.
        /// </para>
        /// </summary>
        public GitMetadata GitMetadata { get; set; }

        /// <summary>
        /// Checks to see if the GitMetadata property is set.
        /// </summary>
        internal bool IsSetGitMetadata() => this.GitMetadata != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the notebook. The name must be between 1 and 256 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NotebookId. 
        /// <para>
        /// The identifier of an existing notebook to sync. If not specified, a new notebook is
        /// created.
        /// </para>
        /// </summary>
        public string NotebookId { get; set; }

        /// <summary>
        /// Checks to see if the NotebookId property is set.
        /// </summary>
        internal bool IsSetNotebookId() => this.NotebookId != null;

        /// <summary>
        /// Gets and sets the property OwningProjectIdentifier. 
        /// <para>
        /// The identifier of the project that will own the synced notebook.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OwningProjectIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the OwningProjectIdentifier property is set.
        /// </summary>
        internal bool IsSetOwningProjectIdentifier() => this.OwningProjectIdentifier != null;

        /// <summary>
        /// Gets and sets the property SourceLocation. 
        /// <para>
        /// The source location of the notebook to sync. This specifies the Amazon Simple Storage
        /// Service URI of the notebook file.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SourceLocation SourceLocation { get; set; }

        /// <summary>
        /// Checks to see if the SourceLocation property is set.
        /// </summary>
        internal bool IsSetSourceLocation() => this.SourceLocation != null;
    }
}
