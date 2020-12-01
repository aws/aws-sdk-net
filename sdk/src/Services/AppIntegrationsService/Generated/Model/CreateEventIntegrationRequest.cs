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

namespace Amazon.AppIntegrationsService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateEventIntegration operation.
    /// The Amazon AppIntegrations APIs are in preview release and are subject to change.
    /// 
    ///  
    /// <para>
    /// Creates an EventIntegration, given a specified name, description, and a reference
    /// to an Amazon Eventbridge bus in your account and a partner event source that will
    /// push events to that bus. No objects are created in the your account, only metadata
    /// that is persisted on the EventIntegration control plane.
    /// </para>
    /// </summary>
    public partial class CreateEventIntegrationRequest : AmazonAppIntegrationsServiceRequest
    {
        private string _clientToken;
        private string _description;
        private string _eventBridgeBus;
        private EventFilter _eventFilter;
        private string _name;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
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
        /// The description of the event integration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// Gets and sets the property EventBridgeBus. 
        /// <para>
        /// The Eventbridge bus.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string EventBridgeBus
        {
            get { return this._eventBridgeBus; }
            set { this._eventBridgeBus = value; }
        }

        // Check to see if EventBridgeBus property is set
        internal bool IsSetEventBridgeBus()
        {
            return this._eventBridgeBus != null;
        }

        /// <summary>
        /// Gets and sets the property EventFilter. 
        /// <para>
        /// The event filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EventFilter EventFilter
        {
            get { return this._eventFilter; }
            set { this._eventFilter = value; }
        }

        // Check to see if EventFilter property is set
        internal bool IsSetEventFilter()
        {
            return this._eventFilter != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the event integration.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tags.
        /// </para>
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
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}