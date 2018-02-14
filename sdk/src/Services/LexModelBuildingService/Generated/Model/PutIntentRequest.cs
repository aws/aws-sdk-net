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
    /// Container for the parameters to the PutIntent operation.
    /// Creates an intent or replaces an existing intent.
    /// 
    ///  
    /// <para>
    /// To define the interaction between the user and your bot, you use one or more intents.
    /// For a pizza ordering bot, for example, you would create an <code>OrderPizza</code>
    /// intent. 
    /// </para>
    ///  
    /// <para>
    /// To create an intent or replace an existing intent, you must provide the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Intent name. For example, <code>OrderPizza</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Sample utterances. For example, "Can I order a pizza, please." and "I want to order
    /// a pizza."
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Information to be gathered. You specify slot types for the information that your bot
    /// will request from the user. You can specify standard slot types, such as a date or
    /// a time, or custom slot types such as the size and crust of a pizza.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// How the intent will be fulfilled. You can provide a Lambda function or configure the
    /// intent to return the intent information to the client application. If you use a Lambda
    /// function, when all of the intent information is available, Amazon Lex invokes your
    /// Lambda function. If you configure your intent to return the intent information to
    /// the client application. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can specify other optional information in the request, such as:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A confirmation prompt to ask the user to confirm an intent. For example, "Shall I
    /// order your pizza?"
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A conclusion statement to send to the user after the intent has been fulfilled. For
    /// example, "I placed your pizza order."
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A follow-up prompt that asks the user for additional activity. For example, asking
    /// "Do you want to order a drink with your pizza?"
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If you specify an existing intent name to update the intent, Amazon Lex replaces the
    /// values in the <code>$LATEST</code> version of the intent with the values in the request.
    /// Amazon Lex removes fields that you don't provide in the request. If you don't specify
    /// the required fields, Amazon Lex throws an exception. When you update the <code>$LATEST</code>
    /// version of an intent, the <code>status</code> field of any bot that uses the <code>$LATEST</code>
    /// version of the intent is set to <code>NOT_BUILT</code>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a>how-it-works</a>.
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions for the <code>lex:PutIntent</code> action.
    /// </para>
    /// </summary>
    public partial class PutIntentRequest : AmazonLexModelBuildingServiceRequest
    {
        private string _checksum;
        private Statement _conclusionStatement;
        private Prompt _confirmationPrompt;
        private bool? _createVersion;
        private string _description;
        private CodeHook _dialogCodeHook;
        private FollowUpPrompt _followUpPrompt;
        private FulfillmentActivity _fulfillmentActivity;
        private string _name;
        private string _parentIntentSignature;
        private Statement _rejectionStatement;
        private List<string> _sampleUtterances = new List<string>();
        private List<Slot> _slots = new List<Slot>();

        /// <summary>
        /// Gets and sets the property Checksum. 
        /// <para>
        /// Identifies a specific revision of the <code>$LATEST</code> version.
        /// </para>
        ///  
        /// <para>
        /// When you create a new intent, leave the <code>checksum</code> field blank. If you
        /// specify a checksum you get a <code>BadRequestException</code> exception.
        /// </para>
        ///  
        /// <para>
        /// When you want to update a intent, set the <code>checksum</code> field to the checksum
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
        /// Gets and sets the property ConclusionStatement. 
        /// <para>
        ///  The statement that you want Amazon Lex to convey to the user after the intent is
        /// successfully fulfilled by the Lambda function. 
        /// </para>
        ///  
        /// <para>
        /// This element is relevant only if you provide a Lambda function in the <code>fulfillmentActivity</code>.
        /// If you return the intent to the client application, you can't specify this element.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>followUpPrompt</code> and <code>conclusionStatement</code> are mutually
        /// exclusive. You can specify only one.
        /// </para>
        ///  </note>
        /// </summary>
        public Statement ConclusionStatement
        {
            get { return this._conclusionStatement; }
            set { this._conclusionStatement = value; }
        }

        // Check to see if ConclusionStatement property is set
        internal bool IsSetConclusionStatement()
        {
            return this._conclusionStatement != null;
        }

        /// <summary>
        /// Gets and sets the property ConfirmationPrompt. 
        /// <para>
        /// Prompts the user to confirm the intent. This question should have a yes or no answer.
        /// </para>
        ///  
        /// <para>
        /// Amazon Lex uses this prompt to ensure that the user acknowledges that the intent is
        /// ready for fulfillment. For example, with the <code>OrderPizza</code> intent, you might
        /// want to confirm that the order is correct before placing it. For other intents, such
        /// as intents that simply respond to user questions, you might not need to ask the user
        /// for confirmation before providing the information. 
        /// </para>
        ///  <note> 
        /// <para>
        /// You you must provide both the <code>rejectionStatement</code> and the <code>confirmationPrompt</code>,
        /// or neither.
        /// </para>
        ///  </note>
        /// </summary>
        public Prompt ConfirmationPrompt
        {
            get { return this._confirmationPrompt; }
            set { this._confirmationPrompt = value; }
        }

        // Check to see if ConfirmationPrompt property is set
        internal bool IsSetConfirmationPrompt()
        {
            return this._confirmationPrompt != null;
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
        /// A description of the intent.
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
        /// Gets and sets the property DialogCodeHook. 
        /// <para>
        ///  Specifies a Lambda function to invoke for each user input. You can invoke this Lambda
        /// function to personalize user interaction. 
        /// </para>
        ///  
        /// <para>
        /// For example, suppose your bot determines that the user is John. Your Lambda function
        /// might retrieve John's information from a backend database and prepopulate some of
        /// the values. For example, if you find that John is gluten intolerant, you might set
        /// the corresponding intent slot, <code>GlutenIntolerant</code>, to true. You might find
        /// John's phone number and set the corresponding session attribute. 
        /// </para>
        /// </summary>
        public CodeHook DialogCodeHook
        {
            get { return this._dialogCodeHook; }
            set { this._dialogCodeHook = value; }
        }

        // Check to see if DialogCodeHook property is set
        internal bool IsSetDialogCodeHook()
        {
            return this._dialogCodeHook != null;
        }

        /// <summary>
        /// Gets and sets the property FollowUpPrompt. 
        /// <para>
        /// Amazon Lex uses this prompt to solicit additional activity after fulfilling an intent.
        /// For example, after the <code>OrderPizza</code> intent is fulfilled, you might prompt
        /// the user to order a drink.
        /// </para>
        ///  
        /// <para>
        /// The action that Amazon Lex takes depends on the user's response, as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the user says "Yes" it responds with the clarification prompt that is configured
        /// for the bot.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// if the user says "Yes" and continues with an utterance that triggers an intent it
        /// starts a conversation for the intent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the user says "No" it responds with the rejection statement configured for the
        /// the follow-up prompt.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If it doesn't recognize the utterance it repeats the follow-up prompt again.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The <code>followUpPrompt</code> field and the <code>conclusionStatement</code> field
        /// are mutually exclusive. You can specify only one. 
        /// </para>
        /// </summary>
        public FollowUpPrompt FollowUpPrompt
        {
            get { return this._followUpPrompt; }
            set { this._followUpPrompt = value; }
        }

        // Check to see if FollowUpPrompt property is set
        internal bool IsSetFollowUpPrompt()
        {
            return this._followUpPrompt != null;
        }

        /// <summary>
        /// Gets and sets the property FulfillmentActivity. 
        /// <para>
        /// Required. Describes how the intent is fulfilled. For example, after a user provides
        /// all of the information for a pizza order, <code>fulfillmentActivity</code> defines
        /// how the bot places an order with a local pizza store. 
        /// </para>
        ///  
        /// <para>
        ///  You might configure Amazon Lex to return all of the intent information to the client
        /// application, or direct it to invoke a Lambda function that can process the intent
        /// (for example, place an order with a pizzeria). 
        /// </para>
        /// </summary>
        public FulfillmentActivity FulfillmentActivity
        {
            get { return this._fulfillmentActivity; }
            set { this._fulfillmentActivity = value; }
        }

        // Check to see if FulfillmentActivity property is set
        internal bool IsSetFulfillmentActivity()
        {
            return this._fulfillmentActivity != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the intent. The name is <i>not</i> case sensitive. 
        /// </para>
        ///  
        /// <para>
        /// The name can't match a built-in intent name, or a built-in intent name with "AMAZON."
        /// removed. For example, because there is a built-in intent called <code>AMAZON.HelpIntent</code>,
        /// you can't create a custom intent called <code>HelpIntent</code>.
        /// </para>
        ///  
        /// <para>
        /// For a list of built-in intents, see <a href="https://developer.amazon.com/public/solutions/alexa/alexa-skills-kit/docs/built-in-intent-ref/standard-intents">Standard
        /// Built-in Intents</a> in the <i>Alexa Skills Kit</i>.
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
        /// Gets and sets the property ParentIntentSignature. 
        /// <para>
        /// A unique identifier for the built-in intent to base this intent on. To find the signature
        /// for an intent, see <a href="https://developer.amazon.com/public/solutions/alexa/alexa-skills-kit/docs/built-in-intent-ref/standard-intents">Standard
        /// Built-in Intents</a> in the <i>Alexa Skills Kit</i>.
        /// </para>
        /// </summary>
        public string ParentIntentSignature
        {
            get { return this._parentIntentSignature; }
            set { this._parentIntentSignature = value; }
        }

        // Check to see if ParentIntentSignature property is set
        internal bool IsSetParentIntentSignature()
        {
            return this._parentIntentSignature != null;
        }

        /// <summary>
        /// Gets and sets the property RejectionStatement. 
        /// <para>
        /// When the user answers "no" to the question defined in <code>confirmationPrompt</code>,
        /// Amazon Lex responds with this statement to acknowledge that the intent was canceled.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// You must provide both the <code>rejectionStatement</code> and the <code>confirmationPrompt</code>,
        /// or neither.
        /// </para>
        ///  </note>
        /// </summary>
        public Statement RejectionStatement
        {
            get { return this._rejectionStatement; }
            set { this._rejectionStatement = value; }
        }

        // Check to see if RejectionStatement property is set
        internal bool IsSetRejectionStatement()
        {
            return this._rejectionStatement != null;
        }

        /// <summary>
        /// Gets and sets the property SampleUtterances. 
        /// <para>
        /// An array of utterances (strings) that a user might say to signal the intent. For example,
        /// "I want {PizzaSize} pizza", "Order {Quantity} {PizzaSize} pizzas". 
        /// </para>
        ///  
        /// <para>
        /// In each utterance, a slot name is enclosed in curly braces. 
        /// </para>
        /// </summary>
        public List<string> SampleUtterances
        {
            get { return this._sampleUtterances; }
            set { this._sampleUtterances = value; }
        }

        // Check to see if SampleUtterances property is set
        internal bool IsSetSampleUtterances()
        {
            return this._sampleUtterances != null && this._sampleUtterances.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Slots. 
        /// <para>
        /// An array of intent slots. At runtime, Amazon Lex elicits required slot values from
        /// the user using prompts defined in the slots. For more information, see <a>how-it-works</a>.
        /// 
        /// </para>
        /// </summary>
        public List<Slot> Slots
        {
            get { return this._slots; }
            set { this._slots = value; }
        }

        // Check to see if Slots property is set
        internal bool IsSetSlots()
        {
            return this._slots != null && this._slots.Count > 0; 
        }

    }
}