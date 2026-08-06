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
 * Do not modify this file. This file is generated from the agent-registry-control-2025-12-01.normal.json service model.
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
namespace Amazon.AgentRegistryControl.Model
{
    /// <summary>
    /// Descriptor that defines the content of an A2A (Agent-to-Agent) agent card registry
    /// record. The content is validated against the A2A protocol schema.
    /// </summary>
    public partial class A2aAgentCardDescriptor
    {
        private string _data;
        private string _dataSchemaVersion;
        private DescriptorSource _source;

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// The A2A agent card content, serialized as descriptor payload data.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=102400)]
        public string Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        // Check to see if Data property is set
        internal bool IsSetData()
        {
            return this._data != null;
        }

        /// <summary>
        /// Gets and sets the property DataSchemaVersion. 
        /// <para>
        /// The schema version of the descriptor payload.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DataSchemaVersion
        {
            get { return this._dataSchemaVersion; }
            set { this._dataSchemaVersion = value; }
        }

        // Check to see if DataSchemaVersion property is set
        internal bool IsSetDataSchemaVersion()
        {
            return this._dataSchemaVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The optional source configuration used to synchronize the A2A agent card descriptor
        /// content.
        /// </para>
        /// </summary>
        public DescriptorSource Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}