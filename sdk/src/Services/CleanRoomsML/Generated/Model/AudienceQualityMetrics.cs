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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
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
namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Metrics that describe the quality of the generated audience.
    /// </summary>
    public partial class AudienceQualityMetrics
    {
        private double? _recallMetric;
        private List<RelevanceMetric> _relevanceMetrics = AWSConfigs.InitializeCollections ? new List<RelevanceMetric>() : null;

        /// <summary>
        /// Gets and sets the property RecallMetric. 
        /// <para>
        /// The recall score of the generated audience. Recall is the percentage of the most similar
        /// users (by default, the most similar 20%) from a sample of the training data that are
        /// included in the seed audience by the audience generation job. Values range from 0-1,
        /// larger values indicate a better audience. A recall value approximately equal to the
        /// maximum bin size indicates that the audience model is equivalent to random selection.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public double? RecallMetric
        {
            get { return this._recallMetric; }
            set { this._recallMetric = value; }
        }

        // Check to see if RecallMetric property is set
        internal bool IsSetRecallMetric()
        {
            return this._recallMetric.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RelevanceMetrics. 
        /// <para>
        /// The relevance scores of the generated audience.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RelevanceMetric> RelevanceMetrics
        {
            get { return this._relevanceMetrics; }
            set { this._relevanceMetrics = value; }
        }

        // Check to see if RelevanceMetrics property is set
        internal bool IsSetRelevanceMetrics()
        {
            return this._relevanceMetrics != null && (this._relevanceMetrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}