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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// The report-generation filters applied when a pentest or code review report is exported.
    /// </summary>
    public partial class ReportFilters
    {
        /// <summary>
        /// Gets and sets the property AnnotationNotes. 
        /// <para>
        /// Whether to include reviewer annotation notes under each finding.
        /// </para>
        /// </summary>
        public bool? AnnotationNotes { get; set; }

        /// <summary>
        /// Checks to see if the AnnotationNotes property is set.
        /// </summary>
        internal bool IsSetAnnotationNotes() => this.AnnotationNotes.HasValue;

        /// <summary>
        /// Gets and sets the property ComplianceReport. 
        /// <para>
        /// Whether to include the compliance-ready report additions.
        /// </para>
        /// </summary>
        public bool? ComplianceReport { get; set; }

        /// <summary>
        /// Checks to see if the ComplianceReport property is set.
        /// </summary>
        internal bool IsSetComplianceReport() => this.ComplianceReport.HasValue;

        /// <summary>
        /// Gets and sets the property ConfidenceLevels. 
        /// <para>
        /// The confidence levels to include in the report.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public List<string> ConfidenceLevels { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ConfidenceLevels property is set.
        /// </summary>
        internal bool IsSetConfidenceLevels() => this.ConfidenceLevels != null && (this.ConfidenceLevels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FindingTypes. 
        /// <para>
        /// The finding types to include in the report.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public List<string> FindingTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FindingTypes property is set.
        /// </summary>
        internal bool IsSetFindingTypes() => this.FindingTypes != null && (this.FindingTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RiskLevels. 
        /// <para>
        /// The severity levels to include in the report.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public List<string> RiskLevels { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RiskLevels property is set.
        /// </summary>
        internal bool IsSetRiskLevels() => this.RiskLevels != null && (this.RiskLevels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RiskTypes. 
        /// <para>
        /// The risk types to include in the report.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public List<string> RiskTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RiskTypes property is set.
        /// </summary>
        internal bool IsSetRiskTypes() => this.RiskTypes != null && (this.RiskTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Statuses. 
        /// <para>
        /// The finding statuses to include in the report.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public List<string> Statuses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Statuses property is set.
        /// </summary>
        internal bool IsSetStatuses() => this.Statuses != null && (this.Statuses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TaskStatuses. 
        /// <para>
        /// The task execution statuses to include in the report's task table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public List<string> TaskStatuses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TaskStatuses property is set.
        /// </summary>
        internal bool IsSetTaskStatuses() => this.TaskStatuses != null && (this.TaskStatuses.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
