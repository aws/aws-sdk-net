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

namespace Amazon.SecurityIR.Model
{
    /// <summary>
    /// Represents a single metadata entry associated with a case. Each entry consists of
    /// a key-value pair that provides additional contextual information about the case, such
    /// as classification tags, custom attributes, or system-generated properties.
    /// </summary>
    public partial class CaseMetadataEntry
    {
        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The identifier for the metadata field. This key uniquely identifies the type of metadata
        /// being stored, such as "severity", "category", or "assignee".
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value associated with the metadata key. This contains the actual data for the
        /// metadata field identified by the key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2000)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
