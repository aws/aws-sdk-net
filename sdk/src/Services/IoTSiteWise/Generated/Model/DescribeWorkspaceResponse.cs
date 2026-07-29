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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the DescribeWorkspace operation.
    /// </summary>
    public partial class DescribeWorkspaceResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private WorkspaceEncryptionConfigurationInfo _encryptionConfiguration;
        private DateTime? _updatedAt;
        private string _workspaceArn;
        private string _workspaceDescription;
        private string _workspaceName;
        private WorkspaceStatus _workspaceStatus;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date the workspace was created, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The encryption configuration information for the workspace.
        /// </para>
        /// </summary>
        public WorkspaceEncryptionConfigurationInfo EncryptionConfiguration
        {
            get { return this._encryptionConfiguration; }
            set { this._encryptionConfiguration = value; }
        }

        // Check to see if EncryptionConfiguration property is set
        internal bool IsSetEncryptionConfiguration()
        {
            return this._encryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date the workspace was last updated, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WorkspaceArn. 
        /// <para>
        /// The ARN of the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string WorkspaceArn
        {
            get { return this._workspaceArn; }
            set { this._workspaceArn = value; }
        }

        // Check to see if WorkspaceArn property is set
        internal bool IsSetWorkspaceArn()
        {
            return this._workspaceArn != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceDescription. 
        /// <para>
        /// The description of the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string WorkspaceDescription
        {
            get { return this._workspaceDescription; }
            set { this._workspaceDescription = value; }
        }

        // Check to see if WorkspaceDescription property is set
        internal bool IsSetWorkspaceDescription()
        {
            return this._workspaceDescription != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string WorkspaceName
        {
            get { return this._workspaceName; }
            set { this._workspaceName = value; }
        }

        // Check to see if WorkspaceName property is set
        internal bool IsSetWorkspaceName()
        {
            return this._workspaceName != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceStatus. 
        /// <para>
        /// The status of the workspace, which contains the state and any error message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WorkspaceStatus WorkspaceStatus
        {
            get { return this._workspaceStatus; }
            set { this._workspaceStatus = value; }
        }

        // Check to see if WorkspaceStatus property is set
        internal bool IsSetWorkspaceStatus()
        {
            return this._workspaceStatus != null;
        }

    }
}