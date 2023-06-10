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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// A choice available to answer question.
    /// </summary>
    public partial class Choice
    {
        private List<AdditionalResources> _additionalResources = new List<AdditionalResources>();
        private string _choiceId;
        private string _description;
        private ChoiceContent _helpfulResource;
        private ChoiceContent _improvementPlan;
        private string _title;

        /// <summary>
        /// Gets and sets the property AdditionalResources. 
        /// <para>
        /// The additional resources for a choice in a custom lens.
        /// </para>
        ///  
        /// <para>
        /// A choice can have up to two additional resources: one of type <code>HELPFUL_RESOURCE</code>,
        /// one of type <code>IMPROVEMENT_PLAN</code>, or both.
        /// </para>
        /// </summary>
        public List<AdditionalResources> AdditionalResources
        {
            get { return this._additionalResources; }
            set { this._additionalResources = value; }
        }

        // Check to see if AdditionalResources property is set
        internal bool IsSetAdditionalResources()
        {
            return this._additionalResources != null && this._additionalResources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ChoiceId.
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ChoiceId
        {
            get { return this._choiceId; }
            set { this._choiceId = value; }
        }

        // Check to see if ChoiceId property is set
        internal bool IsSetChoiceId()
        {
            return this._choiceId != null;
        }

        /// <summary>
        /// Gets and sets the property Description.
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property HelpfulResource. 
        /// <para>
        /// The helpful resource (both text and URL) for a particular choice.
        /// </para>
        ///  
        /// <para>
        /// This field only applies to custom lenses. Each choice can have only one helpful resource.
        /// </para>
        /// </summary>
        public ChoiceContent HelpfulResource
        {
            get { return this._helpfulResource; }
            set { this._helpfulResource = value; }
        }

        // Check to see if HelpfulResource property is set
        internal bool IsSetHelpfulResource()
        {
            return this._helpfulResource != null;
        }

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
        public ChoiceContent ImprovementPlan
        {
            get { return this._improvementPlan; }
            set { this._improvementPlan = value; }
        }

        // Check to see if ImprovementPlan property is set
        internal bool IsSetImprovementPlan()
        {
            return this._improvementPlan != null;
        }

        /// <summary>
        /// Gets and sets the property Title.
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}