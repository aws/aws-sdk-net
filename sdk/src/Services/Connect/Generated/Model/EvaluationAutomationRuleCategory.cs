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
    /// The Contact Lens category used by evaluation automation.
    /// </summary>
    public partial class EvaluationAutomationRuleCategory
    {
        private string _category;
        private QuestionRuleCategoryAutomationCondition _condition;
        private List<EvaluationTranscriptPointOfInterest> _pointsOfInterest = AWSConfigs.InitializeCollections ? new List<EvaluationTranscriptPointOfInterest>() : null;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// A category label.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null;
        }

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// An automation condition for a Contact Lens category.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public QuestionRuleCategoryAutomationCondition Condition
        {
            get { return this._condition; }
            set { this._condition = value; }
        }

        // Check to see if Condition property is set
        internal bool IsSetCondition()
        {
            return this._condition != null;
        }

        /// <summary>
        /// Gets and sets the property PointsOfInterest. 
        /// <para>
        /// A point of interest in a contact transcript that indicates match of condition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<EvaluationTranscriptPointOfInterest> PointsOfInterest
        {
            get { return this._pointsOfInterest; }
            set { this._pointsOfInterest = value; }
        }

        // Check to see if PointsOfInterest property is set
        internal bool IsSetPointsOfInterest()
        {
            return this._pointsOfInterest != null && (this._pointsOfInterest.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}