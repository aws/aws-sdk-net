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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// This is the response object from the ListEngagementMembers operation.
    /// </summary>
    public partial class ListEngagementMembersResponse : AmazonWebServiceResponse
    {
        private List<EngagementMember> _engagementMemberList = AWSConfigs.InitializeCollections ? new List<EngagementMember>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property EngagementMemberList. 
        /// <para>
        ///  Provides a list of engagement members. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<EngagementMember> EngagementMemberList
        {
            get { return this._engagementMemberList; }
            set { this._engagementMemberList = value; }
        }

        // Check to see if EngagementMemberList property is set
        internal bool IsSetEngagementMemberList()
        {
            return this._engagementMemberList != null && (this._engagementMemberList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token used to retrieve the next set of results. If there are more results
        /// available than can be returned in a single response, this token will be present. Use
        /// this token in a subsequent request to retrieve the next page of results. If there
        /// are no more results, this value will be null. 
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

    }
}