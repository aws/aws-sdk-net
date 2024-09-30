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
    /// Container for the parameters to the ListGroupsForMember operation.
    /// Returns group information for the specified member. 
    /// 
    ///  
    /// <para>
    ///  This operation supports pagination with the use of the <c>NextToken</c> request and
    /// response parameters. If more results are available, the <c>ListGroupsForMember.NextToken</c>
    /// member contains a token that you pass in the next call to <c>ListGroupsForMember</c>.
    /// This retrieves the next set of items. 
    /// </para>
    ///  
    /// <para>
    ///  You can also specify a maximum number of return results with the <c>MaxResults</c>
    /// parameter. 
    /// </para>
    /// </summary>
    public partial class ListGroupsForMemberRequest : AmazonDirectoryServiceDataRequest
    {
        private string _directoryId;
        private int? _maxResults;
        private string _memberRealm;
        private string _nextToken;
        private string _realm;
        private string _samAccountName;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        ///  The identifier (ID) of the directory that's associated with the member. 
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
        /// Gets and sets the property MemberRealm. 
        /// <para>
        ///  The domain name that's associated with the group member. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  This parameter is optional, so you can limit your results to the group members in
        /// a specific domain. 
        /// </para>
        ///  
        /// <para>
        ///  This parameter is case insensitive and defaults to <c>Realm</c> 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string MemberRealm
        {
            get { return this._memberRealm; }
            set { this._memberRealm = value; }
        }

        // Check to see if MemberRealm property is set
        internal bool IsSetMemberRealm()
        {
            return this._memberRealm != null;
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
        ///  The domain name that's associated with the group. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  This parameter is optional, so you can return groups outside of your Managed Microsoft
        /// AD domain. When no value is defined, only your Managed Microsoft AD groups are returned.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  This value is case insensitive and defaults to your Managed Microsoft AD domain.
        /// 
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

        /// <summary>
        /// Gets and sets the property SAMAccountName. 
        /// <para>
        ///  The <c>SAMAccountName</c> of the user, group, or computer that's a member of the
        /// group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string SAMAccountName
        {
            get { return this._samAccountName; }
            set { this._samAccountName = value; }
        }

        // Check to see if SAMAccountName property is set
        internal bool IsSetSAMAccountName()
        {
            return this._samAccountName != null;
        }

    }
}