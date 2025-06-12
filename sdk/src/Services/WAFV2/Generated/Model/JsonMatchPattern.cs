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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// The patterns to look for in the JSON body. WAF inspects the results of these pattern
    /// matches against the rule inspection criteria. This is used with the <a>FieldToMatch</a>
    /// option <c>JsonBody</c>.
    /// </summary>
    public partial class JsonMatchPattern
    {
        private All _all;
        private List<string> _includedPaths = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property All. 
        /// <para>
        /// Match all of the elements. See also <c>MatchScope</c> in <a>JsonBody</a>. 
        /// </para>
        ///  
        /// <para>
        /// You must specify either this setting or the <c>IncludedPaths</c> setting, but not
        /// both.
        /// </para>
        /// </summary>
        public All All
        {
            get { return this._all; }
            set { this._all = value; }
        }

        // Check to see if All property is set
        internal bool IsSetAll()
        {
            return this._all != null;
        }

        /// <summary>
        /// Gets and sets the property IncludedPaths. 
        /// <para>
        /// Match only the specified include paths. See also <c>MatchScope</c> in <a>JsonBody</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Provide the include paths using JSON Pointer syntax. For example, <c>"IncludedPaths":
        /// ["/dogs/0/name", "/dogs/1/name"]</c>. For information about this syntax, see the Internet
        /// Engineering Task Force (IETF) documentation <a href="https://tools.ietf.org/html/rfc6901">JavaScript
        /// Object Notation (JSON) Pointer</a>. 
        /// </para>
        ///  
        /// <para>
        /// You must specify either this setting or the <c>All</c> setting, but not both.
        /// </para>
        ///  <note> 
        /// <para>
        /// Don't use this option to include all paths. Instead, use the <c>All</c> setting. 
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> IncludedPaths
        {
            get { return this._includedPaths; }
            set { this._includedPaths = value; }
        }

        // Check to see if IncludedPaths property is set
        internal bool IsSetIncludedPaths()
        {
            return this._includedPaths != null && (this._includedPaths.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}