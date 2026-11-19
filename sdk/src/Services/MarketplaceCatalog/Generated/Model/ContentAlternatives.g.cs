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

namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// The proposed values for a listing field. Exactly one member is set, depending on the
    /// field. The list in that member is empty if the status of the recommendation is <c>INSUFFICIENT_CONTEXT</c>.
    /// </summary>
    public partial class ContentAlternatives
    {
        /// <summary>
        /// Gets and sets the property AdditionalResources. 
        /// <para>
        /// The proposed values for <c>AdditionalResources</c>. You can have up to 3 alternatives.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 3)]
        public List<AdditionalResourcesAlternative> AdditionalResources { get; set; } = AWSConfigs.InitializeCollections ? new List<AdditionalResourcesAlternative>() : null;

        /// <summary>
        /// Checks to see if the AdditionalResources property is set.
        /// </summary>
        internal bool IsSetAdditionalResources() => this.AdditionalResources != null && (this.AdditionalResources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CaseStudies. 
        /// <para>
        /// The proposed values for <c>CaseStudies</c>. You can have up to 3 alternatives.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 3)]
        public List<CaseStudiesAlternative> CaseStudies { get; set; } = AWSConfigs.InitializeCollections ? new List<CaseStudiesAlternative>() : null;

        /// <summary>
        /// Checks to see if the CaseStudies property is set.
        /// </summary>
        internal bool IsSetCaseStudies() => this.CaseStudies != null && (this.CaseStudies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The proposed values for a text field, such as <c>ProductTitle</c> or <c>LongDescription</c>.
        /// You can have up to 3 alternatives.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 3)]
        public List<TextAlternative> Text { get; set; } = AWSConfigs.InitializeCollections ? new List<TextAlternative>() : null;

        /// <summary>
        /// Checks to see if the Text property is set.
        /// </summary>
        internal bool IsSetText() => this.Text != null && (this.Text.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TextList. 
        /// <para>
        /// The proposed values for <c>Highlights</c>, <c>SearchKeywords</c>, or <c>Categories</c>.
        /// You can have up to 3 alternatives.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 3)]
        public List<TextListAlternative> TextList { get; set; } = AWSConfigs.InitializeCollections ? new List<TextListAlternative>() : null;

        /// <summary>
        /// Checks to see if the TextList property is set.
        /// </summary>
        internal bool IsSetTextList() => this.TextList != null && (this.TextList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UseCases. 
        /// <para>
        /// The proposed values for <c>UseCases</c>. You can have up to 3 alternatives.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 3)]
        public List<UseCasesAlternative> UseCases { get; set; } = AWSConfigs.InitializeCollections ? new List<UseCasesAlternative>() : null;

        /// <summary>
        /// Checks to see if the UseCases property is set.
        /// </summary>
        internal bool IsSetUseCases() => this.UseCases != null && (this.UseCases.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
