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
    /// The resolved load balancer configuration for a service revision. This includes information
    /// about which target groups serve traffic and which listener rules direct traffic to
    /// them.
    /// </summary>
    public partial class ServiceRevisionLoadBalancer
    {
        private string _productionListenerRule;
        private string _targetGroupArn;

        /// <summary>
        /// Gets and sets the property ProductionListenerRule. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the production listener rule or listener that directs
        /// traffic to the target group associated with the service revision.
        /// </para>
        /// </summary>
        public string ProductionListenerRule
        {
            get { return this._productionListenerRule; }
            set { this._productionListenerRule = value; }
        }

        // Check to see if ProductionListenerRule property is set
        internal bool IsSetProductionListenerRule()
        {
            return this._productionListenerRule != null;
        }

        /// <summary>
        /// Gets and sets the property TargetGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the target group associated with the service revision.
        /// </para>
        /// </summary>
        public string TargetGroupArn
        {
            get { return this._targetGroupArn; }
            set { this._targetGroupArn = value; }
        }

        // Check to see if TargetGroupArn property is set
        internal bool IsSetTargetGroupArn()
        {
            return this._targetGroupArn != null;
        }

    }
}