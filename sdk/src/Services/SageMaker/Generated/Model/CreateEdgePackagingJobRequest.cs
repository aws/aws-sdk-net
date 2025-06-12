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
    /// Container for the parameters to the CreateEdgePackagingJob operation.
    /// Starts a SageMaker Edge Manager model packaging job. Edge Manager will use the model
    /// artifacts from the Amazon Simple Storage Service bucket that you specify. After the
    /// model has been packaged, Amazon SageMaker saves the resulting artifacts to an S3 bucket
    /// that you specify.
    /// </summary>
    public partial class CreateEdgePackagingJobRequest : AmazonSageMakerRequest
    {
        private string _compilationJobName;
        private string _edgePackagingJobName;
        private string _modelName;
        private string _modelVersion;
        private EdgeOutputConfig _outputConfig;
        private string _resourceKey;
        private string _roleArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property CompilationJobName. 
        /// <para>
        /// The name of the SageMaker Neo compilation job that will be used to locate model artifacts
        /// for packaging.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string CompilationJobName
        {
            get { return this._compilationJobName; }
            set { this._compilationJobName = value; }
        }

        // Check to see if CompilationJobName property is set
        internal bool IsSetCompilationJobName()
        {
            return this._compilationJobName != null;
        }

        /// <summary>
        /// Gets and sets the property EdgePackagingJobName. 
        /// <para>
        /// The name of the edge packaging job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string EdgePackagingJobName
        {
            get { return this._edgePackagingJobName; }
            set { this._edgePackagingJobName = value; }
        }

        // Check to see if EdgePackagingJobName property is set
        internal bool IsSetEdgePackagingJobName()
        {
            return this._edgePackagingJobName != null;
        }

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
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
        /// Gets and sets the property ModelVersion. 
        /// <para>
        /// The version of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=30)]
        public string ModelVersion
        {
            get { return this._modelVersion; }
            set { this._modelVersion = value; }
        }

        // Check to see if ModelVersion property is set
        internal bool IsSetModelVersion()
        {
            return this._modelVersion != null;
        }

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// Provides information about the output location for the packaged model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EdgeOutputConfig OutputConfig
        {
            get { return this._outputConfig; }
            set { this._outputConfig = value; }
        }

        // Check to see if OutputConfig property is set
        internal bool IsSetOutputConfig()
        {
            return this._outputConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceKey. 
        /// <para>
        /// The Amazon Web Services KMS key to use when encrypting the EBS volume the edge packaging
        /// job runs on.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string ResourceKey
        {
            get { return this._resourceKey; }
            set { this._resourceKey = value; }
        }

        // Check to see if ResourceKey property is set
        internal bool IsSetResourceKey()
        {
            return this._resourceKey != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that enables Amazon SageMaker to download
        /// and upload the model, and to contact SageMaker Neo.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Creates tags for the packaging job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}