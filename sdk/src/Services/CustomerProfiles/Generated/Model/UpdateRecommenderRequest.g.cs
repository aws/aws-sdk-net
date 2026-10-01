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
    /// Container for the parameters to the UpdateRecommender operation. Updates the properties
    /// of an existing recommender, allowing you to modify its configuration and description.
    /// </summary>
    public partial class UpdateRecommenderRequest : AmazonCustomerProfilesRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The new description to assign to the recommender.
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
        /// The new configuration settings to apply to the recommender, including updated parameters
        /// and settings that define its behavior.
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
        /// The name of the recommender to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string RecommenderName { get; set; }

        /// <summary>
        /// Checks to see if the RecommenderName property is set.
        /// </summary>
        internal bool IsSetRecommenderName() => this.RecommenderName != null;

        /// <summary>
        /// Gets and sets the property RecommenderVersionName. 
        /// <para>
        /// The name of a specific recommender version to activate as part of this update (for
        /// example, to roll back to a previously trained version).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string RecommenderVersionName { get; set; }

        /// <summary>
        /// Checks to see if the RecommenderVersionName property is set.
        /// </summary>
        internal bool IsSetRecommenderVersionName() => this.RecommenderVersionName != null;
    }
}
