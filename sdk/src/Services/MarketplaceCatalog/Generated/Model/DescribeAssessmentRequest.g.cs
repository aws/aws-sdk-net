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
    /// Container for the parameters to the DescribeAssessment operation. Returns the metadata
    /// and detailed results of a single assessment, including the framework that was evaluated,
    /// the overall assessment result, and a paginated list of individual control evaluation
    /// results. <para> To list available assessments before describing one, use the <c>ListAssessments</c>
    /// action. </para>
    /// </summary>
    public partial class DescribeAssessmentRequest : AmazonMarketplaceCatalogRequest
    {
        /// <summary>
        /// Gets and sets the property AssessmentIdentifier. 
        /// <para>
        /// The unique identifier of the assessment to describe. You can provide either the assessment
        /// ID (for example, <c>assessment-12345</c>) or the full assessment ARN (for example,
        /// <c>arn:aws:aws-marketplace:us-east-1::AWSMarketplace/Assessment/assessment-12345</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string AssessmentIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentIdentifier property is set.
        /// </summary>
        internal bool IsSetAssessmentIdentifier() => this.AssessmentIdentifier != null;

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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specifies the upper limit of <c>ControlAssessment</c> elements returned on a single
        /// page. If a value isn't provided, the default value is 50. Valid values range from
        /// 1 to 100.
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
