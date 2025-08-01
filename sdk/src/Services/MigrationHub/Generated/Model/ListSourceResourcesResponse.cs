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
 * Do not modify this file. This file is generated from the AWSMigrationHub-2017-05-31.normal.json service model.
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
namespace Amazon.MigrationHub.Model
{
    /// <summary>
    /// This is the response object from the ListSourceResources operation.
    /// </summary>
    public partial class ListSourceResourcesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<SourceResource> _sourceResourceList = AWSConfigs.InitializeCollections ? new List<SourceResource>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response includes a <c>NextToken</c> value, that means that there are more
        /// results available. The value of <c>NextToken</c> is a unique pagination token for
        /// each page. To retrieve the next page of results, call this API again and specify this
        /// <c>NextToken</c> value in the request. Keep all other arguments unchanged. Each pagination
        /// token expires after 24 hours. Using an expired pagination token will return an HTTP
        /// 400 InvalidToken error.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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
        /// Gets and sets the property SourceResourceList. 
        /// <para>
        /// The list of source resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SourceResource> SourceResourceList
        {
            get { return this._sourceResourceList; }
            set { this._sourceResourceList = value; }
        }

        // Check to see if SourceResourceList property is set
        internal bool IsSetSourceResourceList()
        {
            return this._sourceResourceList != null && (this._sourceResourceList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}