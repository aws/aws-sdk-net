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
 * Do not modify this file. This file is generated from the codeguruprofiler-2019-07-18.normal.json service model.
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
namespace Amazon.CodeGuruProfiler.Model
{
    /// <summary>
    /// Contains information about a profiling group.
    /// </summary>
    public partial class ProfilingGroupDescription
    {
        private AgentOrchestrationConfig _agentOrchestrationConfig;
        private string _arn;
        private ComputePlatform _computePlatform;
        private DateTime? _createdAt;
        private string _name;
        private ProfilingStatus _profilingStatus;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AgentOrchestrationConfig. 
        /// <para>
        ///  An <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_AgentOrchestrationConfig.html">
        /// <c>AgentOrchestrationConfig</c> </a> object that indicates if the profiling group
        /// is enabled for profiled or not. 
        /// </para>
        /// </summary>
        public AgentOrchestrationConfig AgentOrchestrationConfig
        {
            get { return this._agentOrchestrationConfig; }
            set { this._agentOrchestrationConfig = value; }
        }

        // Check to see if AgentOrchestrationConfig property is set
        internal bool IsSetAgentOrchestrationConfig()
        {
            return this._agentOrchestrationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) identifying the profiling group resource.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ComputePlatform. 
        /// <para>
        ///  The compute platform of the profiling group. If it is set to <c>AWSLambda</c>, then
        /// the profiled application runs on AWS Lambda. If it is set to <c>Default</c>, then
        /// the profiled application runs on a compute platform that is not AWS Lambda, such an
        /// Amazon EC2 instance, an on-premises server, or a different platform. The default is
        /// <c>Default</c>. 
        /// </para>
        /// </summary>
        public ComputePlatform ComputePlatform
        {
            get { return this._computePlatform; }
            set { this._computePlatform = value; }
        }

        // Check to see if ComputePlatform property is set
        internal bool IsSetComputePlatform()
        {
            return this._computePlatform != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the profiling group was created. Specify using the ISO 8601 format.
        /// For example, 2020-06-01T13:15:02.001Z represents 1 millisecond past June 1, 2020 1:15:02
        /// PM UTC. 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the profiling group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ProfilingStatus. 
        /// <para>
        ///  A <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_ProfilingStatus.html">
        /// <c>ProfilingStatus</c> </a> object that includes information about the last time a
        /// profile agent pinged back, the last time a profile was received, and the aggregation
        /// period and start time for the most recent aggregated profile. 
        /// </para>
        /// </summary>
        public ProfilingStatus ProfilingStatus
        {
            get { return this._profilingStatus; }
            set { this._profilingStatus = value; }
        }

        // Check to see if ProfilingStatus property is set
        internal bool IsSetProfilingStatus()
        {
            return this._profilingStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  A list of the tags that belong to this profiling group. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        ///  The date and time when the profiling group was last updated. Specify using the ISO
        /// 8601 format. For example, 2020-06-01T13:15:02.001Z represents 1 millisecond past June
        /// 1, 2020 1:15:02 PM UTC. 
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}