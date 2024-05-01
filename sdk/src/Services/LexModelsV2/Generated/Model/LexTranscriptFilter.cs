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
    /// The object that contains transcript filter details that are associated with a bot
    /// recommendation.
    /// </summary>
    public partial class LexTranscriptFilter
    {
        private DateRangeFilter _dateRangeFilter;

        /// <summary>
        /// Gets and sets the property DateRangeFilter. 
        /// <para>
        /// The object that contains a date range filter that will be applied to the transcript.
        /// Specify this object if you want Amazon Lex to only read the files that are within
        /// the date range.
        /// </para>
        /// </summary>
        public DateRangeFilter DateRangeFilter
        {
            get { return this._dateRangeFilter; }
            set { this._dateRangeFilter = value; }
        }

        // Check to see if DateRangeFilter property is set
        internal bool IsSetDateRangeFilter()
        {
            return this._dateRangeFilter != null;
        }

    }
}