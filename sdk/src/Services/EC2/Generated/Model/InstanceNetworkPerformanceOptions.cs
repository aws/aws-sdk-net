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
    /// With network performance options, you can adjust your bandwidth preferences to meet
    /// the needs of the workload that runs on your instance.
    /// </summary>
    public partial class InstanceNetworkPerformanceOptions
    {
        private InstanceBandwidthWeighting _bandwidthWeighting;

        /// <summary>
        /// Gets and sets the property BandwidthWeighting. 
        /// <para>
        /// When you configure network bandwidth weighting, you can boost your baseline bandwidth
        /// for either networking or EBS by up to 25%. The total available baseline bandwidth
        /// for your instance remains the same. The default option uses the standard bandwidth
        /// configuration for your instance type.
        /// </para>
        /// </summary>
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

    }
}