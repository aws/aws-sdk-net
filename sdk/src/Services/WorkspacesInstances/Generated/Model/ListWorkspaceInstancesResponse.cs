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
 * Do not modify this file. This file is generated from the workspaces-instances-2022-07-26.normal.json service model.
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
namespace Amazon.WorkspacesInstances.Model
{
    /// <summary>
    /// Contains the list of WorkSpaces Instances matching the specified criteria.
    /// </summary>
    public partial class ListWorkspaceInstancesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<WorkspaceInstance> _workspaceInstances = AWSConfigs.InitializeCollections ? new List<WorkspaceInstance>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Token for retrieving additional WorkSpaces Instances if the result set is paginated.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=2048)]
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
        /// Gets and sets the property WorkspaceInstances. 
        /// <para>
        /// Collection of WorkSpaces Instances returned by the query.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<WorkspaceInstance> WorkspaceInstances
        {
            get { return this._workspaceInstances; }
            set { this._workspaceInstances = value; }
        }

        // Check to see if WorkspaceInstances property is set
        internal bool IsSetWorkspaceInstances()
        {
            return this._workspaceInstances != null && (this._workspaceInstances.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}