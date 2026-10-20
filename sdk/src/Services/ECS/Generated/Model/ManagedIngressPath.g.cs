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
    /// The entry point into the Express service.
    /// </summary>
    public partial class ManagedIngressPath
    {
        /// <summary>
        /// Gets and sets the property AccessType. 
        /// <para>
        /// The type of access to the endpoint for the Express service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AccessType AccessType { get; set; }

        /// <summary>
        /// Checks to see if the AccessType property is set.
        /// </summary>
        internal bool IsSetAccessType() => this.AccessType != null;

        /// <summary>
        /// Gets and sets the property Certificate. 
        /// <para>
        /// The ACM certificate for the Express service's domain.
        /// </para>
        /// </summary>
        public ManagedCertificate Certificate { get; set; }

        /// <summary>
        /// Checks to see if the Certificate property is set.
        /// </summary>
        internal bool IsSetCertificate() => this.Certificate != null;

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The endpoint for access to the Express service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

        /// <summary>
        /// Gets and sets the property Listener. 
        /// <para>
        /// The listeners associated with the Application Load Balancer.
        /// </para>
        /// </summary>
        public ManagedListener Listener { get; set; }

        /// <summary>
        /// Checks to see if the Listener property is set.
        /// </summary>
        internal bool IsSetListener() => this.Listener != null;

        /// <summary>
        /// Gets and sets the property LoadBalancer. 
        /// <para>
        /// The Application Load Balancer associated with the Express service.
        /// </para>
        /// </summary>
        public ManagedLoadBalancer LoadBalancer { get; set; }

        /// <summary>
        /// Checks to see if the LoadBalancer property is set.
        /// </summary>
        internal bool IsSetLoadBalancer() => this.LoadBalancer != null;

        /// <summary>
        /// Gets and sets the property LoadBalancerSecurityGroups. 
        /// <para>
        /// The security groups associated with the Application Load Balancer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ManagedSecurityGroup> LoadBalancerSecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<ManagedSecurityGroup>() : null;

        /// <summary>
        /// Checks to see if the LoadBalancerSecurityGroups property is set.
        /// </summary>
        internal bool IsSetLoadBalancerSecurityGroups() => this.LoadBalancerSecurityGroups != null && (this.LoadBalancerSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Rule. 
        /// <para>
        /// The listener rules for the Application Load Balancer.
        /// </para>
        /// </summary>
        public ManagedListenerRule Rule { get; set; }

        /// <summary>
        /// Checks to see if the Rule property is set.
        /// </summary>
        internal bool IsSetRule() => this.Rule != null;

        /// <summary>
        /// Gets and sets the property TargetGroups. 
        /// <para>
        /// The target groups associated with the Application Load Balancer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ManagedTargetGroup> TargetGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<ManagedTargetGroup>() : null;

        /// <summary>
        /// Checks to see if the TargetGroups property is set.
        /// </summary>
        internal bool IsSetTargetGroups() => this.TargetGroups != null && (this.TargetGroups.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
