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

namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// This is the response object from the GetTrainedModelInferenceJob operation.
    /// </summary>
    public partial class GetTrainedModelInferenceJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ConfiguredModelAlgorithmAssociationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the configured model algorithm association that
        /// was used for the trained model inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ConfiguredModelAlgorithmAssociationArn { get; set; }

        /// <summary>
        /// Checks to see if the ConfiguredModelAlgorithmAssociationArn property is set.
        /// </summary>
        internal bool IsSetConfiguredModelAlgorithmAssociationArn() => this.ConfiguredModelAlgorithmAssociationArn != null;

        /// <summary>
        /// Gets and sets the property ContainerExecutionParameters. 
        /// <para>
        /// The execution parameters for the model inference job container.
        /// </para>
        /// </summary>
        public InferenceContainerExecutionParameters ContainerExecutionParameters { get; set; }

        /// <summary>
        /// Checks to see if the ContainerExecutionParameters property is set.
        /// </summary>
        internal bool IsSetContainerExecutionParameters() => this.ContainerExecutionParameters != null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time at which the trained model inference job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        /// The data source that was used for the trained model inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ModelInferenceDataSource DataSource { get; set; }

        /// <summary>
        /// Checks to see if the DataSource property is set.
        /// </summary>
        internal bool IsSetDataSource() => this.DataSource != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the trained model inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment variables to set in the Docker container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 16)]
        public Dictionary<string, string> Environment { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Environment property is set.
        /// </summary>
        internal bool IsSetEnvironment() => this.Environment != null && (this.Environment.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InferenceContainerImageDigest. 
        /// <para>
        /// Information about the training container image.
        /// </para>
        /// </summary>
        public string InferenceContainerImageDigest { get; set; }

        /// <summary>
        /// Checks to see if the InferenceContainerImageDigest property is set.
        /// </summary>
        internal bool IsSetInferenceContainerImageDigest() => this.InferenceContainerImageDigest != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key. This key is used to encrypt and decrypt
        /// customer-owned data in the ML inference job and associated data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property LogsStatus. 
        /// <para>
        /// The logs status for the trained model inference job.
        /// </para>
        /// </summary>
        public LogsStatus LogsStatus { get; set; }

        /// <summary>
        /// Checks to see if the LogsStatus property is set.
        /// </summary>
        internal bool IsSetLogsStatus() => this.LogsStatus != null;

        /// <summary>
        /// Gets and sets the property LogsStatusDetails. 
        /// <para>
        /// Details about the logs status for the trained model inference job.
        /// </para>
        /// </summary>
        public string LogsStatusDetails { get; set; }

        /// <summary>
        /// Checks to see if the LogsStatusDetails property is set.
        /// </summary>
        internal bool IsSetLogsStatusDetails() => this.LogsStatusDetails != null;

        /// <summary>
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        /// The membership ID of the membership that contains the trained model inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string MembershipIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the MembershipIdentifier property is set.
        /// </summary>
        internal bool IsSetMembershipIdentifier() => this.MembershipIdentifier != null;

        /// <summary>
        /// Gets and sets the property MetricsStatus. 
        /// <para>
        /// The metrics status for the trained model inference job.
        /// </para>
        /// </summary>
        public MetricsStatus MetricsStatus { get; set; }

        /// <summary>
        /// Checks to see if the MetricsStatus property is set.
        /// </summary>
        internal bool IsSetMetricsStatus() => this.MetricsStatus != null;

        /// <summary>
        /// Gets and sets the property MetricsStatusDetails. 
        /// <para>
        /// Details about the metrics status for the trained model inference job.
        /// </para>
        /// </summary>
        public string MetricsStatusDetails { get; set; }

        /// <summary>
        /// Checks to see if the MetricsStatusDetails property is set.
        /// </summary>
        internal bool IsSetMetricsStatusDetails() => this.MetricsStatusDetails != null;

        /// <summary>
        /// Gets and sets the property MlModelInferencePayerAccountId. 
        /// <para>
        /// The account ID of the member that is responsible for paying for model inference costs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string MlModelInferencePayerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the MlModelInferencePayerAccountId property is set.
        /// </summary>
        internal bool IsSetMlModelInferencePayerAccountId() => this.MlModelInferencePayerAccountId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the trained model inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OutputConfiguration. 
        /// <para>
        /// The output configuration information for the trained model inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InferenceOutputConfiguration OutputConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OutputConfiguration property is set.
        /// </summary>
        internal bool IsSetOutputConfiguration() => this.OutputConfiguration != null;

        /// <summary>
        /// Gets and sets the property ResourceConfig. 
        /// <para>
        /// The resource configuration information for the trained model inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InferenceResourceConfig ResourceConfig { get; set; }

        /// <summary>
        /// Checks to see if the ResourceConfig property is set.
        /// </summary>
        internal bool IsSetResourceConfig() => this.ResourceConfig != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the trained model inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TrainedModelInferenceJobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusDetails.
        /// </summary>
        public StatusDetails StatusDetails { get; set; }

        /// <summary>
        /// Checks to see if the StatusDetails property is set.
        /// </summary>
        internal bool IsSetStatusDetails() => this.StatusDetails != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The optional metadata that you applied to the resource to help you categorize and
        /// organize them. Each tag consists of a key and an optional value, both of which you
        /// define.
        /// </para>
        ///  
        /// <para>
        /// The following basic restrictions apply to tags:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Maximum number of tags per resource - 50.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For each resource, each tag key must be unique, and each tag key can have only one
        /// value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum key length - 128 Unicode characters in UTF-8.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum value length - 256 Unicode characters in UTF-8.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your tagging schema is used across multiple services and resources, remember that
        /// other services may have restrictions on allowed characters. Generally allowed characters
        /// are: letters, numbers, and spaces representable in UTF-8, and the following characters:
        /// + - = . _ : / @.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tag keys and values are case sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Do not use aws:, AWS:, or any upper or lowercase combination of such as a prefix for
        /// keys as it is reserved for AWS use. You cannot edit or delete tag keys with this prefix.
        /// Values can have this prefix. If a tag value has aws as its prefix but the key does
        /// not, then Clean Rooms ML considers it to be a user tag and will count against the
        /// limit of 50 tags. Tags with only the key prefix of aws do not count against your tags
        /// per resource limit.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TrainedModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the trained model that was used for the trained
        /// model inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string TrainedModelArn { get; set; }

        /// <summary>
        /// Checks to see if the TrainedModelArn property is set.
        /// </summary>
        internal bool IsSetTrainedModelArn() => this.TrainedModelArn != null;

        /// <summary>
        /// Gets and sets the property TrainedModelInferenceJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the trained model inference job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string TrainedModelInferenceJobArn { get; set; }

        /// <summary>
        /// Checks to see if the TrainedModelInferenceJobArn property is set.
        /// </summary>
        internal bool IsSetTrainedModelInferenceJobArn() => this.TrainedModelInferenceJobArn != null;

        /// <summary>
        /// Gets and sets the property TrainedModelVersionIdentifier. 
        /// <para>
        /// The version identifier of the trained model used for this inference job. This identifies
        /// the specific version of the trained model that was used to generate the inference
        /// results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string TrainedModelVersionIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the TrainedModelVersionIdentifier property is set.
        /// </summary>
        internal bool IsSetTrainedModelVersionIdentifier() => this.TrainedModelVersionIdentifier != null;

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The most recent time at which the trained model inference job was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTime property is set.
        /// </summary>
        internal bool IsSetUpdateTime() => this.UpdateTime.HasValue;
    }
}
