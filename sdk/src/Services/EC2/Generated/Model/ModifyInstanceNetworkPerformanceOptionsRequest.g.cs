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
    /// Container for the parameters to the ModifyInstanceNetworkPerformanceOptions operation.
    /// Change the configuration of the network performance options for an existing instance.
    /// </summary>
    public partial class ModifyInstanceNetworkPerformanceOptionsRequest : AmazonEC2Request
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
        [AWSProperty(Required = true)]
        public InstanceBandwidthWeighting BandwidthWeighting { get; set; }

        /// <summary>
        /// Checks to see if the BandwidthWeighting property is set.
        /// </summary>
        internal bool IsSetBandwidthWeighting() => this.BandwidthWeighting != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the operation, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;
    }
}
