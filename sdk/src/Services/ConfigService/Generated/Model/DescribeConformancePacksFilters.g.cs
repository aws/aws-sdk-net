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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Filters for filtering results from <a>DescribeConformancePacks</a> and <a>DescribeConformancePackStatus</a>
    /// by conformance pack type.
    /// </summary>
    public partial class DescribeConformancePacksFilters
    {
        /// <summary>
        /// Gets and sets the property Types. 
        /// <para>
        /// Filters results by conformance pack type. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CUSTOM</c> – A custom conformance pack.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MANAGED</c> – A managed conformance pack.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you specify both values, Config returns conformance packs of either type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public List<string> Types { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Types property is set.
        /// </summary>
        internal bool IsSetTypes() => this.Types != null && (this.Types.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
