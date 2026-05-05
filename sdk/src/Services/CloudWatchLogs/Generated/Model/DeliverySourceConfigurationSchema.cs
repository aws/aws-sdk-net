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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// A structure that describes a single configuration for a log type, including its name,
    /// value type, default value, and the range of supported values.
    /// </summary>
    public partial class DeliverySourceConfigurationSchema
    {
        private string _defaultValue;
        private string _keyName;
        private double? _maxValue;
        private double? _minValue;
        private List<string> _supportedValues = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DeliverySourceConfigurationSchemaValueType _valueType;

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value of the configuration that is used when a value is not specified
        /// in a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliverySource.html">PutDeliverySource</a>
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string DefaultValue
        {
            get { return this._defaultValue; }
            set { this._defaultValue = value; }
        }

        // Check to see if DefaultValue property is set
        internal bool IsSetDefaultValue()
        {
            return this._defaultValue != null;
        }

        /// <summary>
        /// Gets and sets the property KeyName. 
        /// <para>
        /// The name of the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string KeyName
        {
            get { return this._keyName; }
            set { this._keyName = value; }
        }

        // Check to see if KeyName property is set
        internal bool IsSetKeyName()
        {
            return this._keyName != null;
        }

        /// <summary>
        /// Gets and sets the property MaxValue. 
        /// <para>
        /// The maximum numeric value allowed for the configuration. This applies only when the
        /// <c>valueType</c> is a numeric type.
        /// </para>
        /// </summary>
        public double? MaxValue
        {
            get { return this._maxValue; }
            set { this._maxValue = value; }
        }

        // Check to see if MaxValue property is set
        internal bool IsSetMaxValue()
        {
            return this._maxValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinValue. 
        /// <para>
        /// The minimum numeric value allowed for the configuration. This applies only when the
        /// <c>valueType</c> is a numeric type.
        /// </para>
        /// </summary>
        public double? MinValue
        {
            get { return this._minValue; }
            set { this._minValue = value; }
        }

        // Check to see if MinValue property is set
        internal bool IsSetMinValue()
        {
            return this._minValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SupportedValues. 
        /// <para>
        /// The list of allowed values for the configuration. Empty for free-form configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedValues
        {
            get { return this._supportedValues; }
            set { this._supportedValues = value; }
        }

        // Check to see if SupportedValues property is set
        internal bool IsSetSupportedValues()
        {
            return this._supportedValues != null && (this._supportedValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ValueType. 
        /// <para>
        /// The data type of the configuration value. Valid values are <c>string</c>, <c>boolean</c>,
        /// <c>int</c>, <c>double</c>, and <c>long</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DeliverySourceConfigurationSchemaValueType ValueType
        {
            get { return this._valueType; }
            set { this._valueType = value; }
        }

        // Check to see if ValueType property is set
        internal bool IsSetValueType()
        {
            return this._valueType != null;
        }

    }
}