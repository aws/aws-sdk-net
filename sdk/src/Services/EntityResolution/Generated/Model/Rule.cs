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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
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
namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// An object containing the <c>ruleName</c> and <c>matchingKeys</c>.
    /// </summary>
    public partial class Rule
    {
        private List<string> _matchingKeys = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _ruleName;

        /// <summary>
        /// Gets and sets the property MatchingKeys. 
        /// <para>
        /// A list of <c>MatchingKeys</c>. The <c>MatchingKeys</c> must have been defined in the
        /// <c>SchemaMapping</c>. Two records are considered to match according to this rule if
        /// all of the <c>MatchingKeys</c> match.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=15)]
        public List<string> MatchingKeys
        {
            get { return this._matchingKeys; }
            set { this._matchingKeys = value; }
        }

        // Check to see if MatchingKeys property is set
        internal bool IsSetMatchingKeys()
        {
            return this._matchingKeys != null && (this._matchingKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RuleName. 
        /// <para>
        /// A name for the matching rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=255)]
        public string RuleName
        {
            get { return this._ruleName; }
            set { this._ruleName = value; }
        }

        // Check to see if RuleName property is set
        internal bool IsSetRuleName()
        {
            return this._ruleName != null;
        }

    }
}