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

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// This is the response object from the GetSavingsPlansPurchaseRecommendation operation.
    /// </summary>
    public partial class GetSavingsPlansPurchaseRecommendationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Information that regards this specific recommendation set.
        /// </para>
        /// </summary>
        public SavingsPlansPurchaseRecommendationMetadata Metadata { get; set; }

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null;

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The token for the next set of retrievable results. Amazon Web Services provides the
        /// token when the response from a previous call has more results than the maximum page
        /// size.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// Checks to see if the NextPageToken property is set.
        /// </summary>
        internal bool IsSetNextPageToken() => this.NextPageToken != null;

        /// <summary>
        /// Gets and sets the property SavingsPlansPurchaseRecommendation. 
        /// <para>
        /// Contains your request parameters, Savings Plan Recommendations Summary, and Details.
        /// </para>
        /// </summary>
        public SavingsPlansPurchaseRecommendation SavingsPlansPurchaseRecommendation { get; set; }

        /// <summary>
        /// Checks to see if the SavingsPlansPurchaseRecommendation property is set.
        /// </summary>
        internal bool IsSetSavingsPlansPurchaseRecommendation() => this.SavingsPlansPurchaseRecommendation != null;
    }
}
