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
        private DateTime? _nextRotationDate;
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
        /// The date the secret was created.
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
        /// The description of the secret.
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
        /// The key ID or alias ARN of the KMS key that Secrets Manager uses to encrypt the secret
        /// value. If the secret is encrypted with the Amazon Web Services managed key <code>aws/secretsmanager</code>,
        /// this field is omitted. Secrets created using the console use an KMS key ID.
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
        /// The date that the secret was last accessed in the Region. This field is omitted if
        /// the secret has never been retrieved in the Region.
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
        /// The last date and time that Secrets Manager rotated the secret. If the secret isn't
        /// configured for rotation, Secrets Manager returns null.
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
        /// The name of the secret.
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
        /// Gets and sets the property NextRotationDate. 
        /// <para>
        /// The next date and time that Secrets Manager will rotate the secret, rounded to the
        /// nearest hour. If the secret isn't configured for rotation, Secrets Manager returns
        /// null.
        /// </para>
        /// </summary>
        public DateTime NextRotationDate
        {
            get { return this._nextRotationDate.GetValueOrDefault(); }
            set { this._nextRotationDate = value; }
        }

        // Check to see if NextRotationDate property is set
        internal bool IsSetNextRotationDate()
        {
            return this._nextRotationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OwningService. 
        /// <para>
        /// The ID of the service that created this secret. For more information, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/service-linked-secrets.html">Secrets
        /// managed by other Amazon Web Services services</a>.
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
        /// The Region the secret is in. If a secret is replicated to other Regions, the replicas
        /// are listed in <code>ReplicationStatus</code>. 
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
        /// A list of the replicas of this secret and their status: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Failed</code>, which indicates that the replica was not created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>InProgress</code>, which indicates that Secrets Manager is in the process of
        /// creating the replica.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>InSync</code>, which indicates that the replica was created.
        /// </para>
        ///  </li> </ul>
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
        /// Specifies whether automatic rotation is turned on for this secret.
        /// </para>
        ///  
        /// <para>
        /// To turn on rotation, use <a>RotateSecret</a>. To turn off rotation, use <a>CancelRotateSecret</a>.
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
        /// The ARN of the Lambda function that Secrets Manager invokes to rotate the secret.
        /// 
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
        /// The rotation schedule and Lambda function for this secret. If the secret previously
        /// had rotation turned on, but it is now turned off, this field shows the previous rotation
        /// schedule and rotation function. If the secret never had rotation turned on, this field
        /// is omitted.
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
        /// The list of tags attached to the secret. To add tags to a secret, use <a>TagResource</a>.
        /// To remove tags, use <a>UntagResource</a>.
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
        ///  <code>AWSCURRENT</code>, which indicates the current version of the secret.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AWSPENDING</code>, which indicates the version of the secret that contains
        /// new secret information that will become the next current version when rotation finishes.
        /// </para>
        ///  
        /// <para>
        /// During rotation, Secrets Manager creates an <code>AWSPENDING</code> version ID before
        /// creating the new secret version. To check if a secret version exists, call <a>GetSecretValue</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AWSPREVIOUS</code>, which indicates the previous current version of the secret.
        /// You can use this as the <i>last known good</i> version.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about rotation and staging labels, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/rotate-secrets_how.html">How
        /// rotation works</a>.
        /// </para>
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