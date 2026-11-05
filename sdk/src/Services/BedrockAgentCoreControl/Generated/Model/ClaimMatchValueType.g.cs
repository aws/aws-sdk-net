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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The value or values to match for.
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Include a <c>matchValueString</c> with the <c>EQUALS</c> operator to specify a string
    /// that matches the claim field value.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Include a <c>matchValueArray</c> to specify an array of string values. You can use
    /// the following operators:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Use <c>CONTAINS</c> to yield a match if the claim field value is in the array.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use <c>CONTAINS_ANY</c> to yield a match if the claim field value contains any of
    /// the strings in the array.
    /// </para>
    ///  </li> </ul> </li> </ul>
    /// </summary>
    public partial class ClaimMatchValueType
    {
        /// <summary>
        /// Gets and sets the property MatchValueString. 
        /// <para>
        /// The string value to match for.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string MatchValueString { get; set; }

        /// <summary>
        /// Checks to see if the MatchValueString property is set.
        /// </summary>
        internal bool IsSetMatchValueString() => this.MatchValueString != null;

        /// <summary>
        /// Gets and sets the property MatchValueStringList. 
        /// <para>
        /// An array of strings to check for a match.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<string> MatchValueStringList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MatchValueStringList property is set.
        /// </summary>
        internal bool IsSetMatchValueStringList() => this.MatchValueStringList != null && (this.MatchValueStringList.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
