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
 * Do not modify this file. This file is generated from the runtime.lex.v2-2020-08-07.normal.json service model.
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
namespace Amazon.LexRuntimeV2.Model
{
    /// <summary>
    /// Provides an array of phrases that should be given preference when resolving values
    /// for a slot.
    /// </summary>
    public partial class RuntimeHintDetails
    {
        private List<RuntimeHintValue> _runtimeHintValues = AWSConfigs.InitializeCollections ? new List<RuntimeHintValue>() : null;
        private Dictionary<string, RuntimeHintDetails> _subSlotHints = AWSConfigs.InitializeCollections ? new Dictionary<string, RuntimeHintDetails>() : null;

        /// <summary>
        /// Gets and sets the property RuntimeHintValues. 
        /// <para>
        /// One or more strings that Amazon Lex V2 should look for in the input to the bot. Each
        /// phrase is given preference when deciding on slot values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<RuntimeHintValue> RuntimeHintValues
        {
            get { return this._runtimeHintValues; }
            set { this._runtimeHintValues = value; }
        }

        // Check to see if RuntimeHintValues property is set
        internal bool IsSetRuntimeHintValues()
        {
            return this._runtimeHintValues != null && (this._runtimeHintValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubSlotHints. 
        /// <para>
        /// A map of constituent sub slot names inside a composite slot in the intent and the
        /// phrases that should be added for each sub slot. Inside each composite slot hints,
        /// this structure provides a mechanism to add granular sub slot phrases. Only sub slot
        /// hints are supported for composite slots. The intent name, composite slot name and
        /// the constituent sub slot names must exist.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, RuntimeHintDetails> SubSlotHints
        {
            get { return this._subSlotHints; }
            set { this._subSlotHints = value; }
        }

        // Check to see if SubSlotHints property is set
        internal bool IsSetSubSlotHints()
        {
            return this._subSlotHints != null && (this._subSlotHints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}