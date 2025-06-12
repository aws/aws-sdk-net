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
 * Do not modify this file. This file is generated from the wisdom-2020-10-19.normal.json service model.
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
namespace Amazon.ConnectWisdomService.Model
{
    /// <summary>
    /// A recommendation trigger provides context on the event that produced the referenced
    /// recommendations. Recommendations are only referenced in <c>recommendationIds</c> by
    /// a single RecommendationTrigger.
    /// </summary>
    public partial class RecommendationTrigger
    {
        private RecommendationTriggerData _data;
        private string _id;
        private List<string> _recommendationIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private RecommendationSourceType _source;
        private RecommendationTriggerType _type;

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// A union type containing information related to the trigger.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecommendationTriggerData Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        // Check to see if Data property is set
        internal bool IsSetData()
        {
            return this._data != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the recommendation trigger.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendationIds. 
        /// <para>
        /// The identifiers of the recommendations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=25)]
        public List<string> RecommendationIds
        {
            get { return this._recommendationIds; }
            set { this._recommendationIds = value; }
        }

        // Check to see if RecommendationIds property is set
        internal bool IsSetRecommendationIds()
        {
            return this._recommendationIds != null && (this._recommendationIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source of the recommendation trigger.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ISSUE_DETECTION: The corresponding recommendations were triggered by a Contact Lens
        /// issue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RULE_EVALUATION: The corresponding recommendations were triggered by a Contact Lens
        /// rule.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecommendationSourceType Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of recommendation trigger.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecommendationTriggerType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}