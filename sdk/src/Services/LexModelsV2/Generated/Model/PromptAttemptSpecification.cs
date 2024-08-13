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
    /// Specifies the settings on a prompt attempt.
    /// </summary>
    public partial class PromptAttemptSpecification
    {
        private AllowedInputTypes _allowedInputTypes;
        private bool? _allowInterrupt;
        private AudioAndDTMFInputSpecification _audioAndDTMFInputSpecification;
        private TextInputSpecification _textInputSpecification;

        /// <summary>
        /// Gets and sets the property AllowedInputTypes. 
        /// <para>
        /// Indicates the allowed input types of the prompt attempt.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AllowedInputTypes AllowedInputTypes
        {
            get { return this._allowedInputTypes; }
            set { this._allowedInputTypes = value; }
        }

        // Check to see if AllowedInputTypes property is set
        internal bool IsSetAllowedInputTypes()
        {
            return this._allowedInputTypes != null;
        }

        /// <summary>
        /// Gets and sets the property AllowInterrupt. 
        /// <para>
        /// Indicates whether the user can interrupt a speech prompt attempt from the bot.
        /// </para>
        /// </summary>
        public bool? AllowInterrupt
        {
            get { return this._allowInterrupt; }
            set { this._allowInterrupt = value; }
        }

        // Check to see if AllowInterrupt property is set
        internal bool IsSetAllowInterrupt()
        {
            return this._allowInterrupt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AudioAndDTMFInputSpecification. 
        /// <para>
        /// Specifies the settings on audio and DTMF input.
        /// </para>
        /// </summary>
        public AudioAndDTMFInputSpecification AudioAndDTMFInputSpecification
        {
            get { return this._audioAndDTMFInputSpecification; }
            set { this._audioAndDTMFInputSpecification = value; }
        }

        // Check to see if AudioAndDTMFInputSpecification property is set
        internal bool IsSetAudioAndDTMFInputSpecification()
        {
            return this._audioAndDTMFInputSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property TextInputSpecification. 
        /// <para>
        /// Specifies the settings on text input.
        /// </para>
        /// </summary>
        public TextInputSpecification TextInputSpecification
        {
            get { return this._textInputSpecification; }
            set { this._textInputSpecification = value; }
        }

        // Check to see if TextInputSpecification property is set
        internal bool IsSetTextInputSpecification()
        {
            return this._textInputSpecification != null;
        }

    }
}