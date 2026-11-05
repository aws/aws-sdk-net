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

namespace Amazon.LexRuntimeV2.Model
{
    /// <summary>
    /// Information about the value provided for a slot and Amazon Lex V2's interpretation.
    /// </summary>
    public partial class Value
    {
        /// <summary>
        /// Gets and sets the property InterpretedValue. 
        /// <para>
        /// The value that Amazon Lex V2 determines for the slot, given the user input. The actual
        /// value depends on the setting of the value selection strategy for the bot. You can
        /// choose to use the value entered by the user, or you can have Amazon Lex V2 choose
        /// the first value in the <c>resolvedValues</c> list.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string InterpretedValue { get; set; }

        /// <summary>
        /// Checks to see if the InterpretedValue property is set.
        /// </summary>
        internal bool IsSetInterpretedValue() => this.InterpretedValue != null;

        /// <summary>
        /// Gets and sets the property OriginalValue. 
        /// <para>
        /// The part of the user's response to the slot elicitation that Amazon Lex V2 determines
        /// is relevant to the slot value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string OriginalValue { get; set; }

        /// <summary>
        /// Checks to see if the OriginalValue property is set.
        /// </summary>
        internal bool IsSetOriginalValue() => this.OriginalValue != null;

        /// <summary>
        /// Gets and sets the property ResolvedValues. 
        /// <para>
        /// A list of values that Amazon Lex V2 determines are possible resolutions for the user
        /// input. The first value matches the <c>interpretedValue</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ResolvedValues { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ResolvedValues property is set.
        /// </summary>
        internal bool IsSetResolvedValues() => this.ResolvedValues != null && (this.ResolvedValues.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
