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

namespace Amazon.Textract.Model
{
    /// <summary>
    /// Container for the parameters to the ListProjects operation. Lists the projects that
    /// are available to the caller, with optional filtering by blueprint. The results are
    /// paginated. If the response includes a <c>NextToken</c> value, pass it in a subsequent
    /// call to retrieve the next page of results.
    /// </summary>
    public partial class ListProjectsRequest : AmazonTextractRequest
    {
        /// <summary>
        /// Gets and sets the property BlueprintFilter. 
        /// <para>
        /// A filter that limits the results to projects associated with the specified blueprint.
        /// </para>
        /// </summary>
        public BlueprintFilter BlueprintFilter { get; set; }

        /// <summary>
        /// Checks to see if the BlueprintFilter property is set.
        /// </summary>
        internal bool IsSetBlueprintFilter() => this.BlueprintFilter != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of projects to return in each page of results. If you don't specify
        /// a value, the service selects a default page size. Use the <c>NextToken</c> value in
        /// the response to retrieve any remaining results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token returned from a previous call to <c>ListProjects</c>. Use it to
        /// retrieve the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
