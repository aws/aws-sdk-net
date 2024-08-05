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
    /// This is the response object from the CreateWorkspacesPool operation.
    /// </summary>
    public partial class CreateWorkspacesPoolResponse : AmazonWebServiceResponse
    {
        private WorkspacesPool _workspacesPool;

        /// <summary>
        /// Gets and sets the property WorkspacesPool. 
        /// <para>
        /// Indicates the pool to create.
        /// </para>
        /// </summary>
        public WorkspacesPool WorkspacesPool
        {
            get { return this._workspacesPool; }
            set { this._workspacesPool = value; }
        }

        // Check to see if WorkspacesPool property is set
        internal bool IsSetWorkspacesPool()
        {
            return this._workspacesPool != null;
        }

    }
}