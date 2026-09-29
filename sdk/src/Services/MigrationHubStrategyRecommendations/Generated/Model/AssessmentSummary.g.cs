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
    /// Contains the summary of the assessment results.
    /// </summary>
    public partial class AssessmentSummary
    {
        /// <summary>
        /// Gets and sets the property AntipatternReportS3Object. 
        /// <para>
        ///  The Amazon S3 object containing the anti-pattern report. 
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
        ///  The status of the anti-pattern report. 
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
        ///  The status message of the anti-pattern report. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string AntipatternReportStatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the AntipatternReportStatusMessage property is set.
        /// </summary>
        internal bool IsSetAntipatternReportStatusMessage() => this.AntipatternReportStatusMessage != null;

        /// <summary>
        /// Gets and sets the property LastAnalyzedTimestamp. 
        /// <para>
        ///  The time the assessment was performed. 
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
        ///  List of AntipatternSeveritySummary. 
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
        /// Gets and sets the property ListApplicationComponentStatusSummary. 
        /// <para>
        /// List of status summaries of the analyzed application components.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ApplicationComponentStatusSummary> ListApplicationComponentStatusSummary { get; set; } = AWSConfigs.InitializeCollections ? new List<ApplicationComponentStatusSummary>() : null;

        /// <summary>
        /// Checks to see if the ListApplicationComponentStatusSummary property is set.
        /// </summary>
        internal bool IsSetListApplicationComponentStatusSummary() => this.ListApplicationComponentStatusSummary != null && (this.ListApplicationComponentStatusSummary.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ListApplicationComponentStrategySummary. 
        /// <para>
        ///  List of ApplicationComponentStrategySummary. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StrategySummary> ListApplicationComponentStrategySummary { get; set; } = AWSConfigs.InitializeCollections ? new List<StrategySummary>() : null;

        /// <summary>
        /// Checks to see if the ListApplicationComponentStrategySummary property is set.
        /// </summary>
        internal bool IsSetListApplicationComponentStrategySummary() => this.ListApplicationComponentStrategySummary != null && (this.ListApplicationComponentStrategySummary.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ListApplicationComponentSummary. 
        /// <para>
        ///  List of ApplicationComponentSummary. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ApplicationComponentSummary> ListApplicationComponentSummary { get; set; } = AWSConfigs.InitializeCollections ? new List<ApplicationComponentSummary>() : null;

        /// <summary>
        /// Checks to see if the ListApplicationComponentSummary property is set.
        /// </summary>
        internal bool IsSetListApplicationComponentSummary() => this.ListApplicationComponentSummary != null && (this.ListApplicationComponentSummary.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ListServerStatusSummary. 
        /// <para>
        /// List of status summaries of the analyzed servers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServerStatusSummary> ListServerStatusSummary { get; set; } = AWSConfigs.InitializeCollections ? new List<ServerStatusSummary>() : null;

        /// <summary>
        /// Checks to see if the ListServerStatusSummary property is set.
        /// </summary>
        internal bool IsSetListServerStatusSummary() => this.ListServerStatusSummary != null && (this.ListServerStatusSummary.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ListServerStrategySummary. 
        /// <para>
        ///  List of ServerStrategySummary. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StrategySummary> ListServerStrategySummary { get; set; } = AWSConfigs.InitializeCollections ? new List<StrategySummary>() : null;

        /// <summary>
        /// Checks to see if the ListServerStrategySummary property is set.
        /// </summary>
        internal bool IsSetListServerStrategySummary() => this.ListServerStrategySummary != null && (this.ListServerStrategySummary.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ListServerSummary. 
        /// <para>
        ///  List of ServerSummary. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServerSummary> ListServerSummary { get; set; } = AWSConfigs.InitializeCollections ? new List<ServerSummary>() : null;

        /// <summary>
        /// Checks to see if the ListServerSummary property is set.
        /// </summary>
        internal bool IsSetListServerSummary() => this.ListServerSummary != null && (this.ListServerSummary.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
