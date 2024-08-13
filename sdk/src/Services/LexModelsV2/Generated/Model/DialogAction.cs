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
    /// Defines the action that the bot executes at runtime when the conversation reaches
    /// this step.
    /// </summary>
    public partial class DialogAction
    {
        private string _slotToElicit;
        private bool? _suppressNextMessage;
        private DialogActionType _type;

        /// <summary>
        /// Gets and sets the property SlotToElicit. 
        /// <para>
        /// If the dialog action is <c>ElicitSlot</c>, defines the slot to elicit from the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string SlotToElicit
        {
            get { return this._slotToElicit; }
            set { this._slotToElicit = value; }
        }

        // Check to see if SlotToElicit property is set
        internal bool IsSetSlotToElicit()
        {
            return this._slotToElicit != null;
        }

        /// <summary>
        /// Gets and sets the property SuppressNextMessage. 
        /// <para>
        /// When true the next message for the intent is not used.
        /// </para>
        /// </summary>
        public bool? SuppressNextMessage
        {
            get { return this._suppressNextMessage; }
            set { this._suppressNextMessage = value; }
        }

        // Check to see if SuppressNextMessage property is set
        internal bool IsSetSuppressNextMessage()
        {
            return this._suppressNextMessage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The action that the bot should execute. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DialogActionType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}