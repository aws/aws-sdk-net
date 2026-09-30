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

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRecommenderFilter operation. Creates a recommender
    /// filter. A recommender filter specifies which items to include or exclude from recommendations.
    /// </summary>
    public partial class CreateRecommenderFilterRequest : AmazonCustomerProfilesRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the recommender filter.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The unique name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property RecommenderFilterExpression. 
        /// <para>
        /// The filter expression that defines which items to include or exclude from recommendations.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 2500)]
        public string RecommenderFilterExpression { get; set; }

        /// <summary>
        /// Checks to see if the RecommenderFilterExpression property is set.
        /// </summary>
        internal bool IsSetRecommenderFilterExpression() => this.RecommenderFilterExpression != null;

        /// <summary>
        /// Gets and sets the property RecommenderFilterName. 
        /// <para>
        /// The name of the recommender filter. The name must be unique within the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string RecommenderFilterName { get; set; }

        /// <summary>
        /// Checks to see if the RecommenderFilterName property is set.
        /// </summary>
        internal bool IsSetRecommenderFilterName() => this.RecommenderFilterName != null;

        /// <summary>
        /// Gets and sets the property RecommenderSchemaName. 
        /// <para>
        /// The name of the recommender schema to use for this recommender filter. If not specified,
        /// the default schema is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string RecommenderSchemaName { get; set; }

        /// <summary>
        /// Checks to see if the RecommenderSchemaName property is set.
        /// </summary>
        internal bool IsSetRecommenderSchemaName() => this.RecommenderSchemaName != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
