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

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Defines a configuration recommendation.
    /// </summary>
    public partial class ConfigRecommendation
    {
        private string _appComponentName;
        private Dictionary<string, DisruptionCompliance> _compliance = new Dictionary<string, DisruptionCompliance>();
        private Cost _cost;
        private string _description;
        private HaArchitecture _haArchitecture;
        private string _name;
        private ConfigRecommendationOptimizationType _optimizationType;
        private Dictionary<string, RecommendationDisruptionCompliance> _recommendationCompliance = new Dictionary<string, RecommendationDisruptionCompliance>();
        private string _referenceId;
        private List<string> _suggestedChanges = new List<string>();

        /// <summary>
        /// Gets and sets the property AppComponentName. 
        /// <para>
        /// The name of the Application Component.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Compliance. 
        /// <para>
        /// The current compliance against the resiliency policy before applying the configuration
        /// change.
        /// </para>
        /// </summary>
        public Dictionary<string, DisruptionCompliance> Compliance
        {
            get { return this._compliance; }
            set { this._compliance = value; }
        }

        // Check to see if Compliance property is set
        internal bool IsSetCompliance()
        {
            return this._compliance != null && this._compliance.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Cost. 
        /// <para>
        /// The cost for the application.
        /// </para>
        /// </summary>
        public Cost Cost
        {
            get { return this._cost; }
            set { this._cost = value; }
        }

        // Check to see if Cost property is set
        internal bool IsSetCost()
        {
            return this._cost != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The optional description for an app.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property HaArchitecture. 
        /// <para>
        /// The architecture type.
        /// </para>
        /// </summary>
        public HaArchitecture HaArchitecture
        {
            get { return this._haArchitecture; }
            set { this._haArchitecture = value; }
        }

        // Check to see if HaArchitecture property is set
        internal bool IsSetHaArchitecture()
        {
            return this._haArchitecture != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the recommendation configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OptimizationType. 
        /// <para>
        /// The type of optimization.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConfigRecommendationOptimizationType OptimizationType
        {
            get { return this._optimizationType; }
            set { this._optimizationType = value; }
        }

        // Check to see if OptimizationType property is set
        internal bool IsSetOptimizationType()
        {
            return this._optimizationType != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendationCompliance. 
        /// <para>
        /// The expected compliance against the resiliency policy after applying the configuration
        /// change.
        /// </para>
        /// </summary>
        public Dictionary<string, RecommendationDisruptionCompliance> RecommendationCompliance
        {
            get { return this._recommendationCompliance; }
            set { this._recommendationCompliance = value; }
        }

        // Check to see if RecommendationCompliance property is set
        internal bool IsSetRecommendationCompliance()
        {
            return this._recommendationCompliance != null && this._recommendationCompliance.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReferenceId. 
        /// <para>
        /// The reference identifier for the recommendation configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string ReferenceId
        {
            get { return this._referenceId; }
            set { this._referenceId = value; }
        }

        // Check to see if ReferenceId property is set
        internal bool IsSetReferenceId()
        {
            return this._referenceId != null;
        }

        /// <summary>
        /// Gets and sets the property SuggestedChanges. 
        /// <para>
        /// List of the suggested configuration changes.
        /// </para>
        /// </summary>
        public List<string> SuggestedChanges
        {
            get { return this._suggestedChanges; }
            set { this._suggestedChanges = value; }
        }

        // Check to see if SuggestedChanges property is set
        internal bool IsSetSuggestedChanges()
        {
            return this._suggestedChanges != null && this._suggestedChanges.Count > 0; 
        }

    }
}