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

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// The values that are available for a tag.
    /// 
    ///  
    /// <para>
    /// If <c>Values</c> and <c>Key</c> aren't specified, the <c>ABSENT</c> <c>MatchOption</c>
    /// is applied to all tags. That is, it's filtered on resources with no tags.
    /// </para>
    ///  
    /// <para>
    /// If <c>Key</c> is provided and <c>Values</c> isn't specified, the <c>ABSENT</c> <c>MatchOption</c>
    /// is applied to the tag <c>Key</c> only. That is, it's filtered on resources without
    /// the given tag key.
    /// </para>
    /// </summary>
    public partial class TagValues
    {
        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The key for the tag.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property MatchOptions. 
        /// <para>
        /// The match options that you can use to filter your results. <c>MatchOptions</c> is
        /// only applicable for actions related to cost category. The default values for <c>MatchOptions</c>
        /// are <c>EQUALS</c> and <c>CASE_SENSITIVE</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MatchOptions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MatchOptions property is set.
        /// </summary>
        internal bool IsSetMatchOptions() => this.MatchOptions != null && (this.MatchOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The specific value of the tag.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Values { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Values property is set.
        /// </summary>
        internal bool IsSetValues() => this.Values != null && (this.Values.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
