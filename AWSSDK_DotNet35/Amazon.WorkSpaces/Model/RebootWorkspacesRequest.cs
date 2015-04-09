/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Container for the parameters to the RebootWorkspaces operation.
    /// Reboots the specified WorkSpaces.
    /// 
    ///  
    /// <para>
    /// To be able to reboot a WorkSpace, the WorkSpace must have a <b>State</b> of <code>AVAILABLE</code>,
    /// <code>IMPAIRED</code>, or <code>INOPERABLE</code>.
    /// </para>
    ///  <note> 
    /// <para>
    /// This operation is asynchronous and will return before the WorkSpaces have rebooted.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class RebootWorkspacesRequest : AmazonWorkSpacesRequest
    {
        private List<RebootRequest> _rebootWorkspaceRequests = new List<RebootRequest>();

        /// <summary>
        /// Gets and sets the property RebootWorkspaceRequests. 
        /// <para>
        /// An array of structures that specify the WorkSpaces to reboot.
        /// </para>
        /// </summary>
        public List<RebootRequest> RebootWorkspaceRequests
        {
            get { return this._rebootWorkspaceRequests; }
            set { this._rebootWorkspaceRequests = value; }
        }

        // Check to see if RebootWorkspaceRequests property is set
        internal bool IsSetRebootWorkspaceRequests()
        {
            return this._rebootWorkspaceRequests != null && this._rebootWorkspaceRequests.Count > 0; 
        }

    }
}