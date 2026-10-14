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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// The input configuration of the recommendation job.
    /// </summary>
    public partial class RecommendationJobInputConfig
    {
        /// <summary>
        /// Gets and sets the property ContainerConfig. 
        /// <para>
        /// Specifies mandatory fields for running an Inference Recommender job. The fields specified
        /// in <c>ContainerConfig</c> override the corresponding fields in the model package.
        /// </para>
        /// </summary>
        public RecommendationJobContainerConfig ContainerConfig { get; set; }

        /// <summary>
        /// Checks to see if the ContainerConfig property is set.
        /// </summary>
        internal bool IsSetContainerConfig() => this.ContainerConfig != null;

        /// <summary>
        /// Gets and sets the property EndpointConfigurations. 
        /// <para>
        /// Specifies the endpoint configuration to use for a job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<EndpointInputConfiguration> EndpointConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<EndpointInputConfiguration>() : null;

        /// <summary>
        /// Checks to see if the EndpointConfigurations property is set.
        /// </summary>
        internal bool IsSetEndpointConfigurations() => this.EndpointConfigurations != null && (this.EndpointConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Endpoints. 
        /// <para>
        /// Existing customer endpoints on which to run an Inference Recommender job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public List<EndpointInfo> Endpoints { get; set; } = AWSConfigs.InitializeCollections ? new List<EndpointInfo>() : null;

        /// <summary>
        /// Checks to see if the Endpoints property is set.
        /// </summary>
        internal bool IsSetEndpoints() => this.Endpoints != null && (this.Endpoints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property JobDurationInSeconds. 
        /// <para>
        /// Specifies the maximum duration of the job, in seconds. The maximum value is 18,000
        /// seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? JobDurationInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the JobDurationInSeconds property is set.
        /// </summary>
        internal bool IsSetJobDurationInSeconds() => this.JobDurationInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the created model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string ModelName { get; set; }

        /// <summary>
        /// Checks to see if the ModelName property is set.
        /// </summary>
        internal bool IsSetModelName() => this.ModelName != null;

        /// <summary>
        /// Gets and sets the property ModelPackageVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a versioned model package.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ModelPackageVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelPackageVersionArn property is set.
        /// </summary>
        internal bool IsSetModelPackageVersionArn() => this.ModelPackageVersionArn != null;

        /// <summary>
        /// Gets and sets the property ResourceLimit. 
        /// <para>
        /// Defines the resource limit of the job.
        /// </para>
        /// </summary>
        public RecommendationJobResourceLimit ResourceLimit { get; set; }

        /// <summary>
        /// Checks to see if the ResourceLimit property is set.
        /// </summary>
        internal bool IsSetResourceLimit() => this.ResourceLimit != null;

        /// <summary>
        /// Gets and sets the property TrafficPattern. 
        /// <para>
        /// Specifies the traffic pattern of the job.
        /// </para>
        /// </summary>
        public TrafficPattern TrafficPattern { get; set; }

        /// <summary>
        /// Checks to see if the TrafficPattern property is set.
        /// </summary>
        internal bool IsSetTrafficPattern() => this.TrafficPattern != null;

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
        /// The SageMaker execution role must have <c>kms:CreateGrant</c> permission in order
        /// to encrypt data on the storage volume of the endpoints created for inference recommendation.
        /// The inference recommendation job will fail asynchronously during endpoint configuration
        /// creation if the role passed does not have <c>kms:CreateGrant</c> permission.
        /// </para>
        ///  
        /// <para>
        /// The <c>KmsKeyId</c> can be any of the following formats:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// // KMS Key ID
        /// </para>
        ///  
        /// <para>
        ///  <c>"1234abcd-12ab-34cd-56ef-1234567890ab"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// // Amazon Resource Name (ARN) of a KMS Key
        /// </para>
        ///  
        /// <para>
        ///  <c>"arn:aws:kms:&lt;region&gt;:&lt;account&gt;:key/&lt;key-id-12ab-34cd-56ef-1234567890ab&gt;"</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// // KMS Key Alias
        /// </para>
        ///  
        /// <para>
        ///  <c>"alias/ExampleAlias"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// // Amazon Resource Name (ARN) of a KMS Key Alias
        /// </para>
        ///  
        /// <para>
        ///  <c>"arn:aws:kms:&lt;region&gt;:&lt;account&gt;:alias/&lt;ExampleAlias&gt;"</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about key identifiers, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-id-key-id">Key
        /// identifiers (KeyID)</a> in the Amazon Web Services Key Management Service (Amazon
        /// Web Services KMS) documentation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string VolumeKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the VolumeKmsKeyId property is set.
        /// </summary>
        internal bool IsSetVolumeKmsKeyId() => this.VolumeKmsKeyId != null;

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// Inference Recommender provisions SageMaker endpoints with access to VPC in the inference
        /// recommendation job.
        /// </para>
        /// </summary>
        public RecommendationJobVpcConfig VpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfig property is set.
        /// </summary>
        internal bool IsSetVpcConfig() => this.VpcConfig != null;
    }
}
