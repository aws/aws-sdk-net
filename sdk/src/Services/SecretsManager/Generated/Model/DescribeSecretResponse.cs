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
 * Do not modify this file. This file is generated from the secretsmanager-2017-10-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecretsManager.Model
{
    /// <summary>
    /// This is the response object from the DescribeSecret operation.
    /// </summary>
    public partial class DescribeSecretResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private DateTime? _createdDate;
        private DateTime? _deletedDate;
        private string _description;
        private string _kmsKeyId;
        private DateTime? _lastAccessedDate;
        private DateTime? _lastChangedDate;
        private DateTime? _lastRotatedDate;
        private string _name;
        private string _owningService;
        private string _primaryRegion;
        private List<ReplicationStatusType> _replicationStatus = new List<ReplicationStatusType>();
        private bool? _rotationEnabled;
        private string _rotationLambdaARN;
        private RotationRulesType _rotationRules;
        private List<Tag> _tags = new List<Tag>();
        private Dictionary<string, List<string>> _versionIdsToStages = new Dictionary<string, List<string>>();

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The ARN of the secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ARN
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if ARN property is set
        internal bool IsSetARN()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date you created the secret.
        /// </para>
        /// </summary>
        public DateTime CreatedDate
        {
            get { return this._createdDate.GetValueOrDefault(); }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeletedDate. 
        /// <para>
        /// This value exists if the secret is scheduled for deletion. Some time after the specified
        /// date and time, Secrets Manager deletes the secret and all of its versions.
        /// </para>
        ///  
        /// <para>
        /// If a secret is scheduled for deletion, then its details, including the encrypted secret
        /// information, is not accessible. To cancel a scheduled deletion and restore access,
        /// use <a>RestoreSecret</a>.
        /// </para>
        /// </summary>
        public DateTime DeletedDate
        {
            get { return this._deletedDate.GetValueOrDefault(); }
            set { this._deletedDate = value; }
        }

        // Check to see if DeletedDate property is set
        internal bool IsSetDeletedDate()
        {
            return this._deletedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The user-provided description of the secret.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
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
        /// The ARN or alias of the Amazon Web Services KMS customer master key (CMK) that's used
        /// to encrypt the <code>SecretString</code> or <code>SecretBinary</code> fields in each
        /// version of the secret. If you don't provide a key, then Secrets Manager defaults to
        /// encrypting the secret fields with the default Amazon Web Services KMS CMK (the one
        /// named <code>awssecretsmanager</code>) for this account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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
        /// Gets and sets the property LastAccessedDate. 
        /// <para>
        /// The last date that this secret was accessed. This value is truncated to midnight of
        /// the date and therefore shows only the date, not the time.
        /// </para>
        /// </summary>
        public DateTime LastAccessedDate
        {
            get { return this._lastAccessedDate.GetValueOrDefault(); }
            set { this._lastAccessedDate = value; }
        }

        // Check to see if LastAccessedDate property is set
        internal bool IsSetLastAccessedDate()
        {
            return this._lastAccessedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastChangedDate. 
        /// <para>
        /// The last date and time that this secret was modified in any way.
        /// </para>
        /// </summary>
        public DateTime LastChangedDate
        {
            get { return this._lastChangedDate.GetValueOrDefault(); }
            set { this._lastChangedDate = value; }
        }

        // Check to see if LastChangedDate property is set
        internal bool IsSetLastChangedDate()
        {
            return this._lastChangedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastRotatedDate. 
        /// <para>
        /// The last date and time that the rotation process for this secret was invoked.
        /// </para>
        ///  
        /// <para>
        /// The most recent date and time that the Secrets Manager rotation process successfully
        /// completed. If the secret doesn't rotate, Secrets Manager returns a null value.
        /// </para>
        /// </summary>
        public DateTime LastRotatedDate
        {
            get { return this._lastRotatedDate.GetValueOrDefault(); }
            set { this._lastRotatedDate = value; }
        }

        // Check to see if LastRotatedDate property is set
        internal bool IsSetLastRotatedDate()
        {
            return this._lastRotatedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The user-provided friendly name of the secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property OwningService. 
        /// <para>
        /// Returns the name of the service that created this secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string OwningService
        {
            get { return this._owningService; }
            set { this._owningService = value; }
        }

        // Check to see if OwningService property is set
        internal bool IsSetOwningService()
        {
            return this._owningService != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryRegion. 
        /// <para>
        /// Specifies the primary region for secret replication. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string PrimaryRegion
        {
            get { return this._primaryRegion; }
            set { this._primaryRegion = value; }
        }

        // Check to see if PrimaryRegion property is set
        internal bool IsSetPrimaryRegion()
        {
            return this._primaryRegion != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationStatus. 
        /// <para>
        /// Describes a list of replication status objects as <code>InProgress</code>, <code>Failed</code>
        /// or <code>InSync</code>.<code>P</code> 
        /// </para>
        /// </summary>
        public List<ReplicationStatusType> ReplicationStatus
        {
            get { return this._replicationStatus; }
            set { this._replicationStatus = value; }
        }

        // Check to see if ReplicationStatus property is set
        internal bool IsSetReplicationStatus()
        {
            return this._replicationStatus != null && this._replicationStatus.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RotationEnabled. 
        /// <para>
        /// Specifies whether automatic rotation is enabled for this secret.
        /// </para>
        ///  
        /// <para>
        /// To enable rotation, use <a>RotateSecret</a> with <code>AutomaticallyRotateAfterDays</code>
        /// set to a value greater than 0. To disable rotation, use <a>CancelRotateSecret</a>.
        /// </para>
        /// </summary>
        public bool RotationEnabled
        {
            get { return this._rotationEnabled.GetValueOrDefault(); }
            set { this._rotationEnabled = value; }
        }

        // Check to see if RotationEnabled property is set
        internal bool IsSetRotationEnabled()
        {
            return this._rotationEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RotationLambdaARN. 
        /// <para>
        /// The ARN of a Lambda function that's invoked by Secrets Manager to rotate the secret
        /// either automatically per the schedule or manually by a call to <code>RotateSecret</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string RotationLambdaARN
        {
            get { return this._rotationLambdaARN; }
            set { this._rotationLambdaARN = value; }
        }

        // Check to see if RotationLambdaARN property is set
        internal bool IsSetRotationLambdaARN()
        {
            return this._rotationLambdaARN != null;
        }

        /// <summary>
        /// Gets and sets the property RotationRules. 
        /// <para>
        /// A structure with the rotation configuration for this secret.
        /// </para>
        /// </summary>
        public RotationRulesType RotationRules
        {
            get { return this._rotationRules; }
            set { this._rotationRules = value; }
        }

        // Check to see if RotationRules property is set
        internal bool IsSetRotationRules()
        {
            return this._rotationRules != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of user-defined tags that are associated with the secret. To add tags to
        /// a secret, use <a>TagResource</a>. To remove tags, use <a>UntagResource</a>.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VersionIdsToStages. 
        /// <para>
        /// A list of all of the currently assigned <code>VersionStage</code> staging labels and
        /// the <code>VersionId</code> that each is attached to. Staging labels are used to keep
        /// track of the different versions during the rotation process.
        /// </para>
        ///  <note> 
        /// <para>
        /// A version that does not have any staging labels attached is considered deprecated
        /// and subject to deletion. Such versions are not included in this list.
        /// </para>
        ///  </note>
        /// </summary>
        public Dictionary<string, List<string>> VersionIdsToStages
        {
            get { return this._versionIdsToStages; }
            set { this._versionIdsToStages = value; }
        }

        // Check to see if VersionIdsToStages property is set
        internal bool IsSetVersionIdsToStages()
        {
            return this._versionIdsToStages != null && this._versionIdsToStages.Count > 0; 
        }

    }
}