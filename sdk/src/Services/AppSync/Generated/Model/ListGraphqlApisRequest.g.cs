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

namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Container for the parameters to the ListGraphqlApis operation. Lists your GraphQL
    /// APIs.
    /// </summary>
    public partial class ListGraphqlApisRequest : AmazonAppSyncRequest
    {
        /// <summary>
        /// Gets and sets the property ApiType. 
        /// <para>
        /// The value that indicates whether the GraphQL API is a standard API (<c>GRAPHQL</c>)
        /// or merged API (<c>MERGED</c>).
        /// </para>
        /// </summary>
        public GraphQLApiType ApiType { get; set; }

        /// <summary>
        /// Checks to see if the ApiType property is set.
        /// </summary>
        internal bool IsSetApiType() => this.ApiType != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results that you want the request to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 25)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An identifier that was returned from the previous call to this operation, which you
        /// can use to return the next set of items in the list.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 65536)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The account owner of the GraphQL API.
        /// </para>
        /// </summary>
        public Ownership Owner { get; set; }

        /// <summary>
        /// Checks to see if the Owner property is set.
        /// </summary>
        internal bool IsSetOwner() => this.Owner != null;
    }
}
