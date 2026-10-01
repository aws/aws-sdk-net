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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// The value of a document attribute. You can only provide one value for a document attribute.
    /// </summary>
    public partial class DocumentAttributeValue
    {
        /// <summary>
        /// Gets and sets the property DateValue. 
        /// <para>
        /// A date expressed as an ISO 8601 string.
        /// </para>
        ///  
        /// <para>
        /// It's important for the time zone to be included in the ISO 8601 date-time format.
        /// For example, 2012-03-25T12:30:10+01:00 is the ISO 8601 date-time format for March
        /// 25th 2012 at 12:30PM (plus 10 seconds) in Central European Time. 
        /// </para>
        /// </summary>
        public DateTime? DateValue { get; set; }

        /// <summary>
        /// Checks to see if the DateValue property is set.
        /// </summary>
        internal bool IsSetDateValue() => this.DateValue.HasValue;

        /// <summary>
        /// Gets and sets the property LongValue. 
        /// <para>
        /// A long integer value. 
        /// </para>
        /// </summary>
        public long? LongValue { get; set; }

        /// <summary>
        /// Checks to see if the LongValue property is set.
        /// </summary>
        internal bool IsSetLongValue() => this.LongValue.HasValue;

        /// <summary>
        /// Gets and sets the property StringListValue. 
        /// <para>
        /// A list of strings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> StringListValue { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StringListValue property is set.
        /// </summary>
        internal bool IsSetStringListValue() => this.StringListValue != null && (this.StringListValue.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StringValue. 
        /// <para>
        /// A string.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 2048)]
        public string StringValue { get; set; }

        /// <summary>
        /// Checks to see if the StringValue property is set.
        /// </summary>
        internal bool IsSetStringValue() => this.StringValue != null;
    }
}
