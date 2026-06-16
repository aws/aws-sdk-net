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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Contains insights that AI generates for a lead. These insights provide automated analysis
    /// to help partners evaluate the lead quality and prioritize engagement efforts.
    /// </summary>
    public partial class LeadInsights
    {
        private string _leadReadinessScore;

        /// <summary>
        /// Gets and sets the property LeadReadinessScore. 
        /// <para>
        /// A score that indicates the lead's readiness for engagement. Valid values are <c>Low</c>,
        /// <c>Medium</c>, and <c>High</c>. Use this score to prioritize leads based on their
        /// likelihood of conversion.
        /// </para>
        /// </summary>
        public string LeadReadinessScore
        {
            get { return this._leadReadinessScore; }
            set { this._leadReadinessScore = value; }
        }

        // Check to see if LeadReadinessScore property is set
        internal bool IsSetLeadReadinessScore()
        {
            return this._leadReadinessScore != null;
        }

    }
}