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
    /// A metric for a particular question in the pillar.
    /// </summary>
    public partial class QuestionMetric
    {
        private List<BestPractice> _bestPractices = new List<BestPractice>();
        private string _questionId;
        private Risk _risk;

        /// <summary>
        /// Gets and sets the property BestPractices. 
        /// <para>
        /// The best practices, or choices, that have been identified as contributing to risk
        /// in a question.
        /// </para>
        /// </summary>
        public List<BestPractice> BestPractices
        {
            get { return this._bestPractices; }
            set { this._bestPractices = value; }
        }

        // Check to see if BestPractices property is set
        internal bool IsSetBestPractices()
        {
            return this._bestPractices != null && this._bestPractices.Count > 0; 
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