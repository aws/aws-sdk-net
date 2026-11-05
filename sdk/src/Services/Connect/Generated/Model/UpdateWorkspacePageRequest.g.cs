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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateWorkspacePage operation. Updates the configuration
    /// of a page in a workspace, including the associated view and input data.
    /// </summary>
    public partial class UpdateWorkspacePageRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property InputData. 
        /// <para>
        /// A JSON string containing input parameters for the view.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string InputData { get; set; }

        /// <summary>
        /// Checks to see if the InputData property is set.
        /// </summary>
        internal bool IsSetInputData() => this.InputData != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property NewPage. 
        /// <para>
        /// The new page identifier, if changing the page name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public string NewPage { get; set; }

        /// <summary>
        /// Checks to see if the NewPage property is set.
        /// </summary>
        internal bool IsSetNewPage() => this.NewPage != null;

        /// <summary>
        /// Gets and sets the property Page. 
        /// <para>
        /// The current page identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 25)]
        public string Page { get; set; }

        /// <summary>
        /// Checks to see if the Page property is set.
        /// </summary>
        internal bool IsSetPage() => this.Page != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the view to associate with the page.
        /// </para>
        /// </summary>
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property Slug. 
        /// <para>
        /// The URL-friendly identifier for the page.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string Slug { get; set; }

        /// <summary>
        /// Checks to see if the Slug property is set.
        /// </summary>
        internal bool IsSetSlug() => this.Slug != null;

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The identifier of the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceId property is set.
        /// </summary>
        internal bool IsSetWorkspaceId() => this.WorkspaceId != null;
    }
}
