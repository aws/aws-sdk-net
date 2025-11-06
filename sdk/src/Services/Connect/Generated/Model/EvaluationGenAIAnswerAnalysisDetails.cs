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
    /// An analysis for a generative AI answer to the question.
    /// </summary>
    public partial class EvaluationGenAIAnswerAnalysisDetails
    {
        private string _justification;
        private List<EvaluationTranscriptPointOfInterest> _pointsOfInterest = AWSConfigs.InitializeCollections ? new List<EvaluationTranscriptPointOfInterest>() : null;

        /// <summary>
        /// Gets and sets the property Justification. 
        /// <para>
        /// Generative AI automation answer justification.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Justification
        {
            get { return this._justification; }
            set { this._justification = value; }
        }

        // Check to see if Justification property is set
        internal bool IsSetJustification()
        {
            return this._justification != null;
        }

        /// <summary>
        /// Gets and sets the property PointsOfInterest. 
        /// <para>
        /// Generative AI automation answer analysis points of interest.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<EvaluationTranscriptPointOfInterest> PointsOfInterest
        {
            get { return this._pointsOfInterest; }
            set { this._pointsOfInterest = value; }
        }

        // Check to see if PointsOfInterest property is set
        internal bool IsSetPointsOfInterest()
        {
            return this._pointsOfInterest != null && (this._pointsOfInterest.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}