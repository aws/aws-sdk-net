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
    /// Specifies the settings on a prompt attempt.
    /// </summary>
    public partial class PromptAttemptSpecification
    {
        /// <summary>
        /// Gets and sets the property AllowInterrupt. 
        /// <para>
        /// Indicates whether the user can interrupt a speech prompt attempt from the bot.
        /// </para>
        /// </summary>
        public bool? AllowInterrupt { get; set; }

        /// <summary>
        /// Checks to see if the AllowInterrupt property is set.
        /// </summary>
        internal bool IsSetAllowInterrupt() => this.AllowInterrupt.HasValue;

        /// <summary>
        /// Gets and sets the property AllowedInputTypes. 
        /// <para>
        /// Indicates the allowed input types of the prompt attempt.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AllowedInputTypes AllowedInputTypes { get; set; }

        /// <summary>
        /// Checks to see if the AllowedInputTypes property is set.
        /// </summary>
        internal bool IsSetAllowedInputTypes() => this.AllowedInputTypes != null;

        /// <summary>
        /// Gets and sets the property AudioAndDTMFInputSpecification. 
        /// <para>
        /// Specifies the settings on audio and DTMF input.
        /// </para>
        /// </summary>
        public AudioAndDTMFInputSpecification AudioAndDTMFInputSpecification { get; set; }

        /// <summary>
        /// Checks to see if the AudioAndDTMFInputSpecification property is set.
        /// </summary>
        internal bool IsSetAudioAndDTMFInputSpecification() => this.AudioAndDTMFInputSpecification != null;

        /// <summary>
        /// Gets and sets the property TextInputSpecification. 
        /// <para>
        /// Specifies the settings on text input.
        /// </para>
        /// </summary>
        public TextInputSpecification TextInputSpecification { get; set; }

        /// <summary>
        /// Checks to see if the TextInputSpecification property is set.
        /// </summary>
        internal bool IsSetTextInputSpecification() => this.TextInputSpecification != null;
    }
}
