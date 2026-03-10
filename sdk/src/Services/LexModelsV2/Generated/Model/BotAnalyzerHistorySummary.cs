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
    /// Contains summary information about a historical bot analysis execution.
    /// </summary>
    public partial class BotAnalyzerHistorySummary
    {
        private string _botAnalyzerRequestId;
        private BotAnalyzerStatus _botAnalyzerStatus;
        private DateTime? _creationDateTime;

        /// <summary>
        /// Gets and sets the property BotAnalyzerRequestId. 
        /// <para>
        /// The unique identifier for the analysis request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string BotAnalyzerRequestId
        {
            get { return this._botAnalyzerRequestId; }
            set { this._botAnalyzerRequestId = value; }
        }

        // Check to see if BotAnalyzerRequestId property is set
        internal bool IsSetBotAnalyzerRequestId()
        {
            return this._botAnalyzerRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property BotAnalyzerStatus. 
        /// <para>
        /// The status of the historical analysis execution.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>Processing | Available | Failed | Stopping | Stopped</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BotAnalyzerStatus BotAnalyzerStatus
        {
            get { return this._botAnalyzerStatus; }
            set { this._botAnalyzerStatus = value; }
        }

        // Check to see if BotAnalyzerStatus property is set
        internal bool IsSetBotAnalyzerStatus()
        {
            return this._botAnalyzerStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The date and time when the analysis was initiated.
        /// </para>
        /// </summary>
        public DateTime CreationDateTime
        {
            get { return this._creationDateTime.GetValueOrDefault(); }
            set { this._creationDateTime = value; }
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this._creationDateTime.HasValue; 
        }

    }
}