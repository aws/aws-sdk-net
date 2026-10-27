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
    /// Information about the overall results for a test execution result.
    /// </summary>
    public partial class OverallTestResultItem
    {
        /// <summary>
        /// Gets and sets the property EndToEndResultCounts. 
        /// <para>
        /// The number of results that succeeded.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public Dictionary<string, int> EndToEndResultCounts { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;

        /// <summary>
        /// Checks to see if the EndToEndResultCounts property is set.
        /// </summary>
        internal bool IsSetEndToEndResultCounts() => this.EndToEndResultCounts != null && (this.EndToEndResultCounts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MultiTurnConversation. 
        /// <para>
        /// Indicates whether the conversation contains multiple turns or not.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? MultiTurnConversation { get; set; }

        /// <summary>
        /// Checks to see if the MultiTurnConversation property is set.
        /// </summary>
        internal bool IsSetMultiTurnConversation() => this.MultiTurnConversation.HasValue;

        /// <summary>
        /// Gets and sets the property SpeechTranscriptionResultCounts. 
        /// <para>
        /// The number of speech transcription results in the overall test.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, int> SpeechTranscriptionResultCounts { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;

        /// <summary>
        /// Checks to see if the SpeechTranscriptionResultCounts property is set.
        /// </summary>
        internal bool IsSetSpeechTranscriptionResultCounts() => this.SpeechTranscriptionResultCounts != null && (this.SpeechTranscriptionResultCounts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TotalResultCount. 
        /// <para>
        /// The total number of overall results in the result of the test execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? TotalResultCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalResultCount property is set.
        /// </summary>
        internal bool IsSetTotalResultCount() => this.TotalResultCount.HasValue;
    }
}
