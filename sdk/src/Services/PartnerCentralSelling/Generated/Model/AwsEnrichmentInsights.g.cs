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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Values that we compute about the matched customer, such as the marketplace engagement
    /// score and the solution propensity. These differ from the recorded facts in <c>Customer</c>.
    /// </summary>
    public partial class AwsEnrichmentInsights
    {
        /// <summary>
        /// Gets and sets the property MarketplaceEngagementScore. 
        /// <para>
        /// The level of engagement of the customer with AWS Marketplace. Valid values are <c>High</c>,
        /// <c>Medium</c>, and <c>Low</c>.
        /// </para>
        /// </summary>
        public string MarketplaceEngagementScore { get; set; }

        /// <summary>
        /// Checks to see if the MarketplaceEngagementScore property is set.
        /// </summary>
        internal bool IsSetMarketplaceEngagementScore() => this.MarketplaceEngagementScore != null;

        /// <summary>
        /// Gets and sets the property SolutionCategory. 
        /// <para>
        /// The category of the solution that AWS recommends for the customer.
        /// </para>
        /// </summary>
        public string SolutionCategory { get; set; }

        /// <summary>
        /// Checks to see if the SolutionCategory property is set.
        /// </summary>
        internal bool IsSetSolutionCategory() => this.SolutionCategory != null;

        /// <summary>
        /// Gets and sets the property SolutionScore. 
        /// <para>
        /// The likelihood that the customer adopts the recommended solution. Valid values are
        /// <c>High</c>, <c>Medium</c>, and <c>Low</c>.
        /// </para>
        /// </summary>
        public string SolutionScore { get; set; }

        /// <summary>
        /// Checks to see if the SolutionScore property is set.
        /// </summary>
        internal bool IsSetSolutionScore() => this.SolutionScore != null;

        /// <summary>
        /// Gets and sets the property SolutionSubCategory. 
        /// <para>
        /// The sub-category of the solution that AWS recommends for the customer.
        /// </para>
        /// </summary>
        public string SolutionSubCategory { get; set; }

        /// <summary>
        /// Checks to see if the SolutionSubCategory property is set.
        /// </summary>
        internal bool IsSetSolutionSubCategory() => this.SolutionSubCategory != null;
    }
}
