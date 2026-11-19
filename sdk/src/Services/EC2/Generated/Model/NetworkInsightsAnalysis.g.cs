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
    /// Describes a network insights analysis.
    /// </summary>
    public partial class NetworkInsightsAnalysis
    {
        /// <summary>
        /// Gets and sets the property AdditionalAccounts. 
        /// <para>
        /// The member accounts that contain resources that the path can traverse.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AdditionalAccounts { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AdditionalAccounts property is set.
        /// </summary>
        internal bool IsSetAdditionalAccounts() => this.AdditionalAccounts != null && (this.AdditionalAccounts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AlternatePathHints. 
        /// <para>
        /// Potential intermediate components.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AlternatePathHint> AlternatePathHints { get; set; } = AWSConfigs.InitializeCollections ? new List<AlternatePathHint>() : null;

        /// <summary>
        /// Checks to see if the AlternatePathHints property is set.
        /// </summary>
        internal bool IsSetAlternatePathHints() => this.AlternatePathHints != null && (this.AlternatePathHints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Explanations. 
        /// <para>
        /// The explanations. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/reachability/explanation-codes.html">Reachability
        /// Analyzer explanation codes</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Explanation> Explanations { get; set; } = AWSConfigs.InitializeCollections ? new List<Explanation>() : null;

        /// <summary>
        /// Checks to see if the Explanations property is set.
        /// </summary>
        internal bool IsSetExplanations() => this.Explanations != null && (this.Explanations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FilterInArns. 
        /// <para>
        /// The Amazon Resource Names (ARN) of the resources that the path must traverse.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FilterInArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FilterInArns property is set.
        /// </summary>
        internal bool IsSetFilterInArns() => this.FilterInArns != null && (this.FilterInArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FilterOutArns. 
        /// <para>
        /// The Amazon Resource Names (ARN) of the resources that the path must ignore.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FilterOutArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FilterOutArns property is set.
        /// </summary>
        internal bool IsSetFilterOutArns() => this.FilterOutArns != null && (this.FilterOutArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ForwardPathComponents. 
        /// <para>
        /// The components in the path from source to destination.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PathComponent> ForwardPathComponents { get; set; } = AWSConfigs.InitializeCollections ? new List<PathComponent>() : null;

        /// <summary>
        /// Checks to see if the ForwardPathComponents property is set.
        /// </summary>
        internal bool IsSetForwardPathComponents() => this.ForwardPathComponents != null && (this.ForwardPathComponents.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NetworkInsightsAnalysisArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the network insights analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1283)]
        public string NetworkInsightsAnalysisArn { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInsightsAnalysisArn property is set.
        /// </summary>
        internal bool IsSetNetworkInsightsAnalysisArn() => this.NetworkInsightsAnalysisArn != null;

        /// <summary>
        /// Gets and sets the property NetworkInsightsAnalysisId. 
        /// <para>
        /// The ID of the network insights analysis.
        /// </para>
        /// </summary>
        public string NetworkInsightsAnalysisId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInsightsAnalysisId property is set.
        /// </summary>
        internal bool IsSetNetworkInsightsAnalysisId() => this.NetworkInsightsAnalysisId != null;

        /// <summary>
        /// Gets and sets the property NetworkInsightsPathId. 
        /// <para>
        /// The ID of the path.
        /// </para>
        /// </summary>
        public string NetworkInsightsPathId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInsightsPathId property is set.
        /// </summary>
        internal bool IsSetNetworkInsightsPathId() => this.NetworkInsightsPathId != null;

        /// <summary>
        /// Gets and sets the property NetworkPathFound. 
        /// <para>
        /// Indicates whether the destination is reachable from the source.
        /// </para>
        /// </summary>
        public bool? NetworkPathFound { get; set; }

        /// <summary>
        /// Checks to see if the NetworkPathFound property is set.
        /// </summary>
        internal bool IsSetNetworkPathFound() => this.NetworkPathFound.HasValue;

        /// <summary>
        /// Gets and sets the property ReturnPathComponents. 
        /// <para>
        /// The components in the path from destination to source.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PathComponent> ReturnPathComponents { get; set; } = AWSConfigs.InitializeCollections ? new List<PathComponent>() : null;

        /// <summary>
        /// Checks to see if the ReturnPathComponents property is set.
        /// </summary>
        internal bool IsSetReturnPathComponents() => this.ReturnPathComponents != null && (this.ReturnPathComponents.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The time the analysis started.
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
        /// The status of the network insights analysis.
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
        /// The status message, if the status is <c>failed</c>.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property SuggestedAccounts. 
        /// <para>
        /// Potential intermediate accounts.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SuggestedAccounts { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SuggestedAccounts property is set.
        /// </summary>
        internal bool IsSetSuggestedAccounts() => this.SuggestedAccounts != null && (this.SuggestedAccounts.Count > 0 || !AWSConfigs.InitializeCollections);

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
