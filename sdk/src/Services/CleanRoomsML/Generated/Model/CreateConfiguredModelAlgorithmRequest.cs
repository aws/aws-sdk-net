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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
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
    /// Container for the parameters to the CreateConfiguredModelAlgorithm operation.
    /// Creates a configured model algorithm using a container image stored in an ECR repository.
    /// </summary>
    public partial class CreateConfiguredModelAlgorithmRequest : AmazonCleanRoomsMLRequest
    {
        private string _description;
        private InferenceContainerConfig _inferenceContainerConfig;
        private string _kmsKeyArn;
        private string _name;
        private string _roleArn;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private ContainerConfig _trainingContainerConfig;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the configured model algorithm.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
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
        /// Gets and sets the property InferenceContainerConfig. 
        /// <para>
        /// Configuration information for the inference container that is used when you run an
        /// inference job on a configured model algorithm.
        /// </para>
        /// </summary>
        public InferenceContainerConfig InferenceContainerConfig
        {
            get { return this._inferenceContainerConfig; }
            set { this._inferenceContainerConfig = value; }
        }

        // Check to see if InferenceContainerConfig property is set
        internal bool IsSetInferenceContainerConfig()
        {
            return this._inferenceContainerConfig != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key. This key is used to encrypt and decrypt
        /// customer-owned data in the configured ML model algorithm and associated data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the configured model algorithm.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
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
        /// The Amazon Resource Name (ARN) of the role that is used to access the repository.
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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TrainingContainerConfig. 
        /// <para>
        /// Configuration information for the training container, including entrypoints and arguments.
        /// </para>
        /// </summary>
        public ContainerConfig TrainingContainerConfig
        {
            get { return this._trainingContainerConfig; }
            set { this._trainingContainerConfig = value; }
        }

        // Check to see if TrainingContainerConfig property is set
        internal bool IsSetTrainingContainerConfig()
        {
            return this._trainingContainerConfig != null;
        }

    }
}