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

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Contains filters for the object labels returned by DetectLabels. Filters can be inclusive,
    /// exclusive, or a combination of both and can be applied to individual labels or entire
    /// label categories. To see a list of label categories, see <a href="https://docs.aws.amazon.com/rekognition/latest/dg/labels.html">Detecting
    /// Labels</a>.
    /// </summary>
    public partial class GeneralLabelsSettings
    {
        /// <summary>
        /// Gets and sets the property LabelCategoryExclusionFilters. 
        /// <para>
        /// The label categories that should be excluded from the return from DetectLabels.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<string> LabelCategoryExclusionFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LabelCategoryExclusionFilters property is set.
        /// </summary>
        internal bool IsSetLabelCategoryExclusionFilters() => this.LabelCategoryExclusionFilters != null && (this.LabelCategoryExclusionFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LabelCategoryInclusionFilters. 
        /// <para>
        /// The label categories that should be included in the return from DetectLabels.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<string> LabelCategoryInclusionFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LabelCategoryInclusionFilters property is set.
        /// </summary>
        internal bool IsSetLabelCategoryInclusionFilters() => this.LabelCategoryInclusionFilters != null && (this.LabelCategoryInclusionFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LabelExclusionFilters. 
        /// <para>
        /// The labels that should be excluded from the return from DetectLabels.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<string> LabelExclusionFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LabelExclusionFilters property is set.
        /// </summary>
        internal bool IsSetLabelExclusionFilters() => this.LabelExclusionFilters != null && (this.LabelExclusionFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LabelInclusionFilters. 
        /// <para>
        /// The labels that should be included in the return from DetectLabels.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<string> LabelInclusionFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LabelInclusionFilters property is set.
        /// </summary>
        internal bool IsSetLabelInclusionFilters() => this.LabelInclusionFilters != null && (this.LabelInclusionFilters.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
