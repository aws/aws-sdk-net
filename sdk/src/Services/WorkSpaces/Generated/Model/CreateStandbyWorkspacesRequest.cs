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
    /// Container for the parameters to the CreateStandbyWorkspaces operation.
    /// Creates a standby WorkSpace in a secondary Region.
    /// </summary>
    public partial class CreateStandbyWorkspacesRequest : AmazonWorkSpacesRequest
    {
        private string _primaryRegion;
        private List<StandbyWorkspace> _standbyWorkspaces = new List<StandbyWorkspace>();

        /// <summary>
        /// Gets and sets the property PrimaryRegion. 
        /// <para>
        /// The Region of the primary WorkSpace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=31)]
        public string PrimaryRegion
        {
            get { return this._primaryRegion; }
            set { this._primaryRegion = value; }
        }

        // Check to see if PrimaryRegion property is set
        internal bool IsSetPrimaryRegion()
        {
            return this._primaryRegion != null;
        }

        /// <summary>
        /// Gets and sets the property StandbyWorkspaces. 
        /// <para>
        /// Information about the standby WorkSpace to be created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<StandbyWorkspace> StandbyWorkspaces
        {
            get { return this._standbyWorkspaces; }
            set { this._standbyWorkspaces = value; }
        }

        // Check to see if StandbyWorkspaces property is set
        internal bool IsSetStandbyWorkspaces()
        {
            return this._standbyWorkspaces != null && this._standbyWorkspaces.Count > 0; 
        }

    }
}