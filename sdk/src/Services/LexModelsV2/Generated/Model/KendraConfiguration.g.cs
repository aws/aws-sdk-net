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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Provides configuration information for the <c>AMAZON.KendraSearchIntent</c> intent.
    /// When you use this intent, Amazon Lex searches the specified Amazon Kendra index and
    /// returns documents from the index that match the user's utterance.
    /// </summary>
    public partial class KendraConfiguration
    {
        /// <summary>
        /// Gets and sets the property KendraIndex. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Kendra index that you want the <c>AMAZON.KendraSearchIntent</c>
        /// intent to search. The index must be in the same account and Region as the Amazon Lex
        /// bot.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 32, Max = 2048)]
        public string KendraIndex { get; set; }

        /// <summary>
        /// Checks to see if the KendraIndex property is set.
        /// </summary>
        internal bool IsSetKendraIndex() => this.KendraIndex != null;

        /// <summary>
        /// Gets and sets the property QueryFilterString. 
        /// <para>
        /// A query filter that Amazon Lex sends to Amazon Kendra to filter the response from
        /// a query. The filter is in the format defined by Amazon Kendra. For more information,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/filtering.html">Filtering
        /// queries</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5000)]
        public string QueryFilterString { get; set; }

        /// <summary>
        /// Checks to see if the QueryFilterString property is set.
        /// </summary>
        internal bool IsSetQueryFilterString() => this.QueryFilterString != null;

        /// <summary>
        /// Gets and sets the property QueryFilterStringEnabled. 
        /// <para>
        /// Determines whether the <c>AMAZON.KendraSearchIntent</c> intent uses a custom query
        /// string to query the Amazon Kendra index.
        /// </para>
        /// </summary>
        public bool? QueryFilterStringEnabled { get; set; }

        /// <summary>
        /// Checks to see if the QueryFilterStringEnabled property is set.
        /// </summary>
        internal bool IsSetQueryFilterStringEnabled() => this.QueryFilterStringEnabled.HasValue;
    }
}
