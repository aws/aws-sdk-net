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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
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
    /// This is the response object from the CreateBotVersion operation.
    /// </summary>
    public partial class CreateBotVersionResponse : AmazonWebServiceResponse
    {
        private Statement _abortStatement;
        private string _checksum;
        private bool? _childDirected;
        private Prompt _clarificationPrompt;
        private DateTime? _createdDate;
        private string _description;
        private bool? _detectSentiment;
        private bool? _enableModelImprovements;
        private string _failureReason;
        private int? _idleSessionTTLInSeconds;
        private List<Intent> _intents = AWSConfigs.InitializeCollections ? new List<Intent>() : null;
        private DateTime? _lastUpdatedDate;
        private Locale _locale;
        private string _name;
        private Status _status;
        private string _version;
        private string _voiceId;

        /// <summary>
        /// Gets and sets the property AbortStatement. 
        /// <para>
        /// The message that Amazon Lex uses to cancel a conversation. For more information, see
        /// <a>PutBot</a>.
        /// </para>
        /// </summary>
        public Statement AbortStatement
        {
            get { return this._abortStatement; }
            set { this._abortStatement = value; }
        }

        // Check to see if AbortStatement property is set
        internal bool IsSetAbortStatement()
        {
            return this._abortStatement != null;
        }

        /// <summary>
        /// Gets and sets the property Checksum. 
        /// <para>
        /// Checksum identifying the version of the bot that was created.
        /// </para>
        /// </summary>
        public string Checksum
        {
            get { return this._checksum; }
            set { this._checksum = value; }
        }

        // Check to see if Checksum property is set
        internal bool IsSetChecksum()
        {
            return this._checksum != null;
        }

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
        public bool? ChildDirected
        {
            get { return this._childDirected; }
            set { this._childDirected = value; }
        }

        // Check to see if ChildDirected property is set
        internal bool IsSetChildDirected()
        {
            return this._childDirected.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClarificationPrompt. 
        /// <para>
        /// The message that Amazon Lex uses when it doesn't understand the user's request. For
        /// more information, see <a>PutBot</a>. 
        /// </para>
        /// </summary>
        public Prompt ClarificationPrompt
        {
            get { return this._clarificationPrompt; }
            set { this._clarificationPrompt = value; }
        }

        // Check to see if ClarificationPrompt property is set
        internal bool IsSetClarificationPrompt()
        {
            return this._clarificationPrompt != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date when the bot version was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate
        {
            get { return this._createdDate; }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DetectSentiment. 
        /// <para>
        /// Indicates whether utterances entered by the user should be sent to Amazon Comprehend
        /// for sentiment analysis.
        /// </para>
        /// </summary>
        public bool? DetectSentiment
        {
            get { return this._detectSentiment; }
            set { this._detectSentiment = value; }
        }

        // Check to see if DetectSentiment property is set
        internal bool IsSetDetectSentiment()
        {
            return this._detectSentiment.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableModelImprovements. 
        /// <para>
        /// Indicates whether the bot uses accuracy improvements. <c>true</c> indicates that the
        /// bot is using the improvements, otherwise, <c>false</c>.
        /// </para>
        /// </summary>
        public bool? EnableModelImprovements
        {
            get { return this._enableModelImprovements; }
            set { this._enableModelImprovements = value; }
        }

        // Check to see if EnableModelImprovements property is set
        internal bool IsSetEnableModelImprovements()
        {
            return this._enableModelImprovements.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If <c>status</c> is <c>FAILED</c>, Amazon Lex provides the reason that it failed to
        /// build the bot.
        /// </para>
        /// </summary>
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property IdleSessionTTLInSeconds. 
        /// <para>
        /// The maximum time in seconds that Amazon Lex retains the data gathered in a conversation.
        /// For more information, see <a>PutBot</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=60, Max=86400)]
        public int? IdleSessionTTLInSeconds
        {
            get { return this._idleSessionTTLInSeconds; }
            set { this._idleSessionTTLInSeconds = value; }
        }

        // Check to see if IdleSessionTTLInSeconds property is set
        internal bool IsSetIdleSessionTTLInSeconds()
        {
            return this._idleSessionTTLInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Intents. 
        /// <para>
        /// An array of <c>Intent</c> objects. For more information, see <a>PutBot</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Intent> Intents
        {
            get { return this._intents; }
            set { this._intents = value; }
        }

        // Check to see if Intents property is set
        internal bool IsSetIntents()
        {
            return this._intents != null && (this._intents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDate. 
        /// <para>
        /// The date when the <c>$LATEST</c> version of this bot was updated. 
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDate
        {
            get { return this._lastUpdatedDate; }
            set { this._lastUpdatedDate = value; }
        }

        // Check to see if LastUpdatedDate property is set
        internal bool IsSetLastUpdatedDate()
        {
            return this._lastUpdatedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        ///  Specifies the target locale for the bot. 
        /// </para>
        /// </summary>
        public Locale Locale
        {
            get { return this._locale; }
            set { this._locale = value; }
        }

        // Check to see if Locale property is set
        internal bool IsSetLocale()
        {
            return this._locale != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=50)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  When you send a request to create or update a bot, Amazon Lex sets the <c>status</c>
        /// response element to <c>BUILDING</c>. After Amazon Lex builds the bot, it sets <c>status</c>
        /// to <c>READY</c>. If Amazon Lex can't build the bot, it sets <c>status</c> to <c>FAILED</c>.
        /// Amazon Lex returns the reason for the failure in the <c>failureReason</c> response
        /// element. 
        /// </para>
        /// </summary>
        public Status Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the bot. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

        /// <summary>
        /// Gets and sets the property VoiceId. 
        /// <para>
        /// The Amazon Polly voice ID that Amazon Lex uses for voice interactions with the user.
        /// </para>
        /// </summary>
        public string VoiceId
        {
            get { return this._voiceId; }
            set { this._voiceId = value; }
        }

        // Check to see if VoiceId property is set
        internal bool IsSetVoiceId()
        {
            return this._voiceId != null;
        }

    }
}