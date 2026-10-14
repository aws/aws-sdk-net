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
    /// Container for the parameters to the CreateDocumentClassifier operation. Creates a
    /// new document classifier that you can use to categorize documents. To create a classifier,
    /// you provide a set of training documents that are labeled with the categories that
    /// you want to use. For more information, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/training-classifier-model.html">Training
    /// classifier models</a> in the Comprehend Developer Guide.
    /// </summary>
    public partial class CreateDocumentClassifierRequest : AmazonComprehendRequest
    {
        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique identifier for the request. If you don't set the client request token, Amazon
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
        /// Gets and sets the property DocumentClassifierName. 
        /// <para>
        /// The name of the document classifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 63)]
        public string DocumentClassifierName { get; set; }

        /// <summary>
        /// Checks to see if the DocumentClassifierName property is set.
        /// </summary>
        internal bool IsSetDocumentClassifierName() => this.DocumentClassifierName != null;

        /// <summary>
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// Specifies the format and location of the input data for the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DocumentClassifierInputDataConfig InputDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the InputDataConfig property is set.
        /// </summary>
        internal bool IsSetInputDataConfig() => this.InputDataConfig != null;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language of the input documents. You can specify any of the languages supported
        /// by Amazon Comprehend. All documents must be in the same language.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// Indicates the mode in which the classifier will be trained. The classifier can be
        /// trained in multi-class (single-label) mode or multi-label mode. Multi-class mode identifies
        /// a single class label for each document and multi-label mode identifies one or more
        /// class labels for each document. Multiple labels for an individual document are separated
        /// by a delimiter. The default delimiter between labels is a pipe (|).
        /// </para>
        /// </summary>
        public DocumentClassifierMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property ModelKmsKeyId. 
        /// <para>
        /// ID for the KMS key that Amazon Comprehend uses to encrypt trained custom models. The
        /// ModelKmsKeyId can be either of the following formats:
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
        public string ModelKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the ModelKmsKeyId property is set.
        /// </summary>
        internal bool IsSetModelKmsKeyId() => this.ModelKmsKeyId != null;

        /// <summary>
        /// Gets and sets the property ModelPolicy. 
        /// <para>
        /// The resource-based policy to attach to your custom document classifier model. You
        /// can use this policy to allow another Amazon Web Services account to import your custom
        /// model.
        /// </para>
        ///  
        /// <para>
        /// Provide your policy as a JSON body that you enter as a UTF-8 encoded string without
        /// line breaks. To provide valid JSON, enclose the attribute names and values in double
        /// quotes. If the JSON body is also enclosed in double quotes, then you must escape the
        /// double quotes that are inside the policy:
        /// </para>
        ///  
        /// <para>
        ///  <c>"{\"attribute\": \"value\", \"attribute\": [\"value\"]}"</c> 
        /// </para>
        ///  
        /// <para>
        /// To avoid escaping quotes, you can use single quotes to enclose the policy and double
        /// quotes to enclose the JSON names and values:
        /// </para>
        ///  
        /// <para>
        ///  <c>'{"attribute": "value", "attribute": ["value"]}'</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20000)]
        public string ModelPolicy { get; set; }

        /// <summary>
        /// Checks to see if the ModelPolicy property is set.
        /// </summary>
        internal bool IsSetModelPolicy() => this.ModelPolicy != null;

        /// <summary>
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        /// Specifies the location for the output files from a custom classifier job. This parameter
        /// is required for a request that creates a native document model.
        /// </para>
        /// </summary>
        public DocumentClassifierOutputDataConfig OutputDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputDataConfig property is set.
        /// </summary>
        internal bool IsSetOutputDataConfig() => this.OutputDataConfig != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to associate with the document classifier. A tag is a key-value pair that adds
        /// as a metadata to a resource used by Amazon Comprehend. For example, a tag with "Sales"
        /// as the key might be added to a resource to indicate its use by the sales department.
        /// 
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
        /// Gets and sets the property VersionName. 
        /// <para>
        /// The version name given to the newly created classifier. Version names can have a maximum
        /// of 256 characters. Alphanumeric characters, hyphens (-) and underscores (_) are allowed.
        /// The version name must be unique among all models with the same classifier name in
        /// the Amazon Web Services account/Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string VersionName { get; set; }

        /// <summary>
        /// Checks to see if the VersionName property is set.
        /// </summary>
        internal bool IsSetVersionName() => this.VersionName != null;

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
        /// the resources you are using for your custom classifier. For more information, see
        /// <a href="https://docs.aws.amazon.com/vpc/latest/userguide/what-is-amazon-vpc.html">Amazon
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
