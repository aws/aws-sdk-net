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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Contains data processing unit (DPU) configuration settings and parameter mappings
    /// for a notebook engine.
    /// </summary>
    public partial class EngineConfiguration
    {
        private Dictionary<string, string> _additionalConfigs = new Dictionary<string, string>();
        private int? _coordinatorDpuSize;
        private int? _defaultExecutorDpuSize;
        private int? _maxConcurrentDpus;

        /// <summary>
        /// Gets and sets the property AdditionalConfigs. 
        /// <para>
        /// Contains additional notebook engine <code>MAP&lt;string, string&gt;</code> parameter
        /// mappings in the form of key-value pairs. To specify an Amazon S3 URI that the Jupyter
        /// server will download and serve, specify a value for the <a>StartSessionRequest$NotebookVersion</a>
        /// field, and then add a key named <code>NotebookFileURI</code> to <code>AdditionalConfigs</code>
        /// that has value of the Amazon S3 URI.
        /// </para>
        /// </summary>
        public Dictionary<string, string> AdditionalConfigs
        {
            get { return this._additionalConfigs; }
            set { this._additionalConfigs = value; }
        }

        // Check to see if AdditionalConfigs property is set
        internal bool IsSetAdditionalConfigs()
        {
            return this._additionalConfigs != null && this._additionalConfigs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CoordinatorDpuSize. 
        /// <para>
        /// The number of DPUs to use for the coordinator. A coordinator is a special executor
        /// that orchestrates processing work and manages other executors in a notebook session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5000)]
        public int CoordinatorDpuSize
        {
            get { return this._coordinatorDpuSize.GetValueOrDefault(); }
            set { this._coordinatorDpuSize = value; }
        }

        // Check to see if CoordinatorDpuSize property is set
        internal bool IsSetCoordinatorDpuSize()
        {
            return this._coordinatorDpuSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultExecutorDpuSize. 
        /// <para>
        /// The default number of DPUs to use for executors. An executor is the smallest unit
        /// of compute that a notebook session can request from Athena.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5000)]
        public int DefaultExecutorDpuSize
        {
            get { return this._defaultExecutorDpuSize.GetValueOrDefault(); }
            set { this._defaultExecutorDpuSize = value; }
        }

        // Check to see if DefaultExecutorDpuSize property is set
        internal bool IsSetDefaultExecutorDpuSize()
        {
            return this._defaultExecutorDpuSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxConcurrentDpus. 
        /// <para>
        /// The maximum number of DPUs that can run concurrently.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=5000)]
        public int MaxConcurrentDpus
        {
            get { return this._maxConcurrentDpus.GetValueOrDefault(); }
            set { this._maxConcurrentDpus = value; }
        }

        // Check to see if MaxConcurrentDpus property is set
        internal bool IsSetMaxConcurrentDpus()
        {
            return this._maxConcurrentDpus.HasValue; 
        }

    }
}