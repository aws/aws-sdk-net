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
    /// This is the response object from the StartNotebookRun operation.
    /// </summary>
    public partial class StartNotebookRunResponse : AmazonWebServiceResponse
    {
        private List<CellInformation> _cellOrder = AWSConfigs.InitializeCollections ? new List<CellInformation>() : null;
        private DateTime? _completedAt;
        private ComputeConfig _computeConfiguration;
        private DateTime? _createdAt;
        private string _createdBy;
        private string _domainId;
        private EnvironmentConfig _environmentConfiguration;
        private NotebookRunError _error;
        private string _id;
        private Dictionary<string, string> _metadata = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private NetworkConfig _networkConfiguration;
        private string _notebookId;
        private string _owningProjectId;
        private Dictionary<string, string> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _scheduleId;
        private DateTime? _startedAt;
        private NotebookRunStatus _status;
        private StorageConfig _storageConfiguration;
        private TimeoutConfig _timeoutConfiguration;
        private TriggerSource _triggerSource;
        private DateTime? _updatedAt;
        private string _updatedBy;

        /// <summary>
        /// Gets and sets the property CellOrder. 
        /// <para>
        /// The ordered list of cells in the notebook run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
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
        /// Gets and sets the property CompletedAt. 
        /// <para>
        /// The timestamp of when the notebook run completed.
        /// </para>
        /// </summary>
        public DateTime? CompletedAt
        {
            get { return this._completedAt; }
            set { this._completedAt = value; }
        }

        // Check to see if CompletedAt property is set
        internal bool IsSetCompletedAt()
        {
            return this._completedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ComputeConfiguration. 
        /// <para>
        /// The compute configuration of the notebook run.
        /// </para>
        /// </summary>
        public ComputeConfig ComputeConfiguration
        {
            get { return this._computeConfiguration; }
            set { this._computeConfiguration = value; }
        }

        // Check to see if ComputeConfiguration property is set
        internal bool IsSetComputeConfiguration()
        {
            return this._computeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the notebook run was created.
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
        /// The identifier of the user who created the notebook run.
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
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The identifier of the Amazon DataZone domain.
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
        /// The environment configuration of the notebook run, including image version and package
        /// settings.
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
        /// The error details if the notebook run failed.
        /// </para>
        /// </summary>
        public NotebookRunError Error
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
        /// The identifier of the notebook run.
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
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The metadata of the notebook run.
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
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// The network configuration of the notebook run.
        /// </para>
        /// </summary>
        public NetworkConfig NetworkConfiguration
        {
            get { return this._networkConfiguration; }
            set { this._networkConfiguration = value; }
        }

        // Check to see if NetworkConfiguration property is set
        internal bool IsSetNetworkConfiguration()
        {
            return this._networkConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property NotebookId. 
        /// <para>
        /// The identifier of the notebook.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The identifier of the project that owns the notebook run.
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
        /// The sensitive parameters of the notebook run.
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
        /// Gets and sets the property ScheduleId. 
        /// <para>
        /// The identifier of the schedule associated with the notebook run.
        /// </para>
        /// </summary>
        public string ScheduleId
        {
            get { return this._scheduleId; }
            set { this._scheduleId = value; }
        }

        // Check to see if ScheduleId property is set
        internal bool IsSetScheduleId()
        {
            return this._scheduleId != null;
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The timestamp of when the notebook run started executing.
        /// </para>
        /// </summary>
        public DateTime? StartedAt
        {
            get { return this._startedAt; }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the notebook run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NotebookRunStatus Status
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
        /// Gets and sets the property StorageConfiguration. 
        /// <para>
        /// The storage configuration of the notebook run, including the Amazon Simple Storage
        /// Service path and KMS key ARN.
        /// </para>
        /// </summary>
        public StorageConfig StorageConfiguration
        {
            get { return this._storageConfiguration; }
            set { this._storageConfiguration = value; }
        }

        // Check to see if StorageConfiguration property is set
        internal bool IsSetStorageConfiguration()
        {
            return this._storageConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property TimeoutConfiguration. 
        /// <para>
        /// The timeout configuration of the notebook run.
        /// </para>
        /// </summary>
        public TimeoutConfig TimeoutConfiguration
        {
            get { return this._timeoutConfiguration; }
            set { this._timeoutConfiguration = value; }
        }

        // Check to see if TimeoutConfiguration property is set
        internal bool IsSetTimeoutConfiguration()
        {
            return this._timeoutConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property TriggerSource. 
        /// <para>
        /// The source that triggered the notebook run.
        /// </para>
        /// </summary>
        public TriggerSource TriggerSource
        {
            get { return this._triggerSource; }
            set { this._triggerSource = value; }
        }

        // Check to see if TriggerSource property is set
        internal bool IsSetTriggerSource()
        {
            return this._triggerSource != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when the notebook run was last updated.
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
        /// The identifier of the user who last updated the notebook run.
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