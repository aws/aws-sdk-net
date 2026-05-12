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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
        private DateTime? _dateTimeValue;
        private double? _numberValue;
        private List<string> _stringListValue = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _stringValue;

        /// <summary>
        /// Gets and sets the property DateTimeValue. 
        /// <para>
        /// A timestamp value in ISO 8601 UTC format.
        /// </para>
        /// </summary>
        public DateTime? DateTimeValue
        {
            get { return this._dateTimeValue; }
            set { this._dateTimeValue = value; }
        }

        // Check to see if DateTimeValue property is set
        internal bool IsSetDateTimeValue()
        {
            return this._dateTimeValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberValue. 
        /// <para>
        /// A numeric value.
        /// </para>
        /// </summary>
        public double? NumberValue
        {
            get { return this._numberValue; }
            set { this._numberValue = value; }
        }

        // Check to see if NumberValue property is set
        internal bool IsSetNumberValue()
        {
            return this._numberValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StringListValue. 
        /// <para>
        /// A list of string values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<string> StringListValue
        {
            get { return this._stringListValue; }
            set { this._stringListValue = value; }
        }

        // Check to see if StringListValue property is set
        internal bool IsSetStringListValue()
        {
            return this._stringListValue != null && (this._stringListValue.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StringValue. 
        /// <para>
        /// A string value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string StringValue
        {
            get { return this._stringValue; }
            set { this._stringValue = value; }
        }

        // Check to see if StringValue property is set
        internal bool IsSetStringValue()
        {
            return this._stringValue != null;
        }

    }
}