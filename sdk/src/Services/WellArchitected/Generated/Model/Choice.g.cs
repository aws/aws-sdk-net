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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// A choice available to answer question.
    /// </summary>
    public partial class Choice
    {
        /// <summary>
        /// Gets and sets the property AdditionalResources. 
        /// <para>
        /// The additional resources for a choice in a custom lens.
        /// </para>
        ///  
        /// <para>
        /// A choice can have up to two additional resources: one of type <c>HELPFUL_RESOURCE</c>,
        /// one of type <c>IMPROVEMENT_PLAN</c>, or both.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AdditionalResources> AdditionalResources { get; set; } = AWSConfigs.InitializeCollections ? new List<AdditionalResources>() : null;

        /// <summary>
        /// Checks to see if the AdditionalResources property is set.
        /// </summary>
        internal bool IsSetAdditionalResources() => this.AdditionalResources != null && (this.AdditionalResources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ChoiceId.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ChoiceId { get; set; }

        /// <summary>
        /// Checks to see if the ChoiceId property is set.
        /// </summary>
        internal bool IsSetChoiceId() => this.ChoiceId != null;

        /// <summary>
        /// Gets and sets the property Description.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property HelpfulResource. 
        /// <para>
        /// The helpful resource (both text and URL) for a particular choice.
        /// </para>
        ///  
        /// <para>
        /// This field only applies to custom lenses. Each choice can have only one helpful resource.
        /// </para>
        /// </summary>
        public ChoiceContent HelpfulResource { get; set; }

        /// <summary>
        /// Checks to see if the HelpfulResource property is set.
        /// </summary>
        internal bool IsSetHelpfulResource() => this.HelpfulResource != null;

        /// <summary>
        /// Gets and sets the property ImprovementPlan. 
        /// <para>
        /// The improvement plan (both text and URL) for a particular choice.
        /// </para>
        ///  
        /// <para>
        /// This field only applies to custom lenses. Each choice can have only one improvement
        /// plan.
        /// </para>
        /// </summary>
        public ChoiceContent ImprovementPlan { get; set; }

        /// <summary>
        /// Checks to see if the ImprovementPlan property is set.
        /// </summary>
        internal bool IsSetImprovementPlan() => this.ImprovementPlan != null;

        /// <summary>
        /// Gets and sets the property Title.
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
