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
    /// Details about the resources that are deployed with this inference component.
    /// </summary>
    public partial class InferenceComponentContainerSpecificationSummary
    {
        private string _artifactUrl;
        private DeployedImage _deployedImage;
        private Dictionary<string, string> _environment = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ArtifactUrl. 
        /// <para>
        /// The Amazon S3 path where the model artifacts are stored.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ArtifactUrl
        {
            get { return this._artifactUrl; }
            set { this._artifactUrl = value; }
        }

        // Check to see if ArtifactUrl property is set
        internal bool IsSetArtifactUrl()
        {
            return this._artifactUrl != null;
        }

        /// <summary>
        /// Gets and sets the property DeployedImage.
        /// </summary>
        public DeployedImage DeployedImage
        {
            get { return this._deployedImage; }
            set { this._deployedImage = value; }
        }

        // Check to see if DeployedImage property is set
        internal bool IsSetDeployedImage()
        {
            return this._deployedImage != null;
        }

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment variables to set in the Docker container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
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

    }
}