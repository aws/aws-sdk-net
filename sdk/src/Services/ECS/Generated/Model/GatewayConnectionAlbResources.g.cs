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
    /// The Application Load Balancer resources that a gateway created and manages for a connection.
    /// </summary>
    public partial class GatewayConnectionAlbResources
    {
        /// <summary>
        /// Gets and sets the property AcmCertificateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services Certificate Manager certificate
        /// that is attached to the load balancer listener.
        /// </para>
        /// </summary>
        public string AcmCertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the AcmCertificateArn property is set.
        /// </summary>
        internal bool IsSetAcmCertificateArn() => this.AcmCertificateArn != null;

        /// <summary>
        /// Gets and sets the property AlternateTargetGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the alternate target group that the gateway uses
        /// during progressive deployments.
        /// </para>
        /// </summary>
        public string AlternateTargetGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the AlternateTargetGroupArn property is set.
        /// </summary>
        internal bool IsSetAlternateTargetGroupArn() => this.AlternateTargetGroupArn != null;

        /// <summary>
        /// Gets and sets the property ListenerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the listener on the load balancer.
        /// </para>
        /// </summary>
        public string ListenerArn { get; set; }

        /// <summary>
        /// Checks to see if the ListenerArn property is set.
        /// </summary>
        internal bool IsSetListenerArn() => this.ListenerArn != null;

        /// <summary>
        /// Gets and sets the property ListenerRuleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the listener rule that routes production traffic
        /// to the service.
        /// </para>
        /// </summary>
        public string ListenerRuleArn { get; set; }

        /// <summary>
        /// Checks to see if the ListenerRuleArn property is set.
        /// </summary>
        internal bool IsSetListenerRuleArn() => this.ListenerRuleArn != null;

        /// <summary>
        /// Gets and sets the property LoadBalancerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the load balancer.
        /// </para>
        /// </summary>
        public string LoadBalancerArn { get; set; }

        /// <summary>
        /// Checks to see if the LoadBalancerArn property is set.
        /// </summary>
        internal bool IsSetLoadBalancerArn() => this.LoadBalancerArn != null;

        /// <summary>
        /// Gets and sets the property LoadBalancerSecurityGroupArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the security groups that the gateway attaches
        /// to the load balancer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LoadBalancerSecurityGroupArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LoadBalancerSecurityGroupArns property is set.
        /// </summary>
        internal bool IsSetLoadBalancerSecurityGroupArns() => this.LoadBalancerSecurityGroupArns != null && (this.LoadBalancerSecurityGroupArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the target group that receives production traffic.
        /// </para>
        /// </summary>
        public string TargetGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetGroupArn property is set.
        /// </summary>
        internal bool IsSetTargetGroupArn() => this.TargetGroupArn != null;

        /// <summary>
        /// Gets and sets the property TestListenerRuleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the listener rule that routes test traffic to the
        /// service during progressive deployments.
        /// </para>
        /// </summary>
        public string TestListenerRuleArn { get; set; }

        /// <summary>
        /// Checks to see if the TestListenerRuleArn property is set.
        /// </summary>
        internal bool IsSetTestListenerRuleArn() => this.TestListenerRuleArn != null;
    }
}
