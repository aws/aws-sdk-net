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
    /// This is the response object from the UpdateDataSource operation.
    /// </summary>
    public partial class UpdateDataSourceResponse : AmazonWebServiceResponse
    {
        private List<FormOutput> _assetFormsOutput = AWSConfigs.InitializeCollections ? new List<FormOutput>() : null;
        private DataSourceConfigurationOutput _configuration;
        private string _connectionId;
        private DateTime? _createdAt;
        private string _description;
        private string _domainId;
        private EnableSetting _enableSetting;
        private string _environmentId;
        private DataSourceErrorMessage _errorMessage;
        private string _id;
        private DateTime? _lastRunAt;
        private DataSourceErrorMessage _lastRunErrorMessage;
        private DataSourceRunStatus _lastRunStatus;
        private string _name;
        private string _projectId;
        private bool? _publishOnImport;
        private RecommendationConfiguration _recommendation;
        private bool? _retainPermissionsOnRevokeFailure;
        private ScheduleConfiguration _schedule;
        private SelfGrantStatusOutput _selfGrantStatus;
        private DataSourceStatus _status;
        private string _type;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AssetFormsOutput. 
        /// <para>
        /// The asset forms to be updated as part of the <c>UpdateDataSource</c> action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<FormOutput> AssetFormsOutput
        {
            get { return this._assetFormsOutput; }
            set { this._assetFormsOutput = value; }
        }

        // Check to see if AssetFormsOutput property is set
        internal bool IsSetAssetFormsOutput()
        {
            return this._assetFormsOutput != null && (this._assetFormsOutput.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration to be updated as part of the <c>UpdateDataSource</c> action.
        /// </para>
        /// </summary>
        public DataSourceConfigurationOutput Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        /// The connection ID.
        /// </para>
        /// </summary>
        public string ConnectionId
        {
            get { return this._connectionId; }
            set { this._connectionId = value; }
        }

        // Check to see if ConnectionId property is set
        internal bool IsSetConnectionId()
        {
            return this._connectionId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the data source was updated.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description to be updated as part of the <c>UpdateDataSource</c> action.
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
        /// The identifier of the Amazon DataZone domain in which a data source is to be updated.
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
        /// Gets and sets the property EnableSetting. 
        /// <para>
        /// The enable setting to be updated as part of the <c>UpdateDataSource</c> action.
        /// </para>
        /// </summary>
        public EnableSetting EnableSetting
        {
            get { return this._enableSetting; }
            set { this._enableSetting = value; }
        }

        // Check to see if EnableSetting property is set
        internal bool IsSetEnableSetting()
        {
            return this._enableSetting != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The identifier of the environment in which a data source is to be updated.
        /// </para>
        /// </summary>
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// Specifies the error message that is returned if the operation cannot be successfully
        /// completed.
        /// </para>
        /// </summary>
        public DataSourceErrorMessage ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the data source to be updated.
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
        /// Gets and sets the property LastRunAt. 
        /// <para>
        /// The timestamp of when the data source was last run.
        /// </para>
        /// </summary>
        public DateTime? LastRunAt
        {
            get { return this._lastRunAt; }
            set { this._lastRunAt = value; }
        }

        // Check to see if LastRunAt property is set
        internal bool IsSetLastRunAt()
        {
            return this._lastRunAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastRunErrorMessage. 
        /// <para>
        /// The last run error message of the data source.
        /// </para>
        /// </summary>
        public DataSourceErrorMessage LastRunErrorMessage
        {
            get { return this._lastRunErrorMessage; }
            set { this._lastRunErrorMessage = value; }
        }

        // Check to see if LastRunErrorMessage property is set
        internal bool IsSetLastRunErrorMessage()
        {
            return this._lastRunErrorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property LastRunStatus. 
        /// <para>
        /// The last run status of the data source.
        /// </para>
        /// </summary>
        public DataSourceRunStatus LastRunStatus
        {
            get { return this._lastRunStatus; }
            set { this._lastRunStatus = value; }
        }

        // Check to see if LastRunStatus property is set
        internal bool IsSetLastRunStatus()
        {
            return this._lastRunStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name to be updated as part of the <c>UpdateDataSource</c> action.
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
        /// Gets and sets the property ProjectId. 
        /// <para>
        /// The identifier of the project where data source is to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProjectId
        {
            get { return this._projectId; }
            set { this._projectId = value; }
        }

        // Check to see if ProjectId property is set
        internal bool IsSetProjectId()
        {
            return this._projectId != null;
        }

        /// <summary>
        /// Gets and sets the property PublishOnImport. 
        /// <para>
        /// The publish on import setting to be updated as part of the <c>UpdateDataSource</c>
        /// action.
        /// </para>
        /// </summary>
        public bool? PublishOnImport
        {
            get { return this._publishOnImport; }
            set { this._publishOnImport = value; }
        }

        // Check to see if PublishOnImport property is set
        internal bool IsSetPublishOnImport()
        {
            return this._publishOnImport.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Recommendation. 
        /// <para>
        /// The recommendation to be updated as part of the <c>UpdateDataSource</c> action.
        /// </para>
        /// </summary>
        public RecommendationConfiguration Recommendation
        {
            get { return this._recommendation; }
            set { this._recommendation = value; }
        }

        // Check to see if Recommendation property is set
        internal bool IsSetRecommendation()
        {
            return this._recommendation != null;
        }

        /// <summary>
        /// Gets and sets the property RetainPermissionsOnRevokeFailure. 
        /// <para>
        /// Specifies that the granted permissions are retained in case of a self-subscribe functionality
        /// failure for a data source.
        /// </para>
        /// </summary>
        public bool? RetainPermissionsOnRevokeFailure
        {
            get { return this._retainPermissionsOnRevokeFailure; }
            set { this._retainPermissionsOnRevokeFailure = value; }
        }

        // Check to see if RetainPermissionsOnRevokeFailure property is set
        internal bool IsSetRetainPermissionsOnRevokeFailure()
        {
            return this._retainPermissionsOnRevokeFailure.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// The schedule to be updated as part of the <c>UpdateDataSource</c> action.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public ScheduleConfiguration Schedule
        {
            get { return this._schedule; }
            set { this._schedule = value; }
        }

        // Check to see if Schedule property is set
        internal bool IsSetSchedule()
        {
            return this._schedule != null;
        }

        /// <summary>
        /// Gets and sets the property SelfGrantStatus. 
        /// <para>
        /// Specifies the status of the self-granting functionality.
        /// </para>
        /// </summary>
        public SelfGrantStatusOutput SelfGrantStatus
        {
            get { return this._selfGrantStatus; }
            set { this._selfGrantStatus = value; }
        }

        // Check to see if SelfGrantStatus property is set
        internal bool IsSetSelfGrantStatus()
        {
            return this._selfGrantStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status to be updated as part of the <c>UpdateDataSource</c> action.
        /// </para>
        /// </summary>
        public DataSourceStatus Status
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type to be updated as part of the <c>UpdateDataSource</c> action.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when the data source was updated.
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

    }
}