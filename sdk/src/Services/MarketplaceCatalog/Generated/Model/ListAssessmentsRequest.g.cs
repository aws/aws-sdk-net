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

namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// Container for the parameters to the ListAssessments operation. Returns a paginated
    /// list of assessments associated with an entity or change set in AWS Marketplace. An
    /// <i>assessment</i> is the result of evaluating a product or change set against a framework,
    /// such as AMI Security or Container Security. <para> Use the <c>AssessmentTargetFilter</c>
    /// to scope results to a specific entity or change set, and use <c>FrameworkFilters</c>
    /// to scope results to a single framework. To retrieve detailed control-level results
    /// for an individual assessment, use the <c>DescribeAssessment</c> action. </para> <para>
    /// Results are sorted by assessment creation time in descending order. </para>
    /// </summary>
    public partial class ListAssessmentsRequest : AmazonMarketplaceCatalogRequest
    {
        /// <summary>
        /// Gets and sets the property AssessmentTargetFilter. 
        /// <para>
        /// Filters the list of assessments to those performed against a specific entity or change
        /// set.
        /// </para>
        /// </summary>
        public AssessmentTargetFilter AssessmentTargetFilter { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentTargetFilter property is set.
        /// </summary>
        internal bool IsSetAssessmentTargetFilter() => this.AssessmentTargetFilter != null;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog related to the request. Fixed value: <c>AWSMarketplace</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property FrameworkFilters. 
        /// <para>
        /// Framework-specific filters. Set exactly one member to filter results to assessments
        /// performed against that framework.
        /// </para>
        /// </summary>
        public FrameworkFilters FrameworkFilters { get; set; }

        /// <summary>
        /// Checks to see if the FrameworkFilters property is set.
        /// </summary>
        internal bool IsSetFrameworkFilters() => this.FrameworkFilters != null;

        /// <summary>
        /// Gets and sets the property FrameworkId. 
        /// <para>
        /// The unique identifier of a framework. When specified, only assessments performed against
        /// this framework are returned. For example, <c>AMISecurity</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string FrameworkId { get; set; }

        /// <summary>
        /// Checks to see if the FrameworkId property is set.
        /// </summary>
        internal bool IsSetFrameworkId() => this.FrameworkId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specifies the upper limit of the elements on a single page. If a value isn't provided,
        /// the default value is 20. Valid values range from 1 to 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The value of the next token, if it exists. <c>null</c> if there are no more results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
