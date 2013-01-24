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
    /// <para> The output for the DescribeLoadBalancers action. </para>
    /// </summary>
    public class DescribeLoadBalancersResult  
    {
        
        private List<LoadBalancerDescription> loadBalancerDescriptions = new List<LoadBalancerDescription>();
        private string nextMarker;

        /// <summary>
        /// A list of LoadBalancer description structures.
        ///  
        /// </summary>
        public List<LoadBalancerDescription> LoadBalancerDescriptions
        {
            get { return this.loadBalancerDescriptions; }
            set { this.loadBalancerDescriptions = value; }
        }
        /// <summary>
        /// Adds elements to the LoadBalancerDescriptions collection
        /// </summary>
        /// <param name="loadBalancerDescriptions">The values to add to the LoadBalancerDescriptions collection </param>
        /// <returns>this instance</returns>
        public DescribeLoadBalancersResult WithLoadBalancerDescriptions(params LoadBalancerDescription[] loadBalancerDescriptions)
        {
            foreach (LoadBalancerDescription element in loadBalancerDescriptions)
            {
                this.loadBalancerDescriptions.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the LoadBalancerDescriptions collection
        /// </summary>
        /// <param name="loadBalancerDescriptions">The values to add to the LoadBalancerDescriptions collection </param>
        /// <returns>this instance</returns>
        public DescribeLoadBalancersResult WithLoadBalancerDescriptions(IEnumerable<LoadBalancerDescription> loadBalancerDescriptions)
        {
            foreach (LoadBalancerDescription element in loadBalancerDescriptions)
            {
                this.loadBalancerDescriptions.Add(element);
            }

            return this;
        }

        // Check to see if LoadBalancerDescriptions property is set
        internal bool IsSetLoadBalancerDescriptions()
        {
            return this.loadBalancerDescriptions.Count > 0;       
        }

        /// <summary>
        /// An optional parameter reserved for future use.
        ///  
        /// </summary>
        public string NextMarker
        {
            get { return this.nextMarker; }
            set { this.nextMarker = value; }
        }

        /// <summary>
        /// Sets the NextMarker property
        /// </summary>
        /// <param name="nextMarker">The value to set for the NextMarker property </param>
        /// <returns>this instance</returns>
        public DescribeLoadBalancersResult WithNextMarker(string nextMarker)
        {
            this.nextMarker = nextMarker;
            return this;
        }
            

        // Check to see if NextMarker property is set
        internal bool IsSetNextMarker()
        {
            return this.nextMarker != null;       
        }
    }
}
