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
    /// This is the response object from the DescribeSecret operation.
    /// </summary>
    public partial class DescribeSecretResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The ARN of the secret.
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
        /// The date the secret was created.
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
        /// The date the secret is scheduled for deletion. If it is not scheduled for deletion,
        /// this field is omitted. When you delete a secret, Secrets Manager requires a recovery
        /// window of at least 7 days before deleting the secret. Some time after the deleted
        /// date, Secrets Manager deletes the secret, including all of its versions.
        /// </para>
        ///  
        /// <para>
        /// If a secret is scheduled for deletion, then its details, including the encrypted secret
        /// value, is not accessible. To cancel a scheduled deletion and restore access to the
        /// secret, use <a>RestoreSecret</a>.
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
        /// The description of the secret.
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
        /// The Amazon Resource Name (ARN) of the role that allows Secrets Manager to rotate a
        /// secret held by a third-party partner. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/mes-security.html">Security
        /// and permissions</a>.
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
        /// The key ID or alias ARN of the KMS key that Secrets Manager uses to encrypt the secret
        /// value. If the secret is encrypted with the Amazon Web Services managed key <c>aws/secretsmanager</c>,
        /// this field is omitted. Secrets created using the console use an KMS key ID.
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
        /// The last date and time that Secrets Manager rotated the secret. If the secret isn't
        /// configured for rotation or rotation has been disabled, Secrets Manager returns null.
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
        /// The name of the secret.
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
        /// If rotation fails, Secrets Manager retries the entire rotation process multiple times.
        /// If rotation is unsuccessful, this date may be in the past.
        /// </para>
        ///  
        /// <para>
        /// This date represents the latest date that rotation will occur, but it is not an approximate
        /// rotation date. In some cases, for example if you turn off automatic rotation and then
        /// turn it back on, the next rotation may occur much sooner than this date.
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
        /// The ID of the service that created this secret. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/service-linked-secrets.html">Secrets
        /// managed by other Amazon Web Services services</a>.
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
        /// The Region the secret is in. If a secret is replicated to other Regions, the replicas
        /// are listed in <c>ReplicationStatus</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string PrimaryRegion { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryRegion property is set.
        /// </summary>
        internal bool IsSetPrimaryRegion() => this.PrimaryRegion != null;

        /// <summary>
        /// Gets and sets the property ReplicationStatus. 
        /// <para>
        /// A list of the replicas of this secret and their status: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Failed</c>, which indicates that the replica was not created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InProgress</c>, which indicates that Secrets Manager is in the process of creating
        /// the replica.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InSync</c>, which indicates that the replica was created.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReplicationStatusType> ReplicationStatus { get; set; } = AWSConfigs.InitializeCollections ? new List<ReplicationStatusType>() : null;

        /// <summary>
        /// Checks to see if the ReplicationStatus property is set.
        /// </summary>
        internal bool IsSetReplicationStatus() => this.ReplicationStatus != null && (this.ReplicationStatus.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RotationEnabled. 
        /// <para>
        /// Specifies whether automatic rotation is turned on for this secret. If the secret has
        /// never been configured for rotation, Secrets Manager returns null.
        /// </para>
        ///  
        /// <para>
        /// To turn on rotation, use <a>RotateSecret</a>. To turn off rotation, use <a>CancelRotateSecret</a>.
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
        /// The ARN of the Lambda function that Secrets Manager invokes to rotate the secret.
        /// 
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
        /// The rotation schedule and Lambda function for this secret. If the secret previously
        /// had rotation turned on, but it is now turned off, this field shows the previous rotation
        /// schedule and rotation function. If the secret never had rotation turned on, this field
        /// is omitted.
        /// </para>
        /// </summary>
        public RotationRulesType RotationRules { get; set; }

        /// <summary>
        /// Checks to see if the RotationRules property is set.
        /// </summary>
        internal bool IsSetRotationRules() => this.RotationRules != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of tags attached to the secret. To add tags to a secret, use <a>TagResource</a>.
        /// To remove tags, use <a>UntagResource</a>.
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
        /// The exact string that identifies the partner that holds the external secret. For more
        /// information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/managed-external-secrets.html">Using
        /// Secrets Manager managed external secrets</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property VersionIdsToStages. 
        /// <para>
        /// A list of the versions of the secret that have staging labels attached. Versions that
        /// don't have staging labels are considered deprecated and Secrets Manager can delete
        /// them.
        /// </para>
        ///  
        /// <para>
        /// Secrets Manager uses staging labels to indicate the status of a secret version during
        /// rotation. The three staging labels for rotation are: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWSCURRENT</c>, which indicates the current version of the secret.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWSPENDING</c>, which indicates the version of the secret that contains new secret
        /// information that will become the next current version when rotation finishes.
        /// </para>
        ///  
        /// <para>
        /// During rotation, Secrets Manager creates an <c>AWSPENDING</c> version ID before creating
        /// the new secret version. To check if a secret version exists, call <a>GetSecretValue</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWSPREVIOUS</c>, which indicates the previous current version of the secret. You
        /// can use this as the <i>last known good</i> version.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about rotation and staging labels, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/rotate-secrets_how.html">How
        /// rotation works</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> VersionIdsToStages { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the VersionIdsToStages property is set.
        /// </summary>
        internal bool IsSetVersionIdsToStages() => this.VersionIdsToStages != null && (this.VersionIdsToStages.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
