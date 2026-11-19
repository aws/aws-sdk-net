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
    /// Describes the cost allocation policy document for EC2 instances.
    /// </summary>
    public partial class InstanceFlexCostAllocationPolicyDocument
    {
        /// <summary>
        /// Gets and sets the property CidrRangeSpecifications. 
        /// <para>
        /// The CIDR range mappings to use for cost allocation. Specify this value when <c>ReportingGranularity</c>
        /// is <c>cidr</c>, and omit it otherwise.
        /// </para>
        /// </summary>
        public FlexCostAllocationCidrRangeSpecifications CidrRangeSpecifications { get; set; }

        /// <summary>
        /// Checks to see if the CidrRangeSpecifications property is set.
        /// </summary>
        internal bool IsSetCidrRangeSpecifications() => this.CidrRangeSpecifications != null;

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The cost dimensions to report. This parameter is required. The only valid value is
        /// <c>data-transfer</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2)]
        public List<string> Dimensions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Dimensions property is set.
        /// </summary>
        internal bool IsSetDimensions() => this.Dimensions != null && (this.Dimensions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReportingGranularity. 
        /// <para>
        /// The resource granularity level at which networking costs are allocated. This parameter
        /// is required. Specify exactly one value. Valid values are <c>eni</c>, <c>ec2</c>, <c>subnet</c>,
        /// <c>vpc</c>, <c>account</c>, and <c>cidr</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<string> ReportingGranularity { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ReportingGranularity property is set.
        /// </summary>
        internal bool IsSetReportingGranularity() => this.ReportingGranularity != null && (this.ReportingGranularity.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
