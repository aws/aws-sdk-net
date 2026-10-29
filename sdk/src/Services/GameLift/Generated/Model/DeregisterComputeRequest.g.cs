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

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the DeregisterCompute operation. <b>This API works
    /// with the following fleet types:</b> Anywhere <para> Removes a compute resource from
    /// an Anywhere fleet. Deregistered computes can no longer host game sessions through
    /// Amazon GameLift Servers. Use this operation with an Anywhere fleet that doesn't use
    /// the Amazon GameLift Servers Agent. For Anywhere fleets with the Agent, the Agent handles
    /// all compute registry tasks for you. </para> <para> To deregister a compute, call this
    /// operation from the compute that's being deregistered and specify the compute name
    /// and the fleet ID. </para>
    /// </summary>
    public partial class DeregisterComputeRequest : AmazonGameLiftRequest
    {
        /// <summary>
        /// Gets and sets the property ComputeName. 
        /// <para>
        /// The unique identifier of the compute resource to deregister. For an Anywhere fleet
        /// compute, use the registered compute name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string ComputeName { get; set; }

        /// <summary>
        /// Checks to see if the ComputeName property is set.
        /// </summary>
        internal bool IsSetComputeName() => this.ComputeName != null;

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the fleet the compute resource is currently registered to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string FleetId { get; set; }

        /// <summary>
        /// Checks to see if the FleetId property is set.
        /// </summary>
        internal bool IsSetFleetId() => this.FleetId != null;
    }
}
