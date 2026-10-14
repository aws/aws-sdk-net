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

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// Container for the parameters to the ListAssessmentRuns operation. Lists the assessment
    /// runs that correspond to the assessment templates that are specified by the ARNs of
    /// the assessment templates.
    /// </summary>
    public partial class ListAssessmentRunsRequest : AmazonInspectorRequest
    {
        /// <summary>
        /// Gets and sets the property AssessmentTemplateArns. 
        /// <para>
        /// The ARNs that specify the assessment templates whose assessment runs you want to list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> AssessmentTemplateArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AssessmentTemplateArns property is set.
        /// </summary>
        internal bool IsSetAssessmentTemplateArns() => this.AssessmentTemplateArns != null && (this.AssessmentTemplateArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// You can use this parameter to specify a subset of data to be included in the action's
        /// response.
        /// </para>
        ///  
        /// <para>
        /// For a record to match a filter, all specified filter attributes must match. When multiple
        /// values are specified for a filter attribute, any of the values can match.
        /// </para>
        /// </summary>
        public AssessmentRunFilter Filter { get; set; }

        /// <summary>
        /// Checks to see if the Filter property is set.
        /// </summary>
        internal bool IsSetFilter() => this.Filter != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// You can use this parameter to indicate the maximum number of items that you want in
        /// the response. The default value is 10. The maximum value is 500.
        /// </para>
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// You can use this parameter when paginating results. Set the value of this parameter
        /// to null on your first call to the <b>ListAssessmentRuns</b> action. Subsequent calls
        /// to the action fill <b>nextToken</b> in the request with the value of <b>NextToken</b>
        /// from the previous response to continue listing data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
