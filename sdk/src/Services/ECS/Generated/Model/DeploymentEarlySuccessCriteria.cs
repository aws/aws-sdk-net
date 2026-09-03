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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// <note> 
    /// <para>
    /// You can use early success criteria only with rolling deployment strategy.
    /// 
    ///  </note> 
    /// <para>
    /// The configuration that determines when a rolling update deployment is considered successful.
    /// Early success criteria defines the percentage of tasks that must be healthy before
    /// a deployment completes. It also controls whether Amazon ECS must remove the previous
    /// tasks before a deployment completes.
    /// </para>
    /// 
    /// </para>
    /// </summary>
    public partial class DeploymentEarlySuccessCriteria
    {
        private bool? _enable;
        private int? _healthyPercent;
        private ServiceRevisionCleanup _sourceServiceRevisionCleanup;

        /// <summary>
        /// Gets and sets the property Enable. 
        /// <para>
        /// Specifies whether to use the early success criteria for the service deployment. When
        /// set to <c>false</c>, the deployment uses the default behavior, where Amazon ECS considers
        /// the deployment successful when the target service revision fully stabilizes and the
        /// previous tasks are removed. The default value is <c>false</c>.
        /// </para>
        ///  
        /// <para>
        /// When set to <c>true</c>, Amazon ECS monitors the deployment to meet early success
        /// criteria. You must also specify <c>healthyPercent</c> and <c>sourceServiceRevisionCleanup</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Enable
        {
            get { return this._enable; }
            set { this._enable = value; }
        }

        // Check to see if Enable property is set
        internal bool IsSetEnable()
        {
            return this._enable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HealthyPercent. 
        /// <para>
        /// The percentage of healthy tasks that the target service revision must reach before
        /// Amazon ECS considers the deployment successful. This percentage is relative to the
        /// service's <c>desiredCount</c> and must be an integer between <c>0</c> and <c>100</c>.
        /// This value must be greater than or equal to the <c>minimumHealthyPercent</c> value.
        /// </para>
        ///  
        /// <para>
        /// After this percentage of tasks is healthy and the bake time elapses, Amazon ECS completes
        /// the deployment. Amazon ECS continues to scale the target service revision to 100 percent
        /// in the background.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? HealthyPercent
        {
            get { return this._healthyPercent; }
            set { this._healthyPercent = value; }
        }

        // Check to see if HealthyPercent property is set
        internal bool IsSetHealthyPercent()
        {
            return this._healthyPercent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceServiceRevisionCleanup. 
        /// <para>
        /// The time when Amazon ECS removes the source revisions' tasks relative to deployment
        /// completion. The valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>BLOCKING</c>—Amazon ECS removes the previous tasks before it marks the deployment
        /// as successful.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DEFERRED</c>—Amazon ECS marks the deployment successful, and then removes the
        /// previous tasks in the background.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ServiceRevisionCleanup SourceServiceRevisionCleanup
        {
            get { return this._sourceServiceRevisionCleanup; }
            set { this._sourceServiceRevisionCleanup = value; }
        }

        // Check to see if SourceServiceRevisionCleanup property is set
        internal bool IsSetSourceServiceRevisionCleanup()
        {
            return this._sourceServiceRevisionCleanup != null;
        }

    }
}