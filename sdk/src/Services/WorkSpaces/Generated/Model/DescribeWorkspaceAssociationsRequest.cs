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

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeWorkspaceAssociations operation.
    /// Describes the associations betweens applications and the specified WorkSpace.
    /// </summary>
    public partial class DescribeWorkspaceAssociationsRequest : AmazonWorkSpacesRequest
    {
        private List<string> _associatedResourceTypes = new List<string>();
        private string _workspaceId;

        /// <summary>
        /// Gets and sets the property AssociatedResourceTypes. 
        /// <para>
        /// The resource types of the associated resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AssociatedResourceTypes
        {
            get { return this._associatedResourceTypes; }
            set { this._associatedResourceTypes = value; }
        }

        // Check to see if AssociatedResourceTypes property is set
        internal bool IsSetAssociatedResourceTypes()
        {
            return this._associatedResourceTypes != null && this._associatedResourceTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The identifier of the WorkSpace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string WorkspaceId
        {
            get { return this._workspaceId; }
            set { this._workspaceId = value; }
        }

        // Check to see if WorkspaceId property is set
        internal bool IsSetWorkspaceId()
        {
            return this._workspaceId != null;
        }

    }
}