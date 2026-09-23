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

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Defines a recommendation configuration.
    /// </summary>
    public partial class ConfigRecommendation
    {
        /// <summary>
        /// Gets and sets the property AppComponentName. 
        /// <para>
        /// Name of the Application Component.
        /// </para>
        /// </summary>
        public string AppComponentName { get; set; }

        /// <summary>
        /// Checks to see if the AppComponentName property is set.
        /// </summary>
        internal bool IsSetAppComponentName() => this.AppComponentName != null;

        /// <summary>
        /// Gets and sets the property Compliance. 
        /// <para>
        /// The current compliance against the resiliency policy before applying the configuration
        /// change.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, DisruptionCompliance> Compliance { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, DisruptionCompliance>() : null;

        /// <summary>
        /// Checks to see if the Compliance property is set.
        /// </summary>
        internal bool IsSetCompliance() => this.Compliance != null && (this.Compliance.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Cost. 
        /// <para>
        /// The cost for the application.
        /// </para>
        /// </summary>
        public Cost Cost { get; set; }

        /// <summary>
        /// Checks to see if the Cost property is set.
        /// </summary>
        internal bool IsSetCost() => this.Cost != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The optional description for an app.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property HaArchitecture. 
        /// <para>
        /// The architecture type.
        /// </para>
        /// </summary>
        public HaArchitecture HaArchitecture { get; set; }

        /// <summary>
        /// Checks to see if the HaArchitecture property is set.
        /// </summary>
        internal bool IsSetHaArchitecture() => this.HaArchitecture != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the recommendation configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OptimizationType. 
        /// <para>
        /// The type of optimization.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConfigRecommendationOptimizationType OptimizationType { get; set; }

        /// <summary>
        /// Checks to see if the OptimizationType property is set.
        /// </summary>
        internal bool IsSetOptimizationType() => this.OptimizationType != null;

        /// <summary>
        /// Gets and sets the property RecommendationCompliance. 
        /// <para>
        /// The expected compliance against the resiliency policy after applying the configuration
        /// change.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, RecommendationDisruptionCompliance> RecommendationCompliance { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, RecommendationDisruptionCompliance>() : null;

        /// <summary>
        /// Checks to see if the RecommendationCompliance property is set.
        /// </summary>
        internal bool IsSetRecommendationCompliance() => this.RecommendationCompliance != null && (this.RecommendationCompliance.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReferenceId. 
        /// <para>
        /// Reference identifier for the recommendation configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Checks to see if the ReferenceId property is set.
        /// </summary>
        internal bool IsSetReferenceId() => this.ReferenceId != null;

        /// <summary>
        /// Gets and sets the property SuggestedChanges. 
        /// <para>
        /// List of the suggested configuration changes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SuggestedChanges { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SuggestedChanges property is set.
        /// </summary>
        internal bool IsSetSuggestedChanges() => this.SuggestedChanges != null && (this.SuggestedChanges.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
