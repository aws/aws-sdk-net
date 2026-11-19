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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// The value that a leaf condition compares against. Specify one of the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>StringValue</c>: A single string, used with <c>EqualsTo</c>, <c>ContainsAny</c>,
    /// and <c>ContainsAll</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>StringListValue</c>: A list of strings, used with <c>ContainsAny</c> and <c>ContainsAll</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DateValue</c>: A date and time, used with range comparisons on date fields.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>LongValue</c>: A whole number, used with range comparisons on numeric fields.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class EngagementSearchFilterValue
    {
        /// <summary>
        /// Gets and sets the property DateValue. 
        /// <para>
        /// A date-time value in RFC 3339 format, used by the range comparisons on date fields.
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
        /// An integral numeric value, used by the range comparisons on numeric fields.
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
        /// A list of 1 to 20 string values, used by <c>ContainsAny</c> and <c>ContainsAll</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public List<string> StringListValue { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StringListValue property is set.
        /// </summary>
        internal bool IsSetStringListValue() => this.StringListValue != null && (this.StringListValue.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StringValue. 
        /// <para>
        /// A single string value, used by <c>EqualsTo</c>, <c>ContainsAny</c>, and <c>ContainsAll</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public string StringValue { get; set; }

        /// <summary>
        /// Checks to see if the StringValue property is set.
        /// </summary>
        internal bool IsSetStringValue() => this.StringValue != null;
    }
}
