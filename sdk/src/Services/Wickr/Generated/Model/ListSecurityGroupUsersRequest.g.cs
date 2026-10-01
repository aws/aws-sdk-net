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

namespace Amazon.Wickr.Model
{
    /// <summary>
    /// Container for the parameters to the ListSecurityGroupUsers operation. Retrieves a
    /// paginated list of users who belong to a specific security group in a Wickr network.
    /// </summary>
    public partial class ListSecurityGroupUsersRequest : AmazonWickrRequest
    {
        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The unique identifier of the security group whose users will be listed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string GroupId { get; set; }

        /// <summary>
        /// Checks to see if the GroupId property is set.
        /// </summary>
        internal bool IsSetGroupId() => this.GroupId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of users to return in a single page. Valid range is 1-100. Default
        /// is 10.
        /// </para>
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NetworkId. 
        /// <para>
        /// The ID of the Wickr network containing the security group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 8, Max = 8)]
        public string NetworkId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkId property is set.
        /// </summary>
        internal bool IsSetNetworkId() => this.NetworkId != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for retrieving the next page of results. This is returned from a previous
        /// request when there are more results available.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SortDirection. 
        /// <para>
        /// The direction to sort results. Valid values are 'ASC' (ascending) or 'DESC' (descending).
        /// Default is 'DESC'.
        /// </para>
        /// </summary>
        public SortDirection SortDirection { get; set; }

        /// <summary>
        /// Checks to see if the SortDirection property is set.
        /// </summary>
        internal bool IsSetSortDirection() => this.SortDirection != null;

        /// <summary>
        /// Gets and sets the property SortFields. 
        /// <para>
        /// The field to sort users by. Multiple fields can be specified by separating them with
        /// '+'. Accepted values include 'username', 'firstName', and 'lastName'.
        /// </para>
        /// </summary>
        public string SortFields { get; set; }

        /// <summary>
        /// Checks to see if the SortFields property is set.
        /// </summary>
        internal bool IsSetSortFields() => this.SortFields != null;
    }
}
