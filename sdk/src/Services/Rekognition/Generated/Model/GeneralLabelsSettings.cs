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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
        private List<string> _labelCategoryExclusionFilters = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _labelCategoryInclusionFilters = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _labelExclusionFilters = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _labelInclusionFilters = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property LabelCategoryExclusionFilters. 
        /// <para>
        /// The label categories that should be excluded from the return from DetectLabels.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> LabelCategoryExclusionFilters
        {
            get { return this._labelCategoryExclusionFilters; }
            set { this._labelCategoryExclusionFilters = value; }
        }

        // Check to see if LabelCategoryExclusionFilters property is set
        internal bool IsSetLabelCategoryExclusionFilters()
        {
            return this._labelCategoryExclusionFilters != null && (this._labelCategoryExclusionFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LabelCategoryInclusionFilters. 
        /// <para>
        /// The label categories that should be included in the return from DetectLabels.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> LabelCategoryInclusionFilters
        {
            get { return this._labelCategoryInclusionFilters; }
            set { this._labelCategoryInclusionFilters = value; }
        }

        // Check to see if LabelCategoryInclusionFilters property is set
        internal bool IsSetLabelCategoryInclusionFilters()
        {
            return this._labelCategoryInclusionFilters != null && (this._labelCategoryInclusionFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LabelExclusionFilters. 
        /// <para>
        /// The labels that should be excluded from the return from DetectLabels.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> LabelExclusionFilters
        {
            get { return this._labelExclusionFilters; }
            set { this._labelExclusionFilters = value; }
        }

        // Check to see if LabelExclusionFilters property is set
        internal bool IsSetLabelExclusionFilters()
        {
            return this._labelExclusionFilters != null && (this._labelExclusionFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LabelInclusionFilters. 
        /// <para>
        /// The labels that should be included in the return from DetectLabels.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> LabelInclusionFilters
        {
            get { return this._labelInclusionFilters; }
            set { this._labelInclusionFilters = value; }
        }

        // Check to see if LabelInclusionFilters property is set
        internal bool IsSetLabelInclusionFilters()
        {
            return this._labelInclusionFilters != null && (this._labelInclusionFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}