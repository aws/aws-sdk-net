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
 * Do not modify this file. This file is generated from the timestream-influxdb-2023-01-27.normal.json service model.
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
namespace Amazon.TimestreamInfluxDB.Model
{
    /// <summary>
    /// Configuration for node modes in the DbCluster.
    /// </summary>
    public partial class ClusterConfiguration
    {
        private bool? _dedicatedCompactor;
        private int? _ingestQueryInstances;
        private int? _queryOnlyInstances;

        /// <summary>
        /// Gets and sets the property DedicatedCompactor. 
        /// <para>
        /// Indicates if the compactor instance is a standalone instance or not.
        /// </para>
        /// </summary>
        public bool? DedicatedCompactor
        {
            get { return this._dedicatedCompactor; }
            set { this._dedicatedCompactor = value; }
        }

        // Check to see if DedicatedCompactor property is set
        internal bool IsSetDedicatedCompactor()
        {
            return this._dedicatedCompactor.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IngestQueryInstances. 
        /// <para>
        /// The number of instances in the DbCluster which can both ingest and query.
        /// </para>
        /// </summary>
        public int? IngestQueryInstances
        {
            get { return this._ingestQueryInstances; }
            set { this._ingestQueryInstances = value; }
        }

        // Check to see if IngestQueryInstances property is set
        internal bool IsSetIngestQueryInstances()
        {
            return this._ingestQueryInstances.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueryOnlyInstances. 
        /// <para>
        /// The number of instances in the DbCluster which can only query.
        /// </para>
        /// </summary>
        public int? QueryOnlyInstances
        {
            get { return this._queryOnlyInstances; }
            set { this._queryOnlyInstances = value; }
        }

        // Check to see if QueryOnlyInstances property is set
        internal bool IsSetQueryOnlyInstances()
        {
            return this._queryOnlyInstances.HasValue; 
        }

    }
}