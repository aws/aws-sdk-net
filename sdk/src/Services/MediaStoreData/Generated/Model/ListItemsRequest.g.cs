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

namespace Amazon.MediaStoreData.Model
{
    /// <summary>
    /// Container for the parameters to the ListItems operation. Provides a list of metadata
    /// entries about folders and objects in the specified folder.
    /// </summary>
    public partial class ListItemsRequest : AmazonMediaStoreDataRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per API request. For example, you submit a
        /// <c>ListItems</c> request with <c>MaxResults</c> set at 500. Although 2,000 items match
        /// your request, the service returns no more than the first 500 items. (The service also
        /// returns a <c>NextToken</c> value that you can use to fetch the next batch of results.)
        /// The service might return fewer results than the <c>MaxResults</c> value.
        /// </para>
        ///  
        /// <para>
        /// If <c>MaxResults</c> is not included in the request, the service defaults to pagination
        /// with a maximum of 1,000 results per page.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token that identifies which batch of results that you want to see. For example,
        /// you submit a <c>ListItems</c> request with <c>MaxResults</c> set at 500. The service
        /// returns the first batch of results (up to 500) and a <c>NextToken</c> value. To see
        /// the next batch of results, you can submit the <c>ListItems</c> request a second time
        /// and specify the <c>NextToken</c> value.
        /// </para>
        ///  
        /// <para>
        /// Tokens expire after 15 minutes.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path in the container from which to retrieve items. Format: &lt;folder name&gt;/&lt;folder
        /// name&gt;/&lt;file name&gt;
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 900)]
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;
    }
}
