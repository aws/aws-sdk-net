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
    /// Container for the parameters to the CreateRecommender operation. Creates a recommender
    /// </summary>
    public partial class CreateRecommenderRequest : AmazonCustomerProfilesRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the domain object type.
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
        /// Gets and sets the property RecommenderConfig. 
        /// <para>
        /// The recommender configuration.
        /// </para>
        /// </summary>
        public RecommenderConfig RecommenderConfig { get; set; }

        /// <summary>
        /// Checks to see if the RecommenderConfig property is set.
        /// </summary>
        internal bool IsSetRecommenderConfig() => this.RecommenderConfig != null;

        /// <summary>
        /// Gets and sets the property RecommenderName. 
        /// <para>
        /// The name of the recommender.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string RecommenderName { get; set; }

        /// <summary>
        /// Checks to see if the RecommenderName property is set.
        /// </summary>
        internal bool IsSetRecommenderName() => this.RecommenderName != null;

        /// <summary>
        /// Gets and sets the property RecommenderRecipeName. 
        /// <para>
        /// The name of the recommeder recipe.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RecommenderRecipeName RecommenderRecipeName { get; set; }

        /// <summary>
        /// Checks to see if the RecommenderRecipeName property is set.
        /// </summary>
        internal bool IsSetRecommenderRecipeName() => this.RecommenderRecipeName != null;

        /// <summary>
        /// Gets and sets the property RecommenderSchemaName. 
        /// <para>
        /// The name of the recommender schema to use for this recommender. If not specified,
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
