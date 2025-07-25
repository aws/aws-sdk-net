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
 * Do not modify this file. This file is generated from the appintegrations-2020-07-29.normal.json service model.
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
    /// Container for the parameters to the CreateApplication operation.
    /// Creates and persists an Application resource.
    /// </summary>
    public partial class CreateApplicationRequest : AmazonAppIntegrationsServiceRequest
    {
        private ApplicationConfig _applicationConfig;
        private ApplicationSourceConfig _applicationSourceConfig;
        private string _clientToken;
        private string _description;
        private IframeConfig _iframeConfig;
        private int? _initializationTimeout;
        private bool? _isService;
        private string _name;
        private string _awsNamespace;
        private List<string> _permissions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Publication> _publications = AWSConfigs.InitializeCollections ? new List<Publication>() : null;
        private List<Subscription> _subscriptions = AWSConfigs.InitializeCollections ? new List<Subscription>() : null;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ApplicationConfig. 
        /// <para>
        /// The configuration settings for the application.
        /// </para>
        /// </summary>
        public ApplicationConfig ApplicationConfig
        {
            get { return this._applicationConfig; }
            set { this._applicationConfig = value; }
        }

        // Check to see if ApplicationConfig property is set
        internal bool IsSetApplicationConfig()
        {
            return this._applicationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationSourceConfig. 
        /// <para>
        /// The configuration for where the application should be loaded from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ApplicationSourceConfig ApplicationSourceConfig
        {
            get { return this._applicationSourceConfig; }
            set { this._applicationSourceConfig = value; }
        }

        // Check to see if ApplicationSourceConfig property is set
        internal bool IsSetApplicationSourceConfig()
        {
            return this._applicationSourceConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="https://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property IframeConfig. 
        /// <para>
        /// The iframe configuration for the application.
        /// </para>
        /// </summary>
        public IframeConfig IframeConfig
        {
            get { return this._iframeConfig; }
            set { this._iframeConfig = value; }
        }

        // Check to see if IframeConfig property is set
        internal bool IsSetIframeConfig()
        {
            return this._iframeConfig != null;
        }

        /// <summary>
        /// Gets and sets the property InitializationTimeout. 
        /// <para>
        /// The maximum time in milliseconds allowed to establish a connection with the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=600000)]
        public int? InitializationTimeout
        {
            get { return this._initializationTimeout; }
            set { this._initializationTimeout = value; }
        }

        // Check to see if InitializationTimeout property is set
        internal bool IsSetInitializationTimeout()
        {
            return this._initializationTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsService. 
        /// <para>
        /// Indicates whether the application is a service.
        /// </para>
        /// </summary>
        public bool? IsService
        {
            get { return this._isService; }
            set { this._isService = value; }
        }

        // Check to see if IsService property is set
        internal bool IsSetIsService()
        {
            return this._isService.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// The configuration of events or requests that the application has access to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=150)]
        public List<string> Permissions
        {
            get { return this._permissions; }
            set { this._permissions = value; }
        }

        // Check to see if Permissions property is set
        internal bool IsSetPermissions()
        {
            return this._permissions != null && (this._permissions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Publications. 
        /// <para>
        /// The events that the application publishes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("Publications has been replaced with Permissions")]
        [AWSProperty(Min=0, Max=50)]
        public List<Publication> Publications
        {
            get { return this._publications; }
            set { this._publications = value; }
        }

        // Check to see if Publications property is set
        internal bool IsSetPublications()
        {
            return this._publications != null && (this._publications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Subscriptions. 
        /// <para>
        /// The events that the application subscribes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("Subscriptions has been replaced with Permissions")]
        [AWSProperty(Min=0, Max=50)]
        public List<Subscription> Subscriptions
        {
            get { return this._subscriptions; }
            set { this._subscriptions = value; }
        }

        // Check to see if Subscriptions property is set
        internal bool IsSetSubscriptions()
        {
            return this._subscriptions != null && (this._subscriptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource. For example,
        /// { "tags": {"key1":"value1", "key2":"value2"} }.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}