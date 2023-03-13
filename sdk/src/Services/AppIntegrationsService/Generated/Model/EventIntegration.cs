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
    /// The event integration.
    /// </summary>
    public partial class EventIntegration
    {
        private string _description;
        private string _eventBridgeBus;
        private EventFilter _eventFilter;
        private string _eventIntegrationArn;
        private string _name;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The event integration description.
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
        /// The Amazon EventBridge bus for the event integration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// The event integration filter.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property EventIntegrationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the event integration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string EventIntegrationArn
        {
            get { return this._eventIntegrationArn; }
            set { this._eventIntegrationArn = value; }
        }

        // Check to see if EventIntegrationArn property is set
        internal bool IsSetEventIntegrationArn()
        {
            return this._eventIntegrationArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the event integration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// The tags used to organize, track, or control access for this resource. For example,
        /// { "tags": {"key1":"value1", "key2":"value2"} }.
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