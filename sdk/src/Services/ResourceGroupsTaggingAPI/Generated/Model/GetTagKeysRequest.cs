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
 * Do not modify this file. This file is generated from the resourcegroupstaggingapi-2017-01-26.normal.json service model.
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
namespace Amazon.ResourceGroupsTaggingAPI.Model
{
    /// <summary>
    /// Container for the parameters to the GetTagKeys operation.
    /// Returns all tag keys currently in use in the specified Amazon Web Services Region
    /// for the calling account.
    /// 
    ///  
    /// <para>
    /// This operation supports pagination, where the response can be sent in multiple pages.
    /// You should check the <c>PaginationToken</c> response parameter to determine if there
    /// are additional results available to return. Repeat the query, passing the <c>PaginationToken</c>
    /// response parameter value as an input to the next request until you recieve a <c>null</c>
    /// value. A null value for <c>PaginationToken</c> indicates that there are no more results
    /// waiting to be returned.
    /// </para>
    /// </summary>
    public partial class GetTagKeysRequest : AmazonResourceGroupsTaggingAPIRequest
    {
        private string _paginationToken;

        /// <summary>
        /// Gets and sets the property PaginationToken. 
        /// <para>
        /// Specifies a <c>PaginationToken</c> response value from a previous request to indicate
        /// that you want the next page of results. Leave this parameter empty in your initial
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string PaginationToken
        {
            get { return this._paginationToken; }
            set { this._paginationToken = value; }
        }

        // Check to see if PaginationToken property is set
        internal bool IsSetPaginationToken()
        {
            return this._paginationToken != null;
        }

    }
}