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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Describes the AWS resources in use by this environment. This data is not live data.
    /// </summary>
    public partial class EnvironmentResourcesDescription
    {
        private LoadBalancerDescription _loadBalancer;


        /// <summary>
        /// Gets and sets the property LoadBalancer. 
        /// <para>
        /// Describes the LoadBalancer.
        /// </para>
        /// </summary>
        public LoadBalancerDescription LoadBalancer
        {
            get { return this._loadBalancer; }
            set { this._loadBalancer = value; }
        }


        /// <summary>
        /// Sets the LoadBalancer property
        /// </summary>
        /// <param name="loadBalancer">The value to set for the LoadBalancer property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EnvironmentResourcesDescription WithLoadBalancer(LoadBalancerDescription loadBalancer)
        {
            this._loadBalancer = loadBalancer;
            return this;
        }

        // Check to see if LoadBalancer property is set
        internal bool IsSetLoadBalancer()
        {
            return this._loadBalancer != null;
        }

    }
}