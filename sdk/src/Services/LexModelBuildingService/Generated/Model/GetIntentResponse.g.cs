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
    /// This is the response object from the GetIntent operation.
    /// </summary>
    [Obsolete("Amazon Lex V1 is deprecated. Use Amazon Lex V2 instead.")]
    public partial class GetIntentResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Checksum. 
        /// <para>
        /// Checksum of the intent.
        /// </para>
        /// </summary>
        public string Checksum { get; set; }

        /// <summary>
        /// Checks to see if the Checksum property is set.
        /// </summary>
        internal bool IsSetChecksum() => this.Checksum != null;

        /// <summary>
        /// Gets and sets the property ConclusionStatement. 
        /// <para>
        /// After the Lambda function specified in the <c>fulfillmentActivity</c> element fulfills
        /// the intent, Amazon Lex conveys this statement to the user.
        /// </para>
        /// </summary>
        public Statement ConclusionStatement { get; set; }

        /// <summary>
        /// Checks to see if the ConclusionStatement property is set.
        /// </summary>
        internal bool IsSetConclusionStatement() => this.ConclusionStatement != null;

        /// <summary>
        /// Gets and sets the property ConfirmationPrompt. 
        /// <para>
        /// If defined in the bot, Amazon Lex uses prompt to confirm the intent before fulfilling
        /// the user's request. For more information, see <a>PutIntent</a>. 
        /// </para>
        /// </summary>
        public Prompt ConfirmationPrompt { get; set; }

        /// <summary>
        /// Checks to see if the ConfirmationPrompt property is set.
        /// </summary>
        internal bool IsSetConfirmationPrompt() => this.ConfirmationPrompt != null;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date that the intent was created.
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
        /// A description of the intent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DialogCodeHook. 
        /// <para>
        /// If defined in the bot, Amazon Amazon Lex invokes this Lambda function for each user
        /// input. For more information, see <a>PutIntent</a>. 
        /// </para>
        /// </summary>
        public CodeHook DialogCodeHook { get; set; }

        /// <summary>
        /// Checks to see if the DialogCodeHook property is set.
        /// </summary>
        internal bool IsSetDialogCodeHook() => this.DialogCodeHook != null;

        /// <summary>
        /// Gets and sets the property FollowUpPrompt. 
        /// <para>
        /// If defined in the bot, Amazon Lex uses this prompt to solicit additional user activity
        /// after the intent is fulfilled. For more information, see <a>PutIntent</a>.
        /// </para>
        /// </summary>
        public FollowUpPrompt FollowUpPrompt { get; set; }

        /// <summary>
        /// Checks to see if the FollowUpPrompt property is set.
        /// </summary>
        internal bool IsSetFollowUpPrompt() => this.FollowUpPrompt != null;

        /// <summary>
        /// Gets and sets the property FulfillmentActivity. 
        /// <para>
        /// Describes how the intent is fulfilled. For more information, see <a>PutIntent</a>.
        /// 
        /// </para>
        /// </summary>
        public FulfillmentActivity FulfillmentActivity { get; set; }

        /// <summary>
        /// Checks to see if the FulfillmentActivity property is set.
        /// </summary>
        internal bool IsSetFulfillmentActivity() => this.FulfillmentActivity != null;

        /// <summary>
        /// Gets and sets the property InputContexts. 
        /// <para>
        /// An array of <c>InputContext</c> objects that lists the contexts that must be active
        /// for Amazon Lex to choose the intent in a conversation with the user.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<InputContext> InputContexts { get; set; } = AWSConfigs.InitializeCollections ? new List<InputContext>() : null;

        /// <summary>
        /// Checks to see if the InputContexts property is set.
        /// </summary>
        internal bool IsSetInputContexts() => this.InputContexts != null && (this.InputContexts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KendraConfiguration. 
        /// <para>
        /// Configuration information, if any, to connect to an Amazon Kendra index with the <c>AMAZON.KendraSearchIntent</c>
        /// intent.
        /// </para>
        /// </summary>
        public KendraConfiguration KendraConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the KendraConfiguration property is set.
        /// </summary>
        internal bool IsSetKendraConfiguration() => this.KendraConfiguration != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDate. 
        /// <para>
        /// The date that the intent was updated. When you create a resource, the creation date
        /// and the last updated date are the same. 
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDate property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDate() => this.LastUpdatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the intent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OutputContexts. 
        /// <para>
        /// An array of <c>OutputContext</c> objects that lists the contexts that the intent activates
        /// when the intent is fulfilled.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<OutputContext> OutputContexts { get; set; } = AWSConfigs.InitializeCollections ? new List<OutputContext>() : null;

        /// <summary>
        /// Checks to see if the OutputContexts property is set.
        /// </summary>
        internal bool IsSetOutputContexts() => this.OutputContexts != null && (this.OutputContexts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ParentIntentSignature. 
        /// <para>
        /// A unique identifier for a built-in intent.
        /// </para>
        /// </summary>
        public string ParentIntentSignature { get; set; }

        /// <summary>
        /// Checks to see if the ParentIntentSignature property is set.
        /// </summary>
        internal bool IsSetParentIntentSignature() => this.ParentIntentSignature != null;

        /// <summary>
        /// Gets and sets the property RejectionStatement. 
        /// <para>
        /// If the user answers "no" to the question defined in <c>confirmationPrompt</c>, Amazon
        /// Lex responds with this statement to acknowledge that the intent was canceled. 
        /// </para>
        /// </summary>
        public Statement RejectionStatement { get; set; }

        /// <summary>
        /// Checks to see if the RejectionStatement property is set.
        /// </summary>
        internal bool IsSetRejectionStatement() => this.RejectionStatement != null;

        /// <summary>
        /// Gets and sets the property SampleUtterances. 
        /// <para>
        /// An array of sample utterances configured for the intent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1500)]
        public List<string> SampleUtterances { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SampleUtterances property is set.
        /// </summary>
        internal bool IsSetSampleUtterances() => this.SampleUtterances != null && (this.SampleUtterances.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Slots. 
        /// <para>
        /// An array of intent slots configured for the intent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<Slot> Slots { get; set; } = AWSConfigs.InitializeCollections ? new List<Slot>() : null;

        /// <summary>
        /// Checks to see if the Slots property is set.
        /// </summary>
        internal bool IsSetSlots() => this.Slots != null && (this.Slots.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the intent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
