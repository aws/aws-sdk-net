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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
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
namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// This is the response object from the ListPlatformBranches operation.
    /// </summary>
    public partial class ListPlatformBranchesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<PlatformBranchSummary> _platformBranchSummaryList = AWSConfigs.InitializeCollections ? new List<PlatformBranchSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// In a paginated request, if this value isn't <c>null</c>, it's the token that you can
        /// pass in a subsequent request to get the next response page.
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
        /// Gets and sets the property PlatformBranchSummaryList. 
        /// <para>
        /// Summary information about the platform branches.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PlatformBranchSummary> PlatformBranchSummaryList
        {
            get { return this._platformBranchSummaryList; }
            set { this._platformBranchSummaryList = value; }
        }

        // Check to see if PlatformBranchSummaryList property is set
        internal bool IsSetPlatformBranchSummaryList()
        {
            return this._platformBranchSummaryList != null && (this._platformBranchSummaryList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}