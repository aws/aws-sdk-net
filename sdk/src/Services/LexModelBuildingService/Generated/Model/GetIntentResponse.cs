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
    /// This is the response object from the GetIntent operation.
    /// </summary>
    public partial class GetIntentResponse : AmazonWebServiceResponse
    {
        private string _checksum;
        private Statement _conclusionStatement;
        private Prompt _confirmationPrompt;
        private DateTime? _createdDate;
        private string _description;
        private CodeHook _dialogCodeHook;
        private FollowUpPrompt _followUpPrompt;
        private FulfillmentActivity _fulfillmentActivity;
        private DateTime? _lastUpdatedDate;
        private string _name;
        private string _parentIntentSignature;
        private Statement _rejectionStatement;
        private List<string> _sampleUtterances = new List<string>();
        private List<Slot> _slots = new List<Slot>();
        private string _version;

        /// <summary>
        /// Gets and sets the property Checksum. 
        /// <para>
        /// Checksum of the intent.
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
        /// After the Lambda function specified in the <code>fulfillmentActivity</code> element
        /// fulfills the intent, Amazon Lex conveys this statement to the user.
        /// </para>
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
        /// If defined in the bot, Amazon Lex uses prompt to confirm the intent before fulfilling
        /// the user's request. For more information, see . 
        /// </para>
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
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date that the intent was created.
        /// </para>
        /// </summary>
        public DateTime CreatedDate
        {
            get { return this._createdDate.GetValueOrDefault(); }
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
        /// If defined in the bot, Amazon Amazon Lex invokes this Lambda function for each user
        /// input. For more information, see . 
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
        /// If defined in the bot, Amazon Lex uses this prompt to solicit additional user activity
        /// after the intent is fulfilled. For more information, see .
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
        /// Describes how the intent is fulfilled. For more information, see . 
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
        /// Gets and sets the property LastUpdatedDate. 
        /// <para>
        /// The date that the intent was updated. When you create a resource, the creation date
        /// and the last updated date are the same. 
        /// </para>
        /// </summary>
        public DateTime LastUpdatedDate
        {
            get { return this._lastUpdatedDate.GetValueOrDefault(); }
            set { this._lastUpdatedDate = value; }
        }

        // Check to see if LastUpdatedDate property is set
        internal bool IsSetLastUpdatedDate()
        {
            return this._lastUpdatedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the intent.
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
        /// A unique identifier for a built-in intent.
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
        /// If the user answers "no" to the question defined in <code>confirmationPrompt</code>,
        /// Amazon Lex responds with this statement to acknowledge that the intent was canceled.
        /// 
        /// </para>
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
        /// An array of sample utterances configured for the intent.
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
        /// An array of intent slots configured for the intent.
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

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the intent.
        /// </para>
        /// </summary>
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

    }
}