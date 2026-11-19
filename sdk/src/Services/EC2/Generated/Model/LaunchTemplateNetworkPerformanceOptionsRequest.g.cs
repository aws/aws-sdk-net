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
    /// When you configure network performance options in your launch template, your instance
    /// is geared for performance improvements based on the workload that it runs as soon
    /// as it's available.
    /// </summary>
    public partial class LaunchTemplateNetworkPerformanceOptionsRequest
    {
        /// <summary>
        /// Gets and sets the property BandwidthWeighting. 
        /// <para>
        /// Specify the bandwidth weighting option to boost the associated type of baseline bandwidth,
        /// as follows:
        /// </para>
        ///  <dl> <dt>default</dt> <dd> 
        /// <para>
        /// This option uses the standard bandwidth configuration for your instance type.
        /// </para>
        ///  </dd> <dt>vpc-1</dt> <dd> 
        /// <para>
        /// This option boosts your networking baseline bandwidth and reduces your EBS baseline
        /// bandwidth.
        /// </para>
        ///  </dd> <dt>ebs-1</dt> <dd> 
        /// <para>
        /// This option boosts your EBS baseline bandwidth and reduces your networking baseline
        /// bandwidth.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public InstanceBandwidthWeighting BandwidthWeighting { get; set; }

        /// <summary>
        /// Checks to see if the BandwidthWeighting property is set.
        /// </summary>
        internal bool IsSetBandwidthWeighting() => this.BandwidthWeighting != null;
    }
}
