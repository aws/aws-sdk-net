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

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Container for the parameters to the ListContextChanges operation. Returns the context
    /// entries that were added to or removed from a context store after the specified version.
    /// The context store must be in the <c>AVAILABLE</c> state.
    /// </summary>
    public partial class ListContextChangesRequest : AmazonNetworkManagerRequest
    {
        /// <summary>
        /// Gets and sets the property ContextStoreId. 
        /// <para>
        /// The ID of the context store.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 50)]
        public string ContextStoreId { get; set; }

        /// <summary>
        /// Checks to see if the ContextStoreId property is set.
        /// </summary>
        internal bool IsSetContextStoreId() => this.ContextStoreId != null;

        /// <summary>
        /// Gets and sets the property FromVersionId. 
        /// <para>
        /// The version to return changes from. Specify a version returned by <c>ListContexts</c>,
        /// <c>GetContextVersion</c>, or the <c>ToVersionId</c> of a previous <c>ListContextChanges</c>
        /// request. If the version is no longer available, the request fails, and you must call
        /// <c>ListContexts</c> to get the current context entries.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string FromVersionId { get; set; }

        /// <summary>
        /// Checks to see if the FromVersionId property is set.
        /// </summary>
        internal bool IsSetFromVersionId() => this.FromVersionId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return.
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
        /// The token for the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
