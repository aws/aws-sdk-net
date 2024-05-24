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
    /// Contains information about the method by which to filter the results of the test execution.
    /// </summary>
    public partial class TestExecutionResultFilterBy
    {
        private ConversationLevelTestResultsFilterBy _conversationLevelTestResultsFilterBy;
        private TestResultTypeFilter _resultTypeFilter;

        /// <summary>
        /// Gets and sets the property ConversationLevelTestResultsFilterBy. 
        /// <para>
        /// Contains information about the method for filtering Conversation level test results.
        /// </para>
        /// </summary>
        public ConversationLevelTestResultsFilterBy ConversationLevelTestResultsFilterBy
        {
            get { return this._conversationLevelTestResultsFilterBy; }
            set { this._conversationLevelTestResultsFilterBy = value; }
        }

        // Check to see if ConversationLevelTestResultsFilterBy property is set
        internal bool IsSetConversationLevelTestResultsFilterBy()
        {
            return this._conversationLevelTestResultsFilterBy != null;
        }

        /// <summary>
        /// Gets and sets the property ResultTypeFilter. 
        /// <para>
        /// Specifies which results to filter. See <a href="https://docs.aws.amazon.com/lexv2/latest/dg/test-results-details-test-set.html">Test
        /// result details"&gt;Test results details</a> for details about different types of results.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TestResultTypeFilter ResultTypeFilter
        {
            get { return this._resultTypeFilter; }
            set { this._resultTypeFilter = value; }
        }

        // Check to see if ResultTypeFilter property is set
        internal bool IsSetResultTypeFilter()
        {
            return this._resultTypeFilter != null;
        }

    }
}