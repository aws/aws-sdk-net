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
 * Do not modify this file. This file is generated from the qapps-2023-11-27.normal.json service model.
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
namespace Amazon.QApps.Model
{
    /// <summary>
    /// The value or result associated with a card in a Amazon Q App session.
    /// </summary>
    public partial class CardValue
    {
        private string _cardId;
        private SubmissionMutation _submissionMutation;
        private string _value;

        /// <summary>
        /// Gets and sets the property CardId. 
        /// <para>
        /// The unique identifier of the card.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CardId
        {
            get { return this._cardId; }
            set { this._cardId = value; }
        }

        // Check to see if CardId property is set
        internal bool IsSetCardId()
        {
            return this._cardId != null;
        }

        /// <summary>
        /// Gets and sets the property SubmissionMutation. 
        /// <para>
        /// The structure that describes how the current form card value is mutated. Only applies
        /// for form cards when multiple responses are allowed.
        /// </para>
        /// </summary>
        public SubmissionMutation SubmissionMutation
        {
            get { return this._submissionMutation; }
            set { this._submissionMutation = value; }
        }

        // Check to see if SubmissionMutation property is set
        internal bool IsSetSubmissionMutation()
        {
            return this._submissionMutation != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value or result associated with the card.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=40000)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}