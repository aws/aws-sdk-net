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
    /// Performs an Amazon Q Business plugin action during a non-streaming chat conversation.
    /// </summary>
    public partial class ActionExecution
    {
        private Dictionary<string, ActionExecutionPayloadField> _payload = AWSConfigs.InitializeCollections ? new Dictionary<string, ActionExecutionPayloadField>() : null;
        private string _payloadFieldNameSeparator;
        private string _pluginId;

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// A mapping of field names to the field values in input that an end user provides to
        /// Amazon Q Business requests to perform their plugin action. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, ActionExecutionPayloadField> Payload
        {
            get { return this._payload; }
            set { this._payload = value; }
        }

        // Check to see if Payload property is set
        internal bool IsSetPayload()
        {
            return this._payload != null && (this._payload.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PayloadFieldNameSeparator. 
        /// <para>
        /// A string used to retain information about the hierarchical contexts within an action
        /// execution event payload.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public string PayloadFieldNameSeparator
        {
            get { return this._payloadFieldNameSeparator; }
            set { this._payloadFieldNameSeparator = value; }
        }

        // Check to see if PayloadFieldNameSeparator property is set
        internal bool IsSetPayloadFieldNameSeparator()
        {
            return this._payloadFieldNameSeparator != null;
        }

        /// <summary>
        /// Gets and sets the property PluginId. 
        /// <para>
        /// The identifier of the plugin the action is attached to.
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

    }
}