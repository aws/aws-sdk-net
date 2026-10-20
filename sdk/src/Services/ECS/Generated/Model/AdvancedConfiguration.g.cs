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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// The advanced settings for a load balancer used in blue/green deployments. Specify
    /// the alternate target group, listener rules, and IAM role required for traffic shifting
    /// during blue/green deployments. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/blue-green-deployment-implementation.html">Required
    /// resources for Amazon ECS blue/green deployments</a> in the <i>Amazon Elastic Container
    /// Service Developer Guide</i>.
    /// </summary>
    public partial class AdvancedConfiguration
    {
        /// <summary>
        /// Gets and sets the property AlternateTargetGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the alternate target group for Amazon ECS blue/green
        /// deployments.
        /// </para>
        /// </summary>
        public string AlternateTargetGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the AlternateTargetGroupArn property is set.
        /// </summary>
        internal bool IsSetAlternateTargetGroupArn() => this.AlternateTargetGroupArn != null;

        /// <summary>
        /// Gets and sets the property ProductionListenerRule. 
        /// <para>
        /// The Amazon Resource Name (ARN) that that identifies the production listener rule (in
        /// the case of an Application Load Balancer) or listener (in the case for an Network
        /// Load Balancer) for routing production traffic.
        /// </para>
        /// </summary>
        public string ProductionListenerRule { get; set; }

        /// <summary>
        /// Checks to see if the ProductionListenerRule property is set.
        /// </summary>
        internal bool IsSetProductionListenerRule() => this.ProductionListenerRule != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that grants Amazon ECS permission to
        /// call the Elastic Load Balancing APIs for you.
        /// </para>
        /// </summary>
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property TestListenerRule. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies ) that identifies the test listener
        /// rule (in the case of an Application Load Balancer) or listener (in the case for an
        /// Network Load Balancer) for routing test traffic.
        /// </para>
        /// </summary>
        public string TestListenerRule { get; set; }

        /// <summary>
        /// Checks to see if the TestListenerRule property is set.
        /// </summary>
        internal bool IsSetTestListenerRule() => this.TestListenerRule != null;
    }
}
