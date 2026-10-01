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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// The summary of a model available to an Amazon Q in Connect assistant.
    /// </summary>
    public partial class ModelSummary
    {
        /// <summary>
        /// Gets and sets the property CrossRegionStatus. 
        /// <para>
        /// The cross-region availability status of the model. <c>NONE</c> indicates the model
        /// is only available in a single region, <c>REGIONAL</c> indicates the model is available
        /// through regional inference, and <c>GLOBAL</c> indicates the model is available through
        /// global cross-region inference.
        /// </para>
        /// </summary>
        public CrossRegionStatus CrossRegionStatus { get; set; }

        /// <summary>
        /// Checks to see if the CrossRegionStatus property is set.
        /// </summary>
        internal bool IsSetCrossRegionStatus() => this.CrossRegionStatus != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property EndOfLifeTimestamp. 
        /// <para>
        /// The timestamp when the model will reach end of life and no longer be available for
        /// use.
        /// </para>
        /// </summary>
        public DateTime? EndOfLifeTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the EndOfLifeTimestamp property is set.
        /// </summary>
        internal bool IsSetEndOfLifeTimestamp() => this.EndOfLifeTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property LegacyTimestamp. 
        /// <para>
        /// The timestamp when the model lifecycle will transition from <c>ACTIVE</c> to <c>LEGACY</c>.
        /// </para>
        /// </summary>
        public DateTime? LegacyTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LegacyTimestamp property is set.
        /// </summary>
        internal bool IsSetLegacyTimestamp() => this.LegacyTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property ModelId. 
        /// <para>
        /// The identifier of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ModelId { get; set; }

        /// <summary>
        /// Checks to see if the ModelId property is set.
        /// </summary>
        internal bool IsSetModelId() => this.ModelId != null;

        /// <summary>
        /// Gets and sets the property ModelLifecycle. 
        /// <para>
        /// The current lifecycle of the model. <c>ACTIVE</c> indicates the model is recommended
        /// for use and <c>LEGACY</c> indicates the model is still usable but is deprecated.
        /// </para>
        /// </summary>
        public ModelLifecycle ModelLifecycle { get; set; }

        /// <summary>
        /// Checks to see if the ModelLifecycle property is set.
        /// </summary>
        internal bool IsSetModelLifecycle() => this.ModelLifecycle != null;

        /// <summary>
        /// Gets and sets the property SupportedAIPromptTypes. 
        /// <para>
        /// The list of AI Prompt types that the model supports.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedAIPromptTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedAIPromptTypes property is set.
        /// </summary>
        internal bool IsSetSupportedAIPromptTypes() => this.SupportedAIPromptTypes != null && (this.SupportedAIPromptTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportsPromptCaching. 
        /// <para>
        /// Whether the model supports prompt caching.
        /// </para>
        /// </summary>
        public bool? SupportsPromptCaching { get; set; }

        /// <summary>
        /// Checks to see if the SupportsPromptCaching property is set.
        /// </summary>
        internal bool IsSetSupportsPromptCaching() => this.SupportsPromptCaching.HasValue;
    }
}
