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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
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
        private List<ChoiceImprovementPlan> _improvementPlans = AWSConfigs.InitializeCollections ? new List<ChoiceImprovementPlan>() : null;
        private string _improvementPlanUrl;
        private JiraConfiguration _jiraConfiguration;
        private string _pillarId;
        private string _questionId;
        private string _questionTitle;
        private Risk _risk;

        /// <summary>
        /// Gets and sets the property ImprovementPlans. 
        /// <para>
        /// The improvement plan details.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ChoiceImprovementPlan> ImprovementPlans
        {
            get { return this._improvementPlans; }
            set { this._improvementPlans = value; }
        }

        // Check to see if ImprovementPlans property is set
        internal bool IsSetImprovementPlans()
        {
            return this._improvementPlans != null && (this._improvementPlans.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ImprovementPlanUrl.
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ImprovementPlanUrl
        {
            get { return this._improvementPlanUrl; }
            set { this._improvementPlanUrl = value; }
        }

        // Check to see if ImprovementPlanUrl property is set
        internal bool IsSetImprovementPlanUrl()
        {
            return this._improvementPlanUrl != null;
        }

        /// <summary>
        /// Gets and sets the property JiraConfiguration. 
        /// <para>
        /// Configuration of the Jira integration.
        /// </para>
        /// </summary>
        public JiraConfiguration JiraConfiguration
        {
            get { return this._jiraConfiguration; }
            set { this._jiraConfiguration = value; }
        }

        // Check to see if JiraConfiguration property is set
        internal bool IsSetJiraConfiguration()
        {
            return this._jiraConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property PillarId.
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string PillarId
        {
            get { return this._pillarId; }
            set { this._pillarId = value; }
        }

        // Check to see if PillarId property is set
        internal bool IsSetPillarId()
        {
            return this._pillarId != null;
        }

        /// <summary>
        /// Gets and sets the property QuestionId.
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string QuestionId
        {
            get { return this._questionId; }
            set { this._questionId = value; }
        }

        // Check to see if QuestionId property is set
        internal bool IsSetQuestionId()
        {
            return this._questionId != null;
        }

        /// <summary>
        /// Gets and sets the property QuestionTitle.
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string QuestionTitle
        {
            get { return this._questionTitle; }
            set { this._questionTitle = value; }
        }

        // Check to see if QuestionTitle property is set
        internal bool IsSetQuestionTitle()
        {
            return this._questionTitle != null;
        }

        /// <summary>
        /// Gets and sets the property Risk.
        /// </summary>
        public Risk Risk
        {
            get { return this._risk; }
            set { this._risk = value; }
        }

        // Check to see if Risk property is set
        internal bool IsSetRisk()
        {
            return this._risk != null;
        }

    }
}