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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
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
namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Provides configuration information for a slot type.
    /// </summary>
    public partial class SlotTypeConfiguration
    {
        private SlotTypeRegexConfiguration _regexConfiguration;

        /// <summary>
        /// Gets and sets the property RegexConfiguration. 
        /// <para>
        /// A regular expression used to validate the value of a slot.
        /// </para>
        /// </summary>
        public SlotTypeRegexConfiguration RegexConfiguration
        {
            get { return this._regexConfiguration; }
            set { this._regexConfiguration = value; }
        }

        // Check to see if RegexConfiguration property is set
        internal bool IsSetRegexConfiguration()
        {
            return this._regexConfiguration != null;
        }

    }
}