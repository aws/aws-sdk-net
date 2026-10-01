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
    /// Container for the parameters to the UpdateChannelNamespace operation. Updates a <c>ChannelNamespace</c>
    /// associated with an <c>Api</c>.
    /// </summary>
    public partial class UpdateChannelNamespaceRequest : AmazonAppSyncRequest
    {
        /// <summary>
        /// Gets and sets the property ApiId. 
        /// <para>
        /// The <c>Api</c> ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ApiId { get; set; }

        /// <summary>
        /// Checks to see if the ApiId property is set.
        /// </summary>
        internal bool IsSetApiId() => this.ApiId != null;

        /// <summary>
        /// Gets and sets the property CodeHandlers. 
        /// <para>
        /// The event handler functions that run custom business logic to process published events
        /// and subscribe requests.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32768)]
        public string CodeHandlers { get; set; }

        /// <summary>
        /// Checks to see if the CodeHandlers property is set.
        /// </summary>
        internal bool IsSetCodeHandlers() => this.CodeHandlers != null;

        /// <summary>
        /// Gets and sets the property HandlerConfigs. 
        /// <para>
        /// The configuration for the <c>OnPublish</c> and <c>OnSubscribe</c> handlers.
        /// </para>
        /// </summary>
        public HandlerConfigs HandlerConfigs { get; set; }

        /// <summary>
        /// Checks to see if the HandlerConfigs property is set.
        /// </summary>
        internal bool IsSetHandlerConfigs() => this.HandlerConfigs != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the <c>ChannelNamespace</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PublishAuthModes. 
        /// <para>
        /// The authorization mode to use for publishing messages on the channel namespace. This
        /// configuration overrides the default <c>Api</c> authorization configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AuthMode> PublishAuthModes { get; set; } = AWSConfigs.InitializeCollections ? new List<AuthMode>() : null;

        /// <summary>
        /// Checks to see if the PublishAuthModes property is set.
        /// </summary>
        internal bool IsSetPublishAuthModes() => this.PublishAuthModes != null && (this.PublishAuthModes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubscribeAuthModes. 
        /// <para>
        /// The authorization mode to use for subscribing to messages on the channel namespace.
        /// This configuration overrides the default <c>Api</c> authorization configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AuthMode> SubscribeAuthModes { get; set; } = AWSConfigs.InitializeCollections ? new List<AuthMode>() : null;

        /// <summary>
        /// Checks to see if the SubscribeAuthModes property is set.
        /// </summary>
        internal bool IsSetSubscribeAuthModes() => this.SubscribeAuthModes != null && (this.SubscribeAuthModes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
