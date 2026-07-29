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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
        private string _queryParameterName;
        private string _quoteCharacter;
        private bool? _quoteStringValues;

        /// <summary>
        /// Gets and sets the property QueryParameterName. 
        /// <para>
        /// The query parameter name used to send the constructed filter expression string in
        /// API requests.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string QueryParameterName
        {
            get { return this._queryParameterName; }
            set { this._queryParameterName = value; }
        }

        // Check to see if QueryParameterName property is set
        internal bool IsSetQueryParameterName()
        {
            return this._queryParameterName != null;
        }

        /// <summary>
        /// Gets and sets the property QuoteCharacter. 
        /// <para>
        /// The character used to quote values when <c>QuoteStringValues</c> is true. Defaults
        /// to double quotes if not specified.
        /// </para>
        /// </summary>
        public string QuoteCharacter
        {
            get { return this._quoteCharacter; }
            set { this._quoteCharacter = value; }
        }

        // Check to see if QuoteCharacter property is set
        internal bool IsSetQuoteCharacter()
        {
            return this._quoteCharacter != null;
        }

        /// <summary>
        /// Gets and sets the property QuoteStringValues. 
        /// <para>
        /// Indicates whether string and date values should be wrapped with a quote character
        /// in the filter expression.
        /// </para>
        /// </summary>
        public bool? QuoteStringValues
        {
            get { return this._quoteStringValues; }
            set { this._quoteStringValues = value; }
        }

        // Check to see if QuoteStringValues property is set
        internal bool IsSetQuoteStringValues()
        {
            return this._quoteStringValues.HasValue; 
        }

    }
}