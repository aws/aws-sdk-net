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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the AttachInstancesToLoadBalancer operation. Attaches
    /// one or more Lightsail instances to a load balancer. <para> After some time, the instances
    /// are attached to the load balancer and the health check status is available. </para>
    /// <para> The <c>attach instances to load balancer</c> operation supports tag-based access
    /// control via resource tags applied to the resource identified by <c>load balancer name</c>.
    /// For more information, see the <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-controlling-access-using-tags">Lightsail
    /// Developer Guide</a>. </para>
    /// </summary>
    public partial class AttachInstancesToLoadBalancerRequest : AmazonLightsailRequest
    {
        /// <summary>
        /// Gets and sets the property InstanceNames. 
        /// <para>
        /// An array of strings representing the instance name(s) you want to attach to your load
        /// balancer.
        /// </para>
        ///  
        /// <para>
        /// An instance must be <c>running</c> before you can attach it to your load balancer.
        /// </para>
        ///  
        /// <para>
        /// There are no additional limits on the number of instances you can attach to your load
        /// balancer, aside from the limit of Lightsail instances you can create in your account
        /// (20).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> InstanceNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InstanceNames property is set.
        /// </summary>
        internal bool IsSetInstanceNames() => this.InstanceNames != null && (this.InstanceNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        /// The name of the load balancer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// Checks to see if the LoadBalancerName property is set.
        /// </summary>
        internal bool IsSetLoadBalancerName() => this.LoadBalancerName != null;
    }
}
