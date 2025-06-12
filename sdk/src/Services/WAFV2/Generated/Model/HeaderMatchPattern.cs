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
    /// The filter to use to identify the subset of headers to inspect in a web request. 
    /// 
    ///  
    /// <para>
    /// You must specify exactly one setting: either <c>All</c>, <c>IncludedHeaders</c>, or
    /// <c>ExcludedHeaders</c>.
    /// </para>
    ///  
    /// <para>
    /// Example JSON: <c>"MatchPattern": { "ExcludedHeaders": [ "KeyToExclude1", "KeyToExclude2"
    /// ] }</c> 
    /// </para>
    /// </summary>
    public partial class HeaderMatchPattern
    {
        private All _all;
        private List<string> _excludedHeaders = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _includedHeaders = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property All. 
        /// <para>
        /// Inspect all headers. 
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
        /// Gets and sets the property ExcludedHeaders. 
        /// <para>
        /// Inspect only the headers whose keys don't match any of the strings specified here.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=199)]
        public List<string> ExcludedHeaders
        {
            get { return this._excludedHeaders; }
            set { this._excludedHeaders = value; }
        }

        // Check to see if ExcludedHeaders property is set
        internal bool IsSetExcludedHeaders()
        {
            return this._excludedHeaders != null && (this._excludedHeaders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IncludedHeaders. 
        /// <para>
        /// Inspect only the headers that have a key that matches one of the strings specified
        /// here. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=199)]
        public List<string> IncludedHeaders
        {
            get { return this._includedHeaders; }
            set { this._includedHeaders = value; }
        }

        // Check to see if IncludedHeaders property is set
        internal bool IsSetIncludedHeaders()
        {
            return this._includedHeaders != null && (this._includedHeaders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}