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

namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// This is the response object from the GetBot operation.
    /// </summary>
    [Obsolete("Amazon Lex V1 is deprecated. Use Amazon Lex V2 instead.")]
    public partial class GetBotResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AbortStatement. 
        /// <para>
        /// The message that Amazon Lex returns when the user elects to end the conversation without
        /// completing it. For more information, see <a>PutBot</a>.
        /// </para>
        /// </summary>
        public Statement AbortStatement { get; set; }

        /// <summary>
        /// Checks to see if the AbortStatement property is set.
        /// </summary>
        internal bool IsSetAbortStatement() => this.AbortStatement != null;

        /// <summary>
        /// Gets and sets the property Checksum. 
        /// <para>
        /// Checksum of the bot used to identify a specific revision of the bot's <c>$LATEST</c>
        /// version.
        /// </para>
        /// </summary>
        public string Checksum { get; set; }

        /// <summary>
        /// Checks to see if the Checksum property is set.
        /// </summary>
        internal bool IsSetChecksum() => this.Checksum != null;

        /// <summary>
        /// Gets and sets the property ChildDirected. 
        /// <para>
        /// For each Amazon Lex bot created with the Amazon Lex Model Building Service, you must
        /// specify whether your use of Amazon Lex is related to a website, program, or other
        /// application that is directed or targeted, in whole or in part, to children under age
        /// 13 and subject to the Children's Online Privacy Protection Act (COPPA) by specifying
        /// <c>true</c> or <c>false</c> in the <c>childDirected</c> field. By specifying <c>true</c>
        /// in the <c>childDirected</c> field, you confirm that your use of Amazon Lex <b>is</b>
        /// related to a website, program, or other application that is directed or targeted,
        /// in whole or in part, to children under age 13 and subject to COPPA. By specifying
        /// <c>false</c> in the <c>childDirected</c> field, you confirm that your use of Amazon
        /// Lex <b>is not</b> related to a website, program, or other application that is directed
        /// or targeted, in whole or in part, to children under age 13 and subject to COPPA. You
        /// may not specify a default value for the <c>childDirected</c> field that does not accurately
        /// reflect whether your use of Amazon Lex is related to a website, program, or other
        /// application that is directed or targeted, in whole or in part, to children under age
        /// 13 and subject to COPPA.
        /// </para>
        ///  
        /// <para>
        /// If your use of Amazon Lex relates to a website, program, or other application that
        /// is directed in whole or in part, to children under age 13, you must obtain any required
        /// verifiable parental consent under COPPA. For information regarding the use of Amazon
        /// Lex in connection with websites, programs, or other applications that are directed
        /// or targeted, in whole or in part, to children under age 13, see the <a href="https://aws.amazon.com/lex/faqs#data-security">Amazon
        /// Lex FAQ.</a> 
        /// </para>
        /// </summary>
        public bool? ChildDirected { get; set; }

        /// <summary>
        /// Checks to see if the ChildDirected property is set.
        /// </summary>
        internal bool IsSetChildDirected() => this.ChildDirected.HasValue;

        /// <summary>
        /// Gets and sets the property ClarificationPrompt. 
        /// <para>
        /// The message Amazon Lex uses when it doesn't understand the user's request. For more
        /// information, see <a>PutBot</a>. 
        /// </para>
        /// </summary>
        public Prompt ClarificationPrompt { get; set; }

        /// <summary>
        /// Checks to see if the ClarificationPrompt property is set.
        /// </summary>
        internal bool IsSetClarificationPrompt() => this.ClarificationPrompt != null;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date that the bot was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DetectSentiment. 
        /// <para>
        /// Indicates whether user utterances should be sent to Amazon Comprehend for sentiment
        /// analysis.
        /// </para>
        /// </summary>
        public bool? DetectSentiment { get; set; }

        /// <summary>
        /// Checks to see if the DetectSentiment property is set.
        /// </summary>
        internal bool IsSetDetectSentiment() => this.DetectSentiment.HasValue;

        /// <summary>
        /// Gets and sets the property EnableModelImprovements. 
        /// <para>
        /// Indicates whether the bot uses accuracy improvements. <c>true</c> indicates that the
        /// bot is using the improvements, otherwise, <c>false</c>.
        /// </para>
        /// </summary>
        public bool? EnableModelImprovements { get; set; }

        /// <summary>
        /// Checks to see if the EnableModelImprovements property is set.
        /// </summary>
        internal bool IsSetEnableModelImprovements() => this.EnableModelImprovements.HasValue;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If <c>status</c> is <c>FAILED</c>, Amazon Lex explains why it failed to build the
        /// bot.
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property IdleSessionTTLInSeconds. 
        /// <para>
        /// The maximum time in seconds that Amazon Lex retains the data gathered in a conversation.
        /// For more information, see <a>PutBot</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 60, Max = 86400)]
        public int? IdleSessionTTLInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the IdleSessionTTLInSeconds property is set.
        /// </summary>
        internal bool IsSetIdleSessionTTLInSeconds() => this.IdleSessionTTLInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property Intents. 
        /// <para>
        /// An array of <c>intent</c> objects. For more information, see <a>PutBot</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Intent> Intents { get; set; } = AWSConfigs.InitializeCollections ? new List<Intent>() : null;

        /// <summary>
        /// Checks to see if the Intents property is set.
        /// </summary>
        internal bool IsSetIntents() => this.Intents != null && (this.Intents.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastUpdatedDate. 
        /// <para>
        /// The date that the bot was updated. When you create a resource, the creation date and
        /// last updated date are the same. 
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDate property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDate() => this.LastUpdatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        ///  The target locale for the bot. 
        /// </para>
        /// </summary>
        public Locale Locale { get; set; }

        /// <summary>
        /// Checks to see if the Locale property is set.
        /// </summary>
        internal bool IsSetLocale() => this.Locale != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 50)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NluIntentConfidenceThreshold. 
        /// <para>
        /// The score that determines where Amazon Lex inserts the <c>AMAZON.FallbackIntent</c>,
        /// <c>AMAZON.KendraSearchIntent</c>, or both when returning alternative intents in a
        /// <a href="https://docs.aws.amazon.com/lex/latest/dg/API_runtime_PostContent.html">PostContent</a>
        /// or <a href="https://docs.aws.amazon.com/lex/latest/dg/API_runtime_PostText.html">PostText</a>
        /// response. <c>AMAZON.FallbackIntent</c> is inserted if the confidence score for all
        /// intents is below this value. <c>AMAZON.KendraSearchIntent</c> is only inserted if
        /// it is configured for the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public double? NluIntentConfidenceThreshold { get; set; }

        /// <summary>
        /// Checks to see if the NluIntentConfidenceThreshold property is set.
        /// </summary>
        internal bool IsSetNluIntentConfidenceThreshold() => this.NluIntentConfidenceThreshold.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the bot. 
        /// </para>
        ///  
        /// <para>
        /// When the status is <c>BUILDING</c> Amazon Lex is building the bot for testing and
        /// use.
        /// </para>
        ///  
        /// <para>
        /// If the status of the bot is <c>READY_BASIC_TESTING</c>, you can test the bot using
        /// the exact utterances specified in the bot's intents. When the bot is ready for full
        /// testing or to run, the status is <c>READY</c>.
        /// </para>
        ///  
        /// <para>
        /// If there was a problem with building the bot, the status is <c>FAILED</c> and the
        /// <c>failureReason</c> field explains why the bot did not build.
        /// </para>
        ///  
        /// <para>
        /// If the bot was saved but not built, the status is <c>NOT_BUILT</c>.
        /// </para>
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the bot. For a new bot, the version is always <c>$LATEST</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;

        /// <summary>
        /// Gets and sets the property VoiceId. 
        /// <para>
        /// The Amazon Polly voice ID that Amazon Lex uses for voice interaction with the user.
        /// For more information, see <a>PutBot</a>.
        /// </para>
        /// </summary>
        public string VoiceId { get; set; }

        /// <summary>
        /// Checks to see if the VoiceId property is set.
        /// </summary>
        internal bool IsSetVoiceId() => this.VoiceId != null;
    }
}
