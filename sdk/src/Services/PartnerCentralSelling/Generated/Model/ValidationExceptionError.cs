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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Indicates an invalid value for a field.
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <i>REQUIRED_FIELD_MISSING:</i> The request is missing a required field.
    /// </para>
    ///  
    /// <para>
    /// Fix: Verify your request payload includes all required fields.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>INVALID_ENUM_VALUE:</i> The enum field value isn't an accepted values.
    /// </para>
    ///  
    /// <para>
    /// Fix: Check the documentation for the list of valid enum values, and update your request
    /// with a valid value.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>INVALID_STRING_FORMAT:</i> The string format is invalid.
    /// </para>
    ///  
    /// <para>
    /// Fix: Confirm that the string is in the expected format (For example: email address,
    /// date).
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>INVALID_VALUE:</i> The value isn't valid.
    /// </para>
    ///  
    /// <para>
    /// Fix: Confirm that the value meets the expected criteria and is within the allowable
    /// range or set.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>TOO_MANY_VALUES:</i> There are too many values in a field that expects fewer entries.
    /// </para>
    ///  
    /// <para>
    /// Fix: Reduce the number of values to match the expected limit.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>ACTION_NOT_PERMITTED:</i> The action isn't permitted due to current state or permissions.
    /// </para>
    ///  
    /// <para>
    /// Fix: Verify that the action is appropriate for the current state, and that you have
    /// the necessary permissions to perform it.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>DUPLICATE_KEY_VALUE:</i> The value in a field duplicates a value that must be
    /// unique.
    /// </para>
    ///  
    /// <para>
    /// Fix: Verify that the value is unique and doesn't duplicate an existing value in the
    /// system.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ValidationExceptionError
    {
        private ValidationExceptionErrorCode _code;
        private string _fieldName;
        private string _message;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// Specifies the error code for the invalid field value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ValidationExceptionErrorCode Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property FieldName. 
        /// <para>
        /// Specifies the field name with the invalid value.
        /// </para>
        /// </summary>
        public string FieldName
        {
            get { return this._fieldName; }
            set { this._fieldName = value; }
        }

        // Check to see if FieldName property is set
        internal bool IsSetFieldName()
        {
            return this._fieldName != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Specifies the detailed error message for the invalid field value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

    }
}