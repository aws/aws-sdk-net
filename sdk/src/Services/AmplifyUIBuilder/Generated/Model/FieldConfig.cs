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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// Describes the configuration information for a field in a table.
    /// </summary>
    public partial class FieldConfig
    {
        private bool? _excluded;
        private FieldInputConfig _inputType;
        private string _label;
        private FieldPosition _position;
        private List<FieldValidationConfiguration> _validations = AWSConfigs.InitializeCollections ? new List<FieldValidationConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property Excluded. 
        /// <para>
        /// Specifies whether to hide a field.
        /// </para>
        /// </summary>
        public bool? Excluded
        {
            get { return this._excluded; }
            set { this._excluded = value; }
        }

        // Check to see if Excluded property is set
        internal bool IsSetExcluded()
        {
            return this._excluded.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InputType. 
        /// <para>
        /// Describes the configuration for the default input value to display for a field.
        /// </para>
        /// </summary>
        public FieldInputConfig InputType
        {
            get { return this._inputType; }
            set { this._inputType = value; }
        }

        // Check to see if InputType property is set
        internal bool IsSetInputType()
        {
            return this._inputType != null;
        }

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// The label for the field.
        /// </para>
        /// </summary>
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }

        // Check to see if Label property is set
        internal bool IsSetLabel()
        {
            return this._label != null;
        }

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// Specifies the field position.
        /// </para>
        /// </summary>
        public FieldPosition Position
        {
            get { return this._position; }
            set { this._position = value; }
        }

        // Check to see if Position property is set
        internal bool IsSetPosition()
        {
            return this._position != null;
        }

        /// <summary>
        /// Gets and sets the property Validations. 
        /// <para>
        /// The validations to perform on the value in the field.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FieldValidationConfiguration> Validations
        {
            get { return this._validations; }
            set { this._validations = value; }
        }

        // Check to see if Validations property is set
        internal bool IsSetValidations()
        {
            return this._validations != null && (this._validations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}