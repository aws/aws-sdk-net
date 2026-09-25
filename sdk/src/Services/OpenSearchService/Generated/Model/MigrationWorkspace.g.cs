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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// The target workspace configuration for a migration. You can specify an existing workspace
    /// by ID or request creation of a new workspace.
    /// </summary>
    public partial class MigrationWorkspace
    {
        /// <summary>
        /// Gets and sets the property CreateWorkspace. 
        /// <para>
        /// Specifies whether to create a new workspace as the migration target. If <c>true</c>,
        /// you must also specify <c>name</c>.
        /// </para>
        /// </summary>
        public bool? CreateWorkspace { get; set; }

        /// <summary>
        /// Checks to see if the CreateWorkspace property is set.
        /// </summary>
        internal bool IsSetCreateWorkspace() => this.CreateWorkspace.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the new workspace to create. Required when <c>createWorkspace</c> is <c>true</c>.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the new workspace to create.
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The unique identifier of an existing workspace to use as the migration target. Specify
        /// either this parameter or <c>createWorkspace</c>.
        /// </para>
        /// </summary>
        public string WorkspaceId { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceId property is set.
        /// </summary>
        internal bool IsSetWorkspaceId() => this.WorkspaceId != null;
    }
}
