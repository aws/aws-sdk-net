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

namespace Amazon.CodeGuruProfiler.Model
{
    /// <summary>
    /// Container for the parameters to the CreateProfilingGroup operation. Creates a profiling
    /// group.
    /// </summary>
    public partial class CreateProfilingGroupRequest : AmazonCodeGuruProfilerRequest
    {
        /// <summary>
        /// Gets and sets the property AgentOrchestrationConfig. 
        /// <para>
        ///  Specifies whether profiling is enabled or disabled for the created profiling group.
        /// 
        /// </para>
        /// </summary>
        public AgentOrchestrationConfig AgentOrchestrationConfig { get; set; }

        /// <summary>
        /// Checks to see if the AgentOrchestrationConfig property is set.
        /// </summary>
        internal bool IsSetAgentOrchestrationConfig() => this.AgentOrchestrationConfig != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  Amazon CodeGuru Profiler uses this universally unique identifier (UUID) to prevent
        /// the accidental creation of duplicate profiling groups if there are failures and retries.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ComputePlatform. 
        /// <para>
        ///  The compute platform of the profiling group. Use <c>AWSLambda</c> if your application
        /// runs on AWS Lambda. Use <c>Default</c> if your application runs on a compute platform
        /// that is not AWS Lambda, such an Amazon EC2 instance, an on-premises server, or a different
        /// platform. If not specified, <c>Default</c> is used. 
        /// </para>
        /// </summary>
        public ComputePlatform ComputePlatform { get; set; }

        /// <summary>
        /// Checks to see if the ComputePlatform property is set.
        /// </summary>
        internal bool IsSetComputePlatform() => this.ComputePlatform != null;

        /// <summary>
        /// Gets and sets the property ProfilingGroupName. 
        /// <para>
        /// The name of the profiling group to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ProfilingGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ProfilingGroupName property is set.
        /// </summary>
        internal bool IsSetProfilingGroupName() => this.ProfilingGroupName != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  A list of tags to add to the created profiling group. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
