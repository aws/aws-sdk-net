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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// The new custom vocabulary item from the custom vocabulary list.
    /// </summary>
    public partial class NewCustomVocabularyItem
    {
        /// <summary>
        /// Gets and sets the property DisplayAs. 
        /// <para>
        /// The display as value assigned to the new custom vocabulary item from the custom vocabulary
        /// list.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string DisplayAs { get; set; }

        /// <summary>
        /// Checks to see if the DisplayAs property is set.
        /// </summary>
        internal bool IsSetDisplayAs() => this.DisplayAs != null;

        /// <summary>
        /// Gets and sets the property Phrase. 
        /// <para>
        /// The unique phrase for the new custom vocabulary item from the custom vocabulary list.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Phrase { get; set; }

        /// <summary>
        /// Checks to see if the Phrase property is set.
        /// </summary>
        internal bool IsSetPhrase() => this.Phrase != null;

        /// <summary>
        /// Gets and sets the property Weight. 
        /// <para>
        /// The weight assigned to the new custom vocabulary item from the custom vocabulary list.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 3)]
        public int? Weight { get; set; }

        /// <summary>
        /// Checks to see if the Weight property is set.
        /// </summary>
        internal bool IsSetWeight() => this.Weight.HasValue;
    }
}
