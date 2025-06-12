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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MigrationHubStrategyRecommendations.Model
{
    /// <summary>
    /// Contains the summary of the assessment results.
    /// </summary>
    public partial class AssessmentSummary
    {
        private S3Object _antipatternReportS3Object;
        private AntipatternReportStatus _antipatternReportStatus;
        private string _antipatternReportStatusMessage;
        private DateTime? _lastAnalyzedTimestamp;
        private List<AntipatternSeveritySummary> _listAntipatternSeveritySummary = AWSConfigs.InitializeCollections ? new List<AntipatternSeveritySummary>() : null;
        private List<ApplicationComponentStatusSummary> _listApplicationComponentStatusSummary = AWSConfigs.InitializeCollections ? new List<ApplicationComponentStatusSummary>() : null;
        private List<StrategySummary> _listApplicationComponentStrategySummary = AWSConfigs.InitializeCollections ? new List<StrategySummary>() : null;
        private List<ApplicationComponentSummary> _listApplicationComponentSummary = AWSConfigs.InitializeCollections ? new List<ApplicationComponentSummary>() : null;
        private List<ServerStatusSummary> _listServerStatusSummary = AWSConfigs.InitializeCollections ? new List<ServerStatusSummary>() : null;
        private List<StrategySummary> _listServerStrategySummary = AWSConfigs.InitializeCollections ? new List<StrategySummary>() : null;
        private List<ServerSummary> _listServerSummary = AWSConfigs.InitializeCollections ? new List<ServerSummary>() : null;

        /// <summary>
        /// Gets and sets the property AntipatternReportS3Object. 
        /// <para>
        ///  The Amazon S3 object containing the anti-pattern report. 
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
        ///  The status of the anti-pattern report. 
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
        ///  The status message of the anti-pattern report. 
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
        /// Gets and sets the property LastAnalyzedTimestamp. 
        /// <para>
        ///  The time the assessment was performed. 
        /// </para>
        /// </summary>
        public DateTime? LastAnalyzedTimestamp
        {
            get { return this._lastAnalyzedTimestamp; }
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
        ///  List of AntipatternSeveritySummary. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AntipatternSeveritySummary> ListAntipatternSeveritySummary
        {
            get { return this._listAntipatternSeveritySummary; }
            set { this._listAntipatternSeveritySummary = value; }
        }

        // Check to see if ListAntipatternSeveritySummary property is set
        internal bool IsSetListAntipatternSeveritySummary()
        {
            return this._listAntipatternSeveritySummary != null && (this._listAntipatternSeveritySummary.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ListApplicationComponentStatusSummary. 
        /// <para>
        /// List of status summaries of the analyzed application components.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ApplicationComponentStatusSummary> ListApplicationComponentStatusSummary
        {
            get { return this._listApplicationComponentStatusSummary; }
            set { this._listApplicationComponentStatusSummary = value; }
        }

        // Check to see if ListApplicationComponentStatusSummary property is set
        internal bool IsSetListApplicationComponentStatusSummary()
        {
            return this._listApplicationComponentStatusSummary != null && (this._listApplicationComponentStatusSummary.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ListApplicationComponentStrategySummary. 
        /// <para>
        ///  List of ApplicationComponentStrategySummary. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StrategySummary> ListApplicationComponentStrategySummary
        {
            get { return this._listApplicationComponentStrategySummary; }
            set { this._listApplicationComponentStrategySummary = value; }
        }

        // Check to see if ListApplicationComponentStrategySummary property is set
        internal bool IsSetListApplicationComponentStrategySummary()
        {
            return this._listApplicationComponentStrategySummary != null && (this._listApplicationComponentStrategySummary.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ListApplicationComponentSummary. 
        /// <para>
        ///  List of ApplicationComponentSummary. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ApplicationComponentSummary> ListApplicationComponentSummary
        {
            get { return this._listApplicationComponentSummary; }
            set { this._listApplicationComponentSummary = value; }
        }

        // Check to see if ListApplicationComponentSummary property is set
        internal bool IsSetListApplicationComponentSummary()
        {
            return this._listApplicationComponentSummary != null && (this._listApplicationComponentSummary.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ListServerStatusSummary. 
        /// <para>
        /// List of status summaries of the analyzed servers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServerStatusSummary> ListServerStatusSummary
        {
            get { return this._listServerStatusSummary; }
            set { this._listServerStatusSummary = value; }
        }

        // Check to see if ListServerStatusSummary property is set
        internal bool IsSetListServerStatusSummary()
        {
            return this._listServerStatusSummary != null && (this._listServerStatusSummary.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ListServerStrategySummary. 
        /// <para>
        ///  List of ServerStrategySummary. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StrategySummary> ListServerStrategySummary
        {
            get { return this._listServerStrategySummary; }
            set { this._listServerStrategySummary = value; }
        }

        // Check to see if ListServerStrategySummary property is set
        internal bool IsSetListServerStrategySummary()
        {
            return this._listServerStrategySummary != null && (this._listServerStrategySummary.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ListServerSummary. 
        /// <para>
        ///  List of ServerSummary. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServerSummary> ListServerSummary
        {
            get { return this._listServerSummary; }
            set { this._listServerSummary = value; }
        }

        // Check to see if ListServerSummary property is set
        internal bool IsSetListServerSummary()
        {
            return this._listServerSummary != null && (this._listServerSummary.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}