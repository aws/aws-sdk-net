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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// <para>Contains the response to a <c>DescribeElasticIps</c> request.</para>
    /// </summary>
    public class DescribeElasticIpsResult
    {
        
        private List<ElasticIp> elasticIps = new List<ElasticIp>();

        /// <summary>
        /// An <c>ElasticIps</c> object that describes the specified Elastic IP addresses.
        ///  
        /// </summary>
        public List<ElasticIp> ElasticIps
        {
            get { return this.elasticIps; }
            set { this.elasticIps = value; }
        }
        /// <summary>
        /// Adds elements to the ElasticIps collection
        /// </summary>
        /// <param name="elasticIps">The values to add to the ElasticIps collection </param>
        /// <returns>this instance</returns>
        public DescribeElasticIpsResult WithElasticIps(params ElasticIp[] elasticIps)
        {
            foreach (ElasticIp element in elasticIps)
            {
                this.elasticIps.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the ElasticIps collection
        /// </summary>
        /// <param name="elasticIps">The values to add to the ElasticIps collection </param>
        /// <returns>this instance</returns>
        public DescribeElasticIpsResult WithElasticIps(IEnumerable<ElasticIp> elasticIps)
        {
            foreach (ElasticIp element in elasticIps)
            {
                this.elasticIps.Add(element);
            }

            return this;
        }

        // Check to see if ElasticIps property is set
        internal bool IsSetElasticIps()
        {
            return this.elasticIps.Count > 0;
        }
    }
}
