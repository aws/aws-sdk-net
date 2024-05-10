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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
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
    /// Container for the parameters to the DeregisterCompute operation.
    /// <b>This operation has been expanded to use with the Amazon GameLift containers feature,
    /// which is currently in public preview.</b> 
    /// 
    ///  
    /// <para>
    /// Removes a compute resource from an Amazon GameLift Anywhere fleet or container fleet.
    /// Deregistered computes can no longer host game sessions through Amazon GameLift.
    /// </para>
    ///  
    /// <para>
    /// For an Anywhere fleet or a container fleet that's running the Amazon GameLift Agent,
    /// the Agent handles all compute registry tasks for you. For an Anywhere fleet that doesn't
    /// use the Agent, call this operation to deregister fleet computes. 
    /// </para>
    ///  
    /// <para>
    /// To deregister a compute, call this operation from the compute that's being deregistered
    /// and specify the compute name and the fleet ID. 
    /// </para>
    /// </summary>
    public partial class DeregisterComputeRequest : AmazonGameLiftRequest
    {
        private string _computeName;
        private string _fleetId;

        /// <summary>
        /// Gets and sets the property ComputeName. 
        /// <para>
        /// The unique identifier of the compute resource to deregister. For an Anywhere fleet
        /// compute, use the registered compute name. For a container fleet, use the compute name
        /// (for example, <c>a123b456c789012d3e4567f8a901b23c/1a234b56-7cd8-9e0f-a1b2-c34d567ef8a9</c>)
        /// or the compute ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
        public string ComputeName
        {
            get { return this._computeName; }
            set { this._computeName = value; }
        }

        // Check to see if ComputeName property is set
        internal bool IsSetComputeName()
        {
            return this._computeName != null;
        }

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the fleet the compute resource is currently registered to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FleetId
        {
            get { return this._fleetId; }
            set { this._fleetId = value; }
        }

        // Check to see if FleetId property is set
        internal bool IsSetFleetId()
        {
            return this._fleetId != null;
        }

    }
}