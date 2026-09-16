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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
    /// The recommender used to generate the recommendations.
    /// </summary>
    public partial class Recommender
    {
        private List<RecommenderFilter> _filters = AWSConfigs.InitializeCollections ? new List<RecommenderFilter>() : null;
        private string _name;
        private List<RecommenderPromotionalFilter> _promotionalFilters = AWSConfigs.InitializeCollections ? new List<RecommenderPromotionalFilter>() : null;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// A list of filters to apply to the returned recommendations. Filters define criteria
        /// for including or excluding items from the recommendation results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=1)]
        public List<RecommenderFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The unique name of the recommender.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PromotionalFilters. 
        /// <para>
        /// A list of promotional filters to apply to the recommendations. Promotional filters
        /// allow you to promote specific items within a configurable subset of recommendation
        /// results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=1)]
        public List<RecommenderPromotionalFilter> PromotionalFilters
        {
            get { return this._promotionalFilters; }
            set { this._promotionalFilters = value; }
        }

        // Check to see if PromotionalFilters property is set
        internal bool IsSetPromotionalFilters()
        {
            return this._promotionalFilters != null && (this._promotionalFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}