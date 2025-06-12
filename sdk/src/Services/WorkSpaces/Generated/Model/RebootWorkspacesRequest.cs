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
    /// Container for the parameters to the RebootWorkspaces operation.
    /// Reboots the specified WorkSpaces.
    /// 
    ///  
    /// <para>
    /// You cannot reboot a WorkSpace unless its state is <c>AVAILABLE</c>, <c>UNHEALTHY</c>,
    /// or <c>REBOOTING</c>. Reboot a WorkSpace in the <c>REBOOTING</c> state only if your
    /// WorkSpace has been stuck in the <c>REBOOTING</c> state for over 20 minutes.
    /// </para>
    ///  
    /// <para>
    /// This operation is asynchronous and returns before the WorkSpaces have rebooted.
    /// </para>
    /// </summary>
    public partial class RebootWorkspacesRequest : AmazonWorkSpacesRequest
    {
        private List<RebootRequest> _rebootWorkspaceRequests = AWSConfigs.InitializeCollections ? new List<RebootRequest>() : null;

        /// <summary>
        /// Gets and sets the property RebootWorkspaceRequests. 
        /// <para>
        /// The WorkSpaces to reboot. You can specify up to 25 WorkSpaces.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
        public List<RebootRequest> RebootWorkspaceRequests
        {
            get { return this._rebootWorkspaceRequests; }
            set { this._rebootWorkspaceRequests = value; }
        }

        // Check to see if RebootWorkspaceRequests property is set
        internal bool IsSetRebootWorkspaceRequests()
        {
            return this._rebootWorkspaceRequests != null && (this._rebootWorkspaceRequests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}