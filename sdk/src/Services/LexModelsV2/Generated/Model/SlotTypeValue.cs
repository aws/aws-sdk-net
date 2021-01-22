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
    /// Each slot type can have a set of values. Each <code>SlotTypeValue</code> represents
    /// a value that the slot type can take.
    /// </summary>
    public partial class SlotTypeValue
    {
        private SampleValue _sampleValue;
        private List<SampleValue> _synonyms = new List<SampleValue>();

        /// <summary>
        /// Gets and sets the property SampleValue. 
        /// <para>
        /// The value of the slot type entry.
        /// </para>
        /// </summary>
        public SampleValue SampleValue
        {
            get { return this._sampleValue; }
            set { this._sampleValue = value; }
        }

        // Check to see if SampleValue property is set
        internal bool IsSetSampleValue()
        {
            return this._sampleValue != null;
        }

        /// <summary>
        /// Gets and sets the property Synonyms. 
        /// <para>
        /// Additional values releated to the slot type entry.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
        public List<SampleValue> Synonyms
        {
            get { return this._synonyms; }
            set { this._synonyms = value; }
        }

        // Check to see if Synonyms property is set
        internal bool IsSetSynonyms()
        {
            return this._synonyms != null && this._synonyms.Count > 0; 
        }

    }
}