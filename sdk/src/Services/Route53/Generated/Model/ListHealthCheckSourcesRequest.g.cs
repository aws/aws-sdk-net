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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the ListHealthCheckSources operation. Retrieves a
    /// list of the health check sources that are associated with the current Amazon Web Services
    /// account. <para> Results are paginated. To get more results, specify the <c>NextToken</c>
    /// value from the previous response for <c>NextToken</c>. </para>
    /// </summary>
    public partial class ListHealthCheckSourcesRequest : AmazonRoute53Request
    {
        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>NextToken</c> value from the previous response, if it included one. Specify
        /// it to get the next group of health check sources.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of health check sources that you want <c>ListHealthCheckSources</c>
        /// to return. Route 53 returns a maximum of 100 health check sources. If you specify
        /// a value greater than 100, Route 53 returns only the first 100.
        /// </para>
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;
    }
}
