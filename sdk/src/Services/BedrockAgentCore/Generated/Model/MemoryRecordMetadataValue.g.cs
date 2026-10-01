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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// The value of a memory record metadata entry.
    /// </summary>
    public partial class MemoryRecordMetadataValue
    {
        /// <summary>
        /// Gets and sets the property DateTimeValue. 
        /// <para>
        /// A timestamp value in ISO 8601 UTC format.
        /// </para>
        /// </summary>
        public DateTime? DateTimeValue { get; set; }

        /// <summary>
        /// Checks to see if the DateTimeValue property is set.
        /// </summary>
        internal bool IsSetDateTimeValue() => this.DateTimeValue.HasValue;

        /// <summary>
        /// Gets and sets the property NumberValue. 
        /// <para>
        /// A numeric value.
        /// </para>
        /// </summary>
        public double? NumberValue { get; set; }

        /// <summary>
        /// Checks to see if the NumberValue property is set.
        /// </summary>
        internal bool IsSetNumberValue() => this.NumberValue.HasValue;

        /// <summary>
        /// Gets and sets the property StringListValue. 
        /// <para>
        /// A list of string values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<string> StringListValue { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StringListValue property is set.
        /// </summary>
        internal bool IsSetStringListValue() => this.StringListValue != null && (this.StringListValue.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StringValue. 
        /// <para>
        /// A string value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string StringValue { get; set; }

        /// <summary>
        /// Checks to see if the StringValue property is set.
        /// </summary>
        internal bool IsSetStringValue() => this.StringValue != null;
    }
}
