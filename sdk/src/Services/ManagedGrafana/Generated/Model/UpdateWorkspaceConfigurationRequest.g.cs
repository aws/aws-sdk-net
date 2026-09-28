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

namespace Amazon.ManagedGrafana.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateWorkspaceConfiguration operation. Updates
    /// the configuration string for the given workspace
    /// </summary>
    public partial class UpdateWorkspaceConfigurationRequest : AmazonManagedGrafanaRequest
    {
        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The new configuration string for the workspace. For more information about the format
        /// and configuration options available, see <a href="https://docs.aws.amazon.com/grafana/latest/userguide/AMG-configure-workspace.html">Working
        /// in your Grafana workspace</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 65536)]
        public string Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property GrafanaVersion. 
        /// <para>
        /// Specifies the version of Grafana to support in the workspace. If not specified, keeps
        /// the current version of the workspace.
        /// </para>
        ///  
        /// <para>
        /// Can only be used to upgrade (for example, from 8.4 to 9.4), not downgrade (for example,
        /// from 9.4 to 8.4).
        /// </para>
        ///  
        /// <para>
        /// To know what versions are available to upgrade to for a specific workspace, see the
        /// <a href="https://docs.aws.amazon.com/grafana/latest/APIReference/API_ListVersions.html">ListVersions</a>
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string GrafanaVersion { get; set; }

        /// <summary>
        /// Checks to see if the GrafanaVersion property is set.
        /// </summary>
        internal bool IsSetGrafanaVersion() => this.GrafanaVersion != null;

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The ID of the workspace to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceId property is set.
        /// </summary>
        internal bool IsSetWorkspaceId() => this.WorkspaceId != null;
    }
}
