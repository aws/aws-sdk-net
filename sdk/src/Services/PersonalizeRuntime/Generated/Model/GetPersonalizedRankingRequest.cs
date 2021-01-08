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

namespace Amazon.PersonalizeRuntime.Model
{
    /// <summary>
    /// Container for the parameters to the GetPersonalizedRanking operation.
    /// Re-ranks a list of recommended items for the given user. The first item in the list
    /// is deemed the most likely item to be of interest to the user.
    /// 
    ///  <note> 
    /// <para>
    /// The solution backing the campaign must have been created using a recipe of type PERSONALIZED_RANKING.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetPersonalizedRankingRequest : AmazonPersonalizeRuntimeRequest
    {
        private string _campaignArn;
        private Dictionary<string, string> _context = new Dictionary<string, string>();
        private string _filterArn;
        private Dictionary<string, string> _filterValues = new Dictionary<string, string>();
        private List<string> _inputList = new List<string>();
        private string _userId;

        /// <summary>
        /// Gets and sets the property CampaignArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the campaign to use for generating the personalized
        /// ranking.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
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
        /// Gets and sets the property Context. 
        /// <para>
        /// The contextual metadata to use when getting recommendations. Contextual metadata includes
        /// any interaction information that might be relevant when getting a user's recommendations,
        /// such as the user's current location or device type.
        /// </para>
        /// </summary>
        [AWSProperty(Max=150)]
        public Dictionary<string, string> Context
        {
            get { return this._context; }
            set { this._context = value; }
        }

        // Check to see if Context property is set
        internal bool IsSetContext()
        {
            return this._context != null && this._context.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FilterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a filter you created to include items or exclude
        /// items from recommendations for a given user. For more information, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/filter.html">Filtering
        /// Recommendations</a>.
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
        /// For filter expressions that use an <code>INCLUDE</code> element to include items,
        /// you must provide values for all parameters that are defined in the expression. For
        /// filters with expressions that use an <code>EXCLUDE</code> element to exclude items,
        /// you can omit the <code>filter-values</code>.In this case, Amazon Personalize doesn't
        /// use that portion of the expression to filter recommendations.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/filter.html">Filtering
        /// Recommendations</a>.
        /// </para>
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
            return this._filterValues != null && this._filterValues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InputList. 
        /// <para>
        /// A list of items (by <code>itemId</code>) to rank. If an item was not included in the
        /// training dataset, the item is appended to the end of the reranked list. The maximum
        /// is 500.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> InputList
        {
            get { return this._inputList; }
            set { this._inputList = value; }
        }

        // Check to see if InputList property is set
        internal bool IsSetInputList()
        {
            return this._inputList != null && this._inputList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The user for which you want the campaign to provide a personalized ranking.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
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