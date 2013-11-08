/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// <para>The AppCookieStickinessPolicy data type. </para>
    /// </summary>
    public class AppCookieStickinessPolicy
    {
        
        private string policyName;
        private string cookieName;

        /// <summary>
        /// Default constructor for a new AppCookieStickinessPolicy object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public AppCookieStickinessPolicy() {}
    
        /// <summary>
        /// Constructs a new AppCookieStickinessPolicy object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="policyName"> The mnemonic name for the policy being created. The name must be unique within a set of policies for this load
        /// balancer. </param>
        /// <param name="cookieName"> The name of the application cookie used for stickiness. </param>
        public AppCookieStickinessPolicy(string policyName, string cookieName)
        {
            this.policyName = policyName;
            this.cookieName = cookieName;
        }
    

        /// <summary>
        /// The mnemonic name for the policy being created. The name must be unique within a set of policies for this load balancer.
        ///  
        /// </summary>
        public string PolicyName
        {
            get { return this.policyName; }
            set { this.policyName = value; }
        }

        // Check to see if PolicyName property is set
        internal bool IsSetPolicyName()
        {
            return this.policyName != null;
        }

        /// <summary>
        /// The name of the application cookie used for stickiness.
        ///  
        /// </summary>
        public string CookieName
        {
            get { return this.cookieName; }
            set { this.cookieName = value; }
        }

        // Check to see if CookieName property is set
        internal bool IsSetCookieName()
        {
            return this.cookieName != null;
        }
    }
}
