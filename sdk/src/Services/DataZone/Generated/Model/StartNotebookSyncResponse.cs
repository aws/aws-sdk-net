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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
    /// This is the response object from the StartNotebookSync operation.
    /// </summary>
    public partial class StartNotebookSyncResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private string _createdBy;
        private string _description;
        private string _domainId;
        private GitMetadata _gitMetadata;
        private string _name;
        private string _notebookId;
        private string _owningProjectId;
        private SourceLocation _sourceLocation;
        private NotebookStatus _status;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the notebook sync was started.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The identifier of the user who started the notebook sync.
        /// </para>
        /// </summary>
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the synced notebook.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The identifier of the Amazon SageMaker Unified Studio domain.
        /// </para>
        /// </summary>
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property GitMetadata. 
        /// <para>
        /// The Git metadata associated with the synced notebook.
        /// </para>
        /// </summary>
        public GitMetadata GitMetadata
        {
            get { return this._gitMetadata; }
            set { this._gitMetadata = value; }
        }

        // Check to see if GitMetadata property is set
        internal bool IsSetGitMetadata()
        {
            return this._gitMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the synced notebook.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NotebookId. 
        /// <para>
        /// The identifier of the synced notebook.
        /// </para>
        /// </summary>
        public string NotebookId
        {
            get { return this._notebookId; }
            set { this._notebookId = value; }
        }

        // Check to see if NotebookId property is set
        internal bool IsSetNotebookId()
        {
            return this._notebookId != null;
        }

        /// <summary>
        /// Gets and sets the property OwningProjectId. 
        /// <para>
        /// The identifier of the project that owns the synced notebook.
        /// </para>
        /// </summary>
        public string OwningProjectId
        {
            get { return this._owningProjectId; }
            set { this._owningProjectId = value; }
        }

        // Check to see if OwningProjectId property is set
        internal bool IsSetOwningProjectId()
        {
            return this._owningProjectId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceLocation. 
        /// <para>
        /// The source location from which the notebook was synced.
        /// </para>
        /// </summary>
        public SourceLocation SourceLocation
        {
            get { return this._sourceLocation; }
            set { this._sourceLocation = value; }
        }

        // Check to see if SourceLocation property is set
        internal bool IsSetSourceLocation()
        {
            return this._sourceLocation != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the notebook sync.
        /// </para>
        /// </summary>
        public NotebookStatus Status
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