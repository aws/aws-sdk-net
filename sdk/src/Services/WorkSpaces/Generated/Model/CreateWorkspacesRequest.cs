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
    /// Container for the parameters to the CreateWorkspaces operation.
    /// Creates one or more WorkSpaces.
    /// 
    ///  
    /// <para>
    /// This operation is asynchronous and returns before the WorkSpaces are created.
    /// </para>
    ///  <note> <ul> <li> 
    /// <para>
    /// The <c>MANUAL</c> running mode value is only supported by Amazon WorkSpaces Core.
    /// Contact your account team to be allow-listed to use this value. For more information,
    /// see <a href="http://aws.amazon.com/workspaces/core/">Amazon WorkSpaces Core</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You don't need to specify the <c>PCOIP</c> protocol for Linux bundles because <c>DCV</c>
    /// (formerly WSP) is the default protocol for those bundles.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// User-decoupled WorkSpaces are only supported by Amazon WorkSpaces Core.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Review your running mode to ensure you are using one that is optimal for your needs
    /// and budget. For more information on switching running modes, see <a href="http://aws.amazon.com/workspaces-family/workspaces/faqs/#:~:text=Can%20I%20switch%20between%20hourly%20and%20monthly%20billing%20on%20WorkSpaces%20Personal%3F">
    /// Can I switch between hourly and monthly billing?</a> 
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class CreateWorkspacesRequest : AmazonWorkSpacesRequest
    {
        private List<WorkspaceRequest> _workspaces = AWSConfigs.InitializeCollections ? new List<WorkspaceRequest>() : null;

        /// <summary>
        /// Gets and sets the property Workspaces. 
        /// <para>
        /// The WorkSpaces to create. You can specify up to 25 WorkSpaces.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
        public List<WorkspaceRequest> Workspaces
        {
            get { return this._workspaces; }
            set { this._workspaces = value; }
        }

        // Check to see if Workspaces property is set
        internal bool IsSetWorkspaces()
        {
            return this._workspaces != null && (this._workspaces.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}