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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// Describes the configuration for the default input values to display for a field.
    /// </summary>
    public partial class FieldInputConfig
    {
        private bool? _defaultChecked;
        private string _defaultCountryCode;
        private string _defaultValue;
        private string _descriptiveText;
        private FileUploaderFieldConfig _fileUploaderConfig;
        private bool? _isArray;
        private float? _maxValue;
        private float? _minValue;
        private string _name;
        private string _placeholder;
        private bool? _readOnly;
        private bool? _required;
        private float? _step;
        private string _type;
        private string _value;
        private ValueMappings _valueMappings;

        /// <summary>
        /// Gets and sets the property DefaultChecked. 
        /// <para>
        /// Specifies whether a field has a default value.
        /// </para>
        /// </summary>
        public bool DefaultChecked
        {
            get { return this._defaultChecked.GetValueOrDefault(); }
            set { this._defaultChecked = value; }
        }

        // Check to see if DefaultChecked property is set
        internal bool IsSetDefaultChecked()
        {
            return this._defaultChecked.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultCountryCode. 
        /// <para>
        /// The default country code for a phone number.
        /// </para>
        /// </summary>
        public string DefaultCountryCode
        {
            get { return this._defaultCountryCode; }
            set { this._defaultCountryCode = value; }
        }

        // Check to see if DefaultCountryCode property is set
        internal bool IsSetDefaultCountryCode()
        {
            return this._defaultCountryCode != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value for the field.
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
        /// Gets and sets the property DescriptiveText. 
        /// <para>
        /// The text to display to describe the field.
        /// </para>
        /// </summary>
        public string DescriptiveText
        {
            get { return this._descriptiveText; }
            set { this._descriptiveText = value; }
        }

        // Check to see if DescriptiveText property is set
        internal bool IsSetDescriptiveText()
        {
            return this._descriptiveText != null;
        }

        /// <summary>
        /// Gets and sets the property FileUploaderConfig. 
        /// <para>
        /// The configuration for the file uploader field.
        /// </para>
        /// </summary>
        public FileUploaderFieldConfig FileUploaderConfig
        {
            get { return this._fileUploaderConfig; }
            set { this._fileUploaderConfig = value; }
        }

        // Check to see if FileUploaderConfig property is set
        internal bool IsSetFileUploaderConfig()
        {
            return this._fileUploaderConfig != null;
        }

        /// <summary>
        /// Gets and sets the property IsArray. 
        /// <para>
        /// Specifies whether to render the field as an array. This property is ignored if the
        /// <code>dataSourceType</code> for the form is a Data Store.
        /// </para>
        /// </summary>
        public bool IsArray
        {
            get { return this._isArray.GetValueOrDefault(); }
            set { this._isArray = value; }
        }

        // Check to see if IsArray property is set
        internal bool IsSetIsArray()
        {
            return this._isArray.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxValue. 
        /// <para>
        /// The maximum value to display for the field.
        /// </para>
        /// </summary>
        public float MaxValue
        {
            get { return this._maxValue.GetValueOrDefault(); }
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
        /// The minimum value to display for the field.
        /// </para>
        /// </summary>
        public float MinValue
        {
            get { return this._minValue.GetValueOrDefault(); }
            set { this._minValue = value; }
        }

        // Check to see if MinValue property is set
        internal bool IsSetMinValue()
        {
            return this._minValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the field.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Placeholder. 
        /// <para>
        /// The text to display as a placeholder for the field.
        /// </para>
        /// </summary>
        public string Placeholder
        {
            get { return this._placeholder; }
            set { this._placeholder = value; }
        }

        // Check to see if Placeholder property is set
        internal bool IsSetPlaceholder()
        {
            return this._placeholder != null;
        }

        /// <summary>
        /// Gets and sets the property ReadOnly. 
        /// <para>
        /// Specifies a read only field.
        /// </para>
        /// </summary>
        public bool ReadOnly
        {
            get { return this._readOnly.GetValueOrDefault(); }
            set { this._readOnly = value; }
        }

        // Check to see if ReadOnly property is set
        internal bool IsSetReadOnly()
        {
            return this._readOnly.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Required. 
        /// <para>
        /// Specifies a field that requires input.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property Step. 
        /// <para>
        /// The stepping increment for a numeric value in a field.
        /// </para>
        /// </summary>
        public float Step
        {
            get { return this._step.GetValueOrDefault(); }
            set { this._step = value; }
        }

        // Check to see if Step property is set
        internal bool IsSetStep()
        {
            return this._step.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The input type for the field. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value for the field.
        /// </para>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

        /// <summary>
        /// Gets and sets the property ValueMappings. 
        /// <para>
        /// The information to use to customize the input fields with data at runtime.
        /// </para>
        /// </summary>
        public ValueMappings ValueMappings
        {
            get { return this._valueMappings; }
            set { this._valueMappings = value; }
        }

        // Check to see if ValueMappings property is set
        internal bool IsSetValueMappings()
        {
            return this._valueMappings != null;
        }

    }
}