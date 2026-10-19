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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
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
namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Options that control how CodeDeploy manages Amazon EC2 Auto Scaling groups during
    /// a deployment.
    /// </summary>
    public partial class EC2DeploymentOptions
    {
        private List<string> _autoScalingGroupProcessesToSuspend = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupProcessesToSuspend. 
        /// <para>
        /// The Amazon EC2 Auto Scaling processes to suspend during the deployment. CodeDeploy
        /// suspends these processes before it deploys to instances in an Auto Scaling group,
        /// and resumes them when the deployment succeeds, fails, or is stopped. Valid values
        /// are <c>Terminate</c>, <c>AZRebalance</c>, <c>InstanceRefresh</c>, and <c>ScheduledActions</c>.
        /// </para>
        ///  
        /// <para>
        /// This parameter applies only to in-place deployments on the EC2/On-premises compute
        /// platform. If the list is empty, or if the deployment does not target instances in
        /// an Auto Scaling group, no processes are suspended.
        /// </para>
        ///  
        /// <para>
        /// The service role for the deployment group must have permission to call <c>autoscaling:SuspendProcesses</c>
        /// and <c>autoscaling:ResumeProcesses</c> on the target Auto Scaling groups. If the processes
        /// cannot be suspended, the deployment fails before any instance is updated.
        /// </para>
        ///  
        /// <para>
        /// If you suspend <c>ScheduledActions</c>, scheduled actions with a start time during
        /// the deployment are skipped and do not run after the process resumes.
        /// </para>
        ///  <note> 
        /// <para>
        /// If CodeDeploy cannot resume the processes, the deployment fails and the processes
        /// stay suspended until you resume them with the Auto Scaling <c>ResumeProcesses</c>
        /// action. While <c>Terminate</c> is suspended, Auto Scaling does not replace unhealthy
        /// instances. If you suspend <c>Terminate</c>, configure a trigger that notifies you
        /// when a deployment fails.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=4)]
        public List<string> AutoScalingGroupProcessesToSuspend
        {
            get { return this._autoScalingGroupProcessesToSuspend; }
            set { this._autoScalingGroupProcessesToSuspend = value; }
        }

        // Check to see if AutoScalingGroupProcessesToSuspend property is set
        internal bool IsSetAutoScalingGroupProcessesToSuspend()
        {
            return this._autoScalingGroupProcessesToSuspend != null && (this._autoScalingGroupProcessesToSuspend.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}