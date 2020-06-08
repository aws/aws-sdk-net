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

namespace Amazon.CodeGuruProfiler.Model
{
    /// <summary>
    /// The description of a profiling group.
    /// </summary>
    public partial class ProfilingGroupDescription
    {
        private AgentOrchestrationConfig _agentOrchestrationConfig;
        private string _arn;
        private DateTime? _createdAt;
        private string _name;
        private ProfilingStatus _profilingStatus;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AgentOrchestrationConfig.
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
        /// The Amazon Resource Name (ARN) identifying the profiling group.
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time, in milliseconds since the epoch, when the profiling group was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
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
        /// The status of the profiling group.
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time, in milliseconds since the epoch, when the profiling group was last updated.
        /// </para>
        /// </summary>
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}