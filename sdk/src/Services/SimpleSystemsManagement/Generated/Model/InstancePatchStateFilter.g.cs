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
    /// Defines a filter used in <a>DescribeInstancePatchStatesForPatchGroup</a> to scope
    /// down the information returned by the API.
    /// 
    ///  
    /// <para>
    ///  <b>Example</b>: To filter for all managed nodes in a patch group having more than
    /// three patches with a <c>FailedCount</c> status, use the following for the filter:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Value for <c>Key</c>: <c>FailedCount</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Value for <c>Type</c>: <c>GreaterThan</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Value for <c>Values</c>: <c>3</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class InstancePatchStateFilter
    {
        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The key for the filter. Supported values include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>InstalledCount</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InstalledOtherCount</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InstalledPendingRebootCount</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InstalledRejectedCount</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MissingCount</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FailedCount</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UnreportedNotApplicableCount</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NotApplicableCount</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of comparison that should be performed for the value.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InstancePatchStateOperatorType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The value for the filter. Must be an integer greater than or equal to 0.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<string> Values { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Values property is set.
        /// </summary>
        internal bool IsSetValues() => this.Values != null && (this.Values.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
