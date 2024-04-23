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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECR.Model
{
    /// <summary>
    /// Information about the CVSS score.
    /// </summary>
    public partial class CvssScoreDetails
    {
        private List<CvssScoreAdjustment> _adjustments = AWSConfigs.InitializeCollections ? new List<CvssScoreAdjustment>() : null;
        private double? _score;
        private string _scoreSource;
        private string _scoringVector;
        private string _version;

        /// <summary>
        /// Gets and sets the property Adjustments. 
        /// <para>
        /// An object that contains details about adjustment Amazon Inspector made to the CVSS
        /// score.
        /// </para>
        /// </summary>
        public List<CvssScoreAdjustment> Adjustments
        {
            get { return this._adjustments; }
            set { this._adjustments = value; }
        }

        // Check to see if Adjustments property is set
        internal bool IsSetAdjustments()
        {
            return this._adjustments != null && (this._adjustments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        /// The CVSS score.
        /// </para>
        /// </summary>
        public double Score
        {
            get { return this._score.GetValueOrDefault(); }
            set { this._score = value; }
        }

        // Check to see if Score property is set
        internal bool IsSetScore()
        {
            return this._score.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScoreSource. 
        /// <para>
        /// The source for the CVSS score.
        /// </para>
        /// </summary>
        public string ScoreSource
        {
            get { return this._scoreSource; }
            set { this._scoreSource = value; }
        }

        // Check to see if ScoreSource property is set
        internal bool IsSetScoreSource()
        {
            return this._scoreSource != null;
        }

        /// <summary>
        /// Gets and sets the property ScoringVector. 
        /// <para>
        /// The vector for the CVSS score.
        /// </para>
        /// </summary>
        public string ScoringVector
        {
            get { return this._scoringVector; }
            set { this._scoringVector = value; }
        }

        // Check to see if ScoringVector property is set
        internal bool IsSetScoringVector()
        {
            return this._scoringVector != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The CVSS version used in scoring.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}