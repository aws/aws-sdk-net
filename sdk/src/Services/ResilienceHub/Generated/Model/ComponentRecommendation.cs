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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
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
namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Defines recommendations for an Resilience Hub Application Component, returned as an
    /// object. This object contains component names, configuration recommendations, and recommendation
    /// statuses.
    /// </summary>
    public partial class ComponentRecommendation
    {
        private string _appComponentName;
        private List<ConfigRecommendation> _configRecommendations = AWSConfigs.InitializeCollections ? new List<ConfigRecommendation>() : null;
        private RecommendationComplianceStatus _recommendationStatus;

        /// <summary>
        /// Gets and sets the property AppComponentName. 
        /// <para>
        /// Name of the Application Component.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AppComponentName
        {
            get { return this._appComponentName; }
            set { this._appComponentName = value; }
        }

        // Check to see if AppComponentName property is set
        internal bool IsSetAppComponentName()
        {
            return this._appComponentName != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigRecommendations. 
        /// <para>
        /// List of recommendations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ConfigRecommendation> ConfigRecommendations
        {
            get { return this._configRecommendations; }
            set { this._configRecommendations = value; }
        }

        // Check to see if ConfigRecommendations property is set
        internal bool IsSetConfigRecommendations()
        {
            return this._configRecommendations != null && (this._configRecommendations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RecommendationStatus. 
        /// <para>
        /// Status of the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecommendationComplianceStatus RecommendationStatus
        {
            get { return this._recommendationStatus; }
            set { this._recommendationStatus = value; }
        }

        // Check to see if RecommendationStatus property is set
        internal bool IsSetRecommendationStatus()
        {
            return this._recommendationStatus != null;
        }

    }
}