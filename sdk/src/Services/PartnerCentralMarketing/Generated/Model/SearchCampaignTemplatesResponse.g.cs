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

namespace Amazon.PartnerCentralMarketing.Model
{
    /// <summary>
    /// This is the response object from the SearchCampaignTemplates operation.
    /// </summary>
    public partial class SearchCampaignTemplatesResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CampaignTemplates. This page of template summaries.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Max = 100)]
        public List<CampaignTemplateSummary> CampaignTemplates { get; set; } = AWSConfigs.InitializeCollections ? new List<CampaignTemplateSummary>() : null;

        /// <summary>
        /// Checks to see if the CampaignTemplates property is set.
        /// </summary>
        internal bool IsSetCampaignTemplates() => this.CampaignTemplates != null && (this.CampaignTemplates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. Pagination token.
        /// </summary>
        [AWSProperty(Min = 1, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property TotalResults. Total count over the whole matching set,
        /// not just this page — for "over N results" display.
        /// </summary>
        [AWSProperty(Required = true)]
        public int? TotalResults { get; set; }

        /// <summary>
        /// Checks to see if the TotalResults property is set.
        /// </summary>
        internal bool IsSetTotalResults() => this.TotalResults.HasValue;
    }
}
