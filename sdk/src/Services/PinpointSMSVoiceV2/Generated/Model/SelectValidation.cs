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
    /// Validation rules for a select field.
    /// </summary>
    public partial class SelectValidation
    {
        private int? _maxChoices;
        private int? _minChoices;
        private List<string> _options = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property MaxChoices. 
        /// <para>
        /// The maximum number of choices for the select.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? MaxChoices
        {
            get { return this._maxChoices; }
            set { this._maxChoices = value; }
        }

        // Check to see if MaxChoices property is set
        internal bool IsSetMaxChoices()
        {
            return this._maxChoices.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinChoices. 
        /// <para>
        /// The minimum number of choices for the select.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? MinChoices
        {
            get { return this._minChoices; }
            set { this._minChoices = value; }
        }

        // Check to see if MinChoices property is set
        internal bool IsSetMinChoices()
        {
            return this._minChoices.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// An array of strings for the possible selection options. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Options
        {
            get { return this._options; }
            set { this._options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this._options != null && (this._options.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}