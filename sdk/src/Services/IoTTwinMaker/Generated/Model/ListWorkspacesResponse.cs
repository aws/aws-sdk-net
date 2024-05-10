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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
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
namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// This is the response object from the ListWorkspaces operation.
    /// </summary>
    public partial class ListWorkspacesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<WorkspaceSummary> _workspaceSummaries = AWSConfigs.InitializeCollections ? new List<WorkspaceSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The string that specifies the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=17880)]
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
        /// Gets and sets the property WorkspaceSummaries. 
        /// <para>
        /// A list of objects that contain information about the workspaces.
        /// </para>
        /// </summary>
        public List<WorkspaceSummary> WorkspaceSummaries
        {
            get { return this._workspaceSummaries; }
            set { this._workspaceSummaries = value; }
        }

        // Check to see if WorkspaceSummaries property is set
        internal bool IsSetWorkspaceSummaries()
        {
            return this._workspaceSummaries != null && (this._workspaceSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}