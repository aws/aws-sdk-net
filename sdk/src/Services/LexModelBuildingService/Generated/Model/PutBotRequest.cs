/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Container for the parameters to the PutBot operation.
    /// Creates an Amazon Lex conversational bot or replaces an existing bot. When you create
    /// or update a bot you are only required to specify a name, a locale, and whether the
    /// bot is directed toward children under age 13. You can use this to add intents later,
    /// or to remove intents from an existing bot. When you create a bot with the minimum
    /// information, the bot is created or updated but Amazon Lex returns the <code/> response
    /// <code>FAILED</code>. You can build the bot after you add one or more intents. For
    /// more information about Amazon Lex bots, see <a>how-it-works</a>. 
    /// 
    ///  
    /// <para>
    /// If you specify the name of an existing bot, the fields in the request replace the
    /// existing values in the <code>$LATEST</code> version of the bot. Amazon Lex removes
    /// any fields that you don't provide values for in the request, except for the <code>idleTTLInSeconds</code>
    /// and <code>privacySettings</code> fields, which are set to their default values. If
    /// you don't specify values for required fields, Amazon Lex throws an exception.
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions for the <code>lex:PutBot</code> action. For more
    /// information, see <a>auth-and-access-control</a>.
    /// </para>
    /// </summary>
    public partial class PutBotRequest : AmazonLexModelBuildingServiceRequest
    {
        private Statement _abortStatement;
        private string _checksum;
        private bool? _childDirected;
        private Prompt _clarificationPrompt;
        private bool? _createVersion;
        private string _description;
        private int? _idleSessionTTLInSeconds;
        private List<Intent> _intents = new List<Intent>();
        private Locale _locale;
        private string _name;
        private ProcessBehavior _processBehavior;
        private string _voiceId;

        /// <summary>
        /// Gets and sets the property AbortStatement. 
        /// <para>
        /// When Amazon Lex can't understand the user's input in context, it tries to elicit the
        /// information a few times. After that, Amazon Lex sends the message defined in <code>abortStatement</code>
        /// to the user, and then aborts the conversation. To set the number of retries, use the
        /// <code>valueElicitationPrompt</code> field for the slot type. 
        /// </para>
        ///  
        /// <para>
        /// For example, in a pizza ordering bot, Amazon Lex might ask a user "What type of crust
        /// would you like?" If the user's response is not one of the expected responses (for
        /// example, "thin crust, "deep dish," etc.), Amazon Lex tries to elicit a correct response
        /// a few more times. 
        /// </para>
        ///  
        /// <para>
        /// For example, in a pizza ordering application, <code>OrderPizza</code> might be one
        /// of the intents. This intent might require the <code>CrustType</code> slot. You specify
        /// the <code>valueElicitationPrompt</code> field when you create the <code>CrustType</code>
        /// slot.
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
        /// Identifies a specific revision of the <code>$LATEST</code> version.
        /// </para>
        ///  
        /// <para>
        /// When you create a new bot, leave the <code>checksum</code> field blank. If you specify
        /// a checksum you get a <code>BadRequestException</code> exception.
        /// </para>
        ///  
        /// <para>
        /// When you want to update a bot, set the <code>checksum</code> field to the checksum
        /// of the most recent revision of the <code>$LATEST</code> version. If you don't specify
        /// the <code> checksum</code> field, or if the checksum does not match the <code>$LATEST</code>
        /// version, you get a <code>PreconditionFailedException</code> exception.
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
        /// <code>true</code> or <code>false</code> in the <code>childDirected</code> field. By
        /// specifying <code>true</code> in the <code>childDirected</code> field, you confirm
        /// that your use of Amazon Lex <b>is</b> related to a website, program, or other application
        /// that is directed or targeted, in whole or in part, to children under age 13 and subject
        /// to COPPA. By specifying <code>false</code> in the <code>childDirected</code> field,
        /// you confirm that your use of Amazon Lex <b>is not</b> related to a website, program,
        /// or other application that is directed or targeted, in whole or in part, to children
        /// under age 13 and subject to COPPA. You may not specify a default value for the <code>childDirected</code>
        /// field that does not accurately reflect whether your use of Amazon Lex is related to
        /// a website, program, or other application that is directed or targeted, in whole or
        /// in part, to children under age 13 and subject to COPPA.
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
        public bool ChildDirected
        {
            get { return this._childDirected.GetValueOrDefault(); }
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
        /// When Amazon Lex doesn't understand the user's intent, it uses this message to get
        /// clarification. To specify how many times Amazon Lex should repeate the clarification
        /// prompt, use the <code>maxAttempts</code> field. If Amazon Lex still doesn't understand,
        /// it sends the message in the <code>abortStatement</code> field. 
        /// </para>
        ///  
        /// <para>
        /// When you create a clarification prompt, make sure that it suggests the correct response
        /// from the user. for example, for a bot that orders pizza and drinks, you might create
        /// this clarification prompt: "What would you like to do? You can say 'Order a pizza'
        /// or 'Order a drink.'"
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
        /// Gets and sets the property CreateVersion.
        /// </summary>
        public bool CreateVersion
        {
            get { return this._createVersion.GetValueOrDefault(); }
            set { this._createVersion = value; }
        }

        // Check to see if CreateVersion property is set
        internal bool IsSetCreateVersion()
        {
            return this._createVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the bot.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property IdleSessionTTLInSeconds. 
        /// <para>
        /// The maximum time in seconds that Amazon Lex retains the data gathered in a conversation.
        /// </para>
        ///  
        /// <para>
        /// A user interaction session remains active for the amount of time specified. If no
        /// conversation occurs during this time, the session expires and Amazon Lex deletes any
        /// data provided before the timeout.
        /// </para>
        ///  
        /// <para>
        /// For example, suppose that a user chooses the OrderPizza intent, but gets sidetracked
        /// halfway through placing an order. If the user doesn't complete the order within the
        /// specified time, Amazon Lex discards the slot information that it gathered, and the
        /// user must start over.
        /// </para>
        ///  
        /// <para>
        /// If you don't include the <code>idleSessionTTLInSeconds</code> element in a <code>PutBot</code>
        /// operation request, Amazon Lex uses the default value. This is also true if the request
        /// replaces an existing bot.
        /// </para>
        ///  
        /// <para>
        /// The default is 300 seconds (5 minutes).
        /// </para>
        /// </summary>
        public int IdleSessionTTLInSeconds
        {
            get { return this._idleSessionTTLInSeconds.GetValueOrDefault(); }
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
        /// An array of <code>Intent</code> objects. Each intent represents a command that a user
        /// can express. For example, a pizza ordering bot might support an OrderPizza intent.
        /// For more information, see <a>how-it-works</a>.
        /// </para>
        /// </summary>
        public List<Intent> Intents
        {
            get { return this._intents; }
            set { this._intents = value; }
        }

        // Check to see if Intents property is set
        internal bool IsSetIntents()
        {
            return this._intents != null && this._intents.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        ///  Specifies the target locale for the bot. Any intent used in the bot must be compatible
        /// with the locale of the bot. 
        /// </para>
        ///  
        /// <para>
        /// The default is <code>en-US</code>.
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
        /// The name of the bot. The name is <i>not</i> case sensitive. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ProcessBehavior. 
        /// <para>
        /// If you set the <code>processBehavior</code> element to <code>BUILD</code>, Amazon
        /// Lex builds the bot so that it can be run. If you set the element to <code>SAVE</code>
        /// Amazon Lex saves the bot, but doesn't build it. 
        /// </para>
        ///  
        /// <para>
        /// If you don't specify this value, the default value is <code>BUILD</code>.
        /// </para>
        /// </summary>
        public ProcessBehavior ProcessBehavior
        {
            get { return this._processBehavior; }
            set { this._processBehavior = value; }
        }

        // Check to see if ProcessBehavior property is set
        internal bool IsSetProcessBehavior()
        {
            return this._processBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property VoiceId. 
        /// <para>
        /// The Amazon Polly voice ID that you want Amazon Lex to use for voice interactions with
        /// the user. The locale configured for the voice must match the locale of the bot. For
        /// more information, see <a href="http://docs.aws.amazon.com/polly/latest/dg/voicelist.html">Available
        /// Voices</a> in the <i>Amazon Polly Developer Guide</i>.
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