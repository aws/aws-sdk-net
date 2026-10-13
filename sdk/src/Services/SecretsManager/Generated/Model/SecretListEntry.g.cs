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

namespace Amazon.SecretsManager.Model
{
    /// <summary>
    /// A structure that contains the details about a secret. It does not include the encrypted
    /// <c>SecretString</c> and <c>SecretBinary</c> values. To get those values, use <a href="https://docs.aws.amazon.com/secretsmanager/latest/apireference/API_GetSecretValue.html">GetSecretValue</a>
    /// .
    /// </summary>
    public partial class SecretListEntry
    {
        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ARN { get; set; }

        /// <summary>
        /// Checks to see if the ARN property is set.
        /// </summary>
        internal bool IsSetARN() => this.ARN != null;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date and time when a secret was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property DeletedDate. 
        /// <para>
        /// The date and time the deletion of the secret occurred. Not present on active secrets.
        /// The secret can be recovered until the number of days in the recovery window has passed,
        /// as specified in the <c>RecoveryWindowInDays</c> parameter of the <a href="https://docs.aws.amazon.com/secretsmanager/latest/apireference/API_DeleteSecret.html">
        /// <c>DeleteSecret</c> </a> operation.
        /// </para>
        /// </summary>
        public DateTime? DeletedDate { get; set; }

        /// <summary>
        /// Checks to see if the DeletedDate property is set.
        /// </summary>
        internal bool IsSetDeletedDate() => this.DeletedDate.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The user-provided description of the secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExternalSecretRotationMetadata. 
        /// <para>
        /// The metadata needed to successfully rotate a managed external secret. A list of key
        /// value pairs in JSON format specified by the partner. For more information about the
        /// required information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/mes-partners.html">Managed
        /// external secrets partners</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ExternalSecretRotationMetadataItem> ExternalSecretRotationMetadata { get; set; } = AWSConfigs.InitializeCollections ? new List<ExternalSecretRotationMetadataItem>() : null;

        /// <summary>
        /// Checks to see if the ExternalSecretRotationMetadata property is set.
        /// </summary>
        internal bool IsSetExternalSecretRotationMetadata() => this.ExternalSecretRotationMetadata != null && (this.ExternalSecretRotationMetadata.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExternalSecretRotationRoleArn. 
        /// <para>
        /// The role that Secrets Manager assumes to call APIs required to perform the rotation.
        /// For more information about the required information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/mes-partners.html">Managed
        /// external secrets partners</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ExternalSecretRotationRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ExternalSecretRotationRoleArn property is set.
        /// </summary>
        internal bool IsSetExternalSecretRotationRoleArn() => this.ExternalSecretRotationRoleArn != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ARN of the KMS key that Secrets Manager uses to encrypt the secret value. If the
        /// secret is encrypted with the Amazon Web Services managed key <c>aws/secretsmanager</c>,
        /// this field is omitted.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property LastAccessedDate. 
        /// <para>
        /// The date that the secret was last accessed in the Region. This field is omitted if
        /// the secret has never been retrieved in the Region.
        /// </para>
        /// </summary>
        public DateTime? LastAccessedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastAccessedDate property is set.
        /// </summary>
        internal bool IsSetLastAccessedDate() => this.LastAccessedDate.HasValue;

        /// <summary>
        /// Gets and sets the property LastChangedDate. 
        /// <para>
        /// The last date and time that this secret was modified in any way.
        /// </para>
        /// </summary>
        public DateTime? LastChangedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastChangedDate property is set.
        /// </summary>
        internal bool IsSetLastChangedDate() => this.LastChangedDate.HasValue;

        /// <summary>
        /// Gets and sets the property LastRotatedDate. 
        /// <para>
        /// The most recent date and time that the Secrets Manager rotation process was successfully
        /// completed. This value is null if the secret hasn't ever rotated.
        /// </para>
        /// </summary>
        public DateTime? LastRotatedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastRotatedDate property is set.
        /// </summary>
        internal bool IsSetLastRotatedDate() => this.LastRotatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The friendly name of the secret. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NextRotationDate. 
        /// <para>
        /// The next rotation is scheduled to occur on or before this date. If the secret isn't
        /// configured for rotation or rotation has been disabled, Secrets Manager returns null.
        /// </para>
        /// </summary>
        public DateTime? NextRotationDate { get; set; }

        /// <summary>
        /// Checks to see if the NextRotationDate property is set.
        /// </summary>
        internal bool IsSetNextRotationDate() => this.NextRotationDate.HasValue;

        /// <summary>
        /// Gets and sets the property OwningService. 
        /// <para>
        /// Returns the name of the service that created the secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string OwningService { get; set; }

        /// <summary>
        /// Checks to see if the OwningService property is set.
        /// </summary>
        internal bool IsSetOwningService() => this.OwningService != null;

        /// <summary>
        /// Gets and sets the property PrimaryRegion. 
        /// <para>
        /// The Region where Secrets Manager originated the secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string PrimaryRegion { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryRegion property is set.
        /// </summary>
        internal bool IsSetPrimaryRegion() => this.PrimaryRegion != null;

        /// <summary>
        /// Gets and sets the property RotationEnabled. 
        /// <para>
        /// Indicates whether automatic, scheduled rotation is enabled for this secret.
        /// </para>
        /// </summary>
        public bool? RotationEnabled { get; set; }

        /// <summary>
        /// Checks to see if the RotationEnabled property is set.
        /// </summary>
        internal bool IsSetRotationEnabled() => this.RotationEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property RotationLambdaARN. 
        /// <para>
        /// The ARN of an Amazon Web Services Lambda function invoked by Secrets Manager to rotate
        /// and expire the secret either automatically per the schedule or manually by a call
        /// to <a href="https://docs.aws.amazon.com/secretsmanager/latest/apireference/API_RotateSecret.html">
        /// <c>RotateSecret</c> </a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string RotationLambdaARN { get; set; }

        /// <summary>
        /// Checks to see if the RotationLambdaARN property is set.
        /// </summary>
        internal bool IsSetRotationLambdaARN() => this.RotationLambdaARN != null;

        /// <summary>
        /// Gets and sets the property RotationRules. 
        /// <para>
        /// A structure that defines the rotation configuration for the secret.
        /// </para>
        /// </summary>
        public RotationRulesType RotationRules { get; set; }

        /// <summary>
        /// Checks to see if the RotationRules property is set.
        /// </summary>
        internal bool IsSetRotationRules() => this.RotationRules != null;

        /// <summary>
        /// Gets and sets the property SecretVersionsToStages. 
        /// <para>
        /// A list of all of the currently assigned <c>SecretVersionStage</c> staging labels and
        /// the <c>SecretVersionId</c> attached to each one. Staging labels are used to keep track
        /// of the different versions during the rotation process.
        /// </para>
        ///  <note> 
        /// <para>
        /// A version that does not have any <c>SecretVersionStage</c> is considered deprecated
        /// and subject to deletion. Such versions are not included in this list.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> SecretVersionsToStages { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the SecretVersionsToStages property is set.
        /// </summary>
        internal bool IsSetSecretVersionsToStages() => this.SecretVersionsToStages != null && (this.SecretVersionsToStages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of user-defined tags associated with the secret. To add tags to a secret,
        /// use <a href="https://docs.aws.amazon.com/secretsmanager/latest/apireference/API_TagResource.html">
        /// <c>TagResource</c> </a>. To remove tags, use <a href="https://docs.aws.amazon.com/secretsmanager/latest/apireference/API_UntagResource.html">
        /// <c>UntagResource</c> </a>.
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The exact string that identifies the third-party partner that holds the external secret.
        /// For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/mes-partners.html">Managed
        /// external secret partners</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
