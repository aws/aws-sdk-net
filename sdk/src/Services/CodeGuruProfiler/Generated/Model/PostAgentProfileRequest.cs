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
    /// Container for the parameters to the PostAgentProfile operation.
    /// Submits profiling data to an aggregated profile of a profiling group. To get an aggregated
    /// profile that is created with this profiling data, use <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_GetProfile.html">
    /// <c>GetProfile</c> </a>.
    /// </summary>
    public partial class PostAgentProfileRequest : AmazonCodeGuruProfilerRequest
    {
        private MemoryStream _agentProfile;
        private string _contentType;
        private string _profileToken;
        private string _profilingGroupName;

        /// <summary>
        /// Gets and sets the property AgentProfile. 
        /// <para>
        ///  The submitted profiling data. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MemoryStream AgentProfile
        {
            get { return this._agentProfile; }
            set { this._agentProfile = value; }
        }

        // Check to see if AgentProfile property is set
        internal bool IsSetAgentProfile()
        {
            return this._agentProfile != null;
        }

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        ///  The format of the submitted profiling data. The format maps to the <c>Accept</c>
        /// and <c>Content-Type</c> headers of the HTTP request. You can specify one of the following:
        /// or the default . 
        /// </para>
        ///  <pre><c> &lt;ul&gt; &lt;li&gt; &lt;p&gt; &lt;code&gt;application/json&lt;/code&gt;
        /// — standard JSON format &lt;/p&gt; &lt;/li&gt; &lt;li&gt; &lt;p&gt; &lt;code&gt;application/x-amzn-ion&lt;/code&gt;
        /// — the Amazon Ion data format. For more information, see &lt;a href=&quot;http://amzn.github.io/ion-docs/&quot;&gt;Amazon
        /// Ion&lt;/a&gt;. &lt;/p&gt; &lt;/li&gt; &lt;/ul&gt; </c></pre>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileToken. 
        /// <para>
        ///  Amazon CodeGuru Profiler uses this universally unique identifier (UUID) to prevent
        /// the accidental submission of duplicate profiling data if there are failures and retries.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ProfileToken
        {
            get { return this._profileToken; }
            set { this._profileToken = value; }
        }

        // Check to see if ProfileToken property is set
        internal bool IsSetProfileToken()
        {
            return this._profileToken != null;
        }

        /// <summary>
        /// Gets and sets the property ProfilingGroupName. 
        /// <para>
        ///  The name of the profiling group with the aggregated profile that receives the submitted
        /// profiling data. 
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