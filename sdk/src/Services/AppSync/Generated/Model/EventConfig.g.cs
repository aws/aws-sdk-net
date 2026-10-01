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

namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Describes the authorization configuration for connections, message publishing, message
    /// subscriptions, and logging for an Event API.
    /// </summary>
    public partial class EventConfig
    {
        /// <summary>
        /// Gets and sets the property AuthProviders. 
        /// <para>
        /// A list of authorization providers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<AuthProvider> AuthProviders { get; set; } = AWSConfigs.InitializeCollections ? new List<AuthProvider>() : null;

        /// <summary>
        /// Checks to see if the AuthProviders property is set.
        /// </summary>
        internal bool IsSetAuthProviders() => this.AuthProviders != null && (this.AuthProviders.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConnectionAuthModes. 
        /// <para>
        /// A list of valid authorization modes for the Event API connections.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<AuthMode> ConnectionAuthModes { get; set; } = AWSConfigs.InitializeCollections ? new List<AuthMode>() : null;

        /// <summary>
        /// Checks to see if the ConnectionAuthModes property is set.
        /// </summary>
        internal bool IsSetConnectionAuthModes() => this.ConnectionAuthModes != null && (this.ConnectionAuthModes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DefaultPublishAuthModes. 
        /// <para>
        /// A list of valid authorization modes for the Event API publishing.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<AuthMode> DefaultPublishAuthModes { get; set; } = AWSConfigs.InitializeCollections ? new List<AuthMode>() : null;

        /// <summary>
        /// Checks to see if the DefaultPublishAuthModes property is set.
        /// </summary>
        internal bool IsSetDefaultPublishAuthModes() => this.DefaultPublishAuthModes != null && (this.DefaultPublishAuthModes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DefaultSubscribeAuthModes. 
        /// <para>
        /// A list of valid authorization modes for the Event API subscriptions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<AuthMode> DefaultSubscribeAuthModes { get; set; } = AWSConfigs.InitializeCollections ? new List<AuthMode>() : null;

        /// <summary>
        /// Checks to see if the DefaultSubscribeAuthModes property is set.
        /// </summary>
        internal bool IsSetDefaultSubscribeAuthModes() => this.DefaultSubscribeAuthModes != null && (this.DefaultSubscribeAuthModes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LogConfig. 
        /// <para>
        /// The CloudWatch Logs configuration for the Event API.
        /// </para>
        /// </summary>
        public EventLogConfig LogConfig { get; set; }

        /// <summary>
        /// Checks to see if the LogConfig property is set.
        /// </summary>
        internal bool IsSetLogConfig() => this.LogConfig != null;
    }
}
