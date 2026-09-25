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

namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// Describes the configuration for the default input values to display for a field.
    /// </summary>
    public partial class FieldInputConfig
    {
        /// <summary>
        /// Gets and sets the property DefaultChecked. 
        /// <para>
        /// Specifies whether a field has a default value.
        /// </para>
        /// </summary>
        public bool? DefaultChecked { get; set; }

        /// <summary>
        /// Checks to see if the DefaultChecked property is set.
        /// </summary>
        internal bool IsSetDefaultChecked() => this.DefaultChecked.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultCountryCode. 
        /// <para>
        /// The default country code for a phone number.
        /// </para>
        /// </summary>
        public string DefaultCountryCode { get; set; }

        /// <summary>
        /// Checks to see if the DefaultCountryCode property is set.
        /// </summary>
        internal bool IsSetDefaultCountryCode() => this.DefaultCountryCode != null;

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value for the field.
        /// </para>
        /// </summary>
        public string DefaultValue { get; set; }

        /// <summary>
        /// Checks to see if the DefaultValue property is set.
        /// </summary>
        internal bool IsSetDefaultValue() => this.DefaultValue != null;

        /// <summary>
        /// Gets and sets the property DescriptiveText. 
        /// <para>
        /// The text to display to describe the field.
        /// </para>
        /// </summary>
        public string DescriptiveText { get; set; }

        /// <summary>
        /// Checks to see if the DescriptiveText property is set.
        /// </summary>
        internal bool IsSetDescriptiveText() => this.DescriptiveText != null;

        /// <summary>
        /// Gets and sets the property FileUploaderConfig. 
        /// <para>
        /// The configuration for the file uploader field.
        /// </para>
        /// </summary>
        public FileUploaderFieldConfig FileUploaderConfig { get; set; }

        /// <summary>
        /// Checks to see if the FileUploaderConfig property is set.
        /// </summary>
        internal bool IsSetFileUploaderConfig() => this.FileUploaderConfig != null;

        /// <summary>
        /// Gets and sets the property IsArray. 
        /// <para>
        /// Specifies whether to render the field as an array. This property is ignored if the
        /// <c>dataSourceType</c> for the form is a Data Store.
        /// </para>
        /// </summary>
        public bool? IsArray { get; set; }

        /// <summary>
        /// Checks to see if the IsArray property is set.
        /// </summary>
        internal bool IsSetIsArray() => this.IsArray.HasValue;

        /// <summary>
        /// Gets and sets the property MaxValue. 
        /// <para>
        /// The maximum value to display for the field.
        /// </para>
        /// </summary>
        public float? MaxValue { get; set; }

        /// <summary>
        /// Checks to see if the MaxValue property is set.
        /// </summary>
        internal bool IsSetMaxValue() => this.MaxValue.HasValue;

        /// <summary>
        /// Gets and sets the property MinValue. 
        /// <para>
        /// The minimum value to display for the field.
        /// </para>
        /// </summary>
        public float? MinValue { get; set; }

        /// <summary>
        /// Checks to see if the MinValue property is set.
        /// </summary>
        internal bool IsSetMinValue() => this.MinValue.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the field.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Placeholder. 
        /// <para>
        /// The text to display as a placeholder for the field.
        /// </para>
        /// </summary>
        public string Placeholder { get; set; }

        /// <summary>
        /// Checks to see if the Placeholder property is set.
        /// </summary>
        internal bool IsSetPlaceholder() => this.Placeholder != null;

        /// <summary>
        /// Gets and sets the property ReadOnly. 
        /// <para>
        /// Specifies a read only field.
        /// </para>
        /// </summary>
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// Checks to see if the ReadOnly property is set.
        /// </summary>
        internal bool IsSetReadOnly() => this.ReadOnly.HasValue;

        /// <summary>
        /// Gets and sets the property Required. 
        /// <para>
        /// Specifies a field that requires input.
        /// </para>
        /// </summary>
        public bool? Required { get; set; }

        /// <summary>
        /// Checks to see if the Required property is set.
        /// </summary>
        internal bool IsSetRequired() => this.Required.HasValue;

        /// <summary>
        /// Gets and sets the property Step. 
        /// <para>
        /// The stepping increment for a numeric value in a field.
        /// </para>
        /// </summary>
        public float? Step { get; set; }

        /// <summary>
        /// Checks to see if the Step property is set.
        /// </summary>
        internal bool IsSetStep() => this.Step.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The input type for the field. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value for the field.
        /// </para>
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;

        /// <summary>
        /// Gets and sets the property ValueMappings. 
        /// <para>
        /// The information to use to customize the input fields with data at runtime.
        /// </para>
        /// </summary>
        public ValueMappings ValueMappings { get; set; }

        /// <summary>
        /// Checks to see if the ValueMappings property is set.
        /// </summary>
        internal bool IsSetValueMappings() => this.ValueMappings != null;
    }
}
