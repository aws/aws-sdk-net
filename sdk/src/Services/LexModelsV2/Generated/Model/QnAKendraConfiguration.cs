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
    /// Contains details about the configuration of the Amazon Kendra index used for the <c>AMAZON.QnAIntent</c>.
    /// </summary>
    public partial class QnAKendraConfiguration
    {
        private bool? _exactResponse;
        private string _kendraIndex;
        private string _queryFilterString;
        private bool? _queryFilterStringEnabled;

        /// <summary>
        /// Gets and sets the property ExactResponse. 
        /// <para>
        /// Specifies whether to return an exact response from the Amazon Kendra index or to let
        /// the Amazon Bedrock model you select generate a response based on the results. To use
        /// this feature, you must first add FAQ questions to your index by following the steps
        /// at <a href="https://docs.aws.amazon.com/kendra/latest/dg/in-creating-faq.html">Adding
        /// frequently asked questions (FAQs) to an index</a>.
        /// </para>
        /// </summary>
        public bool? ExactResponse
        {
            get { return this._exactResponse; }
            set { this._exactResponse = value; }
        }

        // Check to see if ExactResponse property is set
        internal bool IsSetExactResponse()
        {
            return this._exactResponse.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KendraIndex. 
        /// <para>
        /// The ARN of the Amazon Kendra index to use.
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
        /// Contains the Amazon Kendra filter string to use if enabled. For more information on
        /// the Amazon Kendra search filter JSON format, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/filtering.html#search-filtering">Using
        /// document attributes to filter search results</a>.
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
        /// Specifies whether to enable an Amazon Kendra filter string or not.
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