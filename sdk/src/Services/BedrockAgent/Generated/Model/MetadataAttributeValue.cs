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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Contains the value of the metadata attribute. Choose a <c>type</c> and include the
    /// field that corresponds to it.
    /// </summary>
    public partial class MetadataAttributeValue
    {
        private bool? _booleanValue;
        private double? _numberValue;
        private List<string> _stringListValue = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _stringValue;
        private MetadataValueType _type;

        /// <summary>
        /// Gets and sets the property BooleanValue. 
        /// <para>
        /// The value of the Boolean metadata attribute.
        /// </para>
        /// </summary>
        public bool? BooleanValue
        {
            get { return this._booleanValue; }
            set { this._booleanValue = value; }
        }

        // Check to see if BooleanValue property is set
        internal bool IsSetBooleanValue()
        {
            return this._booleanValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberValue. 
        /// <para>
        /// The value of the numeric metadata attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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
        /// An array of strings that define the value of the metadata attribute.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
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
        /// The value of the string metadata attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=2048)]
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

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the metadata attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MetadataValueType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}