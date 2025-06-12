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
    /// Container for the parameters to the CreatePlugin operation.
    /// Creates an Amazon Q Business plugin.
    /// </summary>
    public partial class CreatePluginRequest : AmazonQBusinessRequest
    {
        private string _applicationId;
        private PluginAuthConfiguration _authConfiguration;
        private string _clientToken;
        private CustomPluginConfiguration _customPluginConfiguration;
        private string _displayName;
        private string _serverUrl;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private PluginType _type;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The identifier of the application that will contain the plugin.
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
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token that you provide to identify the request to create your Amazon Q Business
        /// plugin.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property CustomPluginConfiguration. 
        /// <para>
        /// Contains configuration for a custom plugin.
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
        /// A the name for your plugin.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs that identify or categorize the data source connector. You
        /// can also use tags to help control access to the data source connector. Tag keys and
        /// values can consist of Unicode letters, digits, white space, and any of the following
        /// symbols: _ . : / = + - @.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of plugin you want to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PluginType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}