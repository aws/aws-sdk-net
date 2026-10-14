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
    /// The custom metadata fields that records in the registry can carry. <c>defaultSchema</c>
    /// defines the common attributes for every record type, and <c>recordTypeSchemaOverrides</c>
    /// adds fields for individual record types.
    /// </summary>
    public partial class CustomMetadataSchemaConfiguration
    {
        /// <summary>
        /// Gets and sets the property DefaultSchema. 
        /// <para>
        /// A JSON Schema with the common attributes: fields that records of every record type
        /// can carry.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 16384)]
        public string DefaultSchema { get; set; }

        /// <summary>
        /// Checks to see if the DefaultSchema property is set.
        /// </summary>
        internal bool IsSetDefaultSchema() => this.DefaultSchema != null;

        /// <summary>
        /// Gets and sets the property RecordTypeSchemaOverrides. 
        /// <para>
        /// The fields for individual record types. Records of a record type can carry the common
        /// attributes defined in <c>defaultSchema</c> plus that record type's fields.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<RecordTypeSchemaOverride> RecordTypeSchemaOverrides { get; set; } = AWSConfigs.InitializeCollections ? new List<RecordTypeSchemaOverride>() : null;

        /// <summary>
        /// Checks to see if the RecordTypeSchemaOverrides property is set.
        /// </summary>
        internal bool IsSetRecordTypeSchemaOverrides() => this.RecordTypeSchemaOverrides != null && (this.RecordTypeSchemaOverrides.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
