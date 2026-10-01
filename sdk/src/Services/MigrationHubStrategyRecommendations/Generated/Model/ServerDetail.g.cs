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

namespace Amazon.MigrationHubStrategyRecommendations.Model
{
    /// <summary>
    /// Detailed information about a server.
    /// </summary>
    public partial class ServerDetail
    {
        /// <summary>
        /// Gets and sets the property AntipatternReportS3Object. 
        /// <para>
        ///  The S3 bucket name and Amazon S3 key name for anti-pattern report. 
        /// </para>
        /// </summary>
        public S3Object AntipatternReportS3Object { get; set; }

        /// <summary>
        /// Checks to see if the AntipatternReportS3Object property is set.
        /// </summary>
        internal bool IsSetAntipatternReportS3Object() => this.AntipatternReportS3Object != null;

        /// <summary>
        /// Gets and sets the property AntipatternReportStatus. 
        /// <para>
        ///  The status of the anti-pattern report generation. 
        /// </para>
        /// </summary>
        public AntipatternReportStatus AntipatternReportStatus { get; set; }

        /// <summary>
        /// Checks to see if the AntipatternReportStatus property is set.
        /// </summary>
        internal bool IsSetAntipatternReportStatus() => this.AntipatternReportStatus != null;

        /// <summary>
        /// Gets and sets the property AntipatternReportStatusMessage. 
        /// <para>
        ///  A message about the status of the anti-pattern report generation. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string AntipatternReportStatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the AntipatternReportStatusMessage property is set.
        /// </summary>
        internal bool IsSetAntipatternReportStatusMessage() => this.AntipatternReportStatusMessage != null;

        /// <summary>
        /// Gets and sets the property ApplicationComponentStrategySummary. 
        /// <para>
        ///  A list of strategy summaries. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StrategySummary> ApplicationComponentStrategySummary { get; set; } = AWSConfigs.InitializeCollections ? new List<StrategySummary>() : null;

        /// <summary>
        /// Checks to see if the ApplicationComponentStrategySummary property is set.
        /// </summary>
        internal bool IsSetApplicationComponentStrategySummary() => this.ApplicationComponentStrategySummary != null && (this.ApplicationComponentStrategySummary.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DataCollectionStatus. 
        /// <para>
        ///  The status of assessment for the server. 
        /// </para>
        /// </summary>
        public RunTimeAssessmentStatus DataCollectionStatus { get; set; }

        /// <summary>
        /// Checks to see if the DataCollectionStatus property is set.
        /// </summary>
        internal bool IsSetDataCollectionStatus() => this.DataCollectionStatus != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The server ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 44)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastAnalyzedTimestamp. 
        /// <para>
        ///  The timestamp of when the server was assessed. 
        /// </para>
        /// </summary>
        public DateTime? LastAnalyzedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastAnalyzedTimestamp property is set.
        /// </summary>
        internal bool IsSetLastAnalyzedTimestamp() => this.LastAnalyzedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property ListAntipatternSeveritySummary. 
        /// <para>
        ///  A list of anti-pattern severity summaries. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AntipatternSeveritySummary> ListAntipatternSeveritySummary { get; set; } = AWSConfigs.InitializeCollections ? new List<AntipatternSeveritySummary>() : null;

        /// <summary>
        /// Checks to see if the ListAntipatternSeveritySummary property is set.
        /// </summary>
        internal bool IsSetListAntipatternSeveritySummary() => this.ListAntipatternSeveritySummary != null && (this.ListAntipatternSeveritySummary.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the server. 
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RecommendationSet. 
        /// <para>
        ///  A set of recommendations. 
        /// </para>
        /// </summary>
        public RecommendationSet RecommendationSet { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationSet property is set.
        /// </summary>
        internal bool IsSetRecommendationSet() => this.RecommendationSet != null;

        /// <summary>
        /// Gets and sets the property ServerError. 
        /// <para>
        /// The error in server analysis.
        /// </para>
        /// </summary>
        public ServerError ServerError { get; set; }

        /// <summary>
        /// Checks to see if the ServerError property is set.
        /// </summary>
        internal bool IsSetServerError() => this.ServerError != null;

        /// <summary>
        /// Gets and sets the property ServerType. 
        /// <para>
        ///  The type of server. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ServerType { get; set; }

        /// <summary>
        /// Checks to see if the ServerType property is set.
        /// </summary>
        internal bool IsSetServerType() => this.ServerType != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        ///  A message about the status of data collection, which contains detailed descriptions
        /// of any error messages. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property SystemInfo. 
        /// <para>
        ///  System information about the server. 
        /// </para>
        /// </summary>
        public SystemInfo SystemInfo { get; set; }

        /// <summary>
        /// Checks to see if the SystemInfo property is set.
        /// </summary>
        internal bool IsSetSystemInfo() => this.SystemInfo != null;
    }
}
