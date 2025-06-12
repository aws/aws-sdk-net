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
    /// Contains information for score and potential quality issues for Audio
    /// </summary>
    public partial class AudioQualityMetricsInfo
    {
        private List<string> _potentialQualityIssues = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private float? _qualityScore;

        /// <summary>
        /// Gets and sets the property PotentialQualityIssues. 
        /// <para>
        /// List of potential issues causing degradation of quality on a media connection. If
        /// the service did not detect any potential quality issues the list is empty.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>HighPacketLoss</c> | <c>HighRoundTripTime</c> | <c>HighJitterBuffer</c>
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public List<string> PotentialQualityIssues
        {
            get { return this._potentialQualityIssues; }
            set { this._potentialQualityIssues = value; }
        }

        // Check to see if PotentialQualityIssues property is set
        internal bool IsSetPotentialQualityIssues()
        {
            return this._potentialQualityIssues != null && (this._potentialQualityIssues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QualityScore. 
        /// <para>
        /// Number measuring the estimated quality of the media connection.
        /// </para>
        /// </summary>
        public float? QualityScore
        {
            get { return this._qualityScore; }
            set { this._qualityScore = value; }
        }

        // Check to see if QualityScore property is set
        internal bool IsSetQualityScore()
        {
            return this._qualityScore.HasValue; 
        }

    }
}