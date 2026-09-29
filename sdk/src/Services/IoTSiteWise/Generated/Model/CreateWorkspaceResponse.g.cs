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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// This is the response object from the CreateWorkspace operation.
    /// </summary>
    public partial class CreateWorkspaceResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property WorkspaceArn. 
        /// <para>
        /// The ARN of the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1600)]
        public string WorkspaceArn { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceArn property is set.
        /// </summary>
        internal bool IsSetWorkspaceArn() => this.WorkspaceArn != null;

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string WorkspaceName { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceName property is set.
        /// </summary>
        internal bool IsSetWorkspaceName() => this.WorkspaceName != null;

        /// <summary>
        /// Gets and sets the property WorkspaceStatus. 
        /// <para>
        /// The status of the workspace, which is <c>CREATING</c> when the operation returns.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WorkspaceStatus WorkspaceStatus { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceStatus property is set.
        /// </summary>
        internal bool IsSetWorkspaceStatus() => this.WorkspaceStatus != null;
    }
}
