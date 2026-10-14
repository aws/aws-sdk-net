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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Configuration for constructing filter expression strings when using the <c>FILTER_STRING</c>
    /// filter mode.
    /// </summary>
    public partial class FilterStringConfiguration
    {
        /// <summary>
        /// Gets and sets the property QueryParameterName. 
        /// <para>
        /// The query parameter name used to send the constructed filter expression string in
        /// API requests.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string QueryParameterName { get; set; }

        /// <summary>
        /// Checks to see if the QueryParameterName property is set.
        /// </summary>
        internal bool IsSetQueryParameterName() => this.QueryParameterName != null;

        /// <summary>
        /// Gets and sets the property QuoteCharacter. 
        /// <para>
        /// The character used to quote values when <c>QuoteStringValues</c> is true. Defaults
        /// to double quotes if not specified.
        /// </para>
        /// </summary>
        public string QuoteCharacter { get; set; }

        /// <summary>
        /// Checks to see if the QuoteCharacter property is set.
        /// </summary>
        internal bool IsSetQuoteCharacter() => this.QuoteCharacter != null;

        /// <summary>
        /// Gets and sets the property QuoteStringValues. 
        /// <para>
        /// Indicates whether string and date values should be wrapped with a quote character
        /// in the filter expression.
        /// </para>
        /// </summary>
        public bool? QuoteStringValues { get; set; }

        /// <summary>
        /// Checks to see if the QuoteStringValues property is set.
        /// </summary>
        internal bool IsSetQuoteStringValues() => this.QuoteStringValues.HasValue;
    }
}
