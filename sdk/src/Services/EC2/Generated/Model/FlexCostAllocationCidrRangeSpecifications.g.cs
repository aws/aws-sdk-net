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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Specifies the CIDR ranges and labels to use for cost allocation when the reporting
    /// granularity is <c>cidr</c>.
    /// </summary>
    public partial class FlexCostAllocationCidrRangeSpecifications
    {
        /// <summary>
        /// Gets and sets the property Prefixes. 
        /// <para>
        /// The CIDR range to label mappings. You can specify from 1 to 100 mappings. This parameter
        /// is required.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public List<FlexCostAllocationCidrMapping> Prefixes { get; set; } = AWSConfigs.InitializeCollections ? new List<FlexCostAllocationCidrMapping>() : null;

        /// <summary>
        /// Checks to see if the Prefixes property is set.
        /// </summary>
        internal bool IsSetPrefixes() => this.Prefixes != null && (this.Prefixes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PrefixesType. 
        /// <para>
        /// The type of prefixes to use. This parameter is required. Valid values are <c>source-prefixes</c>
        /// and <c>destination-prefixes</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string PrefixesType { get; set; }

        /// <summary>
        /// Checks to see if the PrefixesType property is set.
        /// </summary>
        internal bool IsSetPrefixesType() => this.PrefixesType != null;
    }
}
