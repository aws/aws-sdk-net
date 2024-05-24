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
    /// Provides parameters for setting the time window and duration for aggregating utterance
    /// data.
    /// </summary>
    public partial class UtteranceAggregationDuration
    {
        private RelativeAggregationDuration _relativeAggregationDuration;

        /// <summary>
        /// Gets and sets the property RelativeAggregationDuration. 
        /// <para>
        /// The desired time window for aggregating utterances. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RelativeAggregationDuration RelativeAggregationDuration
        {
            get { return this._relativeAggregationDuration; }
            set { this._relativeAggregationDuration = value; }
        }

        // Check to see if RelativeAggregationDuration property is set
        internal bool IsSetRelativeAggregationDuration()
        {
            return this._relativeAggregationDuration != null;
        }

    }
}