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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSession operation.
    /// Creates a new session.
    /// </summary>
    public partial class CreateSessionRequest : AmazonGlueRequest
    {
        private SessionCommand _command;
        private ConnectionsList _connections;
        private Dictionary<string, string> _defaultArguments = new Dictionary<string, string>();
        private string _description;
        private string _glueVersion;
        private string _id;
        private int? _idleTimeout;
        private double? _maxCapacity;
        private int? _numberOfWorkers;
        private string _requestOrigin;
        private string _role;
        private string _securityConfiguration;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private int? _timeout;
        private WorkerType _workerType;

        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The <code>SessionCommand</code> that runs the job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SessionCommand Command
        {
            get { return this._command; }
            set { this._command = value; }
        }

        // Check to see if Command property is set
        internal bool IsSetCommand()
        {
            return this._command != null;
        }

        /// <summary>
        /// Gets and sets the property Connections. 
        /// <para>
        /// The number of connections to use for the session. 
        /// </para>
        /// </summary>
        public ConnectionsList Connections
        {
            get { return this._connections; }
            set { this._connections = value; }
        }

        // Check to see if Connections property is set
        internal bool IsSetConnections()
        {
            return this._connections != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultArguments. 
        /// <para>
        /// A map array of key-value pairs. Max is 75 pairs. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=75)]
        public Dictionary<string, string> DefaultArguments
        {
            get { return this._defaultArguments; }
            set { this._defaultArguments = value; }
        }

        // Check to see if DefaultArguments property is set
        internal bool IsSetDefaultArguments()
        {
            return this._defaultArguments != null && this._defaultArguments.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the session. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property GlueVersion. 
        /// <para>
        /// The Glue version determines the versions of Apache Spark and Python that Glue supports.
        /// The GlueVersion must be greater than 2.0. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string GlueVersion
        {
            get { return this._glueVersion; }
            set { this._glueVersion = value; }
        }

        // Check to see if GlueVersion property is set
        internal bool IsSetGlueVersion()
        {
            return this._glueVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the session request. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property IdleTimeout. 
        /// <para>
        ///  The number of minutes when idle before session times out. Default for Spark ETL jobs
        /// is value of Timeout. Consult the documentation for other job types. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int IdleTimeout
        {
            get { return this._idleTimeout.GetValueOrDefault(); }
            set { this._idleTimeout = value; }
        }

        // Check to see if IdleTimeout property is set
        internal bool IsSetIdleTimeout()
        {
            return this._idleTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxCapacity. 
        /// <para>
        /// The number of Glue data processing units (DPUs) that can be allocated when the job
        /// runs. A DPU is a relative measure of processing power that consists of 4 vCPUs of
        /// compute capacity and 16 GB memory. 
        /// </para>
        /// </summary>
        public double MaxCapacity
        {
            get { return this._maxCapacity.GetValueOrDefault(); }
            set { this._maxCapacity = value; }
        }

        // Check to see if MaxCapacity property is set
        internal bool IsSetMaxCapacity()
        {
            return this._maxCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfWorkers. 
        /// <para>
        /// The number of workers of a defined <code>WorkerType</code> to use for the session.
        /// 
        /// </para>
        /// </summary>
        public int NumberOfWorkers
        {
            get { return this._numberOfWorkers.GetValueOrDefault(); }
            set { this._numberOfWorkers = value; }
        }

        // Check to see if NumberOfWorkers property is set
        internal bool IsSetNumberOfWorkers()
        {
            return this._numberOfWorkers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequestOrigin. 
        /// <para>
        /// The origin of the request. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string RequestOrigin
        {
            get { return this._requestOrigin; }
            set { this._requestOrigin = value; }
        }

        // Check to see if RequestOrigin property is set
        internal bool IsSetRequestOrigin()
        {
            return this._requestOrigin != null;
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The IAM Role ARN 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityConfiguration. 
        /// <para>
        /// The name of the SecurityConfiguration structure to be used with the session 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string SecurityConfiguration
        {
            get { return this._securityConfiguration; }
            set { this._securityConfiguration = value; }
        }

        // Check to see if SecurityConfiguration property is set
        internal bool IsSetSecurityConfiguration()
        {
            return this._securityConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The map of key value pairs (tags) belonging to the session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        ///  The number of minutes before session times out. Default for Spark ETL jobs is 48
        /// hours (2880 minutes), the maximum session lifetime for this job type. Consult the
        /// documentation for other job types. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int Timeout
        {
            get { return this._timeout.GetValueOrDefault(); }
            set { this._timeout = value; }
        }

        // Check to see if Timeout property is set
        internal bool IsSetTimeout()
        {
            return this._timeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WorkerType. 
        /// <para>
        /// The type of predefined worker that is allocated when a job runs. Accepts a value of
        /// G.1X, G.2X, G.4X, or G.8X for Spark jobs. Accepts the value Z.2X for Ray notebooks.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For the <code>G.1X</code> worker type, each worker maps to 1 DPU (4 vCPUs, 16 GB of
        /// memory) with 84GB disk (approximately 34GB free), and provides 1 executor per worker.
        /// We recommend this worker type for workloads such as data transforms, joins, and queries,
        /// to offers a scalable and cost effective way to run most jobs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <code>G.2X</code> worker type, each worker maps to 2 DPU (8 vCPUs, 32 GB of
        /// memory) with 128GB disk (approximately 77GB free), and provides 1 executor per worker.
        /// We recommend this worker type for workloads such as data transforms, joins, and queries,
        /// to offers a scalable and cost effective way to run most jobs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <code>G.4X</code> worker type, each worker maps to 4 DPU (16 vCPUs, 64 GB
        /// of memory) with 256GB disk (approximately 235GB free), and provides 1 executor per
        /// worker. We recommend this worker type for jobs whose workloads contain your most demanding
        /// transforms, aggregations, joins, and queries. This worker type is available only for
        /// Glue version 3.0 or later Spark ETL jobs in the following Amazon Web Services Regions:
        /// US East (Ohio), US East (N. Virginia), US West (Oregon), Asia Pacific (Singapore),
        /// Asia Pacific (Sydney), Asia Pacific (Tokyo), Canada (Central), Europe (Frankfurt),
        /// Europe (Ireland), and Europe (Stockholm).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <code>G.8X</code> worker type, each worker maps to 8 DPU (32 vCPUs, 128 GB
        /// of memory) with 512GB disk (approximately 487GB free), and provides 1 executor per
        /// worker. We recommend this worker type for jobs whose workloads contain your most demanding
        /// transforms, aggregations, joins, and queries. This worker type is available only for
        /// Glue version 3.0 or later Spark ETL jobs, in the same Amazon Web Services Regions
        /// as supported for the <code>G.4X</code> worker type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <code>Z.2X</code> worker type, each worker maps to 2 M-DPU (8vCPUs, 64 GB
        /// of memory) with 128 GB disk (approximately 120GB free), and provides up to 8 Ray workers
        /// based on the autoscaler.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public WorkerType WorkerType
        {
            get { return this._workerType; }
            set { this._workerType = value; }
        }

        // Check to see if WorkerType property is set
        internal bool IsSetWorkerType()
        {
            return this._workerType != null;
        }

    }
}