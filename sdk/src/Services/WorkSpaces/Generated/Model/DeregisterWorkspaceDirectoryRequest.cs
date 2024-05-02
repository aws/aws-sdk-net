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
    /// Container for the parameters to the DeregisterWorkspaceDirectory operation.
    /// Deregisters the specified directory. This operation is asynchronous and returns before
    /// the WorkSpace directory is deregistered. If any WorkSpaces are registered to this
    /// directory, you must remove them before you can deregister the directory.
    /// 
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
    public partial class DeregisterWorkspaceDirectoryRequest : AmazonWorkSpacesRequest
    {
        private string _directoryId;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier of the directory. If any WorkSpaces are registered to this directory,
        /// you must remove them before you deregister the directory, or you will receive an OperationNotSupportedException
        /// error.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=65)]
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

    }
}