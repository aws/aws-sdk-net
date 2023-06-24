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
    /// The input configuration of the recommendation job.
    /// </summary>
    public partial class RecommendationJobInputConfig
    {
        private RecommendationJobContainerConfig _containerConfig;
        private List<EndpointInputConfiguration> _endpointConfigurations = new List<EndpointInputConfiguration>();
        private List<EndpointInfo> _endpoints = new List<EndpointInfo>();
        private int? _jobDurationInSeconds;
        private string _modelName;
        private string _modelPackageVersionArn;
        private RecommendationJobResourceLimit _resourceLimit;
        private TrafficPattern _trafficPattern;
        private string _volumeKmsKeyId;
        private RecommendationJobVpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property ContainerConfig. 
        /// <para>
        /// Specifies mandatory fields for running an Inference Recommender job. The fields specified
        /// in <code>ContainerConfig</code> override the corresponding fields in the model package.
        /// </para>
        /// </summary>
        public RecommendationJobContainerConfig ContainerConfig
        {
            get { return this._containerConfig; }
            set { this._containerConfig = value; }
        }

        // Check to see if ContainerConfig property is set
        internal bool IsSetContainerConfig()
        {
            return this._containerConfig != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointConfigurations. 
        /// <para>
        /// Specifies the endpoint configuration to use for a job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<EndpointInputConfiguration> EndpointConfigurations
        {
            get { return this._endpointConfigurations; }
            set { this._endpointConfigurations = value; }
        }

        // Check to see if EndpointConfigurations property is set
        internal bool IsSetEndpointConfigurations()
        {
            return this._endpointConfigurations != null && this._endpointConfigurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Endpoints. 
        /// <para>
        /// Existing customer endpoints on which to run an Inference Recommender job.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1)]
        public List<EndpointInfo> Endpoints
        {
            get { return this._endpoints; }
            set { this._endpoints = value; }
        }

        // Check to see if Endpoints property is set
        internal bool IsSetEndpoints()
        {
            return this._endpoints != null && this._endpoints.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property JobDurationInSeconds. 
        /// <para>
        /// Specifies the maximum duration of the job, in seconds.&gt;
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int JobDurationInSeconds
        {
            get { return this._jobDurationInSeconds.GetValueOrDefault(); }
            set { this._jobDurationInSeconds = value; }
        }

        // Check to see if JobDurationInSeconds property is set
        internal bool IsSetJobDurationInSeconds()
        {
            return this._jobDurationInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the created model.
        /// </para>
        /// </summary>
        [AWSProperty(Max=63)]
        public string ModelName
        {
            get { return this._modelName; }
            set { this._modelName = value; }
        }

        // Check to see if ModelName property is set
        internal bool IsSetModelName()
        {
            return this._modelName != null;
        }

        /// <summary>
        /// Gets and sets the property ModelPackageVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a versioned model package.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ModelPackageVersionArn
        {
            get { return this._modelPackageVersionArn; }
            set { this._modelPackageVersionArn = value; }
        }

        // Check to see if ModelPackageVersionArn property is set
        internal bool IsSetModelPackageVersionArn()
        {
            return this._modelPackageVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceLimit. 
        /// <para>
        /// Defines the resource limit of the job.
        /// </para>
        /// </summary>
        public RecommendationJobResourceLimit ResourceLimit
        {
            get { return this._resourceLimit; }
            set { this._resourceLimit = value; }
        }

        // Check to see if ResourceLimit property is set
        internal bool IsSetResourceLimit()
        {
            return this._resourceLimit != null;
        }

        /// <summary>
        /// Gets and sets the property TrafficPattern. 
        /// <para>
        /// Specifies the traffic pattern of the job.
        /// </para>
        /// </summary>
        public TrafficPattern TrafficPattern
        {
            get { return this._trafficPattern; }
            set { this._trafficPattern = value; }
        }

        // Check to see if TrafficPattern property is set
        internal bool IsSetTrafficPattern()
        {
            return this._trafficPattern != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeKmsKeyId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a Amazon Web Services Key Management Service (Amazon
        /// Web Services KMS) key that Amazon SageMaker uses to encrypt data on the storage volume
        /// attached to the ML compute instance that hosts the endpoint. This key will be passed
        /// to SageMaker Hosting for endpoint creation. 
        /// </para>
        ///  
        /// <para>
        /// The SageMaker execution role must have <code>kms:CreateGrant</code> permission in
        /// order to encrypt data on the storage volume of the endpoints created for inference
        /// recommendation. The inference recommendation job will fail asynchronously during endpoint
        /// configuration creation if the role passed does not have <code>kms:CreateGrant</code>
        /// permission.
        /// </para>
        ///  
        /// <para>
        /// The <code>KmsKeyId</code> can be any of the following formats:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// // KMS Key ID
        /// </para>
        ///  
        /// <para>
        ///  <code>"1234abcd-12ab-34cd-56ef-1234567890ab"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// // Amazon Resource Name (ARN) of a KMS Key
        /// </para>
        ///  
        /// <para>
        ///  <code>"arn:aws:kms:&lt;region&gt;:&lt;account&gt;:key/&lt;key-id-12ab-34cd-56ef-1234567890ab&gt;"</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// // KMS Key Alias
        /// </para>
        ///  
        /// <para>
        ///  <code>"alias/ExampleAlias"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// // Amazon Resource Name (ARN) of a KMS Key Alias
        /// </para>
        ///  
        /// <para>
        ///  <code>"arn:aws:kms:&lt;region&gt;:&lt;account&gt;:alias/&lt;ExampleAlias&gt;"</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about key identifiers, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-id-key-id">Key
        /// identifiers (KeyID)</a> in the Amazon Web Services Key Management Service (Amazon
        /// Web Services KMS) documentation.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string VolumeKmsKeyId
        {
            get { return this._volumeKmsKeyId; }
            set { this._volumeKmsKeyId = value; }
        }

        // Check to see if VolumeKmsKeyId property is set
        internal bool IsSetVolumeKmsKeyId()
        {
            return this._volumeKmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// Inference Recommender provisions SageMaker endpoints with access to VPC in the inference
        /// recommendation job.
        /// </para>
        /// </summary>
        public RecommendationJobVpcConfig VpcConfig
        {
            get { return this._vpcConfig; }
            set { this._vpcConfig = value; }
        }

        // Check to see if VpcConfig property is set
        internal bool IsSetVpcConfig()
        {
            return this._vpcConfig != null;
        }

    }
}