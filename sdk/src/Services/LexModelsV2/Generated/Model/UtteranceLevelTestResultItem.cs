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
    /// Contains information about multiple utterances in the results of a test set execution.
    /// </summary>
    public partial class UtteranceLevelTestResultItem
    {
        private string _conversationId;
        private long? _recordNumber;
        private TestSetTurnResult _turnResult;

        /// <summary>
        /// Gets and sets the property ConversationId. 
        /// <para>
        /// The unique identifier for the conversation associated with the result.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string ConversationId
        {
            get { return this._conversationId; }
            set { this._conversationId = value; }
        }

        // Check to see if ConversationId property is set
        internal bool IsSetConversationId()
        {
            return this._conversationId != null;
        }

        /// <summary>
        /// Gets and sets the property RecordNumber. 
        /// <para>
        /// The record number of the result.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200000)]
        public long? RecordNumber
        {
            get { return this._recordNumber; }
            set { this._recordNumber = value; }
        }

        // Check to see if RecordNumber property is set
        internal bool IsSetRecordNumber()
        {
            return this._recordNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TurnResult. 
        /// <para>
        /// Contains information about the turn associated with the result.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TestSetTurnResult TurnResult
        {
            get { return this._turnResult; }
            set { this._turnResult = value; }
        }

        // Check to see if TurnResult property is set
        internal bool IsSetTurnResult()
        {
            return this._turnResult != null;
        }

    }
}