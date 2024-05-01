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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
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
namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Provides a description of the specified field.
    /// </summary>
    public partial class RegistrationFieldDefinition
    {
        private RegistrationFieldDisplayHints _displayHints;
        private string _fieldPath;
        private FieldRequirement _fieldRequirement;
        private FieldType _fieldType;
        private string _sectionPath;
        private SelectValidation _selectValidation;
        private TextValidation _textValidation;

        /// <summary>
        /// Gets and sets the property DisplayHints. 
        /// <para>
        /// An array of RegistrationFieldDisplayHints objects for the field.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RegistrationFieldDisplayHints DisplayHints
        {
            get { return this._displayHints; }
            set { this._displayHints = value; }
        }

        // Check to see if DisplayHints property is set
        internal bool IsSetDisplayHints()
        {
            return this._displayHints != null;
        }

        /// <summary>
        /// Gets and sets the property FieldPath. 
        /// <para>
        /// The path to the registration form field. You can use <a>DescribeRegistrationFieldDefinitions</a>
        /// for a list of <b>FieldPaths</b>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string FieldPath
        {
            get { return this._fieldPath; }
            set { this._fieldPath = value; }
        }

        // Check to see if FieldPath property is set
        internal bool IsSetFieldPath()
        {
            return this._fieldPath != null;
        }

        /// <summary>
        /// Gets and sets the property FieldRequirement. 
        /// <para>
        /// Specifies if the field for the registration form is required, conditional or optional.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FieldRequirement FieldRequirement
        {
            get { return this._fieldRequirement; }
            set { this._fieldRequirement = value; }
        }

        // Check to see if FieldRequirement property is set
        internal bool IsSetFieldRequirement()
        {
            return this._fieldRequirement != null;
        }

        /// <summary>
        /// Gets and sets the property FieldType. 
        /// <para>
        /// The type of field.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FieldType FieldType
        {
            get { return this._fieldType; }
            set { this._fieldType = value; }
        }

        // Check to see if FieldType property is set
        internal bool IsSetFieldType()
        {
            return this._fieldType != null;
        }

        /// <summary>
        /// Gets and sets the property SectionPath. 
        /// <para>
        /// The section path of the field.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string SectionPath
        {
            get { return this._sectionPath; }
            set { this._sectionPath = value; }
        }

        // Check to see if SectionPath property is set
        internal bool IsSetSectionPath()
        {
            return this._sectionPath != null;
        }

        /// <summary>
        /// Gets and sets the property SelectValidation. 
        /// <para>
        /// The validation rules for a select field.
        /// </para>
        /// </summary>
        public SelectValidation SelectValidation
        {
            get { return this._selectValidation; }
            set { this._selectValidation = value; }
        }

        // Check to see if SelectValidation property is set
        internal bool IsSetSelectValidation()
        {
            return this._selectValidation != null;
        }

        /// <summary>
        /// Gets and sets the property TextValidation. 
        /// <para>
        /// The validation rules for a text field.
        /// </para>
        /// </summary>
        public TextValidation TextValidation
        {
            get { return this._textValidation; }
            set { this._textValidation = value; }
        }

        // Check to see if TextValidation property is set
        internal bool IsSetTextValidation()
        {
            return this._textValidation != null;
        }

    }
}