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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
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
namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// A structure that contains the settings for a keyword match task.
    /// </summary>
    public partial class KeywordMatchConfiguration
    {
        private List<string> _keywords = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _negate;
        private string _ruleName;

        /// <summary>
        /// Gets and sets the property Keywords. 
        /// <para>
        /// The keywords or phrases that you want to match.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> Keywords
        {
            get { return this._keywords; }
            set { this._keywords = value; }
        }

        // Check to see if Keywords property is set
        internal bool IsSetKeywords()
        {
            return this._keywords != null && (this._keywords.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Negate. 
        /// <para>
        /// Matches keywords or phrases on their presence or absence. If set to <c>TRUE</c>, the
        /// rule matches when all the specified keywords or phrases are absent. Default: <c>FALSE</c>.
        /// </para>
        /// </summary>
        public bool? Negate
        {
            get { return this._negate; }
            set { this._negate = value; }
        }

        // Check to see if Negate property is set
        internal bool IsSetNegate()
        {
            return this._negate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RuleName. 
        /// <para>
        /// The name of the keyword match rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=64)]
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