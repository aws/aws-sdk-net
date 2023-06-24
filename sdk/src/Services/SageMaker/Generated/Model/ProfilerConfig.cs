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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Configuration information for Amazon SageMaker Debugger system monitoring, framework
    /// profiling, and storage paths.
    /// </summary>
    public partial class ProfilerConfig
    {
        private bool? _disableProfiler;
        private long? _profilingIntervalInMilliseconds;
        private Dictionary<string, string> _profilingParameters = new Dictionary<string, string>();
        private string _s3OutputPath;

        /// <summary>
        /// Gets and sets the property DisableProfiler. 
        /// <para>
        /// Configuration to turn off Amazon SageMaker Debugger's system monitoring and profiling
        /// functionality. To turn it off, set to <code>True</code>.
        /// </para>
        /// </summary>
        public bool DisableProfiler
        {
            get { return this._disableProfiler.GetValueOrDefault(); }
            set { this._disableProfiler = value; }
        }

        // Check to see if DisableProfiler property is set
        internal bool IsSetDisableProfiler()
        {
            return this._disableProfiler.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProfilingIntervalInMilliseconds. 
        /// <para>
        /// A time interval for capturing system metrics in milliseconds. Available values are
        /// 100, 200, 500, 1000 (1 second), 5000 (5 seconds), and 60000 (1 minute) milliseconds.
        /// The default value is 500 milliseconds.
        /// </para>
        /// </summary>
        public long ProfilingIntervalInMilliseconds
        {
            get { return this._profilingIntervalInMilliseconds.GetValueOrDefault(); }
            set { this._profilingIntervalInMilliseconds = value; }
        }

        // Check to see if ProfilingIntervalInMilliseconds property is set
        internal bool IsSetProfilingIntervalInMilliseconds()
        {
            return this._profilingIntervalInMilliseconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProfilingParameters. 
        /// <para>
        /// Configuration information for capturing framework metrics. Available key strings for
        /// different profiling options are <code>DetailedProfilingConfig</code>, <code>PythonProfilingConfig</code>,
        /// and <code>DataLoaderProfilingConfig</code>. The following codes are configuration
        /// structures for the <code>ProfilingParameters</code> parameter. To learn more about
        /// how to configure the <code>ProfilingParameters</code> parameter, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/debugger-createtrainingjob-api.html">Use
        /// the SageMaker and Debugger Configuration API Operations to Create, Update, and Debug
        /// Your Training Job</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public Dictionary<string, string> ProfilingParameters
        {
            get { return this._profilingParameters; }
            set { this._profilingParameters = value; }
        }

        // Check to see if ProfilingParameters property is set
        internal bool IsSetProfilingParameters()
        {
            return this._profilingParameters != null && this._profilingParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property S3OutputPath. 
        /// <para>
        /// Path to Amazon S3 storage location for system and framework metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string S3OutputPath
        {
            get { return this._s3OutputPath; }
            set { this._s3OutputPath = value; }
        }

        // Check to see if S3OutputPath property is set
        internal bool IsSetS3OutputPath()
        {
            return this._s3OutputPath != null;
        }

    }
}