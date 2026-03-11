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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Defines a property configuration for connection types, default values, and where the
    /// property should be used in requests.
    /// </summary>
    public partial class ConnectorProperty
    {
        private List<string> _allowedValues = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _defaultValue;
        private string _keyOverride;
        private string _name;
        private PropertyLocation _propertyLocation;
        private PropertyType _propertyType;
        private bool? _required;

        /// <summary>
        /// Gets and sets the property AllowedValues. 
        /// <para>
        /// A list of <c>AllowedValue</c> objects representing the values allowed for the property.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowedValues
        {
            get { return this._allowedValues; }
            set { this._allowedValues = value; }
        }

        // Check to see if AllowedValues property is set
        internal bool IsSetAllowedValues()
        {
            return this._allowedValues != null && (this._allowedValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value for the property.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property KeyOverride. 
        /// <para>
        /// A key name to use when sending this property in API requests, if different from the
        /// display name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string KeyOverride
        {
            get { return this._keyOverride; }
            set { this._keyOverride = value; }
        }

        // Check to see if KeyOverride property is set
        internal bool IsSetKeyOverride()
        {
            return this._keyOverride != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the property.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PropertyLocation. 
        /// <para>
        /// Specifies where this property should be included in REST requests, such as in headers,
        /// query parameters, or request body.
        /// </para>
        /// </summary>
        public PropertyLocation PropertyLocation
        {
            get { return this._propertyLocation; }
            set { this._propertyLocation = value; }
        }

        // Check to see if PropertyLocation property is set
        internal bool IsSetPropertyLocation()
        {
            return this._propertyLocation != null;
        }

        /// <summary>
        /// Gets and sets the property PropertyType. 
        /// <para>
        /// The data type of this property
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PropertyType PropertyType
        {
            get { return this._propertyType; }
            set { this._propertyType = value; }
        }

        // Check to see if PropertyType property is set
        internal bool IsSetPropertyType()
        {
            return this._propertyType != null;
        }

        /// <summary>
        /// Gets and sets the property Required. 
        /// <para>
        /// Indicates whether the property is required.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Required
        {
            get { return this._required; }
            set { this._required = value; }
        }

        // Check to see if Required property is set
        internal bool IsSetRequired()
        {
            return this._required.HasValue; 
        }

    }
}