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
    /// Container for the parameters to the UpdateLoadBalancerAttribute operation. Updates
    /// the specified attribute for a load balancer. You can only update one attribute at
    /// a time. <para> The <c>update load balancer attribute</c> operation supports tag-based
    /// access control via resource tags applied to the resource identified by <c>load balancer
    /// name</c>. For more information, see the <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-controlling-access-using-tags">Amazon
    /// Lightsail Developer Guide</a>. </para>
    /// </summary>
    public partial class UpdateLoadBalancerAttributeRequest : AmazonLightsailRequest
    {
        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The name of the attribute you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LoadBalancerAttributeName AttributeName { get; set; }

        /// <summary>
        /// Checks to see if the AttributeName property is set.
        /// </summary>
        internal bool IsSetAttributeName() => this.AttributeName != null;

        /// <summary>
        /// Gets and sets the property AttributeValue. 
        /// <para>
        /// The value that you want to specify for the attribute name.
        /// </para>
        ///  
        /// <para>
        /// The following values are supported depending on what you specify for the <c>attributeName</c>
        /// request parameter:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you specify <c>HealthCheckPath</c> for the <c>attributeName</c> request parameter,
        /// then the <c>attributeValue</c> request parameter must be the path to ping on the target
        /// (for example, <c>/weather/us/wa/seattle</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify <c>SessionStickinessEnabled</c> for the <c>attributeName</c> request
        /// parameter, then the <c>attributeValue</c> request parameter must be <c>true</c> to
        /// activate session stickiness or <c>false</c> to deactivate session stickiness.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify <c>SessionStickiness_LB_CookieDurationSeconds</c> for the <c>attributeName</c>
        /// request parameter, then the <c>attributeValue</c> request parameter must be an interger
        /// that represents the cookie duration in seconds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify <c>HttpsRedirectionEnabled</c> for the <c>attributeName</c> request
        /// parameter, then the <c>attributeValue</c> request parameter must be <c>true</c> to
        /// activate HTTP to HTTPS redirection or <c>false</c> to deactivate HTTP to HTTPS redirection.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify <c>TlsPolicyName</c> for the <c>attributeName</c> request parameter,
        /// then the <c>attributeValue</c> request parameter must be the name of the TLS policy.
        /// </para>
        ///  
        /// <para>
        /// Use the <a href="https://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_GetLoadBalancerTlsPolicies.html">GetLoadBalancerTlsPolicies</a>
        /// action to get a list of TLS policy names that you can specify.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string AttributeValue { get; set; }

        /// <summary>
        /// Checks to see if the AttributeValue property is set.
        /// </summary>
        internal bool IsSetAttributeValue() => this.AttributeValue != null;

        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        /// The name of the load balancer that you want to modify (<c>my-load-balancer</c>.
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
