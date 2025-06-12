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
    /// Container for the parameters to the ConfigureAgent operation.
    /// Used by profiler agents to report their current state and to receive remote configuration
    /// updates. For example, <c>ConfigureAgent</c> can be used to tell an agent whether to
    /// profile or not and for how long to return profiling data.
    /// </summary>
    public partial class ConfigureAgentRequest : AmazonCodeGuruProfilerRequest
    {
        private string _fleetInstanceId;
        private Dictionary<string, string> _metadata = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _profilingGroupName;

        /// <summary>
        /// Gets and sets the property FleetInstanceId. 
        /// <para>
        ///  A universally unique identifier (UUID) for a profiling instance. For example, if
        /// the profiling instance is an Amazon EC2 instance, it is the instance ID. If it is
        /// an AWS Fargate container, it is the container's task ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string FleetInstanceId
        {
            get { return this._fleetInstanceId; }
            set { this._fleetInstanceId = value; }
        }

        // Check to see if FleetInstanceId property is set
        internal bool IsSetFleetInstanceId()
        {
            return this._fleetInstanceId != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        ///  Metadata captured about the compute platform the agent is running on. It includes
        /// information about sampling and reporting. The valid fields are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>COMPUTE_PLATFORM</c> - The compute platform on which the agent is running 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AGENT_ID</c> - The ID for an agent instance. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_REQUEST_ID</c> - The AWS request ID of a Lambda invocation. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EXECUTION_ENVIRONMENT</c> - The execution environment a Lambda function is running
        /// on. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LAMBDA_FUNCTION_ARN</c> - The Amazon Resource Name (ARN) that is used to invoke
        /// a Lambda function. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LAMBDA_MEMORY_LIMIT_IN_MB</c> - The memory allocated to a Lambda function. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LAMBDA_REMAINING_TIME_IN_MILLISECONDS</c> - The time in milliseconds before execution
        /// of a Lambda function times out. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LAMBDA_TIME_GAP_BETWEEN_INVOKES_IN_MILLISECONDS</c> - The time in milliseconds
        /// between two invocations of a Lambda function. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LAMBDA_PREVIOUS_EXECUTION_TIME_IN_MILLISECONDS</c> - The time in milliseconds
        /// for the previous Lambda invocation. 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null && (this._metadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProfilingGroupName. 
        /// <para>
        ///  The name of the profiling group for which the configured agent is collecting profiling
        /// data. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ProfilingGroupName
        {
            get { return this._profilingGroupName; }
            set { this._profilingGroupName = value; }
        }

        // Check to see if ProfilingGroupName property is set
        internal bool IsSetProfilingGroupName()
        {
            return this._profilingGroupName != null;
        }

    }
}