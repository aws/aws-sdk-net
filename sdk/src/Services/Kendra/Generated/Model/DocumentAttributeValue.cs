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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// The value of a document attribute. You can only provide one value for a document attribute.
    /// </summary>
    public partial class DocumentAttributeValue
    {
        private DateTime? _dateValue;
        private long? _longValue;
        private List<string> _stringListValue = new List<string>();
        private string _stringValue;

        /// <summary>
        /// Gets and sets the property DateValue. 
        /// <para>
        /// A date expressed as an ISO 8601 string.
        /// </para>
        ///  
        /// <para>
        /// It is important for the time zone to be included in the ISO 8601 date-time format.
        /// For example, 2012-03-25T12:30:10+01:00 is the ISO 8601 date-time format for March
        /// 25th 2012 at 12:30PM (plus 10 seconds) in Central European Time.
        /// </para>
        /// </summary>
        public DateTime DateValue
        {
            get { return this._dateValue.GetValueOrDefault(); }
            set { this._dateValue = value; }
        }

        // Check to see if DateValue property is set
        internal bool IsSetDateValue()
        {
            return this._dateValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LongValue. 
        /// <para>
        /// A long integer value.
        /// </para>
        /// </summary>
        public long LongValue
        {
            get { return this._longValue.GetValueOrDefault(); }
            set { this._longValue = value; }
        }

        // Check to see if LongValue property is set
        internal bool IsSetLongValue()
        {
            return this._longValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StringListValue. 
        /// <para>
        /// A list of strings. The default maximum length or number of strings is 10.
        /// </para>
        /// </summary>
        public List<string> StringListValue
        {
            get { return this._stringListValue; }
            set { this._stringListValue = value; }
        }

        // Check to see if StringListValue property is set
        internal bool IsSetStringListValue()
        {
            return this._stringListValue != null && this._stringListValue.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StringValue. 
        /// <para>
        /// A string, such as "department".
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string StringValue
        {
            get { return this._stringValue; }
            set { this._stringValue = value; }
        }

        // Check to see if StringValue property is set
        internal bool IsSetStringValue()
        {
            return this._stringValue != null;
        }

    }
}