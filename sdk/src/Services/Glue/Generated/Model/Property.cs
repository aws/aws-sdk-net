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
    /// An object that defines a connection type for a compute environment.
    /// </summary>
    public partial class Property
    {
        private List<AllowedValue> _allowedValues = AWSConfigs.InitializeCollections ? new List<AllowedValue>() : null;
        private List<string> _dataOperationScopes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _defaultValue;
        private string _description;
        private string _keyOverride;
        private string _name;
        private PropertyLocation _propertyLocation;
        private List<string> _propertyTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _required;

        /// <summary>
        /// Gets and sets the property AllowedValues. 
        /// <para>
        /// A list of <c>AllowedValue</c> objects representing the values allowed for the property.
        /// </para>
        /// </summary>
        public List<AllowedValue> AllowedValues
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
        /// Gets and sets the property DataOperationScopes. 
        /// <para>
        /// Indicates which data operations are applicable to the property.
        /// </para>
        /// </summary>
        public List<string> DataOperationScopes
        {
            get { return this._dataOperationScopes; }
            set { this._dataOperationScopes = value; }
        }

        // Check to see if DataOperationScopes property is set
        internal bool IsSetDataOperationScopes()
        {
            return this._dataOperationScopes != null && (this._dataOperationScopes.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the property.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property KeyOverride. 
        /// <para>
        /// A key name to use when sending this property in API requests, if different from the
        /// display name.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property PropertyTypes. 
        /// <para>
        /// Describes the type of property.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> PropertyTypes
        {
            get { return this._propertyTypes; }
            set { this._propertyTypes = value; }
        }

        // Check to see if PropertyTypes property is set
        internal bool IsSetPropertyTypes()
        {
            return this._propertyTypes != null && (this._propertyTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Required. 
        /// <para>
        /// Indicates whether the property is required.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool Required
        {
            get { return this._required.GetValueOrDefault(); }
            set { this._required = value; }
        }

        // Check to see if Required property is set
        internal bool IsSetRequired()
        {
            return this._required.HasValue; 
        }

    }
}