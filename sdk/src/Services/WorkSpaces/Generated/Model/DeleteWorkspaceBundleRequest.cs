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
    /// Container for the parameters to the DeleteWorkspaceBundle operation.
    /// Deletes the specified WorkSpace bundle. For more information about deleting WorkSpace
    /// bundles, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/delete_bundle.html">
    /// Delete a Custom WorkSpaces Bundle or Image</a>.
    /// </summary>
    public partial class DeleteWorkspaceBundleRequest : AmazonWorkSpacesRequest
    {
        private string _bundleId;

        /// <summary>
        /// Gets and sets the property BundleId. 
        /// <para>
        /// The identifier of the bundle.
        /// </para>
        /// </summary>
        public string BundleId
        {
            get { return this._bundleId; }
            set { this._bundleId = value; }
        }

        // Check to see if BundleId property is set
        internal bool IsSetBundleId()
        {
            return this._bundleId != null;
        }

    }
}