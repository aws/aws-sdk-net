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
    /// Container for the parameters to the UpdatePlugin operation. Updates an Amazon Q Business
    /// plugin.
    /// </summary>
    public partial class UpdatePluginRequest : AmazonQBusinessRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The identifier of the application the plugin is attached to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property AuthConfiguration. 
        /// <para>
        /// The authentication configuration the plugin is using.
        /// </para>
        /// </summary>
        public PluginAuthConfiguration AuthConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AuthConfiguration property is set.
        /// </summary>
        internal bool IsSetAuthConfiguration() => this.AuthConfiguration != null;

        /// <summary>
        /// Gets and sets the property CustomPluginConfiguration. 
        /// <para>
        /// The configuration for a custom plugin.
        /// </para>
        /// </summary>
        public CustomPluginConfiguration CustomPluginConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CustomPluginConfiguration property is set.
        /// </summary>
        internal bool IsSetCustomPluginConfiguration() => this.CustomPluginConfiguration != null;

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
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string PluginId { get; set; }

        /// <summary>
        /// Checks to see if the PluginId property is set.
        /// </summary>
        internal bool IsSetPluginId() => this.PluginId != null;

        /// <summary>
        /// Gets and sets the property ServerUrl. 
        /// <para>
        /// The source URL used for plugin configuration.
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
        /// The status of the plugin. 
        /// </para>
        /// </summary>
        public PluginState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
