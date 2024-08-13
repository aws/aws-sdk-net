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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Container for the parameters to the ListContacts operation.
    /// Lists the contacts present in a specific contact list.
    /// </summary>
    public partial class ListContactsRequest : AmazonSimpleEmailServiceV2Request
    {
        private string _contactListName;
        private ListContactsFilter _filter;
        private string _nextToken;
        private int? _pageSize;

        /// <summary>
        /// Gets and sets the property ContactListName. 
        /// <para>
        /// The name of the contact list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ContactListName
        {
            get { return this._contactListName; }
            set { this._contactListName = value; }
        }

        // Check to see if ContactListName property is set
        internal bool IsSetContactListName()
        {
            return this._contactListName != null;
        }

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// A filter that can be applied to a list of contacts.
        /// </para>
        /// </summary>
        public ListContactsFilter Filter
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
        /// A string token indicating that there might be additional contacts available to be
        /// listed. Use the token provided in the Response to use in the subsequent call to ListContacts
        /// with the same parameters to retrieve the next page of contacts.
        /// </para>
        /// </summary>
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
        /// The number of contacts that may be returned at once, which is dependent on if there
        /// are more or less contacts than the value of the PageSize. Use this parameter to paginate
        /// results. If additional contacts exist beyond the specified limit, the <c>NextToken</c>
        /// element is sent in the response. Use the <c>NextToken</c> value in subsequent requests
        /// to retrieve additional contacts.
        /// </para>
        /// </summary>
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