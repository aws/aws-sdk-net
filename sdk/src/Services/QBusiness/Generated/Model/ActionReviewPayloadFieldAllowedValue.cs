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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Information about the field values that an end user can use to provide to Amazon Q
    /// Business for Amazon Q Business to perform the requested plugin action.
    /// </summary>
    public partial class ActionReviewPayloadFieldAllowedValue
    {
        private Amazon.Runtime.Documents.Document _displayValue;
        private Amazon.Runtime.Documents.Document _value;

        /// <summary>
        /// Gets and sets the property DisplayValue. 
        /// <para>
        /// The name of the field.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document DisplayValue
        {
            get { return this._displayValue; }
            set { this._displayValue = value; }
        }

        // Check to see if DisplayValue property is set
        internal bool IsSetDisplayValue()
        {
            return !this._displayValue.IsNull();
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The field value.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return !this._value.IsNull();
        }

    }
}