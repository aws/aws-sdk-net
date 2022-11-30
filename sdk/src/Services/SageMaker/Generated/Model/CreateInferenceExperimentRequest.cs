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
    /// Container for the parameters to the CreateInferenceExperiment operation.
    /// Creates an inference experiment using the configurations specified in the request.
    /// 
    /// 
    ///  
    /// <para>
    ///  Use this API to schedule an experiment to compare model variants on a Amazon SageMaker
    /// inference endpoint. For more information about inference experiments, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/shadow-tests.html">Shadow
    /// tests</a>. 
    /// </para>
    ///  
    /// <para>
    ///  Amazon SageMaker begins your experiment at the scheduled time and routes traffic
    /// to your endpoint's model variants based on your specified configuration. 
    /// </para>
    ///  
    /// <para>
    ///  While the experiment is in progress or after it has concluded, you can view metrics
    /// that compare your model variants. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/shadow-tests-view-monitor-edit.html">View,
    /// monitor, and edit shadow tests</a>. 
    /// </para>
    /// </summary>
    public partial class CreateInferenceExperimentRequest : AmazonSageMakerRequest
    {
        private InferenceExperimentDataStorageConfig _dataStorageConfig;
        private string _description;
        private string _endpointName;
        private string _kmsKey;
        private List<ModelVariantConfig> _modelVariants = new List<ModelVariantConfig>();
        private string _name;
        private string _roleArn;
        private InferenceExperimentSchedule _schedule;
        private ShadowModeConfig _shadowModeConfig;
        private List<Tag> _tags = new List<Tag>();
        private InferenceExperimentType _type;

        /// <summary>
        /// Gets and sets the property DataStorageConfig. 
        /// <para>
        ///  The storage configuration for the inference experiment. This is an optional parameter
        /// that you can use for data capture. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-monitor-data-capture.html">Capture
        /// data</a>. 
        /// </para>
        /// </summary>
        public InferenceExperimentDataStorageConfig DataStorageConfig
        {
            get { return this._dataStorageConfig; }
            set { this._dataStorageConfig = value; }
        }

        // Check to see if DataStorageConfig property is set
        internal bool IsSetDataStorageConfig()
        {
            return this._dataStorageConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the inference experiment.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        ///  The name of the Amazon SageMaker endpoint on which you want to run the inference
        /// experiment. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=63)]
        public string EndpointName
        {
            get { return this._endpointName; }
            set { this._endpointName = value; }
        }

        // Check to see if EndpointName property is set
        internal bool IsSetEndpointName()
        {
            return this._endpointName != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKey. 
        /// <para>
        ///  The Amazon Web Services Key Management Service (Amazon Web Services KMS) key that
        /// Amazon SageMaker uses to encrypt data on the storage volume attached to the ML compute
        /// instance that hosts the endpoint. The <code>KmsKey</code> can be any of the following
        /// formats: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// KMS key ID
        /// </para>
        ///  
        /// <para>
        ///  <code>"1234abcd-12ab-34cd-56ef-1234567890ab"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Resource Name (ARN) of a KMS key
        /// </para>
        ///  
        /// <para>
        ///  <code>"arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab"</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// KMS key Alias
        /// </para>
        ///  
        /// <para>
        ///  <code>"alias/ExampleAlias"</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Resource Name (ARN) of a KMS key Alias
        /// </para>
        ///  
        /// <para>
        ///  <code>"arn:aws:kms:us-west-2:111122223333:alias/ExampleAlias"</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  If you use a KMS key ID or an alias of your KMS key, the Amazon SageMaker execution
        /// role must include permissions to call <code>kms:Encrypt</code>. If you don't provide
        /// a KMS key ID, Amazon SageMaker uses the default KMS key for Amazon S3 for your role's
        /// account. Amazon SageMaker uses server-side encryption with KMS managed keys for <code>OutputDataConfig</code>.
        /// If you use a bucket policy with an <code>s3:PutObject</code> permission that only
        /// allows objects with server-side encryption, set the condition key of <code>s3:x-amz-server-side-encryption</code>
        /// to <code>"aws:kms"</code>. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingKMSEncryption.html">KMS
        /// managed Encryption Keys</a> in the <i>Amazon Simple Storage Service Developer Guide.</i>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  The KMS key policy must grant permission to the IAM role that you specify in your
        /// <code>CreateEndpoint</code> and <code>UpdateEndpoint</code> requests. For more information,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">Using
        /// Key Policies in Amazon Web Services KMS</a> in the <i>Amazon Web Services Key Management
        /// Service Developer Guide</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string KmsKey
        {
            get { return this._kmsKey; }
            set { this._kmsKey = value; }
        }

        // Check to see if KmsKey property is set
        internal bool IsSetKmsKey()
        {
            return this._kmsKey != null;
        }

        /// <summary>
        /// Gets and sets the property ModelVariants. 
        /// <para>
        ///  Array of <code>ModelVariantConfigSummary</code> objects. There is one for each variant
        /// in the inference experiment. Each <code>ModelVariantConfigSummary</code> object in
        /// the array describes the infrastructure configuration for the corresponding variant.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2)]
        public List<ModelVariantConfig> ModelVariants
        {
            get { return this._modelVariants; }
            set { this._modelVariants = value; }
        }

        // Check to see if ModelVariants property is set
        internal bool IsSetModelVariants()
        {
            return this._modelVariants != null && this._modelVariants.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the inference experiment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=120)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        ///  The ARN of the IAM role that Amazon SageMaker can assume to access model artifacts
        /// and container images. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        ///  The duration for which you want the inference experiment to run. If you don't specify
        /// this field, the experiment automatically concludes after 7 days. 
        /// </para>
        /// </summary>
        public InferenceExperimentSchedule Schedule
        {
            get { return this._schedule; }
            set { this._schedule = value; }
        }

        // Check to see if Schedule property is set
        internal bool IsSetSchedule()
        {
            return this._schedule != null;
        }

        /// <summary>
        /// Gets and sets the property ShadowModeConfig. 
        /// <para>
        ///  Shows which variant is the production variant and which variant is the shadow variant.
        /// For the shadow variant, also shows the sampling percentage. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ShadowModeConfig ShadowModeConfig
        {
            get { return this._shadowModeConfig; }
            set { this._shadowModeConfig = value; }
        }

        // Check to see if ShadowModeConfig property is set
        internal bool IsSetShadowModeConfig()
        {
            return this._shadowModeConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  Array of key-value pairs. You can use tags to categorize your Amazon Web Services
        /// resources in different ways, for example, by purpose, owner, or environment. For more
        /// information, see <a href="https://docs.aws.amazon.com/ARG/latest/userguide/tagging.html">Tagging
        /// your Amazon Web Services Resources</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  The type of the inference experiment that you want to run. The following types of
        /// experiments are possible: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ShadowMode</code>: You can use this type to validate a shadow variant. For
        /// more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/shadow-tests.html">Shadow
        /// tests</a>. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public InferenceExperimentType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}