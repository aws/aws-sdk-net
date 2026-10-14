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

namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeCustomDomains operation. Return a description
    /// of custom domain names that are associated with an App Runner service.
    /// </summary>
    public partial class DescribeCustomDomainsRequest : AmazonAppRunnerRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results that each response (result page) can include. It's used
        /// for a paginated request.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify <c>MaxResults</c>, the request retrieves all available results
        /// in a single response.
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
        /// A token from a previous result page. It's used for a paginated request. The request
        /// retrieves the next result page. All other parameter values must be identical to the
        /// ones that are specified in the initial request.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify <c>NextToken</c>, the request retrieves the first result page.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 51200)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ServiceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the App Runner service that you want associated
        /// custom domain names to be described for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string ServiceArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceArn property is set.
        /// </summary>
        internal bool IsSetServiceArn() => this.ServiceArn != null;
    }
}
