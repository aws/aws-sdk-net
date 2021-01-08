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
    /// Defines how to perform inference generation after a training job is run.
    /// </summary>
    public partial class InferenceSpecification
    {
        private List<ModelPackageContainerDefinition> _containers = new List<ModelPackageContainerDefinition>();
        private List<string> _supportedContentTypes = new List<string>();
        private List<string> _supportedRealtimeInferenceInstanceTypes = new List<string>();
        private List<string> _supportedResponseMIMETypes = new List<string>();
        private List<string> _supportedTransformInstanceTypes = new List<string>();

        /// <summary>
        /// Gets and sets the property Containers. 
        /// <para>
        /// The Amazon ECR registry path of the Docker image that contains the inference code.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<ModelPackageContainerDefinition> Containers
        {
            get { return this._containers; }
            set { this._containers = value; }
        }

        // Check to see if Containers property is set
        internal bool IsSetContainers()
        {
            return this._containers != null && this._containers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SupportedContentTypes. 
        /// <para>
        /// The supported MIME types for the input data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> SupportedContentTypes
        {
            get { return this._supportedContentTypes; }
            set { this._supportedContentTypes = value; }
        }

        // Check to see if SupportedContentTypes property is set
        internal bool IsSetSupportedContentTypes()
        {
            return this._supportedContentTypes != null && this._supportedContentTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SupportedRealtimeInferenceInstanceTypes. 
        /// <para>
        /// A list of the instance types that are used to generate inferences in real-time.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required for unversioned models, and optional for versioned models.
        /// </para>
        /// </summary>
        public List<string> SupportedRealtimeInferenceInstanceTypes
        {
            get { return this._supportedRealtimeInferenceInstanceTypes; }
            set { this._supportedRealtimeInferenceInstanceTypes = value; }
        }

        // Check to see if SupportedRealtimeInferenceInstanceTypes property is set
        internal bool IsSetSupportedRealtimeInferenceInstanceTypes()
        {
            return this._supportedRealtimeInferenceInstanceTypes != null && this._supportedRealtimeInferenceInstanceTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SupportedResponseMIMETypes. 
        /// <para>
        /// The supported MIME types for the output data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> SupportedResponseMIMETypes
        {
            get { return this._supportedResponseMIMETypes; }
            set { this._supportedResponseMIMETypes = value; }
        }

        // Check to see if SupportedResponseMIMETypes property is set
        internal bool IsSetSupportedResponseMIMETypes()
        {
            return this._supportedResponseMIMETypes != null && this._supportedResponseMIMETypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SupportedTransformInstanceTypes. 
        /// <para>
        /// A list of the instance types on which a transformation job can be run or on which
        /// an endpoint can be deployed.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required for unversioned models, and optional for versioned models.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> SupportedTransformInstanceTypes
        {
            get { return this._supportedTransformInstanceTypes; }
            set { this._supportedTransformInstanceTypes = value; }
        }

        // Check to see if SupportedTransformInstanceTypes property is set
        internal bool IsSetSupportedTransformInstanceTypes()
        {
            return this._supportedTransformInstanceTypes != null && this._supportedTransformInstanceTypes.Count > 0; 
        }

    }
}