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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Scoring configuration for a question in an evaluation form.
    /// </summary>
    public partial class EvaluationFormQuestionScoringConfiguration
    {
        private bool? _isExcludedFromScoring;
        private QuestionPointsConfiguration _pointsConfiguration;
        private List<EvaluationFormScoreThreshold> _scoreThresholds = AWSConfigs.InitializeCollections ? new List<EvaluationFormScoreThreshold>() : null;

        /// <summary>
        /// Gets and sets the property IsExcludedFromScoring. 
        /// <para>
        /// The flag to exclude the question from scoring.
        /// </para>
        /// </summary>
        public bool? IsExcludedFromScoring
        {
            get { return this._isExcludedFromScoring; }
            set { this._isExcludedFromScoring = value; }
        }

        // Check to see if IsExcludedFromScoring property is set
        internal bool IsSetIsExcludedFromScoring()
        {
            return this._isExcludedFromScoring.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PointsConfiguration. 
        /// <para>
        /// The points configuration for point-based scoring.
        /// </para>
        /// </summary>
        public QuestionPointsConfiguration PointsConfiguration
        {
            get { return this._pointsConfiguration; }
            set { this._pointsConfiguration = value; }
        }

        // Check to see if PointsConfiguration property is set
        internal bool IsSetPointsConfiguration()
        {
            return this._pointsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ScoreThresholds. 
        /// <para>
        /// The score thresholds for performance categories.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EvaluationFormScoreThreshold> ScoreThresholds
        {
            get { return this._scoreThresholds; }
            set { this._scoreThresholds = value; }
        }

        // Check to see if ScoreThresholds property is set
        internal bool IsSetScoreThresholds()
        {
            return this._scoreThresholds != null && (this._scoreThresholds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}