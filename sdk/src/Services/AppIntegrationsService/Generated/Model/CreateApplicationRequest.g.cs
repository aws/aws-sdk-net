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

namespace Amazon.AppIntegrationsService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateApplication operation. Creates and persists
    /// an Application resource.
    /// </summary>
    public partial class CreateApplicationRequest : AmazonAppIntegrationsServiceRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationConfig. 
        /// <para>
        /// The configuration settings for the application.
        /// </para>
        /// </summary>
        public ApplicationConfig ApplicationConfig { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationConfig property is set.
        /// </summary>
        internal bool IsSetApplicationConfig() => this.ApplicationConfig != null;

        /// <summary>
        /// Gets and sets the property ApplicationSourceConfig. 
        /// <para>
        /// The configuration for where the application should be loaded from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ApplicationSourceConfig ApplicationSourceConfig { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationSourceConfig property is set.
        /// </summary>
        internal bool IsSetApplicationSourceConfig() => this.ApplicationSourceConfig != null;

        /// <summary>
        /// Gets and sets the property ApplicationType. 
        /// <para>
        /// The type of application.
        /// </para>
        /// </summary>
        public ApplicationType ApplicationType { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationType property is set.
        /// </summary>
        internal bool IsSetApplicationType() => this.ApplicationType != null;

        /// <summary>
        /// Gets and sets the property AuthConfig. 
        /// <para>
        /// The authentication settings that Connect Customer uses when calling the external application.
        /// </para>
        /// </summary>
        public AuthConfig AuthConfig { get; set; }

        /// <summary>
        /// Checks to see if the AuthConfig property is set.
        /// </summary>
        internal bool IsSetAuthConfig() => this.AuthConfig != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="https://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IframeConfig. 
        /// <para>
        /// The iframe configuration for the application.
        /// </para>
        /// </summary>
        public IframeConfig IframeConfig { get; set; }

        /// <summary>
        /// Checks to see if the IframeConfig property is set.
        /// </summary>
        internal bool IsSetIframeConfig() => this.IframeConfig != null;

        /// <summary>
        /// Gets and sets the property InitializationTimeout. 
        /// <para>
        /// The maximum time in milliseconds allowed to establish a connection with the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 600000)]
        public int? InitializationTimeout { get; set; }

        /// <summary>
        /// Checks to see if the InitializationTimeout property is set.
        /// </summary>
        internal bool IsSetInitializationTimeout() => this.InitializationTimeout.HasValue;

        /// <summary>
        /// Gets and sets the property IsService. 
        /// <para>
        /// Indicates whether the application is a service.
        /// </para>
        /// </summary>
        [Obsolete("IsService has been deprecated in favor of ApplicationType")]
        public bool? IsService { get; set; }

        /// <summary>
        /// Checks to see if the IsService property is set.
        /// </summary>
        internal bool IsSetIsService() => this.IsService.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 211)]
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// The configuration of events or requests that the application has access to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 150)]
        public List<string> Permissions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Permissions property is set.
        /// </summary>
        internal bool IsSetPermissions() => this.Permissions != null && (this.Permissions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Publications. 
        /// <para>
        /// The events that the application publishes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("Publications has been replaced with Permissions")]
        [AWSProperty(Min = 0, Max = 50)]
        public List<Publication> Publications { get; set; } = AWSConfigs.InitializeCollections ? new List<Publication>() : null;

        /// <summary>
        /// Checks to see if the Publications property is set.
        /// </summary>
        internal bool IsSetPublications() => this.Publications != null && (this.Publications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Subscriptions. 
        /// <para>
        /// The events that the application subscribes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("Subscriptions has been replaced with Permissions")]
        [AWSProperty(Min = 0, Max = 50)]
        public List<Subscription> Subscriptions { get; set; } = AWSConfigs.InitializeCollections ? new List<Subscription>() : null;

        /// <summary>
        /// Checks to see if the Subscriptions property is set.
        /// </summary>
        internal bool IsSetSubscriptions() => this.Subscriptions != null && (this.Subscriptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource. For example,
        /// { "tags": {"key1":"value1", "key2":"value2"} }.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
