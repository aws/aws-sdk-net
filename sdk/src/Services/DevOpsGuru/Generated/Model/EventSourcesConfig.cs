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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
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
namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Information about the integration of DevOps Guru as consumer with another AWS service,
    /// such as AWS CodeGuru Profiler via EventBridge.
    /// </summary>
    public partial class EventSourcesConfig
    {
        private AmazonCodeGuruProfilerIntegration _amazonCodeGuruProfiler;

        /// <summary>
        /// Gets and sets the property AmazonCodeGuruProfiler. 
        /// <para>
        /// Information about whether DevOps Guru is configured to consume recommendations which
        /// are generated from AWS CodeGuru Profiler.
        /// </para>
        /// </summary>
        public AmazonCodeGuruProfilerIntegration AmazonCodeGuruProfiler
        {
            get { return this._amazonCodeGuruProfiler; }
            set { this._amazonCodeGuruProfiler = value; }
        }

        // Check to see if AmazonCodeGuruProfiler property is set
        internal bool IsSetAmazonCodeGuruProfiler()
        {
            return this._amazonCodeGuruProfiler != null;
        }

    }
}