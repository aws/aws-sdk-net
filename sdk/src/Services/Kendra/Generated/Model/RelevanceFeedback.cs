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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides feedback on how relevant a document is to a search. Your application uses
    /// the <code>SubmitFeedback</code> API to provide relevance information.
    /// </summary>
    public partial class RelevanceFeedback
    {
        private RelevanceType _relevanceValue;
        private string _resultId;

        /// <summary>
        /// Gets and sets the property RelevanceValue. 
        /// <para>
        /// Whether to document was relevant or not relevant to the search.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RelevanceType RelevanceValue
        {
            get { return this._relevanceValue; }
            set { this._relevanceValue = value; }
        }

        // Check to see if RelevanceValue property is set
        internal bool IsSetRelevanceValue()
        {
            return this._relevanceValue != null;
        }

        /// <summary>
        /// Gets and sets the property ResultId. 
        /// <para>
        /// The identifier of the search result that the user provided relevance feedback for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=73)]
        public string ResultId
        {
            get { return this._resultId; }
            set { this._resultId = value; }
        }

        // Check to see if ResultId property is set
        internal bool IsSetResultId()
        {
            return this._resultId != null;
        }

    }
}