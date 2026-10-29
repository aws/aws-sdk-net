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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about a section from an evaluation form. A section can contain sections
    /// and/or questions. Evaluation forms can only contain sections and subsections (two
    /// level nesting).
    /// </summary>
    public partial class EvaluationFormSection
    {
        /// <summary>
        /// Gets and sets the property Instructions. 
        /// <para>
        /// The instructions of the section.
        /// </para>
        /// </summary>
        public string Instructions { get; set; }

        /// <summary>
        /// Checks to see if the Instructions property is set.
        /// </summary>
        internal bool IsSetInstructions() => this.Instructions != null;

        /// <summary>
        /// Gets and sets the property IsExcludedFromScoring. 
        /// <para>
        /// The flag to exclude the section from scoring.
        /// </para>
        /// </summary>
        public bool? IsExcludedFromScoring { get; set; }

        /// <summary>
        /// Checks to see if the IsExcludedFromScoring property is set.
        /// </summary>
        internal bool IsSetIsExcludedFromScoring() => this.IsExcludedFromScoring.HasValue;

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// The items of the section.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<EvaluationFormItem> Items { get; set; } = AWSConfigs.InitializeCollections ? new List<EvaluationFormItem>() : null;

        /// <summary>
        /// Checks to see if the Items property is set.
        /// </summary>
        internal bool IsSetItems() => this.Items != null && (this.Items.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RefId. 
        /// <para>
        /// The identifier of the section. An identifier must be unique within the evaluation
        /// form.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RefId { get; set; }

        /// <summary>
        /// Checks to see if the RefId property is set.
        /// </summary>
        internal bool IsSetRefId() => this.RefId != null;

        /// <summary>
        /// Gets and sets the property ScoreThresholds. 
        /// <para>
        /// The score thresholds for performance categories.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EvaluationFormScoreThreshold> ScoreThresholds { get; set; } = AWSConfigs.InitializeCollections ? new List<EvaluationFormScoreThreshold>() : null;

        /// <summary>
        /// Checks to see if the ScoreThresholds property is set.
        /// </summary>
        internal bool IsSetScoreThresholds() => this.ScoreThresholds != null && (this.ScoreThresholds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the section.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property Weight. 
        /// <para>
        /// The scoring weight of the section.
        /// </para>
        /// </summary>
        public double? Weight { get; set; }

        /// <summary>
        /// Checks to see if the Weight property is set.
        /// </summary>
        internal bool IsSetWeight() => this.Weight.HasValue;
    }
}
