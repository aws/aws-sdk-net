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
 * Do not modify this file. This file is generated from the amp-2020-08-01.normal.json service model.
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
namespace Amazon.PrometheusService.Model
{
    /// <summary>
    /// Represents the output of a <c>ListWorkspaces</c> operation.
    /// </summary>
    public partial class ListWorkspacesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<WorkspaceSummary> _workspaces = AWSConfigs.InitializeCollections ? new List<WorkspaceSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token indicating that there are more results to retrieve. You can use this token
        /// as part of your next <c>ListWorkspaces</c> request to retrieve those results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
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
        /// Gets and sets the property Workspaces. 
        /// <para>
        /// An array of <c>WorkspaceSummary</c> structures containing information about the workspaces
        /// requested.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<WorkspaceSummary> Workspaces
        {
            get { return this._workspaces; }
            set { this._workspaces = value; }
        }

        // Check to see if Workspaces property is set
        internal bool IsSetWorkspaces()
        {
            return this._workspaces != null && (this._workspaces.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}