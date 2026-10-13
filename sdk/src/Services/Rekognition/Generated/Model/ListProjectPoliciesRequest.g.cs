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

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the ListProjectPolicies operation. <note> <para> This
    /// operation applies only to Amazon Rekognition Custom Labels. </para> </note> <para>
    /// Gets a list of the project policies attached to a project. </para> <para> To attach
    /// a project policy to a project, call <a>PutProjectPolicy</a>. To remove a project policy
    /// from a project, call <a>DeleteProjectPolicy</a>. </para> <para> This operation requires
    /// permissions to perform the <c>rekognition:ListProjectPolicies</c> action. </para>
    /// </summary>
    public partial class ListProjectPoliciesRequest : AmazonRekognitionRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per paginated call. The largest value you
        /// can specify is 5. If you specify a value greater than 5, a ValidationException error
        /// occurs. The default value is 5. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the previous response was incomplete (because there is more results to retrieve),
        /// Amazon Rekognition Custom Labels returns a pagination token in the response. You can
        /// use this pagination token to retrieve the next set of results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ProjectArn. 
        /// <para>
        /// The ARN of the project for which you want to list the project policies.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string ProjectArn { get; set; }

        /// <summary>
        /// Checks to see if the ProjectArn property is set.
        /// </summary>
        internal bool IsSetProjectArn() => this.ProjectArn != null;
    }
}
