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
    /// Container for the parameters to the RequestSpotFleet operation.
    /// Creates a Spot Fleet request.
    /// 
    ///  
    /// <para>
    /// The Spot Fleet request specifies the total target capacity and the On-Demand target
    /// capacity. Amazon EC2 calculates the difference between the total capacity and On-Demand
    /// capacity, and launches the difference as Spot capacity.
    /// </para>
    ///  
    /// <para>
    /// You can submit a single request that includes multiple launch specifications that
    /// vary by instance type, AMI, Availability Zone, or subnet.
    /// </para>
    ///  
    /// <para>
    /// By default, the Spot Fleet requests Spot Instances in the Spot Instance pool where
    /// the price per unit is the lowest. Each launch specification can include its own instance
    /// weighting that reflects the value of the instance type to your application workload.
    /// </para>
    ///  
    /// <para>
    /// Alternatively, you can specify that the Spot Fleet distribute the target capacity
    /// across the Spot pools included in its launch specifications. By ensuring that the
    /// Spot Instances in your Spot Fleet are in different Spot pools, you can improve the
    /// availability of your fleet.
    /// </para>
    ///  
    /// <para>
    /// You can specify tags for the Spot Fleet request and instances launched by the fleet.
    /// You cannot tag other resource types in a Spot Fleet request because only the <c>spot-fleet-request</c>
    /// and <c>instance</c> resource types are supported.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-fleet-requests.html">Spot
    /// Fleet requests</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    ///  <important> 
    /// <para>
    /// We strongly discourage using the RequestSpotFleet API because it is a legacy API with
    /// no planned investment. For options for requesting Spot Instances, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-best-practices.html#which-spot-request-method-to-use">Which
    /// is the best Spot request method to use?</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class RequestSpotFleetRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private SpotFleetRequestConfigData _spotFleetRequestConfig;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
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
        /// Gets and sets the property SpotFleetRequestConfig. 
        /// <para>
        /// The configuration for the Spot Fleet request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SpotFleetRequestConfigData SpotFleetRequestConfig
        {
            get { return this._spotFleetRequestConfig; }
            set { this._spotFleetRequestConfig = value; }
        }

        // Check to see if SpotFleetRequestConfig property is set
        internal bool IsSetSpotFleetRequestConfig()
        {
            return this._spotFleetRequestConfig != null;
        }

    }
}