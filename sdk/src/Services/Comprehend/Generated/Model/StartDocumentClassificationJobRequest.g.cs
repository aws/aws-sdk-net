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

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Container for the parameters to the StartDocumentClassificationJob operation. Starts
    /// an asynchronous document classification job using a custom classification model. Use
    /// the <c>DescribeDocumentClassificationJob</c> operation to track the progress of the
    /// job.
    /// </summary>
    public partial class StartDocumentClassificationJobRequest : AmazonComprehendRequest
    {
        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique identifier for the request. If you do not set the client request token, Amazon
        /// Comprehend generates one.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that grants Amazon Comprehend read
        /// access to your input data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string DataAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the DataAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetDataAccessRoleArn() => this.DataAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property DocumentClassifierArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the document classifier to use to process the job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DocumentClassifierArn { get; set; }

        /// <summary>
        /// Checks to see if the DocumentClassifierArn property is set.
        /// </summary>
        internal bool IsSetDocumentClassifierArn() => this.DocumentClassifierArn != null;

        /// <summary>
        /// Gets and sets the property FlywheelArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the flywheel associated with the model to use.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string FlywheelArn { get; set; }

        /// <summary>
        /// Checks to see if the FlywheelArn property is set.
        /// </summary>
        internal bool IsSetFlywheelArn() => this.FlywheelArn != null;

        /// <summary>
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// Specifies the format and location of the input data for the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InputDataConfig InputDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the InputDataConfig property is set.
        /// </summary>
        internal bool IsSetInputDataConfig() => this.InputDataConfig != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The identifier of the job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        /// Specifies where to send the output files.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OutputDataConfig OutputDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputDataConfig property is set.
        /// </summary>
        internal bool IsSetOutputDataConfig() => this.OutputDataConfig != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to associate with the document classification job. A tag is a key-value pair
        /// that adds metadata to a resource used by Amazon Comprehend. For example, a tag with
        /// "Sales" as the key might be added to a resource to indicate its use by the sales department.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VolumeKmsKeyId. 
        /// <para>
        /// ID for the Amazon Web Services Key Management Service (KMS) key that Amazon Comprehend
        /// uses to encrypt data on the storage volume attached to the ML compute instance(s)
        /// that process the analysis job. The VolumeKmsKeyId can be either of the following formats:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// KMS Key ID: <c>"1234abcd-12ab-34cd-56ef-1234567890ab"</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Resource Name (ARN) of a KMS Key: <c>"arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab"</c>
        /// 
        /// </para>
        ///  </li> </ul>
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
        /// Configuration parameters for an optional private Virtual Private Cloud (VPC) containing
        /// the resources you are using for your document classification job. For more information,
        /// see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/what-is-amazon-vpc.html">Amazon
        /// VPC</a>. 
        /// </para>
        /// </summary>
        public VpcConfig VpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfig property is set.
        /// </summary>
        internal bool IsSetVpcConfig() => this.VpcConfig != null;
    }
}
