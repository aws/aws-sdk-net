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

namespace Amazon.Omics.Model
{
    /// <summary>
    /// Container for the parameters to the ListShares operation. Retrieves the resource shares
    /// associated with an account. Use the filter parameter to retrieve a specific subset
    /// of the shares.
    /// </summary>
    public partial class ListSharesRequest : AmazonOmicsRequest
    {
        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// Attributes that you use to filter for a specific subset of resource shares.
        /// </para>
        /// </summary>
        public Filter Filter { get; set; }

        /// <summary>
        /// Checks to see if the Filter property is set.
        /// </summary>
        internal bool IsSetFilter() => this.Filter != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of shares to return in one page of results.
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
        /// Next token returned in the response of a previous ListReadSetUploadPartsRequest call.
        /// Used to get the next page of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ResourceOwner. 
        /// <para>
        /// The account that owns the resource shares.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceOwner ResourceOwner { get; set; }

        /// <summary>
        /// Checks to see if the ResourceOwner property is set.
        /// </summary>
        internal bool IsSetResourceOwner() => this.ResourceOwner != null;
    }
}
