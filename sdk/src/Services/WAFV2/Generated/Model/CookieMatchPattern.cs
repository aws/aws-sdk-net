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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// The filter to use to identify the subset of cookies to inspect in a web request. 
    /// 
    ///  
    /// <para>
    /// You must specify exactly one setting: either <code>All</code>, <code>IncludedCookies</code>,
    /// or <code>ExcludedCookies</code>.
    /// </para>
    ///  
    /// <para>
    /// Example JSON: <code>"MatchPattern": { "IncludedCookies": [ "session-id-time", "session-id"
    /// ] }</code> 
    /// </para>
    /// </summary>
    public partial class CookieMatchPattern
    {
        private All _all;
        private List<string> _excludedCookies = new List<string>();
        private List<string> _includedCookies = new List<string>();

        /// <summary>
        /// Gets and sets the property All. 
        /// <para>
        /// Inspect all cookies. 
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
        /// Gets and sets the property ExcludedCookies. 
        /// <para>
        /// Inspect only the cookies whose keys don't match any of the strings specified here.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=199)]
        public List<string> ExcludedCookies
        {
            get { return this._excludedCookies; }
            set { this._excludedCookies = value; }
        }

        // Check to see if ExcludedCookies property is set
        internal bool IsSetExcludedCookies()
        {
            return this._excludedCookies != null && this._excludedCookies.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IncludedCookies. 
        /// <para>
        /// Inspect only the cookies that have a key that matches one of the strings specified
        /// here. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=199)]
        public List<string> IncludedCookies
        {
            get { return this._includedCookies; }
            set { this._includedCookies = value; }
        }

        // Check to see if IncludedCookies property is set
        internal bool IsSetIncludedCookies()
        {
            return this._includedCookies != null && this._includedCookies.Count > 0; 
        }

    }
}