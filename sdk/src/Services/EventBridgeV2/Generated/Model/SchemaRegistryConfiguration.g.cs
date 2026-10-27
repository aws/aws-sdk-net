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

namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// Schema registry settings used to encode open-format (Avro/Protobuf) events.
    /// </summary>
    public partial class SchemaRegistryConfiguration
    {
        /// <summary>
        /// Gets and sets the property ConfluentPublicRegistryConfiguration. Required when RegistryUri
        /// is an HTTPS URL. Provides Connection-based auth for Confluent Cloud.
        /// </summary>
        public ConfluentPublicRegistryConfiguration ConfluentPublicRegistryConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ConfluentPublicRegistryConfiguration property is set.
        /// </summary>
        internal bool IsSetConfluentPublicRegistryConfiguration() => this.ConfluentPublicRegistryConfiguration != null;

        /// <summary>
        /// Gets and sets the property RegistryUri. Glue Schema Registry ARN, or Confluent Cloud
        /// HTTPS URL.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string RegistryUri { get; set; }

        /// <summary>
        /// Checks to see if the RegistryUri property is set.
        /// </summary>
        internal bool IsSetRegistryUri() => this.RegistryUri != null;
    }
}
