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

namespace Amazon.AgentRegistryControl.Model
{
    /// <summary>
    /// Configuration that defines a typed metadata schema for a registry. Specify at least
    /// one of a default schema or per-record-type schema overrides. You can provide both.
    /// </summary>
    public partial class CustomMetadataSchemaConfiguration
    {
        /// <summary>
        /// Gets and sets the property DefaultSchema. 
        /// <para>
        /// The default JSON Schema that applies to record types without a specific override.
        /// Supported property types are <c>string</c>, <c>string</c> with an <c>enum</c> constraint,
        /// <c>string</c> with a <c>uri</c> format, and <c>boolean</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 10240)]
        public string DefaultSchema { get; set; }

        /// <summary>
        /// Checks to see if the DefaultSchema property is set.
        /// </summary>
        internal bool IsSetDefaultSchema() => this.DefaultSchema != null;

        /// <summary>
        /// Gets and sets the property RecordTypeSchemaOverrides. 
        /// <para>
        /// A list of per-record-type schema overrides. When a record's type matches an override,
        /// that override's schema is used instead of the default schema for validation. If you
        /// don't specify an override for a record type, the default schema applies. If no default
        /// schema exists, custom metadata on records of that type is rejected.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 5)]
        public List<RecordTypeSchemaOverride> RecordTypeSchemaOverrides { get; set; } = AWSConfigs.InitializeCollections ? new List<RecordTypeSchemaOverride>() : null;

        /// <summary>
        /// Checks to see if the RecordTypeSchemaOverrides property is set.
        /// </summary>
        internal bool IsSetRecordTypeSchemaOverrides() => this.RecordTypeSchemaOverrides != null && (this.RecordTypeSchemaOverrides.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
