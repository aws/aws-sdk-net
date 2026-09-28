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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Input information for the query.
    /// </summary>
    public partial class QueryInputData
    {
        /// <summary>
        /// Gets and sets the property CaseSummarizationInputData. 
        /// <para>
        /// Input data for case summarization queries.
        /// </para>
        /// </summary>
        public CaseSummarizationInputData CaseSummarizationInputData { get; set; }

        /// <summary>
        /// Checks to see if the CaseSummarizationInputData property is set.
        /// </summary>
        internal bool IsSetCaseSummarizationInputData() => this.CaseSummarizationInputData != null;

        /// <summary>
        /// Gets and sets the property IntentInputData. 
        /// <para>
        /// Input information for the intent.
        /// </para>
        /// </summary>
        public IntentInputData IntentInputData { get; set; }

        /// <summary>
        /// Checks to see if the IntentInputData property is set.
        /// </summary>
        internal bool IsSetIntentInputData() => this.IntentInputData != null;

        /// <summary>
        /// Gets and sets the property QueryTextInputData. 
        /// <para>
        /// Input information for the query.
        /// </para>
        /// </summary>
        public QueryTextInputData QueryTextInputData { get; set; }

        /// <summary>
        /// Checks to see if the QueryTextInputData property is set.
        /// </summary>
        internal bool IsSetQueryTextInputData() => this.QueryTextInputData != null;
    }
}
