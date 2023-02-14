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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// The unique custom vocabulary item from the custom vocabulary list.
    /// </summary>
    public partial class CustomVocabularyItem
    {
        private string _displayAs;
        private string _itemId;
        private string _phrase;
        private int? _weight;

        /// <summary>
        /// Gets and sets the property DisplayAs. 
        /// <para>
        /// The DisplayAs value for the custom vocabulary item from the custom vocabulary list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string DisplayAs
        {
            get { return this._displayAs; }
            set { this._displayAs = value; }
        }

        // Check to see if DisplayAs property is set
        internal bool IsSetDisplayAs()
        {
            return this._displayAs != null;
        }

        /// <summary>
        /// Gets and sets the property ItemId. 
        /// <para>
        /// The unique item identifer for the custom vocabulary item from the custom vocabulary
        /// list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string ItemId
        {
            get { return this._itemId; }
            set { this._itemId = value; }
        }

        // Check to see if ItemId property is set
        internal bool IsSetItemId()
        {
            return this._itemId != null;
        }

        /// <summary>
        /// Gets and sets the property Phrase. 
        /// <para>
        /// The unique phrase for the custom vocabulary item from the custom vocabulary list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Phrase
        {
            get { return this._phrase; }
            set { this._phrase = value; }
        }

        // Check to see if Phrase property is set
        internal bool IsSetPhrase()
        {
            return this._phrase != null;
        }

        /// <summary>
        /// Gets and sets the property Weight. 
        /// <para>
        /// The weight assigned for the custom vocabulary item from the custom vocabulary list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3)]
        public int Weight
        {
            get { return this._weight.GetValueOrDefault(); }
            set { this._weight = value; }
        }

        // Check to see if Weight property is set
        internal bool IsSetWeight()
        {
            return this._weight.HasValue; 
        }

    }
}