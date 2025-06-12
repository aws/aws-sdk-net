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
    /// Docker container image configuration object for the model explainability job.
    /// </summary>
    public partial class ModelExplainabilityAppSpecification
    {
        private string _configUri;
        private Dictionary<string, string> _environment = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _imageUri;

        /// <summary>
        /// Gets and sets the property ConfigUri. 
        /// <para>
        /// JSON formatted Amazon S3 file that defines explainability parameters. For more information
        /// on this JSON configuration file, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/clarify-config-json-monitor-model-explainability-parameters.html">Configure
        /// model explainability parameters</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string ConfigUri
        {
            get { return this._configUri; }
            set { this._configUri = value; }
        }

        // Check to see if ConfigUri property is set
        internal bool IsSetConfigUri()
        {
            return this._configUri != null;
        }

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// Sets the environment variables in the Docker container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Environment
        {
            get { return this._environment; }
            set { this._environment = value; }
        }

        // Check to see if Environment property is set
        internal bool IsSetEnvironment()
        {
            return this._environment != null && (this._environment.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ImageUri. 
        /// <para>
        /// The container image to be run by the model explainability job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=255)]
        public string ImageUri
        {
            get { return this._imageUri; }
            set { this._imageUri = value; }
        }

        // Check to see if ImageUri property is set
        internal bool IsSetImageUri()
        {
            return this._imageUri != null;
        }

    }
}