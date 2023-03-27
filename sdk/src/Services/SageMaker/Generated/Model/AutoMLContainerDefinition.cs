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
    /// A list of container definitions that describe the different containers that make up
    /// an AutoML candidate. For more information, see <code> <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ContainerDefinition.html">
    /// ContainerDefinition</a> </code>.
    /// </summary>
    public partial class AutoMLContainerDefinition
    {
        private Dictionary<string, string> _environment = new Dictionary<string, string>();
        private string _image;
        private string _modelDataUrl;

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment variables to set in the container. For more information, see <code>
        /// <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ContainerDefinition.html">
        /// ContainerDefinition</a> </code>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=16)]
        public Dictionary<string, string> Environment
        {
            get { return this._environment; }
            set { this._environment = value; }
        }

        // Check to see if Environment property is set
        internal bool IsSetEnvironment()
        {
            return this._environment != null && this._environment.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The Amazon Elastic Container Registry (Amazon ECR) path of the container. For more
        /// information, see <code> <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ContainerDefinition.html">
        /// ContainerDefinition</a> </code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string Image
        {
            get { return this._image; }
            set { this._image = value; }
        }

        // Check to see if Image property is set
        internal bool IsSetImage()
        {
            return this._image != null;
        }

        /// <summary>
        /// Gets and sets the property ModelDataUrl. 
        /// <para>
        /// The location of the model artifacts. For more information, see <code> <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ContainerDefinition.html">
        /// ContainerDefinition</a> </code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
        public string ModelDataUrl
        {
            get { return this._modelDataUrl; }
            set { this._modelDataUrl = value; }
        }

        // Check to see if ModelDataUrl property is set
        internal bool IsSetModelDataUrl()
        {
            return this._modelDataUrl != null;
        }

    }
}