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
 * Do not modify this file. This file is generated from the identitystore-2020-06-15.normal.json service model.
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
namespace Amazon.IdentityStore.Model
{
    /// <summary>
    /// This is the response object from the ListGroupMemberships operation.
    /// </summary>
    public partial class ListGroupMembershipsResponse : AmazonWebServiceResponse
    {
        private List<GroupMembership> _groupMemberships = AWSConfigs.InitializeCollections ? new List<GroupMembership>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property GroupMemberships. 
        /// <para>
        /// A list of <c>GroupMembership</c> objects in the group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<GroupMembership> GroupMemberships
        {
            get { return this._groupMemberships; }
            set { this._groupMemberships = value; }
        }

        // Check to see if GroupMemberships property is set
        internal bool IsSetGroupMemberships()
        {
            return this._groupMemberships != null && (this._groupMemberships.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token used for the <c>ListUsers</c>, <c>ListGroups</c>, and <c>ListGroupMemberships</c>
        /// API operations. This value is generated by the identity store service. It is returned
        /// in the API response if the total results are more than the size of one page. This
        /// token is also returned when it is used in the API request to search for the next page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
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

    }
}