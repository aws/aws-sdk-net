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
    /// This is the response object from the CreateNotebook operation.
    /// </summary>
    public partial class CreateNotebookResponse : AmazonWebServiceResponse
    {
        private List<CellInformation> _cellOrder = AWSConfigs.InitializeCollections ? new List<CellInformation>() : null;
        private string _computeId;
        private DateTime? _createdAt;
        private string _createdBy;
        private string _description;
        private string _domainId;
        private EnvironmentConfig _environmentConfiguration;
        private NotebookError _error;
        private string _id;
        private DateTime? _lockedAt;
        private string _lockedBy;
        private DateTime? _lockExpiresAt;
        private Dictionary<string, string> _metadata = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _name;
        private string _owningProjectId;
        private Dictionary<string, string> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private NotebookStatus _status;
        private DateTime? _updatedAt;
        private string _updatedBy;

        /// <summary>
        /// Gets and sets the property CellOrder. 
        /// <para>
        /// The ordered list of cells in the notebook.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=200)]
        public List<CellInformation> CellOrder
        {
            get { return this._cellOrder; }
            set { this._cellOrder = value; }
        }

        // Check to see if CellOrder property is set
        internal bool IsSetCellOrder()
        {
            return this._cellOrder != null && (this._cellOrder.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ComputeId. 
        /// <para>
        /// The identifier of the compute associated with the notebook.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string ComputeId
        {
            get { return this._computeId; }
            set { this._computeId = value; }
        }

        // Check to see if ComputeId property is set
        internal bool IsSetComputeId()
        {
            return this._computeId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the notebook was created.
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
        /// The identifier of the user who created the notebook.
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
        /// The description of the notebook.
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
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property EnvironmentConfiguration. 
        /// <para>
        /// The environment configuration of the notebook.
        /// </para>
        /// </summary>
        public EnvironmentConfig EnvironmentConfiguration
        {
            get { return this._environmentConfiguration; }
            set { this._environmentConfiguration = value; }
        }

        // Check to see if EnvironmentConfiguration property is set
        internal bool IsSetEnvironmentConfiguration()
        {
            return this._environmentConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// The error details if the notebook creation failed.
        /// </para>
        /// </summary>
        public NotebookError Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the notebook.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LockedAt. 
        /// <para>
        /// The timestamp of when the notebook was locked.
        /// </para>
        /// </summary>
        public DateTime? LockedAt
        {
            get { return this._lockedAt; }
            set { this._lockedAt = value; }
        }

        // Check to see if LockedAt property is set
        internal bool IsSetLockedAt()
        {
            return this._lockedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LockedBy. 
        /// <para>
        /// The identifier of the user who locked the notebook.
        /// </para>
        /// </summary>
        public string LockedBy
        {
            get { return this._lockedBy; }
            set { this._lockedBy = value; }
        }

        // Check to see if LockedBy property is set
        internal bool IsSetLockedBy()
        {
            return this._lockedBy != null;
        }

        /// <summary>
        /// Gets and sets the property LockExpiresAt. 
        /// <para>
        /// The timestamp of when the notebook lock expires.
        /// </para>
        /// </summary>
        public DateTime? LockExpiresAt
        {
            get { return this._lockExpiresAt; }
            set { this._lockExpiresAt = value; }
        }

        // Check to see if LockExpiresAt property is set
        internal bool IsSetLockExpiresAt()
        {
            return this._lockExpiresAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The metadata of the notebook.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null && (this._metadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the notebook.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=256)]
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
        /// Gets and sets the property OwningProjectId. 
        /// <para>
        /// The identifier of the project that owns the notebook.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The sensitive parameters of the notebook.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=50)]
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the notebook.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when the notebook was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedBy. 
        /// <para>
        /// The identifier of the user who last updated the notebook.
        /// </para>
        /// </summary>
        public string UpdatedBy
        {
            get { return this._updatedBy; }
            set { this._updatedBy = value; }
        }

        // Check to see if UpdatedBy property is set
        internal bool IsSetUpdatedBy()
        {
            return this._updatedBy != null;
        }

    }
}