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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// The filter to use to identify the subset of cookies to inspect in a web request. 
    /// 
    ///  
    /// <para>
    /// You must specify exactly one setting: either <c>All</c>, <c>IncludedCookies</c>, or
    /// <c>ExcludedCookies</c>.
    /// </para>
    ///  
    /// <para>
    /// Example JSON: <c>"MatchPattern": { "IncludedCookies": [ "session-id-time", "session-id"
    /// ] }</c> 
    /// </para>
    /// </summary>
    public partial class CookieMatchPattern
    {
        /// <summary>
        /// Gets and sets the property All. 
        /// <para>
        /// Inspect all cookies. 
        /// </para>
        /// </summary>
        public All All { get; set; }

        /// <summary>
        /// Checks to see if the All property is set.
        /// </summary>
        internal bool IsSetAll() => this.All != null;

        /// <summary>
        /// Gets and sets the property ExcludedCookies. 
        /// <para>
        /// Inspect only the cookies whose keys don't match any of the strings specified here.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 199)]
        public List<string> ExcludedCookies { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ExcludedCookies property is set.
        /// </summary>
        internal bool IsSetExcludedCookies() => this.ExcludedCookies != null && (this.ExcludedCookies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IncludedCookies. 
        /// <para>
        /// Inspect only the cookies that have a key that matches one of the strings specified
        /// here. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 199)]
        public List<string> IncludedCookies { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the IncludedCookies property is set.
        /// </summary>
        internal bool IsSetIncludedCookies() => this.IncludedCookies != null && (this.IncludedCookies.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
