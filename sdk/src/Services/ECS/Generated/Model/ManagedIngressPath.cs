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
    /// The entry point into the Express service.
    /// </summary>
    public partial class ManagedIngressPath
    {
        private AccessType _accessType;
        private ManagedCertificate _certificate;
        private string _endpoint;
        private ManagedListener _listener;
        private ManagedLoadBalancer _loadBalancer;
        private List<ManagedSecurityGroup> _loadBalancerSecurityGroups = AWSConfigs.InitializeCollections ? new List<ManagedSecurityGroup>() : null;
        private ManagedListenerRule _rule;
        private List<ManagedTargetGroup> _targetGroups = AWSConfigs.InitializeCollections ? new List<ManagedTargetGroup>() : null;

        /// <summary>
        /// Gets and sets the property AccessType. 
        /// <para>
        /// The type of access to the endpoint for the Express service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AccessType AccessType
        {
            get { return this._accessType; }
            set { this._accessType = value; }
        }

        // Check to see if AccessType property is set
        internal bool IsSetAccessType()
        {
            return this._accessType != null;
        }

        /// <summary>
        /// Gets and sets the property Certificate. 
        /// <para>
        /// The ACM certificate for the Express service's domain.
        /// </para>
        /// </summary>
        public ManagedCertificate Certificate
        {
            get { return this._certificate; }
            set { this._certificate = value; }
        }

        // Check to see if Certificate property is set
        internal bool IsSetCertificate()
        {
            return this._certificate != null;
        }

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The endpoint for access to the Express service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property Listener. 
        /// <para>
        /// The listeners associated with the Application Load Balancer.
        /// </para>
        /// </summary>
        public ManagedListener Listener
        {
            get { return this._listener; }
            set { this._listener = value; }
        }

        // Check to see if Listener property is set
        internal bool IsSetListener()
        {
            return this._listener != null;
        }

        /// <summary>
        /// Gets and sets the property LoadBalancer. 
        /// <para>
        /// The Application Load Balancer associated with the Express service.
        /// </para>
        /// </summary>
        public ManagedLoadBalancer LoadBalancer
        {
            get { return this._loadBalancer; }
            set { this._loadBalancer = value; }
        }

        // Check to see if LoadBalancer property is set
        internal bool IsSetLoadBalancer()
        {
            return this._loadBalancer != null;
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerSecurityGroups. 
        /// <para>
        /// The security groups associated with the Application Load Balancer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ManagedSecurityGroup> LoadBalancerSecurityGroups
        {
            get { return this._loadBalancerSecurityGroups; }
            set { this._loadBalancerSecurityGroups = value; }
        }

        // Check to see if LoadBalancerSecurityGroups property is set
        internal bool IsSetLoadBalancerSecurityGroups()
        {
            return this._loadBalancerSecurityGroups != null && (this._loadBalancerSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Rule. 
        /// <para>
        /// The listener rules for the Application Load Balancer.
        /// </para>
        /// </summary>
        public ManagedListenerRule Rule
        {
            get { return this._rule; }
            set { this._rule = value; }
        }

        // Check to see if Rule property is set
        internal bool IsSetRule()
        {
            return this._rule != null;
        }

        /// <summary>
        /// Gets and sets the property TargetGroups. 
        /// <para>
        /// The target groups associated with the Application Load Balancer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ManagedTargetGroup> TargetGroups
        {
            get { return this._targetGroups; }
            set { this._targetGroups = value; }
        }

        // Check to see if TargetGroups property is set
        internal bool IsSetTargetGroups()
        {
            return this._targetGroups != null && (this._targetGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}