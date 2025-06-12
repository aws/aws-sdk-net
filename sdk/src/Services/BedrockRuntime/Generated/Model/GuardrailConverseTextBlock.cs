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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
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
namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// A text block that contains text that you want to assess with a guardrail. For more
    /// information, see <a>GuardrailConverseContentBlock</a>.
    /// </summary>
    public partial class GuardrailConverseTextBlock
    {
        private List<string> _qualifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _text;

        /// <summary>
        /// Gets and sets the property Qualifiers. 
        /// <para>
        /// The qualifier details for the guardrails contextual grounding filter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Qualifiers
        {
            get { return this._qualifiers; }
            set { this._qualifiers = value; }
        }

        // Check to see if Qualifiers property is set
        internal bool IsSetQualifiers()
        {
            return this._qualifiers != null && (this._qualifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The text that you want to guard.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        // Check to see if Text property is set
        internal bool IsSetText()
        {
            return this._text != null;
        }

    }
}