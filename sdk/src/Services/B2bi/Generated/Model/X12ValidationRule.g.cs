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

namespace Amazon.B2bi.Model
{
    /// <summary>
    /// Represents a single validation rule that can be applied during X12 EDI processing.
    /// This is a union type that can contain one of several specific validation rule types:
    /// code list validation rules for modifying allowed element codes, element length validation
    /// rules for enforcing custom length constraints, or element requirement validation rules
    /// for changing mandatory/optional status. Each validation rule targets specific aspects
    /// of EDI document validation to ensure compliance with trading partner requirements
    /// and business rules.
    /// </summary>
    public partial class X12ValidationRule
    {
        /// <summary>
        /// Gets and sets the property CodeListValidationRule. 
        /// <para>
        /// Specifies a code list validation rule that modifies the allowed code values for a
        /// specific X12 element. This rule enables you to customize which codes are considered
        /// valid for an element, allowing for trading partner-specific code requirements.
        /// </para>
        /// </summary>
        public X12CodeListValidationRule CodeListValidationRule { get; set; }

        /// <summary>
        /// Checks to see if the CodeListValidationRule property is set.
        /// </summary>
        internal bool IsSetCodeListValidationRule() => this.CodeListValidationRule != null;

        /// <summary>
        /// Gets and sets the property ElementLengthValidationRule. 
        /// <para>
        /// Specifies an element length validation rule that defines custom length constraints
        /// for a specific X12 element. This rule allows you to enforce minimum and maximum length
        /// requirements that may differ from the standard X12 specification.
        /// </para>
        /// </summary>
        public X12ElementLengthValidationRule ElementLengthValidationRule { get; set; }

        /// <summary>
        /// Checks to see if the ElementLengthValidationRule property is set.
        /// </summary>
        internal bool IsSetElementLengthValidationRule() => this.ElementLengthValidationRule != null;

        /// <summary>
        /// Gets and sets the property ElementRequirementValidationRule. 
        /// <para>
        /// Specifies an element requirement validation rule that modifies whether a specific
        /// X12 element is required or optional within a segment. This rule provides flexibility
        /// to accommodate different trading partner requirements for element presence.
        /// </para>
        /// </summary>
        public X12ElementRequirementValidationRule ElementRequirementValidationRule { get; set; }

        /// <summary>
        /// Checks to see if the ElementRequirementValidationRule property is set.
        /// </summary>
        internal bool IsSetElementRequirementValidationRule() => this.ElementRequirementValidationRule != null;
    }
}
