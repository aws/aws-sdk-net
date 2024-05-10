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
    /// Provides a regular expression used to validate the value of a slot.
    /// </summary>
    public partial class SlotTypeRegexConfiguration
    {
        private string _pattern;

        /// <summary>
        /// Gets and sets the property Pattern. 
        /// <para>
        /// A regular expression used to validate the value of a slot. 
        /// </para>
        ///  
        /// <para>
        /// Use a standard regular expression. Amazon Lex supports the following characters in
        /// the regular expression:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A-Z, a-z
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 0-9
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Unicode characters ("\ u&lt;Unicode&gt;")
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Represent Unicode characters with four digits, for example "\u0041" or "\u005A".
        /// </para>
        ///  
        /// <para>
        /// The following regular expression operators are not supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Infinite repeaters: *, +, or {x,} with no upper bound.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Wild card (.)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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