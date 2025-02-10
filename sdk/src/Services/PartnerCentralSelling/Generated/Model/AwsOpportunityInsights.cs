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
    /// Contains insights provided by AWS for the opportunity, offering recommendations and
    /// analysis that can help the partner optimize their engagement and strategy.
    /// </summary>
    public partial class AwsOpportunityInsights
    {
        private EngagementScore _engagementScore;
        private string _nextBestActions;

        /// <summary>
        /// Gets and sets the property EngagementScore. 
        /// <para>
        /// Represents a score assigned by AWS to indicate the level of engagement and potential
        /// success for the opportunity. This score helps partners prioritize their efforts.
        /// </para>
        /// </summary>
        public EngagementScore EngagementScore
        {
            get { return this._engagementScore; }
            set { this._engagementScore = value; }
        }

        // Check to see if EngagementScore property is set
        internal bool IsSetEngagementScore()
        {
            return this._engagementScore != null;
        }

        /// <summary>
        /// Gets and sets the property NextBestActions. 
        /// <para>
        /// Provides recommendations from AWS on the next best actions to take in order to move
        /// the opportunity forward and increase the likelihood of success.
        /// </para>
        /// </summary>
        public string NextBestActions
        {
            get { return this._nextBestActions; }
            set { this._nextBestActions = value; }
        }

        // Check to see if NextBestActions property is set
        internal bool IsSetNextBestActions()
        {
            return this._nextBestActions != null;
        }

    }
}