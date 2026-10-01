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

namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// Structure representing a capability schema item that defines the functionality and
    /// features supported by a managed thing.
    /// </summary>
    public partial class CapabilitySchemaItem
    {
        /// <summary>
        /// Gets and sets the property CapabilityId. 
        /// <para>
        /// The unique identifier of the capability defined in the schema.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 7, Max = 128)]
        public string CapabilityId { get; set; }

        /// <summary>
        /// Checks to see if the CapabilityId property is set.
        /// </summary>
        internal bool IsSetCapabilityId() => this.CapabilityId != null;

        /// <summary>
        /// Gets and sets the property ExtrinsicId. 
        /// <para>
        /// The external identifier for the capability, used when referencing the capability outside
        /// of the AWS ecosystem.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public string ExtrinsicId { get; set; }

        /// <summary>
        /// Checks to see if the ExtrinsicId property is set.
        /// </summary>
        internal bool IsSetExtrinsicId() => this.ExtrinsicId != null;

        /// <summary>
        /// Gets and sets the property ExtrinsicVersion. 
        /// <para>
        /// The version of the external capability definition, used to track compatibility with
        /// external systems.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public int? ExtrinsicVersion { get; set; }

        /// <summary>
        /// Checks to see if the ExtrinsicVersion property is set.
        /// </summary>
        internal bool IsSetExtrinsicVersion() => this.ExtrinsicVersion.HasValue;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the capability schema, which defines how the schema is structured and
        /// interpreted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SchemaVersionFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// The actual schema definition that describes the capability's properties, actions,
        /// and events.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Amazon.Runtime.Documents.Document Schema { get; set; }

        /// <summary>
        /// Checks to see if the Schema property is set.
        /// </summary>
        internal bool IsSetSchema() => !this.Schema.IsNull();
    }
}
