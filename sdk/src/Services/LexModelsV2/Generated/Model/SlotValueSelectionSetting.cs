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
    /// Contains settings used by Amazon Lex to select a slot value.
    /// </summary>
    public partial class SlotValueSelectionSetting
    {
        private AdvancedRecognitionSetting _advancedRecognitionSetting;
        private SlotValueRegexFilter _regexFilter;
        private SlotValueResolutionStrategy _resolutionStrategy;

        /// <summary>
        /// Gets and sets the property AdvancedRecognitionSetting. 
        /// <para>
        /// Provides settings that enable advanced recognition settings for slot values. You can
        /// use this to enable using slot values as a custom vocabulary for recognizing user utterances.
        /// </para>
        /// </summary>
        public AdvancedRecognitionSetting AdvancedRecognitionSetting
        {
            get { return this._advancedRecognitionSetting; }
            set { this._advancedRecognitionSetting = value; }
        }

        // Check to see if AdvancedRecognitionSetting property is set
        internal bool IsSetAdvancedRecognitionSetting()
        {
            return this._advancedRecognitionSetting != null;
        }

        /// <summary>
        /// Gets and sets the property RegexFilter. 
        /// <para>
        /// A regular expression used to validate the value of a slot.
        /// </para>
        /// </summary>
        public SlotValueRegexFilter RegexFilter
        {
            get { return this._regexFilter; }
            set { this._regexFilter = value; }
        }

        // Check to see if RegexFilter property is set
        internal bool IsSetRegexFilter()
        {
            return this._regexFilter != null;
        }

        /// <summary>
        /// Gets and sets the property ResolutionStrategy. 
        /// <para>
        /// Determines the slot resolution strategy that Amazon Lex uses to return slot type values.
        /// The field can be set to one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ORIGINAL_VALUE</c> - Returns the value entered by the user, if the user value
        /// is similar to the slot value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TOP_RESOLUTION</c> - If there is a resolution list for the slot, return the first
        /// value in the resolution list as the slot type value. If there is no resolution list,
        /// null is returned.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify the <c>valueSelectionStrategy</c>, the default is <c>ORIGINAL_VALUE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SlotValueResolutionStrategy ResolutionStrategy
        {
            get { return this._resolutionStrategy; }
            set { this._resolutionStrategy = value; }
        }

        // Check to see if ResolutionStrategy property is set
        internal bool IsSetResolutionStrategy()
        {
            return this._resolutionStrategy != null;
        }

    }
}