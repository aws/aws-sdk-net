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
    /// This is the response object from the CreateConfigurationProfile operation.
    /// </summary>
    public partial class CreateConfigurationProfileResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The application ID.
        /// </para>
        /// </summary>
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The configuration profile description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The configuration profile ID.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name of the Key Management Service key to encrypt new configuration
        /// data versions in the AppConfig hosted configuration store. This attribute is only
        /// used for <c>hosted</c> configuration types. To encrypt data managed in other configuration
        /// stores, see the documentation for how to specify an KMS key for that particular service.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property KmsKeyIdentifier. 
        /// <para>
        /// The Key Management Service key identifier (key ID, key alias, or key ARN) provided
        /// when the resource was created or updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyIdentifier property is set.
        /// </summary>
        internal bool IsSetKmsKeyIdentifier() => this.KmsKeyIdentifier != null;

        /// <summary>
        /// Gets and sets the property LocationUri. 
        /// <para>
        /// The URI location of the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string LocationUri { get; set; }

        /// <summary>
        /// Checks to see if the LocationUri property is set.
        /// </summary>
        internal bool IsSetLocationUri() => this.LocationUri != null;

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
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RetrievalRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RetrievalRoleArn property is set.
        /// </summary>
        internal bool IsSetRetrievalRoleArn() => this.RetrievalRoleArn != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of configurations contained in the profile. AppConfig supports <c>feature
        /// flags</c> and <c>freeform</c> configurations. We recommend you create feature flag
        /// configurations to enable or disable new features and freeform configurations to distribute
        /// configurations to an application. When calling this API, enter one of the following
        /// values for <c>Type</c>:
        /// </para>
        ///  
        /// <para>
        ///  <c>AWS.AppConfig.FeatureFlags</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>AWS.Freeform</c> 
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

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
