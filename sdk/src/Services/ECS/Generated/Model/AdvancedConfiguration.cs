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
    /// The advanced settings for a load balancer used in blue/green deployments. Specify
    /// the alternate target group, listener rules, and IAM role required for traffic shifting
    /// during blue/green deployments. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/blue-green-deployment-implementation.html">Required
    /// resources for Amazon ECS blue/green deployments</a> in the <i>Amazon Elastic Container
    /// Service Developer Guide</i>.
    /// </summary>
    public partial class AdvancedConfiguration
    {
        private string _alternateTargetGroupArn;
        private string _productionListenerRule;
        private string _roleArn;
        private string _testListenerRule;

        /// <summary>
        /// Gets and sets the property AlternateTargetGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the alternate target group for Amazon ECS blue/green
        /// deployments.
        /// </para>
        /// </summary>
        public string AlternateTargetGroupArn
        {
            get { return this._alternateTargetGroupArn; }
            set { this._alternateTargetGroupArn = value; }
        }

        // Check to see if AlternateTargetGroupArn property is set
        internal bool IsSetAlternateTargetGroupArn()
        {
            return this._alternateTargetGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property ProductionListenerRule. 
        /// <para>
        /// The Amazon Resource Name (ARN) that that identifies the production listener rule (in
        /// the case of an Application Load Balancer) or listener (in the case for an Network
        /// Load Balancer) for routing production traffic.
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
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that grants Amazon ECS permission to
        /// call the Elastic Load Balancing APIs for you.
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property TestListenerRule. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies ) that identifies the test listener
        /// rule (in the case of an Application Load Balancer) or listener (in the case for an
        /// Network Load Balancer) for routing test traffic.
        /// </para>
        /// </summary>
        public string TestListenerRule
        {
            get { return this._testListenerRule; }
            set { this._testListenerRule = value; }
        }

        // Check to see if TestListenerRule property is set
        internal bool IsSetTestListenerRule()
        {
            return this._testListenerRule != null;
        }

    }
}