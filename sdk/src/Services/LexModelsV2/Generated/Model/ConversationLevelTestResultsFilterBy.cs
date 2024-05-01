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
    /// The selection to filter the test set results data at the conversation level.
    /// </summary>
    public partial class ConversationLevelTestResultsFilterBy
    {
        private TestResultMatchStatus _endToEndResult;

        /// <summary>
        /// Gets and sets the property EndToEndResult. 
        /// <para>
        /// The selection of matched or mismatched end-to-end status to filter test set results
        /// data at the conversation level.
        /// </para>
        /// </summary>
        public TestResultMatchStatus EndToEndResult
        {
            get { return this._endToEndResult; }
            set { this._endToEndResult = value; }
        }

        // Check to see if EndToEndResult property is set
        internal bool IsSetEndToEndResult()
        {
            return this._endToEndResult != null;
        }

    }
}