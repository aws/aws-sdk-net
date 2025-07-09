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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// The tier that your guardrail uses for denied topic filters.
    /// </summary>
    public partial class GuardrailTopicsTier
    {
        private GuardrailTopicsTierName _tierName;

        /// <summary>
        /// Gets and sets the property TierName. 
        /// <para>
        /// The tier that your guardrail uses for denied topic filters. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CLASSIC</c> tier – Provides established guardrails functionality supporting English,
        /// French, and Spanish languages.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STANDARD</c> tier – Provides a more robust solution than the <c>CLASSIC</c> tier
        /// and has more comprehensive language support. This tier requires that your guardrail
        /// use <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/guardrails-cross-region.html">cross-Region
        /// inference</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public GuardrailTopicsTierName TierName
        {
            get { return this._tierName; }
            set { this._tierName = value; }
        }

        // Check to see if TierName property is set
        internal bool IsSetTierName()
        {
            return this._tierName != null;
        }

    }
}