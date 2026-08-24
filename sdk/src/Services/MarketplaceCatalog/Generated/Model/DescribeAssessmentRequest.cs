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
 * Do not modify this file. This file is generated from the marketplace-catalog-2018-09-17.normal.json service model.
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
    /// Container for the parameters to the DescribeAssessment operation.
    /// Returns the metadata and detailed results of a single assessment, including the framework
    /// that was evaluated, the overall assessment result, and a paginated list of individual
    /// control evaluation results.
    /// 
    ///  
    /// <para>
    /// To list available assessments before describing one, use the <c>ListAssessments</c>
    /// action.
    /// </para>
    /// </summary>
    public partial class DescribeAssessmentRequest : AmazonMarketplaceCatalogRequest
    {
        private string _assessmentIdentifier;
        private string _catalog;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AssessmentIdentifier. 
        /// <para>
        /// The unique identifier of the assessment to describe. You can provide either the assessment
        /// ID (for example, <c>assessment-12345</c>) or the full assessment ARN (for example,
        /// <c>arn:aws:aws-marketplace:us-east-1::AWSMarketplace/Assessment/assessment-12345</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string AssessmentIdentifier
        {
            get { return this._assessmentIdentifier; }
            set { this._assessmentIdentifier = value; }
        }

        // Check to see if AssessmentIdentifier property is set
        internal bool IsSetAssessmentIdentifier()
        {
            return this._assessmentIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The catalog related to the request. Fixed value: <c>AWSMarketplace</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Catalog
        {
            get { return this._catalog; }
            set { this._catalog = value; }
        }

        // Check to see if Catalog property is set
        internal bool IsSetCatalog()
        {
            return this._catalog != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specifies the upper limit of <c>ControlAssessment</c> elements returned on a single
        /// page. If a value isn't provided, the default value is 50. Valid values range from
        /// 1 to 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The value of the next token, if it exists. <c>null</c> if there are no more results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}