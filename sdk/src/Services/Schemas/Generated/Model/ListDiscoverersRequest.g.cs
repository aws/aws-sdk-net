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

namespace Amazon.Schemas.Model
{
    /// <summary>
    /// Container for the parameters to the ListDiscoverers operation. List the discoverers.
    /// </summary>
    public partial class ListDiscoverersRequest : AmazonSchemasRequest
    {
        /// <summary>
        /// Gets and sets the property DiscovererIdPrefix. 
        /// <para>
        /// Specifying this limits the results to only those discoverer IDs that start with the
        /// specified prefix.
        /// </para>
        /// </summary>
        public string DiscovererIdPrefix { get; set; }

        /// <summary>
        /// Checks to see if the DiscovererIdPrefix property is set.
        /// </summary>
        internal bool IsSetDiscovererIdPrefix() => this.DiscovererIdPrefix != null;

        /// <summary>
        /// Gets and sets the property Limit.
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token that specifies the next page of results to return. To request the first
        /// page, leave NextToken empty. The token will expire in 24 hours, and cannot be shared
        /// with other accounts.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SourceArnPrefix. 
        /// <para>
        /// Specifying this limits the results to only those ARNs that start with the specified
        /// prefix.
        /// </para>
        /// </summary>
        public string SourceArnPrefix { get; set; }

        /// <summary>
        /// Checks to see if the SourceArnPrefix property is set.
        /// </summary>
        internal bool IsSetSourceArnPrefix() => this.SourceArnPrefix != null;
    }
}
