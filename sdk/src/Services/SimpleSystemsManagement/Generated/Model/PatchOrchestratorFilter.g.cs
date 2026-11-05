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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Defines a filter used in Patch Manager APIs. Supported filter keys depend on the API
    /// operation that includes the filter. Patch Manager API operations that use <c>PatchOrchestratorFilter</c>
    /// include the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <a>DescribeAvailablePatches</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeInstancePatches</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribePatchBaselines</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribePatchGroups</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PatchOrchestratorFilter
    {
        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The key for the filter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The value for the filter.
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
