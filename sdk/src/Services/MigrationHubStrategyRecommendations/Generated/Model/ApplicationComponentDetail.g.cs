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
    /// Contains detailed information about an application component.
    /// </summary>
    public partial class ApplicationComponentDetail
    {
        /// <summary>
        /// Gets and sets the property AnalysisStatus. 
        /// <para>
        ///  The status of analysis, if the application component has source code or an associated
        /// database. 
        /// </para>
        /// </summary>
        public SrcCodeOrDbAnalysisStatus AnalysisStatus { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisStatus property is set.
        /// </summary>
        internal bool IsSetAnalysisStatus() => this.AnalysisStatus != null;

        /// <summary>
        /// Gets and sets the property AntipatternReportS3Object. 
        /// <para>
        ///  The S3 bucket name and the Amazon S3 key name for the anti-pattern report. 
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
        ///  The status message for the anti-pattern. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string AntipatternReportStatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the AntipatternReportStatusMessage property is set.
        /// </summary>
        internal bool IsSetAntipatternReportStatusMessage() => this.AntipatternReportStatusMessage != null;

        /// <summary>
        /// Gets and sets the property AppType. 
        /// <para>
        ///  The type of application component. 
        /// </para>
        /// </summary>
        public AppType AppType { get; set; }

        /// <summary>
        /// Checks to see if the AppType property is set.
        /// </summary>
        internal bool IsSetAppType() => this.AppType != null;

        /// <summary>
        /// Gets and sets the property AppUnitError. 
        /// <para>
        /// The error in the analysis of the source code or database.
        /// </para>
        /// </summary>
        public AppUnitError AppUnitError { get; set; }

        /// <summary>
        /// Checks to see if the AppUnitError property is set.
        /// </summary>
        internal bool IsSetAppUnitError() => this.AppUnitError != null;

        /// <summary>
        /// Gets and sets the property AssociatedServerId. 
        /// <para>
        ///  The ID of the server that the application component is running on. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 27)]
        public string AssociatedServerId { get; set; }

        /// <summary>
        /// Checks to see if the AssociatedServerId property is set.
        /// </summary>
        internal bool IsSetAssociatedServerId() => this.AssociatedServerId != null;

        /// <summary>
        /// Gets and sets the property DatabaseConfigDetail. 
        /// <para>
        ///  Configuration details for the database associated with the application component.
        /// 
        /// </para>
        /// </summary>
        public DatabaseConfigDetail DatabaseConfigDetail { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseConfigDetail property is set.
        /// </summary>
        internal bool IsSetDatabaseConfigDetail() => this.DatabaseConfigDetail != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The ID of the application component. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 44)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property InclusionStatus. 
        /// <para>
        ///  Indicates whether the application component has been included for server recommendation
        /// or not. 
        /// </para>
        /// </summary>
        public InclusionStatus InclusionStatus { get; set; }

        /// <summary>
        /// Checks to see if the InclusionStatus property is set.
        /// </summary>
        internal bool IsSetInclusionStatus() => this.InclusionStatus != null;

        /// <summary>
        /// Gets and sets the property LastAnalyzedTimestamp. 
        /// <para>
        ///  The timestamp of when the application component was assessed. 
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
        /// Gets and sets the property MoreServerAssociationExists. 
        /// <para>
        ///  Set to true if the application component is running on multiple servers.
        /// </para>
        /// </summary>
        public bool? MoreServerAssociationExists { get; set; }

        /// <summary>
        /// Checks to see if the MoreServerAssociationExists property is set.
        /// </summary>
        internal bool IsSetMoreServerAssociationExists() => this.MoreServerAssociationExists.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of application component. 
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OsDriver. 
        /// <para>
        ///  OS driver. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string OsDriver { get; set; }

        /// <summary>
        /// Checks to see if the OsDriver property is set.
        /// </summary>
        internal bool IsSetOsDriver() => this.OsDriver != null;

        /// <summary>
        /// Gets and sets the property OsVersion. 
        /// <para>
        ///  OS version. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string OsVersion { get; set; }

        /// <summary>
        /// Checks to see if the OsVersion property is set.
        /// </summary>
        internal bool IsSetOsVersion() => this.OsVersion != null;

        /// <summary>
        /// Gets and sets the property RecommendationSet. 
        /// <para>
        ///  The top recommendation set for the application component. 
        /// </para>
        /// </summary>
        public RecommendationSet RecommendationSet { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationSet property is set.
        /// </summary>
        internal bool IsSetRecommendationSet() => this.RecommendationSet != null;

        /// <summary>
        /// Gets and sets the property ResourceSubType. 
        /// <para>
        ///  The application component subtype.
        /// </para>
        /// </summary>
        public ResourceSubType ResourceSubType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceSubType property is set.
        /// </summary>
        internal bool IsSetResourceSubType() => this.ResourceSubType != null;

        /// <summary>
        /// Gets and sets the property ResultList. 
        /// <para>
        /// A list of the analysis results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Result> ResultList { get; set; } = AWSConfigs.InitializeCollections ? new List<Result>() : null;

        /// <summary>
        /// Checks to see if the ResultList property is set.
        /// </summary>
        internal bool IsSetResultList() => this.ResultList != null && (this.ResultList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RuntimeStatus. 
        /// <para>
        /// The status of the application unit.
        /// </para>
        /// </summary>
        public RuntimeAnalysisStatus RuntimeStatus { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeStatus property is set.
        /// </summary>
        internal bool IsSetRuntimeStatus() => this.RuntimeStatus != null;

        /// <summary>
        /// Gets and sets the property RuntimeStatusMessage. 
        /// <para>
        /// The status message for the application unit.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string RuntimeStatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the RuntimeStatusMessage property is set.
        /// </summary>
        internal bool IsSetRuntimeStatusMessage() => this.RuntimeStatusMessage != null;

        /// <summary>
        /// Gets and sets the property SourceCodeRepositories. 
        /// <para>
        ///  Details about the source code repository associated with the application component.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SourceCodeRepository> SourceCodeRepositories { get; set; } = AWSConfigs.InitializeCollections ? new List<SourceCodeRepository>() : null;

        /// <summary>
        /// Checks to see if the SourceCodeRepositories property is set.
        /// </summary>
        internal bool IsSetSourceCodeRepositories() => this.SourceCodeRepositories != null && (this.SourceCodeRepositories.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        ///  A detailed description of the analysis status and any failure message. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;
    }
}
