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
    /// Details about the source content ranking data.
    /// </summary>
    public partial class RankingData
    {
        private RelevanceLevel _relevanceLevel;
        private double? _relevanceScore;

        /// <summary>
        /// Gets and sets the property RelevanceLevel. 
        /// <para>
        /// The relevance score of the content.
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
        /// The relevance level of the recommendation.
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

    }
}