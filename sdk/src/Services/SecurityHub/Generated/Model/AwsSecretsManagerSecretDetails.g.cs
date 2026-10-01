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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Details about an Secrets Manager secret.
    /// </summary>
    public partial class AwsSecretsManagerSecretDetails
    {
        /// <summary>
        /// Gets and sets the property Deleted. 
        /// <para>
        /// Whether the secret is deleted.
        /// </para>
        /// </summary>
        public bool? Deleted { get; set; }

        /// <summary>
        /// Checks to see if the Deleted property is set.
        /// </summary>
        internal bool IsSetDeleted() => this.Deleted.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The user-provided description of the secret.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ARN, Key ID, or alias of the KMS key used to encrypt the <c>SecretString</c> or
        /// <c>SecretBinary</c> values for versions of this secret.
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the secret.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RotationEnabled. 
        /// <para>
        /// Whether rotation is enabled.
        /// </para>
        /// </summary>
        public bool? RotationEnabled { get; set; }

        /// <summary>
        /// Checks to see if the RotationEnabled property is set.
        /// </summary>
        internal bool IsSetRotationEnabled() => this.RotationEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property RotationLambdaArn. 
        /// <para>
        /// The ARN of the Lambda function that rotates the secret.
        /// </para>
        /// </summary>
        public string RotationLambdaArn { get; set; }

        /// <summary>
        /// Checks to see if the RotationLambdaArn property is set.
        /// </summary>
        internal bool IsSetRotationLambdaArn() => this.RotationLambdaArn != null;

        /// <summary>
        /// Gets and sets the property RotationOccurredWithinFrequency. 
        /// <para>
        /// Whether the rotation occurred within the specified rotation frequency.
        /// </para>
        /// </summary>
        public bool? RotationOccurredWithinFrequency { get; set; }

        /// <summary>
        /// Checks to see if the RotationOccurredWithinFrequency property is set.
        /// </summary>
        internal bool IsSetRotationOccurredWithinFrequency() => this.RotationOccurredWithinFrequency.HasValue;

        /// <summary>
        /// Gets and sets the property RotationRules. 
        /// <para>
        /// Defines the rotation schedule for the secret.
        /// </para>
        /// </summary>
        public AwsSecretsManagerSecretRotationRules RotationRules { get; set; }

        /// <summary>
        /// Checks to see if the RotationRules property is set.
        /// </summary>
        internal bool IsSetRotationRules() => this.RotationRules != null;
    }
}
