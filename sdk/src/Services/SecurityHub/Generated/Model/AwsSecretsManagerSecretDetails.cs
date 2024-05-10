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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
        private bool? _deleted;
        private string _description;
        private string _kmsKeyId;
        private string _name;
        private bool? _rotationEnabled;
        private string _rotationLambdaArn;
        private bool? _rotationOccurredWithinFrequency;
        private AwsSecretsManagerSecretRotationRules _rotationRules;

        /// <summary>
        /// Gets and sets the property Deleted. 
        /// <para>
        /// Whether the secret is deleted.
        /// </para>
        /// </summary>
        public bool? Deleted
        {
            get { return this._deleted; }
            set { this._deleted = value; }
        }

        // Check to see if Deleted property is set
        internal bool IsSetDeleted()
        {
            return this._deleted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The user-provided description of the secret.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ARN, Key ID, or alias of the KMS key used to encrypt the <c>SecretString</c> or
        /// <c>SecretBinary</c> values for versions of this secret.
        /// </para>
        /// </summary>
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the secret.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property RotationEnabled. 
        /// <para>
        /// Whether rotation is enabled.
        /// </para>
        /// </summary>
        public bool? RotationEnabled
        {
            get { return this._rotationEnabled; }
            set { this._rotationEnabled = value; }
        }

        // Check to see if RotationEnabled property is set
        internal bool IsSetRotationEnabled()
        {
            return this._rotationEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RotationLambdaArn. 
        /// <para>
        /// The ARN of the Lambda function that rotates the secret.
        /// </para>
        /// </summary>
        public string RotationLambdaArn
        {
            get { return this._rotationLambdaArn; }
            set { this._rotationLambdaArn = value; }
        }

        // Check to see if RotationLambdaArn property is set
        internal bool IsSetRotationLambdaArn()
        {
            return this._rotationLambdaArn != null;
        }

        /// <summary>
        /// Gets and sets the property RotationOccurredWithinFrequency. 
        /// <para>
        /// Whether the rotation occurred within the specified rotation frequency.
        /// </para>
        /// </summary>
        public bool? RotationOccurredWithinFrequency
        {
            get { return this._rotationOccurredWithinFrequency; }
            set { this._rotationOccurredWithinFrequency = value; }
        }

        // Check to see if RotationOccurredWithinFrequency property is set
        internal bool IsSetRotationOccurredWithinFrequency()
        {
            return this._rotationOccurredWithinFrequency.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RotationRules. 
        /// <para>
        /// Defines the rotation schedule for the secret.
        /// </para>
        /// </summary>
        public AwsSecretsManagerSecretRotationRules RotationRules
        {
            get { return this._rotationRules; }
            set { this._rotationRules = value; }
        }

        // Check to see if RotationRules property is set
        internal bool IsSetRotationRules()
        {
            return this._rotationRules != null;
        }

    }
}