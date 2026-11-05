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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSession operation. Creates a new session.
    /// </summary>
    public partial class CreateSessionRequest : AmazonGlueRequest
    {
        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The <c>SessionCommand</c> that runs the job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SessionCommand Command { get; set; }

        /// <summary>
        /// Checks to see if the Command property is set.
        /// </summary>
        internal bool IsSetCommand() => this.Command != null;

        /// <summary>
        /// Gets and sets the property Connections. 
        /// <para>
        /// The number of connections to use for the session. 
        /// </para>
        /// </summary>
        public ConnectionsList Connections { get; set; }

        /// <summary>
        /// Checks to see if the Connections property is set.
        /// </summary>
        internal bool IsSetConnections() => this.Connections != null;

        /// <summary>
        /// Gets and sets the property DefaultArguments. 
        /// <para>
        /// A map array of key-value pairs. Max is 75 pairs. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 75)]
        public Dictionary<string, string> DefaultArguments { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the DefaultArguments property is set.
        /// </summary>
        internal bool IsSetDefaultArguments() => this.DefaultArguments != null && (this.DefaultArguments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the session. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property GlueVersion. 
        /// <para>
        /// The Glue version determines the versions of Apache Spark and Python that Glue supports.
        /// The GlueVersion must be greater than 2.0. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string GlueVersion { get; set; }

        /// <summary>
        /// Checks to see if the GlueVersion property is set.
        /// </summary>
        internal bool IsSetGlueVersion() => this.GlueVersion != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the session request. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property IdleTimeout. 
        /// <para>
        ///  The number of minutes when idle before session times out. Default for Spark ETL jobs
        /// is value of Timeout. Consult the documentation for other job types. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// Checks to see if the IdleTimeout property is set.
        /// </summary>
        internal bool IsSetIdleTimeout() => this.IdleTimeout.HasValue;

        /// <summary>
        /// Gets and sets the property MaxCapacity. 
        /// <para>
        /// The number of Glue data processing units (DPUs) that can be allocated when the job
        /// runs. A DPU is a relative measure of processing power that consists of 4 vCPUs of
        /// compute capacity and 16 GB memory. 
        /// </para>
        /// </summary>
        public double? MaxCapacity { get; set; }

        /// <summary>
        /// Checks to see if the MaxCapacity property is set.
        /// </summary>
        internal bool IsSetMaxCapacity() => this.MaxCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfWorkers. 
        /// <para>
        /// The number of workers of a defined <c>WorkerType</c> to use for the session. 
        /// </para>
        /// </summary>
        public int? NumberOfWorkers { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfWorkers property is set.
        /// </summary>
        internal bool IsSetNumberOfWorkers() => this.NumberOfWorkers.HasValue;

        /// <summary>
        /// Gets and sets the property RequestOrigin. 
        /// <para>
        /// The origin of the request. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string RequestOrigin { get; set; }

        /// <summary>
        /// Checks to see if the RequestOrigin property is set.
        /// </summary>
        internal bool IsSetRequestOrigin() => this.RequestOrigin != null;

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The IAM Role ARN 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string Role { get; set; }

        /// <summary>
        /// Checks to see if the Role property is set.
        /// </summary>
        internal bool IsSetRole() => this.Role != null;

        /// <summary>
        /// Gets and sets the property SecurityConfiguration. 
        /// <para>
        /// The name of the SecurityConfiguration structure to be used with the session 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string SecurityConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SecurityConfiguration property is set.
        /// </summary>
        internal bool IsSetSecurityConfiguration() => this.SecurityConfiguration != null;

        /// <summary>
        /// Gets and sets the property SessionType. 
        /// <para>
        /// The type of session to create.
        /// </para>
        /// </summary>
        public SessionType SessionType { get; set; }

        /// <summary>
        /// Checks to see if the SessionType property is set.
        /// </summary>
        internal bool IsSetSessionType() => this.SessionType != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The map of key value pairs (tags) belonging to the session.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        ///  The number of minutes before session times out. Default for Spark ETL jobs is 48
        /// hours (2880 minutes). Consult the documentation for other job types. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? Timeout { get; set; }

        /// <summary>
        /// Checks to see if the Timeout property is set.
        /// </summary>
        internal bool IsSetTimeout() => this.Timeout.HasValue;

        /// <summary>
        /// Gets and sets the property WorkerType. 
        /// <para>
        /// The type of predefined worker that is allocated when a job runs. Accepts a value of
        /// G.1X, G.2X, G.4X, G.8X, G.12X, G.16X, R.1X, R.2X, R.4X, or R.8X for Spark jobs. Accepts
        /// the value Z.2X for Ray notebooks.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For the <c>G.1X</c> worker type, each worker maps to 1 DPU (4 vCPUs, 16 GB of memory)
        /// with 94GB disk, and provides 1 executor per worker. We recommend this worker type
        /// for workloads such as data transforms, joins, and queries, to offers a scalable and
        /// cost effective way to run most jobs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <c>G.2X</c> worker type, each worker maps to 2 DPU (8 vCPUs, 32 GB of memory)
        /// with 138GB disk, and provides 1 executor per worker. We recommend this worker type
        /// for workloads such as data transforms, joins, and queries, to offers a scalable and
        /// cost effective way to run most jobs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <c>G.4X</c> worker type, each worker maps to 4 DPU (16 vCPUs, 64 GB of memory)
        /// with 256GB disk, and provides 1 executor per worker. We recommend this worker type
        /// for jobs whose workloads contain your most demanding transforms, aggregations, joins,
        /// and queries. This worker type is available only for Glue version 3.0 or later Spark
        /// ETL jobs in select Amazon Web Services Regions. For the supported Regions, see <a
        /// href="https://docs.aws.amazon.com/glue/latest/dg/add-job.html">Configuring job properties
        /// for Spark jobs</a> in the developer guide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <c>G.8X</c> worker type, each worker maps to 8 DPU (32 vCPUs, 128 GB of memory)
        /// with 512GB disk, and provides 1 executor per worker. We recommend this worker type
        /// for jobs whose workloads contain your most demanding transforms, aggregations, joins,
        /// and queries. This worker type is available only for Glue version 3.0 or later Spark
        /// ETL jobs in select Amazon Web Services Regions. For the supported Regions, see <a
        /// href="https://docs.aws.amazon.com/glue/latest/dg/add-job.html">Configuring job properties
        /// for Spark jobs</a> in the developer guide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <c>G.12X</c> worker type, each worker maps to 12 DPU (48 vCPUs, 192 GB of
        /// memory) with 768GB disk, and provides 1 executor per worker. We recommend this worker
        /// type for jobs with very large workloads. This worker type is available only for Glue
        /// version 4.0 or later Spark ETL jobs in select Amazon Web Services Regions. For the
        /// supported Regions, see <a href="https://docs.aws.amazon.com/glue/latest/dg/add-job.html">Configuring
        /// job properties for Spark jobs</a> in the developer guide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <c>G.16X</c> worker type, each worker maps to 16 DPU (64 vCPUs, 256 GB of
        /// memory) with 1024GB disk, and provides 1 executor per worker. We recommend this worker
        /// type for jobs with very large workloads. This worker type is available only for Glue
        /// version 4.0 or later Spark ETL jobs in select Amazon Web Services Regions. For the
        /// supported Regions, see <a href="https://docs.aws.amazon.com/glue/latest/dg/add-job.html">Configuring
        /// job properties for Spark jobs</a> in the developer guide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <c>R.1X</c> worker type, each worker maps to 1 M-DPU (4 vCPUs, 32 GB of memory)
        /// with 94GB disk, and provides 1 executor per worker. We recommend this worker type
        /// for memory-intensive workloads. This worker type is available only for Glue version
        /// 4.0 or later Spark ETL jobs in select Amazon Web Services Regions. For the supported
        /// Regions, see <a href="https://docs.aws.amazon.com/glue/latest/dg/add-job.html">Configuring
        /// job properties for Spark jobs</a> in the developer guide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <c>R.2X</c> worker type, each worker maps to 2 M-DPU (8 vCPUs, 64 GB of memory)
        /// with 138GB disk, and provides 1 executor per worker. We recommend this worker type
        /// for memory-intensive workloads. This worker type is available only for Glue version
        /// 4.0 or later Spark ETL jobs in select Amazon Web Services Regions. For the supported
        /// Regions, see <a href="https://docs.aws.amazon.com/glue/latest/dg/add-job.html">Configuring
        /// job properties for Spark jobs</a> in the developer guide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <c>R.4X</c> worker type, each worker maps to 4 M-DPU (16 vCPUs, 128 GB of
        /// memory) with 256GB disk, and provides 1 executor per worker. We recommend this worker
        /// type for memory-intensive workloads. This worker type is available only for Glue version
        /// 4.0 or later Spark ETL jobs in select Amazon Web Services Regions. For the supported
        /// Regions, see <a href="https://docs.aws.amazon.com/glue/latest/dg/add-job.html">Configuring
        /// job properties for Spark jobs</a> in the developer guide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <c>R.8X</c> worker type, each worker maps to 8 M-DPU (32 vCPUs, 256 GB of
        /// memory) with 512GB disk, and provides 1 executor per worker. We recommend this worker
        /// type for memory-intensive workloads. This worker type is available only for Glue version
        /// 4.0 or later Spark ETL jobs in select Amazon Web Services Regions. For the supported
        /// Regions, see <a href="https://docs.aws.amazon.com/glue/latest/dg/add-job.html">Configuring
        /// job properties for Spark jobs</a> in the developer guide.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <c>Z.2X</c> worker type, each worker maps to 2 M-DPU (8vCPUs, 64 GB of memory)
        /// with 128 GB disk, and provides up to 8 Ray workers based on the autoscaler.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public WorkerType WorkerType { get; set; }

        /// <summary>
        /// Checks to see if the WorkerType property is set.
        /// </summary>
        internal bool IsSetWorkerType() => this.WorkerType != null;
    }
}
