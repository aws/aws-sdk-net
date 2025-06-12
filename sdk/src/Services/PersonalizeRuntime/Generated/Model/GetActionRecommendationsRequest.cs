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
 * Do not modify this file. This file is generated from the personalize-runtime-2018-05-22.normal.json service model.
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
namespace Amazon.PersonalizeRuntime.Model
{
    /// <summary>
    /// Container for the parameters to the GetActionRecommendations operation.
    /// Returns a list of recommended actions in sorted in descending order by prediction
    /// score. Use the <c>GetActionRecommendations</c> API if you have a custom campaign that
    /// deploys a solution version trained with a PERSONALIZED_ACTIONS recipe. 
    /// 
    ///  
    /// <para>
    /// For more information about PERSONALIZED_ACTIONS recipes, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/nexts-best-action-recipes.html">PERSONALIZED_ACTIONS
    /// recipes</a>. For more information about getting action recommendations, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/get-action-recommendations.html">Getting
    /// action recommendations</a>.
    /// </para>
    /// </summary>
    public partial class GetActionRecommendationsRequest : AmazonPersonalizeRuntimeRequest
    {
        private string _campaignArn;
        private string _filterArn;
        private Dictionary<string, string> _filterValues = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private int? _numResults;
        private string _userId;

        /// <summary>
        /// Gets and sets the property CampaignArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the campaign to use for getting action recommendations.
        /// This campaign must deploy a solution version trained with a PERSONALIZED_ACTIONS recipe.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string CampaignArn
        {
            get { return this._campaignArn; }
            set { this._campaignArn = value; }
        }

        // Check to see if CampaignArn property is set
        internal bool IsSetCampaignArn()
        {
            return this._campaignArn != null;
        }

        /// <summary>
        /// Gets and sets the property FilterArn. 
        /// <para>
        /// The ARN of the filter to apply to the returned recommendations. For more information,
        /// see <a href="https://docs.aws.amazon.com/personalize/latest/dg/filter.html">Filtering
        /// Recommendations</a>.
        /// </para>
        ///  
        /// <para>
        /// When using this parameter, be sure the filter resource is <c>ACTIVE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string FilterArn
        {
            get { return this._filterArn; }
            set { this._filterArn = value; }
        }

        // Check to see if FilterArn property is set
        internal bool IsSetFilterArn()
        {
            return this._filterArn != null;
        }

        /// <summary>
        /// Gets and sets the property FilterValues. 
        /// <para>
        /// The values to use when filtering recommendations. For each placeholder parameter in
        /// your filter expression, provide the parameter name (in matching case) as a key and
        /// the filter value(s) as the corresponding value. Separate multiple values for one parameter
        /// with a comma. 
        /// </para>
        ///  
        /// <para>
        /// For filter expressions that use an <c>INCLUDE</c> element to include actions, you
        /// must provide values for all parameters that are defined in the expression. For filters
        /// with expressions that use an <c>EXCLUDE</c> element to exclude actions, you can omit
        /// the <c>filter-values</c>. In this case, Amazon Personalize doesn't use that portion
        /// of the expression to filter recommendations.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/filter.html">Filtering
        /// recommendations and user segments</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=25)]
        public Dictionary<string, string> FilterValues
        {
            get { return this._filterValues; }
            set { this._filterValues = value; }
        }

        // Check to see if FilterValues property is set
        internal bool IsSetFilterValues()
        {
            return this._filterValues != null && (this._filterValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NumResults. 
        /// <para>
        /// The number of results to return. The default is 5. The maximum is 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? NumResults
        {
            get { return this._numResults; }
            set { this._numResults = value; }
        }

        // Check to see if NumResults property is set
        internal bool IsSetNumResults()
        {
            return this._numResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The user ID of the user to provide action recommendations for.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}