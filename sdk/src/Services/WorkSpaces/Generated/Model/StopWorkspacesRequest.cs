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
    /// Container for the parameters to the StopWorkspaces operation.
    /// Stops the specified WorkSpaces.
    /// 
    ///  
    /// <para>
    /// You cannot stop a WorkSpace unless it has a running mode of <c>AutoStop</c> or <c>Manual</c>
    /// and a state of <c>AVAILABLE</c>, <c>IMPAIRED</c>, <c>UNHEALTHY</c>, or <c>ERROR</c>.
    /// </para>
    /// </summary>
    public partial class StopWorkspacesRequest : AmazonWorkSpacesRequest
    {
        private List<StopRequest> _stopWorkspaceRequests = AWSConfigs.InitializeCollections ? new List<StopRequest>() : null;

        /// <summary>
        /// Gets and sets the property StopWorkspaceRequests. 
        /// <para>
        /// The WorkSpaces to stop. You can specify up to 25 WorkSpaces.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
        public List<StopRequest> StopWorkspaceRequests
        {
            get { return this._stopWorkspaceRequests; }
            set { this._stopWorkspaceRequests = value; }
        }

        // Check to see if StopWorkspaceRequests property is set
        internal bool IsSetStopWorkspaceRequests()
        {
            return this._stopWorkspaceRequests != null && (this._stopWorkspaceRequests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}