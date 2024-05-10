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
 * Do not modify this file. This file is generated from the migration-hub-refactor-spaces-2021-10-26.normal.json service model.
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
namespace Amazon.MigrationHubRefactorSpaces.Model
{
    /// <summary>
    /// This is the response object from the ListRoutes operation.
    /// </summary>
    public partial class ListRoutesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<RouteSummary> _routeSummaryList = AWSConfigs.InitializeCollections ? new List<RouteSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next page of results.
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
        /// Gets and sets the property RouteSummaryList. 
        /// <para>
        /// The list of <c>RouteSummary</c> objects. 
        /// </para>
        /// </summary>
        public List<RouteSummary> RouteSummaryList
        {
            get { return this._routeSummaryList; }
            set { this._routeSummaryList = value; }
        }

        // Check to see if RouteSummaryList property is set
        internal bool IsSetRouteSummaryList()
        {
            return this._routeSummaryList != null && (this._routeSummaryList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}