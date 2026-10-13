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
    /// The Cost Categories values used for filtering the costs.
    /// 
    ///  
    /// <para>
    /// If <c>Values</c> and <c>Key</c> are not specified, the <c>ABSENT</c> <c>MatchOption</c>
    /// is applied to all Cost Categories. That is, it filters on resources that aren't mapped
    /// to any Cost Categories.
    /// </para>
    ///  
    /// <para>
    /// If <c>Values</c> is provided and <c>Key</c> isn't specified, the <c>ABSENT</c> <c>MatchOption</c>
    /// is applied to the Cost Categories <c>Key</c> only. That is, it filters on resources
    /// without the given Cost Categories key.
    /// </para>
    /// </summary>
    public partial class CostCategoryValues
    {
        /// <summary>
        /// Gets and sets the property Key.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property MatchOptions. 
        /// <para>
        /// The match options that you can use to filter your results. MatchOptions is only applicable
        /// for actions related to cost category. The default values for <c>MatchOptions</c> is
        /// <c>EQUALS</c> and <c>CASE_SENSITIVE</c>. 
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
        /// The specific value of the cost category.
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
