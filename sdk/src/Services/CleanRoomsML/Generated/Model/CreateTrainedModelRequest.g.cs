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
    /// Container for the parameters to the CreateTrainedModel operation. Creates a trained
    /// model from an associated configured model algorithm using data from any member of
    /// the collaboration.
    /// </summary>
    public partial class CreateTrainedModelRequest : AmazonCleanRoomsMLRequest
    {
        /// <summary>
        /// Gets and sets the property ConfiguredModelAlgorithmAssociationArn. 
        /// <para>
        /// The associated configured model algorithm used to train this model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string ConfiguredModelAlgorithmAssociationArn { get; set; }

        /// <summary>
        /// Checks to see if the ConfiguredModelAlgorithmAssociationArn property is set.
        /// </summary>
        internal bool IsSetConfiguredModelAlgorithmAssociationArn() => this.ConfiguredModelAlgorithmAssociationArn != null;

        /// <summary>
        /// Gets and sets the property DataChannels. 
        /// <para>
        /// Defines the data channels that are used as input for the trained model request.
        /// </para>
        ///  
        /// <para>
        /// Limit: Maximum of 20 channels total (including both <c>dataChannels</c> and <c>incrementalTrainingDataChannels</c>).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public List<ModelTrainingDataChannel> DataChannels { get; set; } = AWSConfigs.InitializeCollections ? new List<ModelTrainingDataChannel>() : null;

        /// <summary>
        /// Checks to see if the DataChannels property is set.
        /// </summary>
        internal bool IsSetDataChannels() => this.DataChannels != null && (this.DataChannels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the trained model.
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
        [AWSProperty(Min = 0, Max = 100)]
        public Dictionary<string, string> Environment { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Environment property is set.
        /// </summary>
        internal bool IsSetEnvironment() => this.Environment != null && (this.Environment.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Hyperparameters. 
        /// <para>
        /// Algorithm-specific parameters that influence the quality of the model. You set hyperparameters
        /// before you start the learning process.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public Dictionary<string, string> Hyperparameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Hyperparameters property is set.
        /// </summary>
        internal bool IsSetHyperparameters() => this.Hyperparameters != null && (this.Hyperparameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IncrementalTrainingDataChannels. 
        /// <para>
        /// Specifies the incremental training data channels for the trained model. 
        /// </para>
        ///  
        /// <para>
        /// Incremental training allows you to create a new trained model with updates without
        /// retraining from scratch. You can specify up to one incremental training data channel
        /// that references a previously trained model and its version.
        /// </para>
        ///  
        /// <para>
        /// Limit: Maximum of 20 channels total (including both <c>incrementalTrainingDataChannels</c>
        /// and <c>dataChannels</c>).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<IncrementalTrainingDataChannel> IncrementalTrainingDataChannels { get; set; } = AWSConfigs.InitializeCollections ? new List<IncrementalTrainingDataChannel>() : null;

        /// <summary>
        /// Checks to see if the IncrementalTrainingDataChannels property is set.
        /// </summary>
        internal bool IsSetIncrementalTrainingDataChannels() => this.IncrementalTrainingDataChannels != null && (this.IncrementalTrainingDataChannels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key. This key is used to encrypt and decrypt
        /// customer-owned data in the trained ML model and the associated data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        /// The membership ID of the member that is creating the trained model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string MembershipIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the MembershipIdentifier property is set.
        /// </summary>
        internal bool IsSetMembershipIdentifier() => this.MembershipIdentifier != null;

        /// <summary>
        /// Gets and sets the property MlModelTrainingPayerAccountId. 
        /// <para>
        /// The account ID of the member that is responsible for paying for model training costs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string MlModelTrainingPayerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the MlModelTrainingPayerAccountId property is set.
        /// </summary>
        internal bool IsSetMlModelTrainingPayerAccountId() => this.MlModelTrainingPayerAccountId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the trained model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ResourceConfig. 
        /// <para>
        /// Information about the EC2 resources that are used to train this model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceConfig ResourceConfig { get; set; }

        /// <summary>
        /// Checks to see if the ResourceConfig property is set.
        /// </summary>
        internal bool IsSetResourceConfig() => this.ResourceConfig != null;

        /// <summary>
        /// Gets and sets the property StoppingCondition. 
        /// <para>
        /// The criteria that is used to stop model training.
        /// </para>
        /// </summary>
        public StoppingCondition StoppingCondition { get; set; }

        /// <summary>
        /// Checks to see if the StoppingCondition property is set.
        /// </summary>
        internal bool IsSetStoppingCondition() => this.StoppingCondition != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The optional metadata that you apply to the resource to help you categorize and organize
        /// them. Each tag consists of a key and an optional value, both of which you define.
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
        /// Gets and sets the property TrainingInputMode. 
        /// <para>
        /// The input mode for accessing the training data. This parameter determines how the
        /// training data is made available to the training algorithm. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>File</c> - The training data is downloaded to the training instance and made available
        /// as files.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FastFile</c> - The training data is streamed directly from Amazon S3 to the training
        /// algorithm, providing faster access for large datasets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Pipe</c> - The training data is streamed to the training algorithm using named
        /// pipes, which can improve performance for certain algorithms.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TrainingInputMode TrainingInputMode { get; set; }

        /// <summary>
        /// Checks to see if the TrainingInputMode property is set.
        /// </summary>
        internal bool IsSetTrainingInputMode() => this.TrainingInputMode != null;
    }
}
