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
    /// Defines a validation rule that specifies custom length constraints for a specific
    /// X12 element. This rule allows you to override the standard minimum and maximum length
    /// requirements for an element, enabling validation of trading partner-specific length
    /// requirements that may differ from the X12 specification. Both minimum and maximum
    /// length values must be specified and must be between 1 and 200 characters.
    /// </summary>
    public partial class X12ElementLengthValidationRule
    {
        private string _elementId;
        private int? _maxLength;
        private int? _minLength;

        /// <summary>
        /// Gets and sets the property ElementId. 
        /// <para>
        /// Specifies the four-digit element ID to which the length constraints will be applied.
        /// This identifies which X12 element will have its length requirements modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ElementId
        {
            get { return this._elementId; }
            set { this._elementId = value; }
        }

        // Check to see if ElementId property is set
        internal bool IsSetElementId()
        {
            return this._elementId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxLength. 
        /// <para>
        /// Specifies the maximum allowed length for the identified element. This value must be
        /// between 1 and 200 characters and defines the upper limit for the element's content
        /// length.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000000)]
        public int? MaxLength
        {
            get { return this._maxLength; }
            set { this._maxLength = value; }
        }

        // Check to see if MaxLength property is set
        internal bool IsSetMaxLength()
        {
            return this._maxLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinLength. 
        /// <para>
        /// Specifies the minimum required length for the identified element. This value must
        /// be between 1 and 200 characters and defines the lower limit for the element's content
        /// length.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000000)]
        public int? MinLength
        {
            get { return this._minLength; }
            set { this._minLength = value; }
        }

        // Check to see if MinLength property is set
        internal bool IsSetMinLength()
        {
            return this._minLength.HasValue; 
        }

    }
}