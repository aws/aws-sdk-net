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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
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
namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// This is the response object from the CreateWorkspaces operation.
    /// </summary>
    public partial class CreateWorkspacesResponse : AmazonWebServiceResponse
    {
        private List<FailedCreateWorkspaceRequest> _failedRequests = AWSConfigs.InitializeCollections ? new List<FailedCreateWorkspaceRequest>() : null;
        private List<Workspace> _pendingRequests = AWSConfigs.InitializeCollections ? new List<Workspace>() : null;

        /// <summary>
        /// Gets and sets the property FailedRequests. 
        /// <para>
        /// Information about the WorkSpaces that could not be created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FailedCreateWorkspaceRequest> FailedRequests
        {
            get { return this._failedRequests; }
            set { this._failedRequests = value; }
        }

        // Check to see if FailedRequests property is set
        internal bool IsSetFailedRequests()
        {
            return this._failedRequests != null && (this._failedRequests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PendingRequests. 
        /// <para>
        /// Information about the WorkSpaces that were created.
        /// </para>
        ///  
        /// <para>
        /// Because this operation is asynchronous, the identifier returned is not immediately
        /// available for use with other operations. For example, if you call <a>DescribeWorkspaces</a>
        /// before the WorkSpace is created, the information returned can be incomplete.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Workspace> PendingRequests
        {
            get { return this._pendingRequests; }
            set { this._pendingRequests = value; }
        }

        // Check to see if PendingRequests property is set
        internal bool IsSetPendingRequests()
        {
            return this._pendingRequests != null && (this._pendingRequests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}