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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The formatting configuration for all types of field.
    /// </summary>
    public partial class FormatConfiguration
    {
        /// <summary>
        /// Gets and sets the property DateTimeFormatConfiguration. 
        /// <para>
        /// Formatting configuration for <c>DateTime</c> fields.
        /// </para>
        /// </summary>
        public DateTimeFormatConfiguration DateTimeFormatConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DateTimeFormatConfiguration property is set.
        /// </summary>
        internal bool IsSetDateTimeFormatConfiguration() => this.DateTimeFormatConfiguration != null;

        /// <summary>
        /// Gets and sets the property NumberFormatConfiguration. 
        /// <para>
        /// Formatting configuration for number fields.
        /// </para>
        /// </summary>
        public NumberFormatConfiguration NumberFormatConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NumberFormatConfiguration property is set.
        /// </summary>
        internal bool IsSetNumberFormatConfiguration() => this.NumberFormatConfiguration != null;

        /// <summary>
        /// Gets and sets the property StringFormatConfiguration. 
        /// <para>
        /// Formatting configuration for string fields.
        /// </para>
        /// </summary>
        public StringFormatConfiguration StringFormatConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the StringFormatConfiguration property is set.
        /// </summary>
        internal bool IsSetStringFormatConfiguration() => this.StringFormatConfiguration != null;
    }
}
