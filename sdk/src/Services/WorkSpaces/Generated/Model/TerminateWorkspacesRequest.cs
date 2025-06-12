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
    /// Container for the parameters to the TerminateWorkspaces operation.
    /// Terminates the specified WorkSpaces.
    /// 
    ///  <important> 
    /// <para>
    /// Terminating a WorkSpace is a permanent action and cannot be undone. The user's data
    /// is destroyed. If you need to archive any user data, contact Amazon Web ServicesSupport
    /// before terminating the WorkSpace.
    /// </para>
    ///  </important> 
    /// <para>
    /// You can terminate a WorkSpace that is in any state except <c>SUSPENDED</c>.
    /// </para>
    ///  
    /// <para>
    /// This operation is asynchronous and returns before the WorkSpaces have been completely
    /// terminated. After a WorkSpace is terminated, the <c>TERMINATED</c> state is returned
    /// only briefly before the WorkSpace directory metadata is cleaned up, so this state
    /// is rarely returned. To confirm that a WorkSpace is terminated, check for the WorkSpace
    /// ID by using <a href="https://docs.aws.amazon.com/workspaces/latest/api/API_DescribeWorkspaces.html">
    /// DescribeWorkSpaces</a>. If the WorkSpace ID isn't returned, then the WorkSpace has
    /// been successfully terminated.
    /// </para>
    ///  <note> 
    /// <para>
    /// Simple AD and AD Connector are made available to you free of charge to use with WorkSpaces.
    /// If there are no WorkSpaces being used with your Simple AD or AD Connector directory
    /// for 30 consecutive days, this directory will be automatically deregistered for use
    /// with Amazon WorkSpaces, and you will be charged for this directory as per the <a href="http://aws.amazon.com/directoryservice/pricing/">Directory
    /// Service pricing terms</a>.
    /// </para>
    ///  
    /// <para>
    /// To delete empty directories, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/delete-workspaces-directory.html">
    /// Delete the Directory for Your WorkSpaces</a>. If you delete your Simple AD or AD Connector
    /// directory, you can always create a new one when you want to start using WorkSpaces
    /// again.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class TerminateWorkspacesRequest : AmazonWorkSpacesRequest
    {
        private List<TerminateRequest> _terminateWorkspaceRequests = AWSConfigs.InitializeCollections ? new List<TerminateRequest>() : null;

        /// <summary>
        /// Gets and sets the property TerminateWorkspaceRequests. 
        /// <para>
        /// The WorkSpaces to terminate. You can specify up to 25 WorkSpaces.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
        public List<TerminateRequest> TerminateWorkspaceRequests
        {
            get { return this._terminateWorkspaceRequests; }
            set { this._terminateWorkspaceRequests = value; }
        }

        // Check to see if TerminateWorkspaceRequests property is set
        internal bool IsSetTerminateWorkspaceRequests()
        {
            return this._terminateWorkspaceRequests != null && (this._terminateWorkspaceRequests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}