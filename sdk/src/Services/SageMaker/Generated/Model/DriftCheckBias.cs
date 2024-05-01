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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Represents the drift check bias baselines that can be used when the model monitor
    /// is set using the model package.
    /// </summary>
    public partial class DriftCheckBias
    {
        private FileSource _configFile;
        private MetricsSource _postTrainingConstraints;
        private MetricsSource _preTrainingConstraints;

        /// <summary>
        /// Gets and sets the property ConfigFile. 
        /// <para>
        /// The bias config file for a model.
        /// </para>
        /// </summary>
        public FileSource ConfigFile
        {
            get { return this._configFile; }
            set { this._configFile = value; }
        }

        // Check to see if ConfigFile property is set
        internal bool IsSetConfigFile()
        {
            return this._configFile != null;
        }

        /// <summary>
        /// Gets and sets the property PostTrainingConstraints. 
        /// <para>
        /// The post-training constraints.
        /// </para>
        /// </summary>
        public MetricsSource PostTrainingConstraints
        {
            get { return this._postTrainingConstraints; }
            set { this._postTrainingConstraints = value; }
        }

        // Check to see if PostTrainingConstraints property is set
        internal bool IsSetPostTrainingConstraints()
        {
            return this._postTrainingConstraints != null;
        }

        /// <summary>
        /// Gets and sets the property PreTrainingConstraints. 
        /// <para>
        /// The pre-training constraints.
        /// </para>
        /// </summary>
        public MetricsSource PreTrainingConstraints
        {
            get { return this._preTrainingConstraints; }
            set { this._preTrainingConstraints = value; }
        }

        // Check to see if PreTrainingConstraints property is set
        internal bool IsSetPreTrainingConstraints()
        {
            return this._preTrainingConstraints != null;
        }

    }
}