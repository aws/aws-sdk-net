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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
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
namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// This is the response object from the ListSharedProjects operation.
    /// </summary>
    public partial class ListSharedProjectsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<string> _projects = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  During a previous call, the maximum number of items that can be returned is the value
        /// specified in <c>maxResults</c>. If there more items in the list, then a unique string
        /// called a <i>nextToken</i> is returned. To get the next batch of items in the list,
        /// call this operation again, adding the next token to the call. To get all of the items
        /// in the list, keep calling this operation with each subsequent next token that is returned,
        /// until no more next tokens are returned. 
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
        /// Gets and sets the property Projects. 
        /// <para>
        ///  The list of ARNs for the build projects shared with the current Amazon Web Services
        /// account or user. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> Projects
        {
            get { return this._projects; }
            set { this._projects = value; }
        }

        // Check to see if Projects property is set
        internal bool IsSetProjects()
        {
            return this._projects != null && (this._projects.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}