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
    /// The error in server analysis.
    /// </summary>
    public partial class Result
    {
        /// <summary>
        /// Gets and sets the property AnalysisStatus. 
        /// <para>
        /// The error in server analysis.
        /// </para>
        /// </summary>
        public AnalysisStatusUnion AnalysisStatus { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisStatus property is set.
        /// </summary>
        internal bool IsSetAnalysisStatus() => this.AnalysisStatus != null;

        /// <summary>
        /// Gets and sets the property AnalysisType. 
        /// <para>
        /// The error in server analysis.
        /// </para>
        /// </summary>
        public AnalysisType AnalysisType { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisType property is set.
        /// </summary>
        internal bool IsSetAnalysisType() => this.AnalysisType != null;

        /// <summary>
        /// Gets and sets the property AntipatternReportResultList. 
        /// <para>
        /// The error in server analysis.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AntipatternReportResult> AntipatternReportResultList { get; set; } = AWSConfigs.InitializeCollections ? new List<AntipatternReportResult>() : null;

        /// <summary>
        /// Checks to see if the AntipatternReportResultList property is set.
        /// </summary>
        internal bool IsSetAntipatternReportResultList() => this.AntipatternReportResultList != null && (this.AntipatternReportResultList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The error in server analysis.
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
