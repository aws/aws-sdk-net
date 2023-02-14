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
 * Do not modify this file. This file is generated from the runtime.lex-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lex.Model
{
    /// <summary>
    /// Container for the parameters to the PostText operation.
    /// Sends user input to Amazon Lex. Client applications can use this API to send requests
    /// to Amazon Lex at runtime. Amazon Lex then interprets the user input using the machine
    /// learning model it built for the bot. 
    /// 
    ///  
    /// <para>
    ///  In response, Amazon Lex returns the next <code>message</code> to convey to the user
    /// an optional <code>responseCard</code> to display. Consider the following example messages:
    /// 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  For a user input "I would like a pizza", Amazon Lex might return a response with
    /// a message eliciting slot data (for example, PizzaSize): "What size pizza would you
    /// like?" 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  After the user provides all of the pizza order information, Amazon Lex might return
    /// a response with a message to obtain user confirmation "Proceed with the pizza order?".
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  After the user replies to a confirmation prompt with a "yes", Amazon Lex might return
    /// a conclusion statement: "Thank you, your cheese pizza has been ordered.". 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  Not all Amazon Lex messages require a user response. For example, a conclusion statement
    /// does not require a response. Some messages require only a "yes" or "no" user response.
    /// In addition to the <code>message</code>, Amazon Lex provides additional context about
    /// the message in the response that you might use to enhance client behavior, for example,
    /// to display the appropriate client user interface. These are the <code>slotToElicit</code>,
    /// <code>dialogState</code>, <code>intentName</code>, and <code>slots</code> fields in
    /// the response. Consider the following examples: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the message is to elicit slot data, Amazon Lex returns the following context information:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>dialogState</code> set to ElicitSlot 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>intentName</code> set to the intent name in the current context 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>slotToElicit</code> set to the slot name for which the <code>message</code>
    /// is eliciting information 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>slots</code> set to a map of slots, configured for the intent, with currently
    /// known values 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  If the message is a confirmation prompt, the <code>dialogState</code> is set to ConfirmIntent
    /// and <code>SlotToElicit</code> is set to null. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the message is a clarification prompt (configured for the intent) that indicates
    /// that user intent is not understood, the <code>dialogState</code> is set to ElicitIntent
    /// and <code>slotToElicit</code> is set to null. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  In addition, Amazon Lex also returns your application-specific <code>sessionAttributes</code>.
    /// For more information, see <a href="https://docs.aws.amazon.com/lex/latest/dg/context-mgmt.html">Managing
    /// Conversation Context</a>. 
    /// </para>
    /// </summary>
    public partial class PostTextRequest : AmazonLexRequest
    {
        private List<ActiveContext> _activeContexts = new List<ActiveContext>();
        private string _botAlias;
        private string _botName;
        private string _inputText;
        private Dictionary<string, string> _requestAttributes = new Dictionary<string, string>();
        private Dictionary<string, string> _sessionAttributes = new Dictionary<string, string>();
        private string _userId;

        /// <summary>
        /// Gets and sets the property ActiveContexts. 
        /// <para>
        /// A list of contexts active for the request. A context can be activated when a previous
        /// intent is fulfilled, or by including the context in the request,
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a list of contexts, Amazon Lex will use the current list of contexts
        /// for the session. If you specify an empty list, all contexts for the session are cleared.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=20)]
        public List<ActiveContext> ActiveContexts
        {
            get { return this._activeContexts; }
            set { this._activeContexts = value; }
        }

        // Check to see if ActiveContexts property is set
        internal bool IsSetActiveContexts()
        {
            return this._activeContexts != null && this._activeContexts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property BotAlias. 
        /// <para>
        /// The alias of the Amazon Lex bot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BotAlias
        {
            get { return this._botAlias; }
            set { this._botAlias = value; }
        }

        // Check to see if BotAlias property is set
        internal bool IsSetBotAlias()
        {
            return this._botAlias != null;
        }

        /// <summary>
        /// Gets and sets the property BotName. 
        /// <para>
        /// The name of the Amazon Lex bot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BotName
        {
            get { return this._botName; }
            set { this._botName = value; }
        }

        // Check to see if BotName property is set
        internal bool IsSetBotName()
        {
            return this._botName != null;
        }

        /// <summary>
        /// Gets and sets the property InputText. 
        /// <para>
        /// The text that the user entered (Amazon Lex interprets this text).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=1024)]
        public string InputText
        {
            get { return this._inputText; }
            set { this._inputText = value; }
        }

        // Check to see if InputText property is set
        internal bool IsSetInputText()
        {
            return this._inputText != null;
        }

        /// <summary>
        /// Gets and sets the property RequestAttributes. 
        /// <para>
        /// Request-specific information passed between Amazon Lex and a client application.
        /// </para>
        ///  
        /// <para>
        /// The namespace <code>x-amz-lex:</code> is reserved for special attributes. Don't create
        /// any request attributes with the prefix <code>x-amz-lex:</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/lex/latest/dg/context-mgmt.html#context-mgmt-request-attribs">Setting
        /// Request Attributes</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> RequestAttributes
        {
            get { return this._requestAttributes; }
            set { this._requestAttributes = value; }
        }

        // Check to see if RequestAttributes property is set
        internal bool IsSetRequestAttributes()
        {
            return this._requestAttributes != null && this._requestAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SessionAttributes. 
        /// <para>
        /// Application-specific information passed between Amazon Lex and a client application.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/lex/latest/dg/context-mgmt.html#context-mgmt-session-attribs">Setting
        /// Session Attributes</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> SessionAttributes
        {
            get { return this._sessionAttributes; }
            set { this._sessionAttributes = value; }
        }

        // Check to see if SessionAttributes property is set
        internal bool IsSetSessionAttributes()
        {
            return this._sessionAttributes != null && this._sessionAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The ID of the client application user. Amazon Lex uses this to identify a user's conversation
        /// with your bot. At runtime, each request must contain the <code>userID</code> field.
        /// </para>
        ///  
        /// <para>
        /// To decide the user ID to use for your application, consider the following factors.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <code>userID</code> field must not contain any personally identifiable information
        /// of the user, for example, name, personal identification numbers, or other end user
        /// personal information.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you want a user to start a conversation on one device and continue on another device,
        /// use a user-specific identifier.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you want the same user to be able to have two independent conversations on two
        /// different devices, choose a device-specific identifier.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A user can't have two independent conversations with two different versions of the
        /// same bot. For example, a user can't have a conversation with the PROD and BETA versions
        /// of the same bot. If you anticipate that a user will need to have conversation with
        /// two different versions, for example, while testing, include the bot alias in the user
        /// ID to separate the two conversations.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=100)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}