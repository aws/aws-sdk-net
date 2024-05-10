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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
        private string _kendraIndex;
        private string _queryFilterString;
        private bool? _queryFilterStringEnabled;

        /// <summary>
        /// Gets and sets the property KendraIndex. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Kendra index that you want the <c>AMAZON.KendraSearchIntent</c>
        /// intent to search. The index must be in the same account and Region as the Amazon Lex
        /// bot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=32, Max=2048)]
        public string KendraIndex
        {
            get { return this._kendraIndex; }
            set { this._kendraIndex = value; }
        }

        // Check to see if KendraIndex property is set
        internal bool IsSetKendraIndex()
        {
            return this._kendraIndex != null;
        }

        /// <summary>
        /// Gets and sets the property QueryFilterString. 
        /// <para>
        /// A query filter that Amazon Lex sends to Amazon Kendra to filter the response from
        /// a query. The filter is in the format defined by Amazon Kendra. For more information,
        /// see <a href="https://docs.aws.amazon.com/kendra/latest/dg/filtering.html">Filtering
        /// queries</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5000)]
        public string QueryFilterString
        {
            get { return this._queryFilterString; }
            set { this._queryFilterString = value; }
        }

        // Check to see if QueryFilterString property is set
        internal bool IsSetQueryFilterString()
        {
            return this._queryFilterString != null;
        }

        /// <summary>
        /// Gets and sets the property QueryFilterStringEnabled. 
        /// <para>
        /// Determines whether the <c>AMAZON.KendraSearchIntent</c> intent uses a custom query
        /// string to query the Amazon Kendra index.
        /// </para>
        /// </summary>
        public bool? QueryFilterStringEnabled
        {
            get { return this._queryFilterStringEnabled; }
            set { this._queryFilterStringEnabled = value; }
        }

        // Check to see if QueryFilterStringEnabled property is set
        internal bool IsSetQueryFilterStringEnabled()
        {
            return this._queryFilterStringEnabled.HasValue; 
        }

    }
}