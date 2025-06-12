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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
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
namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Describes the authorization configuration for connections, message publishing, message
    /// subscriptions, and logging for an Event API.
    /// </summary>
    public partial class EventConfig
    {
        private List<AuthProvider> _authProviders = AWSConfigs.InitializeCollections ? new List<AuthProvider>() : null;
        private List<AuthMode> _connectionAuthModes = AWSConfigs.InitializeCollections ? new List<AuthMode>() : null;
        private List<AuthMode> _defaultPublishAuthModes = AWSConfigs.InitializeCollections ? new List<AuthMode>() : null;
        private List<AuthMode> _defaultSubscribeAuthModes = AWSConfigs.InitializeCollections ? new List<AuthMode>() : null;
        private EventLogConfig _logConfig;

        /// <summary>
        /// Gets and sets the property AuthProviders. 
        /// <para>
        /// A list of authorization providers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AuthProvider> AuthProviders
        {
            get { return this._authProviders; }
            set { this._authProviders = value; }
        }

        // Check to see if AuthProviders property is set
        internal bool IsSetAuthProviders()
        {
            return this._authProviders != null && (this._authProviders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConnectionAuthModes. 
        /// <para>
        /// A list of valid authorization modes for the Event API connections.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AuthMode> ConnectionAuthModes
        {
            get { return this._connectionAuthModes; }
            set { this._connectionAuthModes = value; }
        }

        // Check to see if ConnectionAuthModes property is set
        internal bool IsSetConnectionAuthModes()
        {
            return this._connectionAuthModes != null && (this._connectionAuthModes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DefaultPublishAuthModes. 
        /// <para>
        /// A list of valid authorization modes for the Event API publishing.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AuthMode> DefaultPublishAuthModes
        {
            get { return this._defaultPublishAuthModes; }
            set { this._defaultPublishAuthModes = value; }
        }

        // Check to see if DefaultPublishAuthModes property is set
        internal bool IsSetDefaultPublishAuthModes()
        {
            return this._defaultPublishAuthModes != null && (this._defaultPublishAuthModes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DefaultSubscribeAuthModes. 
        /// <para>
        /// A list of valid authorization modes for the Event API subscriptions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AuthMode> DefaultSubscribeAuthModes
        {
            get { return this._defaultSubscribeAuthModes; }
            set { this._defaultSubscribeAuthModes = value; }
        }

        // Check to see if DefaultSubscribeAuthModes property is set
        internal bool IsSetDefaultSubscribeAuthModes()
        {
            return this._defaultSubscribeAuthModes != null && (this._defaultSubscribeAuthModes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LogConfig. 
        /// <para>
        /// The CloudWatch Logs configuration for the Event API.
        /// </para>
        /// </summary>
        public EventLogConfig LogConfig
        {
            get { return this._logConfig; }
            set { this._logConfig = value; }
        }

        // Check to see if LogConfig property is set
        internal bool IsSetLogConfig()
        {
            return this._logConfig != null;
        }

    }
}