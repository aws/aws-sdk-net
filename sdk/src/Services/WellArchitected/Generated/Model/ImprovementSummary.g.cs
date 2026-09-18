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
    /// An improvement summary of a lens review in a workload.
    /// </summary>
    public partial class ImprovementSummary
    {
        /// <summary>
        /// Gets and sets the property ImprovementPlanUrl.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ImprovementPlanUrl { get; set; }

        /// <summary>
        /// Checks to see if the ImprovementPlanUrl property is set.
        /// </summary>
        internal bool IsSetImprovementPlanUrl() => this.ImprovementPlanUrl != null;

        /// <summary>
        /// Gets and sets the property ImprovementPlans. 
        /// <para>
        /// The improvement plan details.
        /// </para>
        ///  
        /// <para>
        /// This value is only applicable to custom lenses.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ChoiceImprovementPlan> ImprovementPlans { get; set; } = AWSConfigs.InitializeCollections ? new List<ChoiceImprovementPlan>() : null;

        /// <summary>
        /// Checks to see if the ImprovementPlans property is set.
        /// </summary>
        internal bool IsSetImprovementPlans() => this.ImprovementPlans != null && (this.ImprovementPlans.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property JiraConfiguration. 
        /// <para>
        /// Configuration of the Jira integration.
        /// </para>
        /// </summary>
        public JiraConfiguration JiraConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the JiraConfiguration property is set.
        /// </summary>
        internal bool IsSetJiraConfiguration() => this.JiraConfiguration != null;

        /// <summary>
        /// Gets and sets the property PillarId.
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string PillarId { get; set; }

        /// <summary>
        /// Checks to see if the PillarId property is set.
        /// </summary>
        internal bool IsSetPillarId() => this.PillarId != null;

        /// <summary>
        /// Gets and sets the property QuestionId.
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string QuestionId { get; set; }

        /// <summary>
        /// Checks to see if the QuestionId property is set.
        /// </summary>
        internal bool IsSetQuestionId() => this.QuestionId != null;

        /// <summary>
        /// Gets and sets the property QuestionTitle.
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string QuestionTitle { get; set; }

        /// <summary>
        /// Checks to see if the QuestionTitle property is set.
        /// </summary>
        internal bool IsSetQuestionTitle() => this.QuestionTitle != null;

        /// <summary>
        /// Gets and sets the property Risk.
        /// </summary>
        public Risk Risk { get; set; }

        /// <summary>
        /// Checks to see if the Risk property is set.
        /// </summary>
        internal bool IsSetRisk() => this.Risk != null;
    }
}
