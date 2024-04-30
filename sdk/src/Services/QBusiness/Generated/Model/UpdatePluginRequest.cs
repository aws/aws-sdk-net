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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
    /// Container for the parameters to the UpdatePlugin operation.
    /// Updates an Amazon Q Business plugin.
    /// </summary>
    public partial class UpdatePluginRequest : AmazonQBusinessRequest
    {
        private string _applicationId;
        private PluginAuthConfiguration _authConfiguration;
        private CustomPluginConfiguration _customPluginConfiguration;
        private string _displayName;
        private string _pluginId;
        private string _serverUrl;
        private PluginState _state;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The identifier of the application the plugin is attached to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property AuthConfiguration. 
        /// <para>
        /// The authentication configuration the plugin is using.
        /// </para>
        /// </summary>
        public PluginAuthConfiguration AuthConfiguration
        {
            get { return this._authConfiguration; }
            set { this._authConfiguration = value; }
        }

        // Check to see if AuthConfiguration property is set
        internal bool IsSetAuthConfiguration()
        {
            return this._authConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property CustomPluginConfiguration. 
        /// <para>
        /// The configuration for a custom plugin.
        /// </para>
        /// </summary>
        public CustomPluginConfiguration CustomPluginConfiguration
        {
            get { return this._customPluginConfiguration; }
            set { this._customPluginConfiguration = value; }
        }

        // Check to see if CustomPluginConfiguration property is set
        internal bool IsSetCustomPluginConfiguration()
        {
            return this._customPluginConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name of the plugin.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property PluginId. 
        /// <para>
        /// The identifier of the plugin.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string PluginId
        {
            get { return this._pluginId; }
            set { this._pluginId = value; }
        }

        // Check to see if PluginId property is set
        internal bool IsSetPluginId()
        {
            return this._pluginId != null;
        }

        /// <summary>
        /// Gets and sets the property ServerUrl. 
        /// <para>
        /// The source URL used for plugin configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ServerUrl
        {
            get { return this._serverUrl; }
            set { this._serverUrl = value; }
        }

        // Check to see if ServerUrl property is set
        internal bool IsSetServerUrl()
        {
            return this._serverUrl != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The status of the plugin. 
        /// </para>
        /// </summary>
        public PluginState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}