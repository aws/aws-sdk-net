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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
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
namespace Amazon.MailManager.Model
{
    /// <summary>
    /// Container for the parameters to the ListMembersOfAddressList operation.
    /// Lists members of an address list.
    /// </summary>
    public partial class ListMembersOfAddressListRequest : AmazonMailManagerRequest
    {
        private string _addressListId;
        private AddressFilter _filter;
        private string _nextToken;
        private int? _pageSize;

        /// <summary>
        /// Gets and sets the property AddressListId. 
        /// <para>
        /// The unique identifier of the address list to list the addresses from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string AddressListId
        {
            get { return this._addressListId; }
            set { this._addressListId = value; }
        }

        // Check to see if AddressListId property is set
        internal bool IsSetAddressListId()
        {
            return this._addressListId != null;
        }

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// Filter to be used to limit the results.
        /// </para>
        /// </summary>
        public AddressFilter Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If you received a pagination token from a previous call to this API, you can provide
        /// it here to continue paginating through the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        /// The maximum number of address list members that are returned per call. You can use
        /// NextToken to retrieve the next page of members.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? PageSize
        {
            get { return this._pageSize; }
            set { this._pageSize = value; }
        }

        // Check to see if PageSize property is set
        internal bool IsSetPageSize()
        {
            return this._pageSize.HasValue; 
        }

    }
}