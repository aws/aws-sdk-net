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

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateLanguageModel operation. Updates the encryption
    /// configuration for an existing custom language model. You can use this operation to
    /// change the KMS key used to encrypt your model artifacts. The model artifacts are re-encrypted
    /// in place. No model training is required. <para> Your custom language model must not
    /// be in the <c>IN_PROGRESS</c> state when you call this operation. You cannot submit
    /// another update while a previous update is in progress. Use to check the current state
    /// of your model. </para> <para> Your custom language model remains available for transcription
    /// jobs while the update is being processed. </para>
    /// </summary>
    public partial class UpdateLanguageModelRequest : AmazonTranscribeServiceRequest
    {
        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role. If you include <c>EncryptionConfiguration</c>
        /// in your request, this role must have permissions to access the specified KMS key.
        /// If the role that you specify doesn't have the appropriate permissions, your request
        /// fails.
        /// </para>
        ///  
        /// <para>
        /// IAM role ARNs have the format <c>arn:partition:iam::account:role/role-name-with-path</c>.
        /// For example: <c>arn:aws:iam::111122223333:role/Admin</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_identifiers.html#identifiers-arns">IAM
        /// ARNs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string DataAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the DataAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetDataAccessRoleArn() => this.DataAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// Specifies the new encryption configuration for your custom language model. The model
        /// artifacts are re-encrypted in place using the specified KMS key or with an AWS-owned
        /// key if a key is not supplied.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the custom language model you want to update. Model names are case sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string ModelName { get; set; }

        /// <summary>
        /// Checks to see if the ModelName property is set.
        /// </summary>
        internal bool IsSetModelName() => this.ModelName != null;
    }
}
