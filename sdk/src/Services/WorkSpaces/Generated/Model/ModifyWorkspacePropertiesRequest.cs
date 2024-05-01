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
    /// Container for the parameters to the ModifyWorkspaceProperties operation.
    /// Modifies the specified WorkSpace properties. For important information about how to
    /// modify the size of the root and user volumes, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/modify-workspaces.html">
    /// Modify a WorkSpace</a>. 
    /// 
    ///  <note> 
    /// <para>
    /// The <c>MANUAL</c> running mode value is only supported by Amazon WorkSpaces Core.
    /// Contact your account team to be allow-listed to use this value. For more information,
    /// see <a href="http://aws.amazon.com/workspaces/core/">Amazon WorkSpaces Core</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ModifyWorkspacePropertiesRequest : AmazonWorkSpacesRequest
    {
        private DataReplication _dataReplication;
        private string _workspaceId;
        private WorkspaceProperties _workspaceProperties;

        /// <summary>
        /// Gets and sets the property DataReplication. 
        /// <para>
        /// Indicates the data replication status.
        /// </para>
        /// </summary>
        public DataReplication DataReplication
        {
            get { return this._dataReplication; }
            set { this._dataReplication = value; }
        }

        // Check to see if DataReplication property is set
        internal bool IsSetDataReplication()
        {
            return this._dataReplication != null;
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

        /// <summary>
        /// Gets and sets the property WorkspaceProperties. 
        /// <para>
        /// The properties of the WorkSpace.
        /// </para>
        /// </summary>
        public WorkspaceProperties WorkspaceProperties
        {
            get { return this._workspaceProperties; }
            set { this._workspaceProperties = value; }
        }

        // Check to see if WorkspaceProperties property is set
        internal bool IsSetWorkspaceProperties()
        {
            return this._workspaceProperties != null;
        }

    }
}