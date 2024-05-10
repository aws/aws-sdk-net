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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Information about the recommendation.
    /// </summary>
    public partial class RecommendationData
    {
        private DataSummary _data;
        private Document _document;
        private string _recommendationId;
        private RelevanceLevel _relevanceLevel;
        private double? _relevanceScore;
        private RecommendationType _type;

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        ///  Summary of the recommended content.
        /// </para>
        /// </summary>
        public DataSummary Data
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
        /// Gets and sets the property Document. 
        /// <para>
        /// The recommended document.
        /// </para>
        /// </summary>
        public Document Document
        {
            get { return this._document; }
            set { this._document = value; }
        }

        // Check to see if Document property is set
        internal bool IsSetDocument()
        {
            return this._document != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendationId. 
        /// <para>
        /// The identifier of the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string RecommendationId
        {
            get { return this._recommendationId; }
            set { this._recommendationId = value; }
        }

        // Check to see if RecommendationId property is set
        internal bool IsSetRecommendationId()
        {
            return this._recommendationId != null;
        }

        /// <summary>
        /// Gets and sets the property RelevanceLevel. 
        /// <para>
        /// The relevance level of the recommendation.
        /// </para>
        /// </summary>
        public RelevanceLevel RelevanceLevel
        {
            get { return this._relevanceLevel; }
            set { this._relevanceLevel = value; }
        }

        // Check to see if RelevanceLevel property is set
        internal bool IsSetRelevanceLevel()
        {
            return this._relevanceLevel != null;
        }

        /// <summary>
        /// Gets and sets the property RelevanceScore. 
        /// <para>
        /// The relevance score of the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public double? RelevanceScore
        {
            get { return this._relevanceScore; }
            set { this._relevanceScore = value; }
        }

        // Check to see if RelevanceScore property is set
        internal bool IsSetRelevanceScore()
        {
            return this._relevanceScore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of recommendation.
        /// </para>
        /// </summary>
        public RecommendationType Type
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