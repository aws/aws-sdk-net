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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Athena.Model
{
    /// <summary>
    /// Contains data processing unit (DPU) configuration settings and parameter mappings
    /// for a notebook engine.
    /// </summary>
    public partial class EngineConfiguration
    {
        private Dictionary<string, string> _additionalConfigs = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private int? _coordinatorDpuSize;
        private int? _defaultExecutorDpuSize;
        private int? _maxConcurrentDpus;
        private Dictionary<string, string> _sparkProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AdditionalConfigs. 
        /// <para>
        /// Contains additional notebook engine <c>MAP&lt;string, string&gt;</c> parameter mappings
        /// in the form of key-value pairs. To specify an Athena notebook that the Jupyter server
        /// will download and serve, specify a value for the <a>StartSessionRequest$NotebookVersion</a>
        /// field, and then add a key named <c>NotebookId</c> to <c>AdditionalConfigs</c> that
        /// has the value of the Athena notebook ID.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> AdditionalConfigs
        {
            get { return this._additionalConfigs; }
            set { this._additionalConfigs = value; }
        }

        // Check to see if AdditionalConfigs property is set
        internal bool IsSetAdditionalConfigs()
        {
            return this._additionalConfigs != null && (this._additionalConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CoordinatorDpuSize. 
        /// <para>
        /// The number of DPUs to use for the coordinator. A coordinator is a special executor
        /// that orchestrates processing work and manages other executors in a notebook session.
        /// The default is 1.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public int? CoordinatorDpuSize
        {
            get { return this._coordinatorDpuSize; }
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
        /// of compute that a notebook session can request from Athena. The default is 1.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public int? DefaultExecutorDpuSize
        {
            get { return this._defaultExecutorDpuSize; }
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
        public int? MaxConcurrentDpus
        {
            get { return this._maxConcurrentDpus; }
            set { this._maxConcurrentDpus = value; }
        }

        // Check to see if MaxConcurrentDpus property is set
        internal bool IsSetMaxConcurrentDpus()
        {
            return this._maxConcurrentDpus.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SparkProperties. 
        /// <para>
        /// Specifies custom jar files and Spark properties for use cases like cluster encryption,
        /// table formats, and general Spark tuning.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> SparkProperties
        {
            get { return this._sparkProperties; }
            set { this._sparkProperties = value; }
        }

        // Check to see if SparkProperties property is set
        internal bool IsSetSparkProperties()
        {
            return this._sparkProperties != null && (this._sparkProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}