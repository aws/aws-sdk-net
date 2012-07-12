/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// <para>A response message that contains the access policies for a domain.</para>
    /// </summary>
    public class DescribeServiceAccessPoliciesResult  
    {
        
        private AccessPoliciesStatus accessPolicies;

        /// <summary>
        /// A <c>PolicyDocument</c> that specifies access policies for the search domain's services, and the current status of those policies.
        ///  
        /// </summary>
        public AccessPoliciesStatus AccessPolicies
        {
            get { return this.accessPolicies; }
            set { this.accessPolicies = value; }
        }

        /// <summary>
        /// Sets the AccessPolicies property
        /// </summary>
        /// <param name="accessPolicies">The value to set for the AccessPolicies property </param>
        /// <returns>this instance</returns>
        public DescribeServiceAccessPoliciesResult WithAccessPolicies(AccessPoliciesStatus accessPolicies)
        {
            this.accessPolicies = accessPolicies;
            return this;
        }
            

        // Check to see if AccessPolicies property is set
        internal bool IsSetAccessPolicies()
        {
            return this.accessPolicies != null;       
        }
    }
}
