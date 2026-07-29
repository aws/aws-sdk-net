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
    /// Contains insights that AI generates from the prospecting analysis. These insights
    /// include marketplace engagement scoring, solution fit assessments, and solution categorization
    /// for the prospected customer.
    /// </summary>
    public partial class ProspectingInsights
    {
        private string _marketplaceEngagementScore;
        private string _solutionCategory;
        private string _solutionScore;
        private string _solutionSubCategory;

        /// <summary>
        /// Gets and sets the property MarketplaceEngagementScore. 
        /// <para>
        /// A score that indicates the prospected customer's level of engagement with AWS Marketplace.
        /// Valid values are <c>High</c>, <c>Medium</c>, and <c>Low</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string MarketplaceEngagementScore
        {
            get { return this._marketplaceEngagementScore; }
            set { this._marketplaceEngagementScore = value; }
        }

        // Check to see if MarketplaceEngagementScore property is set
        internal bool IsSetMarketplaceEngagementScore()
        {
            return this._marketplaceEngagementScore != null;
        }

        /// <summary>
        /// Gets and sets the property SolutionCategory. 
        /// <para>
        /// The primary solution category classification for the prospected customer. This indicates
        /// the type of solution that best addresses their needs.
        /// </para>
        /// </summary>
        public string SolutionCategory
        {
            get { return this._solutionCategory; }
            set { this._solutionCategory = value; }
        }

        // Check to see if SolutionCategory property is set
        internal bool IsSetSolutionCategory()
        {
            return this._solutionCategory != null;
        }

        /// <summary>
        /// Gets and sets the property SolutionScore. 
        /// <para>
        /// A score that indicates how well the partner's solution fits the prospected customer's
        /// needs.
        /// </para>
        /// </summary>
        public string SolutionScore
        {
            get { return this._solutionScore; }
            set { this._solutionScore = value; }
        }

        // Check to see if SolutionScore property is set
        internal bool IsSetSolutionScore()
        {
            return this._solutionScore != null;
        }

        /// <summary>
        /// Gets and sets the property SolutionSubCategory. 
        /// <para>
        /// The solution sub-category classification for the prospected customer. This provides
        /// more granular categorization of the recommended solution type.
        /// </para>
        /// </summary>
        public string SolutionSubCategory
        {
            get { return this._solutionSubCategory; }
            set { this._solutionSubCategory = value; }
        }

        // Check to see if SolutionSubCategory property is set
        internal bool IsSetSolutionSubCategory()
        {
            return this._solutionSubCategory != null;
        }

    }
}