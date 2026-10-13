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
    /// Container for the parameters to the ListAssessmentTargets operation. Lists the ARNs
    /// of the assessment targets within this AWS account. For more information about assessment
    /// targets, see <a href="https://docs.aws.amazon.com/inspector/latest/userguide/inspector_applications.html">Amazon
    /// Inspector Assessment Targets</a>.
    /// </summary>
    public partial class ListAssessmentTargetsRequest : AmazonInspectorRequest
    {
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
        public AssessmentTargetFilter Filter { get; set; }

        /// <summary>
        /// Checks to see if the Filter property is set.
        /// </summary>
        internal bool IsSetFilter() => this.Filter != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// You can use this parameter to indicate the maximum number of items you want in the
        /// response. The default value is 10. The maximum value is 500.
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
        /// to null on your first call to the <b>ListAssessmentTargets</b> action. Subsequent
        /// calls to the action fill <b>nextToken</b> in the request with the value of <b>NextToken</b>
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
