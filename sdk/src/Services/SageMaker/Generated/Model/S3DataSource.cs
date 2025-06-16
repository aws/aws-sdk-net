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
    /// Describes the S3 data source.
    /// 
    ///  
    /// <para>
    /// Your input bucket must be in the same Amazon Web Services region as your training
    /// job.
    /// </para>
    /// </summary>
    public partial class S3DataSource
    {
        private List<string> _attributeNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private HubAccessConfig _hubAccessConfig;
        private List<string> _instanceGroupNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ModelAccessConfig _modelAccessConfig;
        private S3DataDistribution _s3DataDistributionType;
        private S3DataType _s3DataType;
        private string _s3Uri;

        /// <summary>
        /// Gets and sets the property AttributeNames. 
        /// <para>
        /// A list of one or more attribute names to use that are found in a specified augmented
        /// manifest file.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=16)]
        public List<string> AttributeNames
        {
            get { return this._attributeNames; }
            set { this._attributeNames = value; }
        }

        // Check to see if AttributeNames property is set
        internal bool IsSetAttributeNames()
        {
            return this._attributeNames != null && (this._attributeNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HubAccessConfig. 
        /// <para>
        /// The configuration for a private hub model reference that points to a SageMaker JumpStart
        /// public hub model.
        /// </para>
        /// </summary>
        public HubAccessConfig HubAccessConfig
        {
            get { return this._hubAccessConfig; }
            set { this._hubAccessConfig = value; }
        }

        // Check to see if HubAccessConfig property is set
        internal bool IsSetHubAccessConfig()
        {
            return this._hubAccessConfig != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceGroupNames. 
        /// <para>
        /// A list of names of instance groups that get data from the S3 data source.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> InstanceGroupNames
        {
            get { return this._instanceGroupNames; }
            set { this._instanceGroupNames = value; }
        }

        // Check to see if InstanceGroupNames property is set
        internal bool IsSetInstanceGroupNames()
        {
            return this._instanceGroupNames != null && (this._instanceGroupNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ModelAccessConfig.
        /// </summary>
        public ModelAccessConfig ModelAccessConfig
        {
            get { return this._modelAccessConfig; }
            set { this._modelAccessConfig = value; }
        }

        // Check to see if ModelAccessConfig property is set
        internal bool IsSetModelAccessConfig()
        {
            return this._modelAccessConfig != null;
        }

        /// <summary>
        /// Gets and sets the property S3DataDistributionType. 
        /// <para>
        /// If you want SageMaker to replicate the entire dataset on each ML compute instance
        /// that is launched for model training, specify <c>FullyReplicated</c>. 
        /// </para>
        ///  
        /// <para>
        /// If you want SageMaker to replicate a subset of data on each ML compute instance that
        /// is launched for model training, specify <c>ShardedByS3Key</c>. If there are <i>n</i>
        /// ML compute instances launched for a training job, each instance gets approximately
        /// 1/<i>n</i> of the number of S3 objects. In this case, model training on each machine
        /// uses only the subset of training data. 
        /// </para>
        ///  
        /// <para>
        /// Don't choose more ML compute instances for training than available S3 objects. If
        /// you do, some nodes won't get any data and you will pay for nodes that aren't getting
        /// any training data. This applies in both File and Pipe modes. Keep this in mind when
        /// developing algorithms. 
        /// </para>
        ///  
        /// <para>
        /// In distributed training, where you use multiple ML compute EC2 instances, you might
        /// choose <c>ShardedByS3Key</c>. If the algorithm requires copying training data to the
        /// ML storage volume (when <c>TrainingInputMode</c> is set to <c>File</c>), this copies
        /// 1/<i>n</i> of the number of objects. 
        /// </para>
        /// </summary>
        public S3DataDistribution S3DataDistributionType
        {
            get { return this._s3DataDistributionType; }
            set { this._s3DataDistributionType = value; }
        }

        // Check to see if S3DataDistributionType property is set
        internal bool IsSetS3DataDistributionType()
        {
            return this._s3DataDistributionType != null;
        }

        /// <summary>
        /// Gets and sets the property S3DataType. 
        /// <para>
        /// If you choose <c>S3Prefix</c>, <c>S3Uri</c> identifies a key name prefix. SageMaker
        /// uses all objects that match the specified key name prefix for model training. 
        /// </para>
        ///  
        /// <para>
        /// If you choose <c>ManifestFile</c>, <c>S3Uri</c> identifies an object that is a manifest
        /// file containing a list of object keys that you want SageMaker to use for model training.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If you choose <c>AugmentedManifestFile</c>, <c>S3Uri</c> identifies an object that
        /// is an augmented manifest file in JSON lines format. This file contains the data you
        /// want to use for model training. <c>AugmentedManifestFile</c> can only be used if the
        /// Channel's input mode is <c>Pipe</c>.
        /// </para>
        ///  
        /// <para>
        /// If you choose <c>Converse</c>, <c>S3Uri</c> identifies an Amazon S3 location that
        /// contains data formatted according to Converse format. This format structures conversational
        /// messages with specific roles and content types used for training and fine-tuning foundational
        /// models.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3DataType S3DataType
        {
            get { return this._s3DataType; }
            set { this._s3DataType = value; }
        }

        // Check to see if S3DataType property is set
        internal bool IsSetS3DataType()
        {
            return this._s3DataType != null;
        }

        /// <summary>
        /// Gets and sets the property S3Uri. 
        /// <para>
        /// Depending on the value specified for the <c>S3DataType</c>, identifies either a key
        /// name prefix or a manifest. For example: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  A key name prefix might look like this: <c>s3://bucketname/exampleprefix/</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  A manifest might look like this: <c>s3://bucketname/example.manifest</c> 
        /// </para>
        ///  
        /// <para>
        ///  A manifest is an S3 object which is a JSON file consisting of an array of elements.
        /// The first element is a prefix which is followed by one or more suffixes. SageMaker
        /// appends the suffix elements to the prefix to get a full set of <c>S3Uri</c>. Note
        /// that the prefix must be a valid non-empty <c>S3Uri</c> that precludes users from specifying
        /// a manifest whose individual <c>S3Uri</c> is sourced from different S3 buckets.
        /// </para>
        ///  
        /// <para>
        ///  The following code example shows a valid manifest format: 
        /// </para>
        ///  
        /// <para>
        ///  <c>[ {"prefix": "s3://customer_bucket/some/prefix/"},</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c> "relative/path/to/custdata-1",</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c> "relative/path/custdata-2",</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c> ...</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c> "relative/path/custdata-N"</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>]</c> 
        /// </para>
        ///  
        /// <para>
        ///  This JSON is equivalent to the following <c>S3Uri</c> list:
        /// </para>
        ///  
        /// <para>
        ///  <c>s3://customer_bucket/some/prefix/relative/path/to/custdata-1</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>s3://customer_bucket/some/prefix/relative/path/custdata-2</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>...</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>s3://customer_bucket/some/prefix/relative/path/custdata-N</c> 
        /// </para>
        ///  
        /// <para>
        /// The complete set of <c>S3Uri</c> in this manifest is the input data for the channel
        /// for this data source. The object that each <c>S3Uri</c> points to must be readable
        /// by the IAM role that SageMaker uses to perform tasks on your behalf. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Your input bucket must be located in same Amazon Web Services region as your training
        /// job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string S3Uri
        {
            get { return this._s3Uri; }
            set { this._s3Uri = value; }
        }

        // Check to see if S3Uri property is set
        internal bool IsSetS3Uri()
        {
            return this._s3Uri != null;
        }

    }
}