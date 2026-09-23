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
    /// Defines a standard operating procedure (SOP) recommendation.
    /// </summary>
    public partial class SopRecommendation
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
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the SOP recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// The recommendation items.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RecommendationItem> Items { get; set; } = AWSConfigs.InitializeCollections ? new List<RecommendationItem>() : null;

        /// <summary>
        /// Checks to see if the Items property is set.
        /// </summary>
        internal bool IsSetItems() => this.Items != null && (this.Items.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the SOP recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Prerequisite. 
        /// <para>
        /// Prerequisite for the SOP recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string Prerequisite { get; set; }

        /// <summary>
        /// Checks to see if the Prerequisite property is set.
        /// </summary>
        internal bool IsSetPrerequisite() => this.Prerequisite != null;

        /// <summary>
        /// Gets and sets the property RecommendationId. 
        /// <para>
        /// Identifier for the SOP recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RecommendationId { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationId property is set.
        /// </summary>
        internal bool IsSetRecommendationId() => this.RecommendationId != null;

        /// <summary>
        /// Gets and sets the property RecommendationStatus. 
        /// <para>
        /// Status of the recommended standard operating procedure.
        /// </para>
        /// </summary>
        public RecommendationStatus RecommendationStatus { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationStatus property is set.
        /// </summary>
        internal bool IsSetRecommendationStatus() => this.RecommendationStatus != null;

        /// <summary>
        /// Gets and sets the property ReferenceId. 
        /// <para>
        /// Reference identifier for the SOP recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Checks to see if the ReferenceId property is set.
        /// </summary>
        internal bool IsSetReferenceId() => this.ReferenceId != null;

        /// <summary>
        /// Gets and sets the property ServiceType. 
        /// <para>
        /// The service type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SopServiceType ServiceType { get; set; }

        /// <summary>
        /// Checks to see if the ServiceType property is set.
        /// </summary>
        internal bool IsSetServiceType() => this.ServiceType != null;
    }
}
