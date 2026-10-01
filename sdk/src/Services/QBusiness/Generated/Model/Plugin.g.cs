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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Information about an Amazon Q Business plugin and its configuration.
    /// </summary>
    public partial class Plugin
    {
        /// <summary>
        /// Gets and sets the property BuildStatus. 
        /// <para>
        /// The status of the plugin.
        /// </para>
        /// </summary>
        public PluginBuildStatus BuildStatus { get; set; }

        /// <summary>
        /// Checks to see if the BuildStatus property is set.
        /// </summary>
        internal bool IsSetBuildStatus() => this.BuildStatus != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp for when the plugin was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name of the plugin.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property PluginId. 
        /// <para>
        /// The identifier of the plugin.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string PluginId { get; set; }

        /// <summary>
        /// Checks to see if the PluginId property is set.
        /// </summary>
        internal bool IsSetPluginId() => this.PluginId != null;

        /// <summary>
        /// Gets and sets the property ServerUrl. 
        /// <para>
        /// The plugin server URL used for configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ServerUrl { get; set; }

        /// <summary>
        /// Checks to see if the ServerUrl property is set.
        /// </summary>
        internal bool IsSetServerUrl() => this.ServerUrl != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current status of the plugin.
        /// </para>
        /// </summary>
        public PluginState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the plugin.
        /// </para>
        /// </summary>
        public PluginType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp for when the plugin was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
