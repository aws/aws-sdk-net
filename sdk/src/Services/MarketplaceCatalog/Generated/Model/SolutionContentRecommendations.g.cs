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
    /// The content recommendations for a solution listing, with one member for each listing
    /// field. A member is absent if nothing is recommended for that field.
    /// </summary>
    public partial class SolutionContentRecommendations
    {
        /// <summary>
        /// Gets and sets the property AdditionalResources. 
        /// <para>
        /// The recommendation for the additional resources. Each alternative has up to 8 resources.
        /// </para>
        /// </summary>
        public ContentRecommendation AdditionalResources { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalResources property is set.
        /// </summary>
        internal bool IsSetAdditionalResources() => this.AdditionalResources != null;

        /// <summary>
        /// Gets and sets the property CaseStudies. 
        /// <para>
        /// The recommendation for the case studies of the solution. Each alternative has up to
        /// 20 case studies.
        /// </para>
        /// </summary>
        public ContentRecommendation CaseStudies { get; set; }

        /// <summary>
        /// Checks to see if the CaseStudies property is set.
        /// </summary>
        internal bool IsSetCaseStudies() => this.CaseStudies != null;

        /// <summary>
        /// Gets and sets the property Citations. 
        /// <para>
        /// The sources that the recommendations are based on. You can have up to 5 sources. The
        /// list is empty if there are none.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 5)]
        public List<RecommendationCitation> Citations { get; set; } = AWSConfigs.InitializeCollections ? new List<RecommendationCitation>() : null;

        /// <summary>
        /// Checks to see if the Citations property is set.
        /// </summary>
        internal bool IsSetCitations() => this.Citations != null && (this.Citations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IntegrationDetails. 
        /// <para>
        /// The recommendation for the integration details of the solution.
        /// </para>
        /// </summary>
        public ContentRecommendation IntegrationDetails { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationDetails property is set.
        /// </summary>
        internal bool IsSetIntegrationDetails() => this.IntegrationDetails != null;

        /// <summary>
        /// Gets and sets the property LongDescription. 
        /// <para>
        /// The recommendation for the long description of the solution.
        /// </para>
        /// </summary>
        public ContentRecommendation LongDescription { get; set; }

        /// <summary>
        /// Checks to see if the LongDescription property is set.
        /// </summary>
        internal bool IsSetLongDescription() => this.LongDescription != null;

        /// <summary>
        /// Gets and sets the property ShortDescription. 
        /// <para>
        /// The recommendation for the value proposition of the solution.
        /// </para>
        /// </summary>
        public ContentRecommendation ShortDescription { get; set; }

        /// <summary>
        /// Checks to see if the ShortDescription property is set.
        /// </summary>
        internal bool IsSetShortDescription() => this.ShortDescription != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The recommendation for the external title of the solution.
        /// </para>
        /// </summary>
        public ContentRecommendation Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property UseCases. 
        /// <para>
        /// The recommendation for the use cases of the solution.
        /// </para>
        /// </summary>
        public ContentRecommendation UseCases { get; set; }

        /// <summary>
        /// Checks to see if the UseCases property is set.
        /// </summary>
        internal bool IsSetUseCases() => this.UseCases != null;
    }
}
