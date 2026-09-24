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
    /// Container for the parameters to the PostAgentProfile operation. Submits profiling
    /// data to an aggregated profile of a profiling group. To get an aggregated profile that
    /// is created with this profiling data, use <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_GetProfile.html">
    /// <c>GetProfile</c> </a>.
    /// </summary>
    public partial class PostAgentProfileRequest : AmazonCodeGuruProfilerRequest
    {
        /// <summary>
        /// Gets and sets the property AgentProfile. 
        /// <para>
        ///  The submitted profiling data. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MemoryStream AgentProfile { get; set; }

        /// <summary>
        /// Checks to see if the AgentProfile property is set.
        /// </summary>
        internal bool IsSetAgentProfile() => this.AgentProfile != null;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        ///  The format of the submitted profiling data. The format maps to the <c>Accept</c>
        /// and <c>Content-Type</c> headers of the HTTP request. You can specify one of the following:
        /// or the default . 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>application/json</c> — standard JSON format 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>application/x-amzn-ion</c> — the Amazon Ion data format. For more information,
        /// see <a href="http://amzn.github.io/ion-docs/">Amazon Ion</a>. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property ProfileToken. 
        /// <para>
        ///  Amazon CodeGuru Profiler uses this universally unique identifier (UUID) to prevent
        /// the accidental submission of duplicate profiling data if there are failures and retries.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ProfileToken { get; set; }

        /// <summary>
        /// Checks to see if the ProfileToken property is set.
        /// </summary>
        internal bool IsSetProfileToken() => this.ProfileToken != null;

        /// <summary>
        /// Gets and sets the property ProfilingGroupName. 
        /// <para>
        ///  The name of the profiling group with the aggregated profile that receives the submitted
        /// profiling data. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ProfilingGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ProfilingGroupName property is set.
        /// </summary>
        internal bool IsSetProfilingGroupName() => this.ProfilingGroupName != null;
    }
}
