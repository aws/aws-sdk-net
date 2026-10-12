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

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Provides a description of the specified field.
    /// </summary>
    public partial class RegistrationFieldDefinition
    {
        /// <summary>
        /// Gets and sets the property ConditionalBehavior. 
        /// <para>
        /// The conditional behavior rules for this field. Only present when <b>FieldRequirement</b>
        /// is <b>CONDITIONAL</b>. Rules are evaluated in order and the first matching rule determines
        /// the field's resolved requirement. If no rule matches, the <b>DefaultBehavior</b> applies.
        /// </para>
        /// </summary>
        public ConditionalBehavior ConditionalBehavior { get; set; }

        /// <summary>
        /// Checks to see if the ConditionalBehavior property is set.
        /// </summary>
        internal bool IsSetConditionalBehavior() => this.ConditionalBehavior != null;

        /// <summary>
        /// Gets and sets the property DisplayHints. 
        /// <para>
        /// An array of RegistrationFieldDisplayHints objects for the field.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RegistrationFieldDisplayHints DisplayHints { get; set; }

        /// <summary>
        /// Checks to see if the DisplayHints property is set.
        /// </summary>
        internal bool IsSetDisplayHints() => this.DisplayHints != null;

        /// <summary>
        /// Gets and sets the property FieldPath. 
        /// <para>
        /// The path to the registration form field. You can use <a>DescribeRegistrationFieldDefinitions</a>
        /// for a list of <b>FieldPaths</b>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string FieldPath { get; set; }

        /// <summary>
        /// Checks to see if the FieldPath property is set.
        /// </summary>
        internal bool IsSetFieldPath() => this.FieldPath != null;

        /// <summary>
        /// Gets and sets the property FieldRequirement. 
        /// <para>
        /// Specifies if the field for the registration form is required, conditional or optional.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FieldRequirement FieldRequirement { get; set; }

        /// <summary>
        /// Checks to see if the FieldRequirement property is set.
        /// </summary>
        internal bool IsSetFieldRequirement() => this.FieldRequirement != null;

        /// <summary>
        /// Gets and sets the property FieldType. 
        /// <para>
        /// The type of field.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FieldType FieldType { get; set; }

        /// <summary>
        /// Checks to see if the FieldType property is set.
        /// </summary>
        internal bool IsSetFieldType() => this.FieldType != null;

        /// <summary>
        /// Gets and sets the property SectionPath. 
        /// <para>
        /// The section path of the field.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string SectionPath { get; set; }

        /// <summary>
        /// Checks to see if the SectionPath property is set.
        /// </summary>
        internal bool IsSetSectionPath() => this.SectionPath != null;

        /// <summary>
        /// Gets and sets the property SelectValidation. 
        /// <para>
        /// The validation rules for a select field.
        /// </para>
        /// </summary>
        public SelectValidation SelectValidation { get; set; }

        /// <summary>
        /// Checks to see if the SelectValidation property is set.
        /// </summary>
        internal bool IsSetSelectValidation() => this.SelectValidation != null;

        /// <summary>
        /// Gets and sets the property TextValidation. 
        /// <para>
        /// The validation rules for a text field.
        /// </para>
        /// </summary>
        public TextValidation TextValidation { get; set; }

        /// <summary>
        /// Checks to see if the TextValidation property is set.
        /// </summary>
        internal bool IsSetTextValidation() => this.TextValidation != null;
    }
}
