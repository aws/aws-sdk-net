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
 * Do not modify this file. This file is generated from the directory-service-data-2023-05-31.normal.json service model.
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
namespace Amazon.DirectoryServiceData.Model
{
    /// <summary>
    /// Container for the parameters to the ListUsers operation.
    /// Returns user information for the specified directory. 
    /// 
    ///  
    /// <para>
    ///  This operation supports pagination with the use of the <c>NextToken</c> request and
    /// response parameters. If more results are available, the <c>ListUsers.NextToken</c>
    /// member contains a token that you pass in the next call to <c>ListUsers</c>. This retrieves
    /// the next set of items. 
    /// </para>
    ///  
    /// <para>
    ///  You can also specify a maximum number of return results with the <c>MaxResults</c>
    /// parameter. 
    /// </para>
    /// </summary>
    public partial class ListUsersRequest : AmazonDirectoryServiceDataRequest
    {
        private string _directoryId;
        private int? _maxResults;
        private string _nextToken;
        private string _realm;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        ///  The identifier (ID) of the directory that's associated with the user. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of results to be returned per request. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  An encoded paging token for paginated calls that can be passed back to retrieve the
        /// next page. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=6144)]
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
        /// Gets and sets the property Realm. 
        /// <para>
        ///  The domain name that's associated with the user. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  This parameter is optional, so you can return users outside of your Managed Microsoft
        /// AD domain. When no value is defined, only your Managed Microsoft AD users are returned.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  This value is case insensitive. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Realm
        {
            get { return this._realm; }
            set { this._realm = value; }
        }

        // Check to see if Realm property is set
        internal bool IsSetRealm()
        {
            return this._realm != null;
        }

    }
}