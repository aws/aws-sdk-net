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
    /// Container for the parameters to the ModifyWorkspaceAccessProperties operation.
    /// Specifies which devices and operating systems users can use to access their WorkSpaces.
    /// For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/update-directory-details.html#control-device-access">
    /// Control Device Access</a>.
    /// </summary>
    public partial class ModifyWorkspaceAccessPropertiesRequest : AmazonWorkSpacesRequest
    {
        private string _resourceId;
        private WorkspaceAccessProperties _workspaceAccessProperties;

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
        /// Gets and sets the property WorkspaceAccessProperties. 
        /// <para>
        /// The device types and operating systems to enable or disable for access.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WorkspaceAccessProperties WorkspaceAccessProperties
        {
            get { return this._workspaceAccessProperties; }
            set { this._workspaceAccessProperties = value; }
        }

        // Check to see if WorkspaceAccessProperties property is set
        internal bool IsSetWorkspaceAccessProperties()
        {
            return this._workspaceAccessProperties != null;
        }

    }
}