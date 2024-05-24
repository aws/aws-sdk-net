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
    /// This is the response object from the MigrateWorkspace operation.
    /// </summary>
    public partial class MigrateWorkspaceResponse : AmazonWebServiceResponse
    {
        private string _sourceWorkspaceId;
        private string _targetWorkspaceId;

        /// <summary>
        /// Gets and sets the property SourceWorkspaceId. 
        /// <para>
        /// The original identifier of the WorkSpace that is being migrated.
        /// </para>
        /// </summary>
        public string SourceWorkspaceId
        {
            get { return this._sourceWorkspaceId; }
            set { this._sourceWorkspaceId = value; }
        }

        // Check to see if SourceWorkspaceId property is set
        internal bool IsSetSourceWorkspaceId()
        {
            return this._sourceWorkspaceId != null;
        }

        /// <summary>
        /// Gets and sets the property TargetWorkspaceId. 
        /// <para>
        /// The new identifier of the WorkSpace that is being migrated. If the migration does
        /// not succeed, the target WorkSpace ID will not be used, and the WorkSpace will still
        /// have the original WorkSpace ID.
        /// </para>
        /// </summary>
        public string TargetWorkspaceId
        {
            get { return this._targetWorkspaceId; }
            set { this._targetWorkspaceId = value; }
        }

        // Check to see if TargetWorkspaceId property is set
        internal bool IsSetTargetWorkspaceId()
        {
            return this._targetWorkspaceId != null;
        }

    }
}