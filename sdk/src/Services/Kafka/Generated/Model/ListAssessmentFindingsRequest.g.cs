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

namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Container for the parameters to the ListAssessmentFindings operation. Returns the
    /// findings for a completed assessment. Paginated.
    /// </summary>
    public partial class ListAssessmentFindingsRequest : AmazonKafkaRequest
    {
        /// <summary>
        /// Gets and sets the property AssessmentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the assessment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AssessmentArn { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentArn property is set.
        /// </summary>
        internal bool IsSetAssessmentArn() => this.AssessmentArn != null;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// Optional filter. Only return findings matching this category.
        /// </para>
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of findings to return. Default 100, maximum 500.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response is truncated, it returns a nextToken. Send this in the subsequent
        /// request to get the remaining results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// Optional filter. Only return findings matching this severity.
        /// </para>
        /// </summary>
        public string Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;
    }
}
