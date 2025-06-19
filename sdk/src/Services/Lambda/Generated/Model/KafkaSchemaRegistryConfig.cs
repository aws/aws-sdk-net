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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Specific configuration settings for a Kafka schema registry.
    /// </summary>
    public partial class KafkaSchemaRegistryConfig
    {
        private List<KafkaSchemaRegistryAccessConfig> _accessConfigs = AWSConfigs.InitializeCollections ? new List<KafkaSchemaRegistryAccessConfig>() : null;
        private SchemaRegistryEventRecordFormat _eventRecordFormat;
        private string _schemaRegistryURI;
        private List<KafkaSchemaValidationConfig> _schemaValidationConfigs = AWSConfigs.InitializeCollections ? new List<KafkaSchemaValidationConfig>() : null;

        /// <summary>
        /// Gets and sets the property AccessConfigs. 
        /// <para>
        /// An array of access configuration objects that tell Lambda how to authenticate with
        /// your schema registry.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<KafkaSchemaRegistryAccessConfig> AccessConfigs
        {
            get { return this._accessConfigs; }
            set { this._accessConfigs = value; }
        }

        // Check to see if AccessConfigs property is set
        internal bool IsSetAccessConfigs()
        {
            return this._accessConfigs != null && (this._accessConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EventRecordFormat. 
        /// <para>
        /// The record format that Lambda delivers to your function after schema validation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Choose <c>JSON</c> to have Lambda deliver the record to your function as a standard
        /// JSON object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Choose <c>SOURCE</c> to have Lambda deliver the record to your function in its original
        /// source format. Lambda removes all schema metadata, such as the schema ID, before sending
        /// the record to your function.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SchemaRegistryEventRecordFormat EventRecordFormat
        {
            get { return this._eventRecordFormat; }
            set { this._eventRecordFormat = value; }
        }

        // Check to see if EventRecordFormat property is set
        internal bool IsSetEventRecordFormat()
        {
            return this._eventRecordFormat != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaRegistryURI. 
        /// <para>
        /// The URI for your schema registry. The correct URI format depends on the type of schema
        /// registry you're using.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For Glue schema registries, use the ARN of the registry.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Confluent schema registries, use the URL of the registry.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
        public string SchemaRegistryURI
        {
            get { return this._schemaRegistryURI; }
            set { this._schemaRegistryURI = value; }
        }

        // Check to see if SchemaRegistryURI property is set
        internal bool IsSetSchemaRegistryURI()
        {
            return this._schemaRegistryURI != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaValidationConfigs. 
        /// <para>
        /// An array of schema validation configuration objects, which tell Lambda the message
        /// attributes you want to validate and filter using your schema registry.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<KafkaSchemaValidationConfig> SchemaValidationConfigs
        {
            get { return this._schemaValidationConfigs; }
            set { this._schemaValidationConfigs = value; }
        }

        // Check to see if SchemaValidationConfigs property is set
        internal bool IsSetSchemaValidationConfigs()
        {
            return this._schemaValidationConfigs != null && (this._schemaValidationConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}