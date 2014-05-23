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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Contains the response to a <code>DescribeElasticIps</code> request.
    /// </summary>
    public partial class DescribeElasticIpsResult
    {
        private List<ElasticIp> _elasticIps = new List<ElasticIp>();


        /// <summary>
        /// Gets and sets the property ElasticIps. 
        /// <para>
        /// An <code>ElasticIps</code> object that describes the specified Elastic IP addresses.
        /// </para>
        /// </summary>
        public List<ElasticIp> ElasticIps
        {
            get { return this._elasticIps; }
            set { this._elasticIps = value; }
        }

        /// <summary>
        /// Sets the ElasticIps property
        /// </summary>
        /// <param name="elasticIps">The values to add to the ElasticIps collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeElasticIpsResult WithElasticIps(params ElasticIp[] elasticIps)
        {
            foreach (var element in elasticIps)
            {
                this._elasticIps.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the ElasticIps property
        /// </summary>
        /// <param name="elasticIps">The values to add to the ElasticIps collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeElasticIpsResult WithElasticIps(IEnumerable<ElasticIp> elasticIps)
        {
            foreach (var element in elasticIps)
            {
                this._elasticIps.Add(element);
            }
            return this;
        }
        // Check to see if ElasticIps property is set
        internal bool IsSetElasticIps()
        {
            return this._elasticIps != null && this._elasticIps.Count > 0; 
        }

    }
}