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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a Network Access Scope analysis.
    /// </summary>
    public partial class NetworkInsightsAccessScopeAnalysis
    {
        /// <summary>
        /// Gets and sets the property AnalyzedEniCount. 
        /// <para>
        /// The number of network interfaces analyzed.
        /// </para>
        /// </summary>
        public int? AnalyzedEniCount { get; set; }

        /// <summary>
        /// Checks to see if the AnalyzedEniCount property is set.
        /// </summary>
        internal bool IsSetAnalyzedEniCount() => this.AnalyzedEniCount.HasValue;

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The analysis end date.
        /// </para>
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Checks to see if the EndDate property is set.
        /// </summary>
        internal bool IsSetEndDate() => this.EndDate.HasValue;

        /// <summary>
        /// Gets and sets the property FindingsFound. 
        /// <para>
        /// Indicates whether there are findings.
        /// </para>
        /// </summary>
        public FindingsFound FindingsFound { get; set; }

        /// <summary>
        /// Checks to see if the FindingsFound property is set.
        /// </summary>
        internal bool IsSetFindingsFound() => this.FindingsFound != null;

        /// <summary>
        /// Gets and sets the property NetworkInsightsAccessScopeAnalysisArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Network Access Scope analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1283)]
        public string NetworkInsightsAccessScopeAnalysisArn { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInsightsAccessScopeAnalysisArn property is set.
        /// </summary>
        internal bool IsSetNetworkInsightsAccessScopeAnalysisArn() => this.NetworkInsightsAccessScopeAnalysisArn != null;

        /// <summary>
        /// Gets and sets the property NetworkInsightsAccessScopeAnalysisId. 
        /// <para>
        /// The ID of the Network Access Scope analysis.
        /// </para>
        /// </summary>
        public string NetworkInsightsAccessScopeAnalysisId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInsightsAccessScopeAnalysisId property is set.
        /// </summary>
        internal bool IsSetNetworkInsightsAccessScopeAnalysisId() => this.NetworkInsightsAccessScopeAnalysisId != null;

        /// <summary>
        /// Gets and sets the property NetworkInsightsAccessScopeId. 
        /// <para>
        /// The ID of the Network Access Scope.
        /// </para>
        /// </summary>
        public string NetworkInsightsAccessScopeId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInsightsAccessScopeId property is set.
        /// </summary>
        internal bool IsSetNetworkInsightsAccessScopeId() => this.NetworkInsightsAccessScopeId != null;

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The analysis start date.
        /// </para>
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Checks to see if the StartDate property is set.
        /// </summary>
        internal bool IsSetStartDate() => this.StartDate.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status.
        /// </para>
        /// </summary>
        public AnalysisStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WarningMessage. 
        /// <para>
        /// The warning message.
        /// </para>
        /// </summary>
        public string WarningMessage { get; set; }

        /// <summary>
        /// Checks to see if the WarningMessage property is set.
        /// </summary>
        internal bool IsSetWarningMessage() => this.WarningMessage != null;
    }
}
