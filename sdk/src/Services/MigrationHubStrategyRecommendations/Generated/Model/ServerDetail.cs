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
    /// Detailed information about a server.
    /// </summary>
    public partial class ServerDetail
    {
        private S3Object _antipatternReportS3Object;
        private AntipatternReportStatus _antipatternReportStatus;
        private string _antipatternReportStatusMessage;
        private List<StrategySummary> _applicationComponentStrategySummary = new List<StrategySummary>();
        private RunTimeAssessmentStatus _dataCollectionStatus;
        private string _id;
        private DateTime? _lastAnalyzedTimestamp;
        private List<AntipatternSeveritySummary> _listAntipatternSeveritySummary = new List<AntipatternSeveritySummary>();
        private string _name;
        private RecommendationSet _recommendationSet;
        private ServerError _serverError;
        private string _serverType;
        private string _statusMessage;
        private SystemInfo _systemInfo;

        /// <summary>
        /// Gets and sets the property AntipatternReportS3Object. 
        /// <para>
        ///  The S3 bucket name and Amazon S3 key name for anti-pattern report. 
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
        ///  A message about the status of the anti-pattern report generation. 
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
        /// Gets and sets the property ApplicationComponentStrategySummary. 
        /// <para>
        ///  A list of strategy summaries. 
        /// </para>
        /// </summary>
        public List<StrategySummary> ApplicationComponentStrategySummary
        {
            get { return this._applicationComponentStrategySummary; }
            set { this._applicationComponentStrategySummary = value; }
        }

        // Check to see if ApplicationComponentStrategySummary property is set
        internal bool IsSetApplicationComponentStrategySummary()
        {
            return this._applicationComponentStrategySummary != null && this._applicationComponentStrategySummary.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DataCollectionStatus. 
        /// <para>
        ///  The status of assessment for the server. 
        /// </para>
        /// </summary>
        public RunTimeAssessmentStatus DataCollectionStatus
        {
            get { return this._dataCollectionStatus; }
            set { this._dataCollectionStatus = value; }
        }

        // Check to see if DataCollectionStatus property is set
        internal bool IsSetDataCollectionStatus()
        {
            return this._dataCollectionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The server ID. 
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
        /// Gets and sets the property LastAnalyzedTimestamp. 
        /// <para>
        ///  The timestamp of when the server was assessed. 
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
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the server. 
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
        /// Gets and sets the property RecommendationSet. 
        /// <para>
        ///  A set of recommendations. 
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
        /// Gets and sets the property ServerError. 
        /// <para>
        /// The error in server analysis.
        /// </para>
        /// </summary>
        public ServerError ServerError
        {
            get { return this._serverError; }
            set { this._serverError = value; }
        }

        // Check to see if ServerError property is set
        internal bool IsSetServerError()
        {
            return this._serverError != null;
        }

        /// <summary>
        /// Gets and sets the property ServerType. 
        /// <para>
        ///  The type of server. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ServerType
        {
            get { return this._serverType; }
            set { this._serverType = value; }
        }

        // Check to see if ServerType property is set
        internal bool IsSetServerType()
        {
            return this._serverType != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        ///  A message about the status of data collection, which contains detailed descriptions
        /// of any error messages. 
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

        /// <summary>
        /// Gets and sets the property SystemInfo. 
        /// <para>
        ///  System information about the server. 
        /// </para>
        /// </summary>
        public SystemInfo SystemInfo
        {
            get { return this._systemInfo; }
            set { this._systemInfo = value; }
        }

        // Check to see if SystemInfo property is set
        internal bool IsSetSystemInfo()
        {
            return this._systemInfo != null;
        }

    }
}