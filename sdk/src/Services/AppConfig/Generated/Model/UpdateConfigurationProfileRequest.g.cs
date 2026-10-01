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

namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateConfigurationProfile operation. Updates
    /// a configuration profile.
    /// </summary>
    public partial class UpdateConfigurationProfileRequest : AmazonAppConfigRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The application ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property ConfigurationProfileId. 
        /// <para>
        /// The ID of the configuration profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ConfigurationProfileId { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationProfileId property is set.
        /// </summary>
        internal bool IsSetConfigurationProfileId() => this.ConfigurationProfileId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the configuration profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property KmsKeyIdentifier. 
        /// <para>
        /// The identifier for a Key Management Service key to encrypt new configuration data
        /// versions in the AppConfig hosted configuration store. This attribute is only used
        /// for <c>hosted</c> configuration types. The identifier can be an KMS key ID, alias,
        /// or the Amazon Resource Name (ARN) of the key ID or alias. To encrypt data managed
        /// in other configuration stores, see the documentation for how to specify an KMS key
        /// for that particular service.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string KmsKeyIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyIdentifier property is set.
        /// </summary>
        internal bool IsSetKmsKeyIdentifier() => this.KmsKeyIdentifier != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the configuration profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RetrievalRoleArn. 
        /// <para>
        /// The ARN of an IAM role with permission to access the configuration at the specified
        /// <c>LocationUri</c>.
        /// </para>
        ///  <important> 
        /// <para>
        /// A retrieval role ARN is not required for configurations stored in CodePipeline or
        /// the AppConfig hosted configuration store. It is required for all other sources that
        /// store your configuration. 
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RetrievalRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RetrievalRoleArn property is set.
        /// </summary>
        internal bool IsSetRetrievalRoleArn() => this.RetrievalRoleArn != null;

        /// <summary>
        /// Gets and sets the property Validators. 
        /// <para>
        /// A list of methods for validating the configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2)]
        public List<Validator> Validators { get; set; } = AWSConfigs.InitializeCollections ? new List<Validator>() : null;

        /// <summary>
        /// Checks to see if the Validators property is set.
        /// </summary>
        internal bool IsSetValidators() => this.Validators != null && (this.Validators.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
