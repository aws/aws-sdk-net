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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// The estimated monthly savings after you adjust the configurations of your instances
    /// running on the inferred workload types to the recommended configurations. If the <code>inferredWorkloadTypes</code>
    /// list contains multiple entries, then the savings are the sum of the monthly savings
    /// from instances that run the exact combination of the inferred workload types.
    /// </summary>
    public partial class InferredWorkloadSaving
    {
        private EstimatedMonthlySavings _estimatedMonthlySavings;
        private List<string> _inferredWorkloadTypes = new List<string>();

        /// <summary>
        /// Gets and sets the property EstimatedMonthlySavings. 
        /// <para>
        /// An object that describes the estimated monthly savings amount possible by adopting
        /// Compute Optimizer recommendations for a given resource. This is based on the On-Demand
        /// instance pricing.
        /// </para>
        /// </summary>
        public EstimatedMonthlySavings EstimatedMonthlySavings
        {
            get { return this._estimatedMonthlySavings; }
            set { this._estimatedMonthlySavings = value; }
        }

        // Check to see if EstimatedMonthlySavings property is set
        internal bool IsSetEstimatedMonthlySavings()
        {
            return this._estimatedMonthlySavings != null;
        }

        /// <summary>
        /// Gets and sets the property InferredWorkloadTypes. 
        /// <para>
        /// The applications that might be running on the instance as inferred by Compute Optimizer.
        /// </para>
        ///  
        /// <para>
        /// Compute Optimizer can infer if one of the following applications might be running
        /// on the instance:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AmazonEmr</code> - Infers that Amazon EMR might be running on the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ApacheCassandra</code> - Infers that Apache Cassandra might be running on the
        /// instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ApacheHadoop</code> - Infers that Apache Hadoop might be running on the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Memcached</code> - Infers that Memcached might be running on the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NGINX</code> - Infers that NGINX might be running on the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PostgreSql</code> - Infers that PostgreSQL might be running on the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Redis</code> - Infers that Redis might be running on the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Kafka</code> - Infers that Kafka might be running on the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SQLServer</code> - Infers that SQLServer might be running on the instance.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<string> InferredWorkloadTypes
        {
            get { return this._inferredWorkloadTypes; }
            set { this._inferredWorkloadTypes = value; }
        }

        // Check to see if InferredWorkloadTypes property is set
        internal bool IsSetInferredWorkloadTypes()
        {
            return this._inferredWorkloadTypes != null && this._inferredWorkloadTypes.Count > 0; 
        }

    }
}