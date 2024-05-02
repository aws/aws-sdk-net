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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
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
namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Validation rules for a text field.
    /// </summary>
    public partial class TextValidation
    {
        private int? _maxLength;
        private int? _minLength;
        private string _pattern;

        /// <summary>
        /// Gets and sets the property MaxLength. 
        /// <para>
        /// The maximum number of characters for the text field.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? MaxLength
        {
            get { return this._maxLength; }
            set { this._maxLength = value; }
        }

        // Check to see if MaxLength property is set
        internal bool IsSetMaxLength()
        {
            return this._maxLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinLength. 
        /// <para>
        /// The minimum number of characters for the text field.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? MinLength
        {
            get { return this._minLength; }
            set { this._minLength = value; }
        }

        // Check to see if MinLength property is set
        internal bool IsSetMinLength()
        {
            return this._minLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Pattern. 
        /// <para>
        /// The regular expression used to validate the text field.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Pattern
        {
            get { return this._pattern; }
            set { this._pattern = value; }
        }

        // Check to see if Pattern property is set
        internal bool IsSetPattern()
        {
            return this._pattern != null;
        }

    }
}