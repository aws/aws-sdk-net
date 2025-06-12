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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// The estimated monthly savings after you adjust the configurations of your instances
    /// running on the inferred workload types to the recommended configurations. If the <c>inferredWorkloadTypes</c>
    /// list contains multiple entries, then the savings are the sum of the monthly savings
    /// from instances that run the exact combination of the inferred workload types.
    /// </summary>
    public partial class InferredWorkloadSaving
    {
        private EstimatedMonthlySavings _estimatedMonthlySavings;
        private List<string> _inferredWorkloadTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

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
        ///  <c>AmazonEmr</c> - Infers that Amazon EMR might be running on the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ApacheCassandra</c> - Infers that Apache Cassandra might be running on the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ApacheHadoop</c> - Infers that Apache Hadoop might be running on the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Memcached</c> - Infers that Memcached might be running on the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NGINX</c> - Infers that NGINX might be running on the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PostgreSql</c> - Infers that PostgreSQL might be running on the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Redis</c> - Infers that Redis might be running on the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Kafka</c> - Infers that Kafka might be running on the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SQLServer</c> - Infers that SQLServer might be running on the instance.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InferredWorkloadTypes
        {
            get { return this._inferredWorkloadTypes; }
            set { this._inferredWorkloadTypes = value; }
        }

        // Check to see if InferredWorkloadTypes property is set
        internal bool IsSetInferredWorkloadTypes()
        {
            return this._inferredWorkloadTypes != null && (this._inferredWorkloadTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}