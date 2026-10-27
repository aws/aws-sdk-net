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
    /// Contains details about the configuration of the Amazon Kendra index used for the <c>AMAZON.QnAIntent</c>.
    /// </summary>
    public partial class QnAKendraConfiguration
    {
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
        public bool? ExactResponse { get; set; }

        /// <summary>
        /// Checks to see if the ExactResponse property is set.
        /// </summary>
        internal bool IsSetExactResponse() => this.ExactResponse.HasValue;

        /// <summary>
        /// Gets and sets the property KendraIndex. 
        /// <para>
        /// The ARN of the Amazon Kendra index to use.
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
        /// Contains the Amazon Kendra filter string to use if enabled. For more information on
        /// the Amazon Kendra search filter JSON format, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/filtering.html#search-filtering">Using
        /// document attributes to filter search results</a>.
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
        /// Specifies whether to enable an Amazon Kendra filter string or not.
        /// </para>
        /// </summary>
        public bool? QueryFilterStringEnabled { get; set; }

        /// <summary>
        /// Checks to see if the QueryFilterStringEnabled property is set.
        /// </summary>
        internal bool IsSetQueryFilterStringEnabled() => this.QueryFilterStringEnabled.HasValue;
    }
}
