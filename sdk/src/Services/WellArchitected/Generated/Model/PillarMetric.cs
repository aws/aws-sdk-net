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
    /// A metric for a particular pillar in a lens.
    /// </summary>
    public partial class PillarMetric
    {
        private string _pillarId;
        private List<QuestionMetric> _questions = new List<QuestionMetric>();
        private Dictionary<string, int> _riskCounts = new Dictionary<string, int>();

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
        /// Gets and sets the property Questions. 
        /// <para>
        /// The questions that have been identified as risks in the pillar.
        /// </para>
        /// </summary>
        public List<QuestionMetric> Questions
        {
            get { return this._questions; }
            set { this._questions = value; }
        }

        // Check to see if Questions property is set
        internal bool IsSetQuestions()
        {
            return this._questions != null && this._questions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RiskCounts.
        /// </summary>
        public Dictionary<string, int> RiskCounts
        {
            get { return this._riskCounts; }
            set { this._riskCounts = value; }
        }

        // Check to see if RiskCounts property is set
        internal bool IsSetRiskCounts()
        {
            return this._riskCounts != null && this._riskCounts.Count > 0; 
        }

    }
}