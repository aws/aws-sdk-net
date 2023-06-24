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
 * Do not modify this file. This file is generated from the migrationhubstrategy-2020-02-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MigrationHubStrategyRecommendations.Model
{
    /// <summary>
    /// Contains detailed information about an application component.
    /// </summary>
    public partial class ApplicationComponentDetail
    {
        private SrcCodeOrDbAnalysisStatus _analysisStatus;
        private S3Object _antipatternReportS3Object;
        private AntipatternReportStatus _antipatternReportStatus;
        private string _antipatternReportStatusMessage;
        private AppType _appType;
        private AppUnitError _appUnitError;
        private string _associatedServerId;
        private DatabaseConfigDetail _databaseConfigDetail;
        private string _id;
        private InclusionStatus _inclusionStatus;
        private DateTime? _lastAnalyzedTimestamp;
        private List<AntipatternSeveritySummary> _listAntipatternSeveritySummary = new List<AntipatternSeveritySummary>();
        private bool? _moreServerAssociationExists;
        private string _name;
        private string _osDriver;
        private string _osVersion;
        private RecommendationSet _recommendationSet;
        private ResourceSubType _resourceSubType;
        private List<Result> _resultList = new List<Result>();
        private RuntimeAnalysisStatus _runtimeStatus;
        private string _runtimeStatusMessage;
        private List<SourceCodeRepository> _sourceCodeRepositories = new List<SourceCodeRepository>();
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property AnalysisStatus. 
        /// <para>
        ///  The status of analysis, if the application component has source code or an associated
        /// database. 
        /// </para>
        /// </summary>
        public SrcCodeOrDbAnalysisStatus AnalysisStatus
        {
            get { return this._analysisStatus; }
            set { this._analysisStatus = value; }
        }

        // Check to see if AnalysisStatus property is set
        internal bool IsSetAnalysisStatus()
        {
            return this._analysisStatus != null;
        }

        /// <summary>
        /// Gets and sets the property AntipatternReportS3Object. 
        /// <para>
        ///  The S3 bucket name and the Amazon S3 key name for the anti-pattern report. 
        /// </para>
        /// </summary>
        public S3Object AntipatternReportS3Object
        {
            get { return this._antipatternReportS3Object; }
            set { this._antipatternReportS3Object = value; }
        }

        // Check to see if AntipatternReportS3Object property is set
        internal bool IsSetAntipatternReportS3Object()
        {
            return this._antipatternReportS3Object != null;
        }

        /// <summary>
        /// Gets and sets the property AntipatternReportStatus. 
        /// <para>
        ///  The status of the anti-pattern report generation.
        /// </para>
        /// </summary>
        public AntipatternReportStatus AntipatternReportStatus
        {
            get { return this._antipatternReportStatus; }
            set { this._antipatternReportStatus = value; }
        }

        // Check to see if AntipatternReportStatus property is set
        internal bool IsSetAntipatternReportStatus()
        {
            return this._antipatternReportStatus != null;
        }

        /// <summary>
        /// Gets and sets the property AntipatternReportStatusMessage. 
        /// <para>
        ///  The status message for the anti-pattern. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string AntipatternReportStatusMessage
        {
            get { return this._antipatternReportStatusMessage; }
            set { this._antipatternReportStatusMessage = value; }
        }

        // Check to see if AntipatternReportStatusMessage property is set
        internal bool IsSetAntipatternReportStatusMessage()
        {
            return this._antipatternReportStatusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property AppType. 
        /// <para>
        ///  The type of application component. 
        /// </para>
        /// </summary>
        public AppType AppType
        {
            get { return this._appType; }
            set { this._appType = value; }
        }

        // Check to see if AppType property is set
        internal bool IsSetAppType()
        {
            return this._appType != null;
        }

        /// <summary>
        /// Gets and sets the property AppUnitError. 
        /// <para>
        /// The error in the analysis of the source code or database.
        /// </para>
        /// </summary>
        public AppUnitError AppUnitError
        {
            get { return this._appUnitError; }
            set { this._appUnitError = value; }
        }

        // Check to see if AppUnitError property is set
        internal bool IsSetAppUnitError()
        {
            return this._appUnitError != null;
        }

        /// <summary>
        /// Gets and sets the property AssociatedServerId. 
        /// <para>
        ///  The ID of the server that the application component is running on. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=27)]
        public string AssociatedServerId
        {
            get { return this._associatedServerId; }
            set { this._associatedServerId = value; }
        }

        // Check to see if AssociatedServerId property is set
        internal bool IsSetAssociatedServerId()
        {
            return this._associatedServerId != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseConfigDetail. 
        /// <para>
        ///  Configuration details for the database associated with the application component.
        /// 
        /// </para>
        /// </summary>
        public DatabaseConfigDetail DatabaseConfigDetail
        {
            get { return this._databaseConfigDetail; }
            set { this._databaseConfigDetail = value; }
        }

        // Check to see if DatabaseConfigDetail property is set
        internal bool IsSetDatabaseConfigDetail()
        {
            return this._databaseConfigDetail != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The ID of the application component. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=44)]
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
        /// Gets and sets the property InclusionStatus. 
        /// <para>
        ///  Indicates whether the application component has been included for server recommendation
        /// or not. 
        /// </para>
        /// </summary>
        public InclusionStatus InclusionStatus
        {
            get { return this._inclusionStatus; }
            set { this._inclusionStatus = value; }
        }

        // Check to see if InclusionStatus property is set
        internal bool IsSetInclusionStatus()
        {
            return this._inclusionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastAnalyzedTimestamp. 
        /// <para>
        ///  The timestamp of when the application component was assessed. 
        /// </para>
        /// </summary>
        public DateTime LastAnalyzedTimestamp
        {
            get { return this._lastAnalyzedTimestamp.GetValueOrDefault(); }
            set { this._lastAnalyzedTimestamp = value; }
        }

        // Check to see if LastAnalyzedTimestamp property is set
        internal bool IsSetLastAnalyzedTimestamp()
        {
            return this._lastAnalyzedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ListAntipatternSeveritySummary. 
        /// <para>
        ///  A list of anti-pattern severity summaries. 
        /// </para>
        /// </summary>
        public List<AntipatternSeveritySummary> ListAntipatternSeveritySummary
        {
            get { return this._listAntipatternSeveritySummary; }
            set { this._listAntipatternSeveritySummary = value; }
        }

        // Check to see if ListAntipatternSeveritySummary property is set
        internal bool IsSetListAntipatternSeveritySummary()
        {
            return this._listAntipatternSeveritySummary != null && this._listAntipatternSeveritySummary.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MoreServerAssociationExists. 
        /// <para>
        ///  Set to true if the application component is running on multiple servers.
        /// </para>
        /// </summary>
        public bool MoreServerAssociationExists
        {
            get { return this._moreServerAssociationExists.GetValueOrDefault(); }
            set { this._moreServerAssociationExists = value; }
        }

        // Check to see if MoreServerAssociationExists property is set
        internal bool IsSetMoreServerAssociationExists()
        {
            return this._moreServerAssociationExists.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of application component. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property OsDriver. 
        /// <para>
        ///  OS driver. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string OsDriver
        {
            get { return this._osDriver; }
            set { this._osDriver = value; }
        }

        // Check to see if OsDriver property is set
        internal bool IsSetOsDriver()
        {
            return this._osDriver != null;
        }

        /// <summary>
        /// Gets and sets the property OsVersion. 
        /// <para>
        ///  OS version. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string OsVersion
        {
            get { return this._osVersion; }
            set { this._osVersion = value; }
        }

        // Check to see if OsVersion property is set
        internal bool IsSetOsVersion()
        {
            return this._osVersion != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendationSet. 
        /// <para>
        ///  The top recommendation set for the application component. 
        /// </para>
        /// </summary>
        public RecommendationSet RecommendationSet
        {
            get { return this._recommendationSet; }
            set { this._recommendationSet = value; }
        }

        // Check to see if RecommendationSet property is set
        internal bool IsSetRecommendationSet()
        {
            return this._recommendationSet != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceSubType. 
        /// <para>
        ///  The application component subtype.
        /// </para>
        /// </summary>
        public ResourceSubType ResourceSubType
        {
            get { return this._resourceSubType; }
            set { this._resourceSubType = value; }
        }

        // Check to see if ResourceSubType property is set
        internal bool IsSetResourceSubType()
        {
            return this._resourceSubType != null;
        }

        /// <summary>
        /// Gets and sets the property ResultList. 
        /// <para>
        /// A list of the analysis results.
        /// </para>
        /// </summary>
        public List<Result> ResultList
        {
            get { return this._resultList; }
            set { this._resultList = value; }
        }

        // Check to see if ResultList property is set
        internal bool IsSetResultList()
        {
            return this._resultList != null && this._resultList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RuntimeStatus. 
        /// <para>
        /// The status of the application unit.
        /// </para>
        /// </summary>
        public RuntimeAnalysisStatus RuntimeStatus
        {
            get { return this._runtimeStatus; }
            set { this._runtimeStatus = value; }
        }

        // Check to see if RuntimeStatus property is set
        internal bool IsSetRuntimeStatus()
        {
            return this._runtimeStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RuntimeStatusMessage. 
        /// <para>
        /// The status message for the application unit.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string RuntimeStatusMessage
        {
            get { return this._runtimeStatusMessage; }
            set { this._runtimeStatusMessage = value; }
        }

        // Check to see if RuntimeStatusMessage property is set
        internal bool IsSetRuntimeStatusMessage()
        {
            return this._runtimeStatusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property SourceCodeRepositories. 
        /// <para>
        ///  Details about the source code repository associated with the application component.
        /// 
        /// </para>
        /// </summary>
        public List<SourceCodeRepository> SourceCodeRepositories
        {
            get { return this._sourceCodeRepositories; }
            set { this._sourceCodeRepositories = value; }
        }

        // Check to see if SourceCodeRepositories property is set
        internal bool IsSetSourceCodeRepositories()
        {
            return this._sourceCodeRepositories != null && this._sourceCodeRepositories.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        ///  A detailed description of the analysis status and any failure message. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}