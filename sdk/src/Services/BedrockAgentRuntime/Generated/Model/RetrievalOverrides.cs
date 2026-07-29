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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Overrides for retrieval behavior.
    /// </summary>
    public partial class RetrievalOverrides
    {
        private RetrievalFilter _filter;
        private int? _maxNumberOfResults;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// A filter to apply to the retrieval results.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public RetrievalFilter Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property MaxNumberOfResults. 
        /// <para>
        /// The maximum number of results to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MaxNumberOfResults
        {
            get { return this._maxNumberOfResults; }
            set { this._maxNumberOfResults = value; }
        }

        // Check to see if MaxNumberOfResults property is set
        internal bool IsSetMaxNumberOfResults()
        {
            return this._maxNumberOfResults.HasValue; 
        }

    }
}