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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
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
namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// Structure representing one schema item associated with a managed thing.
    /// </summary>
    public partial class ManagedThingSchemaListItem
    {
        private string _capabilityId;
        private string _endpointId;
        private Amazon.Runtime.Documents.Document _schema;

        /// <summary>
        /// Gets and sets the property CapabilityId. 
        /// <para>
        /// The id of the capability for a managed thing.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string CapabilityId
        {
            get { return this._capabilityId; }
            set { this._capabilityId = value; }
        }

        // Check to see if CapabilityId property is set
        internal bool IsSetCapabilityId()
        {
            return this._capabilityId != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointId. 
        /// <para>
        /// The id of the endpoint for a managed thing.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string EndpointId
        {
            get { return this._endpointId; }
            set { this._endpointId = value; }
        }

        // Check to see if EndpointId property is set
        internal bool IsSetEndpointId()
        {
            return this._endpointId != null;
        }

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// The validation schema for one schema item associated with a managed thing.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document Schema
        {
            get { return this._schema; }
            set { this._schema = value; }
        }

        // Check to see if Schema property is set
        internal bool IsSetSchema()
        {
            return !this._schema.IsNull();
        }

    }
}