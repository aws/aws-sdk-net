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
    /// This is the response object from the ListGroupsForMember operation.
    /// </summary>
    public partial class ListGroupsForMemberResponse : AmazonWebServiceResponse
    {
        private string _directoryId;
        private List<GroupSummary> _groups = AWSConfigs.InitializeCollections ? new List<GroupSummary>() : null;
        private string _memberRealm;
        private string _nextToken;
        private string _realm;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        ///  The identifier (ID) of the directory that's associated with the member. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Groups. 
        /// <para>
        ///  The group information that the request returns. 
        /// </para>
        /// </summary>
        public List<GroupSummary> Groups
        {
            get { return this._groups; }
            set { this._groups = value; }
        }

        // Check to see if Groups property is set
        internal bool IsSetGroups()
        {
            return this._groups != null && (this._groups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MemberRealm. 
        /// <para>
        ///  The domain that's associated with the member. 
        /// </para>
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
        ///  The domain that's associated with the group. 
        /// </para>
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