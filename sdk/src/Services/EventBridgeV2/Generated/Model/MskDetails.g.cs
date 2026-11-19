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

namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// Values EventBridge manages for a subscriber that targets an Amazon MSK cluster.
    /// </summary>
    public partial class MskDetails
    {
        /// <summary>
        /// Gets and sets the property ConnectivityState. 
        /// <para>
        /// Provisioning state of the connectivity EventBridge sets up to the cluster. Distinct
        /// from the subscriber's State, which the customer controls.
        /// </para>
        /// </summary>
        public ConnectivityState ConnectivityState { get; set; }

        /// <summary>
        /// Checks to see if the ConnectivityState property is set.
        /// </summary>
        internal bool IsSetConnectivityState() => this.ConnectivityState != null;

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// Why provisioning failed. Present only when ConnectivityState is PROVISION_FAILED.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string StateReason { get; set; }

        /// <summary>
        /// Checks to see if the StateReason property is set.
        /// </summary>
        internal bool IsSetStateReason() => this.StateReason != null;

        /// <summary>
        /// Gets and sets the property VpcConnectionArn. 
        /// <para>
        /// ARN of the VPC connection EventBridge uses to reach the cluster. Present only for
        /// PRIVATE connectivity, once the connection exists. It is the connection the cluster
        /// owner sees through the MSK ListClientVpcConnections API.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string VpcConnectionArn { get; set; }

        /// <summary>
        /// Checks to see if the VpcConnectionArn property is set.
        /// </summary>
        internal bool IsSetVpcConnectionArn() => this.VpcConnectionArn != null;
    }
}
