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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
        private InstanceBandwidthWeighting _bandwidthWeighting;
        private bool? _dryRun;
        private string _instanceId;

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
        [AWSProperty(Required=true)]
        public InstanceBandwidthWeighting BandwidthWeighting
        {
            get { return this._bandwidthWeighting; }
            set { this._bandwidthWeighting = value; }
        }

        // Check to see if BandwidthWeighting property is set
        internal bool IsSetBandwidthWeighting()
        {
            return this._bandwidthWeighting != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the operation, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

    }
}