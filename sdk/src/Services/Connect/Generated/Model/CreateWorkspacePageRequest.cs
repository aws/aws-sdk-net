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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the CreateWorkspacePage operation.
    /// Associates a view with a page in a workspace, defining what users see when they navigate
    /// to that page.
    /// </summary>
    public partial class CreateWorkspacePageRequest : AmazonConnectRequest
    {
        private string _inputData;
        private string _instanceId;
        private string _page;
        private string _resourceArn;
        private string _slug;
        private string _workspaceId;

        /// <summary>
        /// Gets and sets the property InputData. 
        /// <para>
        /// A JSON string containing input parameters for the view, validated against the view's
        /// input schema.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=4096)]
        public string InputData
        {
            get { return this._inputData; }
            set { this._inputData = value; }
        }

        // Check to see if InputData property is set
        internal bool IsSetInputData()
        {
            return this._inputData != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property Page. 
        /// <para>
        /// The page identifier. Valid system pages include <c>HOME</c> and <c>AGENT_EXPERIENCE</c>.
        /// Custom pages cannot use the <c>aws:</c> or <c>connect:</c> prefixes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
        public string Page
        {
            get { return this._page; }
            set { this._page = value; }
        }

        // Check to see if Page property is set
        internal bool IsSetPage()
        {
            return this._page != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the view to associate with the page.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Slug. 
        /// <para>
        /// The URL-friendly identifier for the page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public string Slug
        {
            get { return this._slug; }
            set { this._slug = value; }
        }

        // Check to see if Slug property is set
        internal bool IsSetSlug()
        {
            return this._slug != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The identifier of the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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

    }
}