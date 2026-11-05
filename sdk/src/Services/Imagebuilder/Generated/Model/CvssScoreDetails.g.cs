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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Details about the source of the score, and the factors that determined the adjustments
    /// to create the final score.
    /// </summary>
    public partial class CvssScoreDetails
    {
        /// <summary>
        /// Gets and sets the property Adjustments. 
        /// <para>
        /// The adjustments that Amazon Inspector applied to the base CVSS score to produce its
        /// own score for the finding. The list is empty when Amazon Inspector made no adjustments.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CvssScoreAdjustment> Adjustments { get; set; } = AWSConfigs.InitializeCollections ? new List<CvssScoreAdjustment>() : null;

        /// <summary>
        /// Checks to see if the Adjustments property is set.
        /// </summary>
        internal bool IsSetAdjustments() => this.Adjustments != null && (this.Adjustments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CvssSource. 
        /// <para>
        /// The source of the CVSS data that the Amazon Inspector score for the finding is based
        /// on, for example NVD or a vendor security feed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string CvssSource { get; set; }

        /// <summary>
        /// Checks to see if the CvssSource property is set.
        /// </summary>
        internal bool IsSetCvssSource() => this.CvssSource != null;

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        /// The CVSS score.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public double? Score { get; set; }

        /// <summary>
        /// Checks to see if the Score property is set.
        /// </summary>
        internal bool IsSetScore() => this.Score.HasValue;

        /// <summary>
        /// Gets and sets the property ScoreSource. 
        /// <para>
        /// The source for the CVSS score.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ScoreSource { get; set; }

        /// <summary>
        /// Checks to see if the ScoreSource property is set.
        /// </summary>
        internal bool IsSetScoreSource() => this.ScoreSource != null;

        /// <summary>
        /// Gets and sets the property ScoringVector. 
        /// <para>
        /// A vector that measures the severity of the vulnerability.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ScoringVector { get; set; }

        /// <summary>
        /// Checks to see if the ScoringVector property is set.
        /// </summary>
        internal bool IsSetScoringVector() => this.ScoringVector != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The CVSS version that generated the score.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
