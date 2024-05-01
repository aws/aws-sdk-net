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
    /// Container for the parameters to the ModifyWorkspaceCreationProperties operation.
    /// Modify the default properties used to create WorkSpaces.
    /// </summary>
    public partial class ModifyWorkspaceCreationPropertiesRequest : AmazonWorkSpacesRequest
    {
        private string _resourceId;
        private WorkspaceCreationProperties _workspaceCreationProperties;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The identifier of the directory.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=65)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceCreationProperties. 
        /// <para>
        /// The default properties for creating WorkSpaces.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WorkspaceCreationProperties WorkspaceCreationProperties
        {
            get { return this._workspaceCreationProperties; }
            set { this._workspaceCreationProperties = value; }
        }

        // Check to see if WorkspaceCreationProperties property is set
        internal bool IsSetWorkspaceCreationProperties()
        {
            return this._workspaceCreationProperties != null;
        }

    }
}