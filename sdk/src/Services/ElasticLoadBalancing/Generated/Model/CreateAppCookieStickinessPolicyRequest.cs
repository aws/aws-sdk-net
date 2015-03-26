/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the elasticloadbalancing-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAppCookieStickinessPolicy operation.
    /// Generates a stickiness policy with sticky session lifetimes that follow that of an
    /// application-generated cookie. This policy can be associated only with HTTP/HTTPS listeners.
    /// 
    /// 
    ///  
    /// <para>
    ///  This policy is similar to the policy created by <a>CreateLBCookieStickinessPolicy</a>,
    /// except that the lifetime of the special Elastic Load Balancing cookie follows the
    /// lifetime of the application-generated cookie specified in the policy configuration.
    /// The load balancer only inserts a new stickiness cookie when the application response
    /// includes a new application cookie. 
    /// </para>
    ///  
    /// <para>
    ///  If the application cookie is explicitly removed or expires, the session stops being
    /// sticky until a new application cookie is issued. 
    /// </para>
    ///  <note> An application client must receive and send two cookies: the application-generated
    /// cookie and the special Elastic Load Balancing cookie named <code>AWSELB</code>. This
    /// is the default behavior for many common web browsers. </note> 
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_StickySessions.html#US_EnableStickySessionsAppCookies">Enabling
    /// Application-Controlled Session Stickiness</a> in the <i>Elastic Load Balancing Developer
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateAppCookieStickinessPolicyRequest : AmazonElasticLoadBalancingRequest
    {
        private string _cookieName;
        private string _loadBalancerName;
        private string _policyName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateAppCookieStickinessPolicyRequest() { }

        /// <summary>
        /// Instantiates CreateAppCookieStickinessPolicyRequest with the parameterized properties
        /// </summary>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="policyName"> The name of the policy being created. The name must be unique within the set of policies for this load balancer. </param>
        /// <param name="cookieName"> Name of the application cookie used for stickiness. </param>
        public CreateAppCookieStickinessPolicyRequest(string loadBalancerName, string policyName, string cookieName)
        {
            _loadBalancerName = loadBalancerName;
            _policyName = policyName;
            _cookieName = cookieName;
        }

        /// <summary>
        /// Gets and sets the property CookieName. 
        /// <para>
        ///  Name of the application cookie used for stickiness. 
        /// </para>
        /// </summary>
        public string CookieName
        {
            get { return this._cookieName; }
            set { this._cookieName = value; }
        }

        // Check to see if CookieName property is set
        internal bool IsSetCookieName()
        {
            return this._cookieName != null;
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        ///  The name of the load balancer. 
        /// </para>
        /// </summary>
        public string LoadBalancerName
        {
            get { return this._loadBalancerName; }
            set { this._loadBalancerName = value; }
        }

        // Check to see if LoadBalancerName property is set
        internal bool IsSetLoadBalancerName()
        {
            return this._loadBalancerName != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        ///  The name of the policy being created. The name must be unique within the set of policies
        /// for this load balancer. 
        /// </para>
        /// </summary>
        public string PolicyName
        {
            get { return this._policyName; }
            set { this._policyName = value; }
        }

        // Check to see if PolicyName property is set
        internal bool IsSetPolicyName()
        {
            return this._policyName != null;
        }

    }
}