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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
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
    /// Contains configuration options for X12 EDI validation. This structure allows you to
    /// specify custom validation rules that will be applied during EDI document processing,
    /// including element length constraints, code list modifications, and element requirement
    /// changes. These validation options provide flexibility to accommodate trading partner-specific
    /// requirements while maintaining EDI compliance. The validation rules are applied in
    /// addition to standard X12 validation to ensure documents meet both standard and custom
    /// requirements.
    /// </summary>
    public partial class X12ValidationOptions
    {
        private List<X12ValidationRule> _validationRules = AWSConfigs.InitializeCollections ? new List<X12ValidationRule>() : null;

        /// <summary>
        /// Gets and sets the property ValidationRules. 
        /// <para>
        /// Specifies a list of validation rules to apply during EDI document processing. These
        /// rules can include code list modifications, element length constraints, and element
        /// requirement changes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<X12ValidationRule> ValidationRules
        {
            get { return this._validationRules; }
            set { this._validationRules = value; }
        }

        // Check to see if ValidationRules property is set
        internal bool IsSetValidationRules()
        {
            return this._validationRules != null && (this._validationRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}