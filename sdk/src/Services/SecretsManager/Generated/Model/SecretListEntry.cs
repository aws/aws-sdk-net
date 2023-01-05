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
    /// A structure that contains the details about a secret. It does not include the encrypted
    /// <code>SecretString</code> and <code>SecretBinary</code> values. To get those values,
    /// use <a href="https://docs.aws.amazon.com/secretsmanager/latest/apireference/API_GetSecretValue.html">GetSecretValue</a>
    /// .
    /// </summary>
    public partial class SecretListEntry
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
        private bool? _rotationEnabled;
        private string _rotationLambdaARN;
        private RotationRulesType _rotationRules;
        private Dictionary<string, List<string>> _secretVersionsToStages = new Dictionary<string, List<string>>();
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the secret.
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
        /// The date and time when a secret was created.
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
        /// The date and time the deletion of the secret occurred. Not present on active secrets.
        /// The secret can be recovered until the number of days in the recovery window has passed,
        /// as specified in the <code>RecoveryWindowInDays</code> parameter of the <a href="https://docs.aws.amazon.com/secretsmanager/latest/apireference/API_DeleteSecret.html">
        /// <code>DeleteSecret</code> </a> operation.
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
        /// The ARN of the KMS key that Secrets Manager uses to encrypt the secret value. If the
        /// secret is encrypted with the Amazon Web Services managed key <code>aws/secretsmanager</code>,
        /// this field is omitted.
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
        /// The most recent date and time that the Secrets Manager rotation process was successfully
        /// completed. This value is null if the secret hasn't ever rotated.
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
        /// The friendly name of the secret. You can use forward slashes in the name to represent
        /// a path hierarchy. For example, <code>/prod/databases/dbserver1</code> could represent
        /// the secret for a server named <code>dbserver1</code> in the folder <code>databases</code>
        /// in the folder <code>prod</code>. 
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
        /// Returns the name of the service that created the secret.
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
        /// The Region where Secrets Manager originated the secret.
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
        /// Gets and sets the property RotationEnabled. 
        /// <para>
        /// Indicates whether automatic, scheduled rotation is enabled for this secret.
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
        /// The ARN of an Amazon Web Services Lambda function invoked by Secrets Manager to rotate
        /// and expire the secret either automatically per the schedule or manually by a call
        /// to <a href="https://docs.aws.amazon.com/secretsmanager/latest/apireference/API_RotateSecret.html">
        /// <code>RotateSecret</code> </a>.
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
        /// A structure that defines the rotation configuration for the secret.
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
        /// Gets and sets the property SecretVersionsToStages. 
        /// <para>
        /// A list of all of the currently assigned <code>SecretVersionStage</code> staging labels
        /// and the <code>SecretVersionId</code> attached to each one. Staging labels are used
        /// to keep track of the different versions during the rotation process.
        /// </para>
        ///  <note> 
        /// <para>
        /// A version that does not have any <code>SecretVersionStage</code> is considered deprecated
        /// and subject to deletion. Such versions are not included in this list.
        /// </para>
        ///  </note>
        /// </summary>
        public Dictionary<string, List<string>> SecretVersionsToStages
        {
            get { return this._secretVersionsToStages; }
            set { this._secretVersionsToStages = value; }
        }

        // Check to see if SecretVersionsToStages property is set
        internal bool IsSetSecretVersionsToStages()
        {
            return this._secretVersionsToStages != null && this._secretVersionsToStages.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of user-defined tags associated with the secret. To add tags to a secret,
        /// use <a href="https://docs.aws.amazon.com/secretsmanager/latest/apireference/API_TagResource.html">
        /// <code>TagResource</code> </a>. To remove tags, use <a href="https://docs.aws.amazon.com/secretsmanager/latest/apireference/API_UntagResource.html">
        /// <code>UntagResource</code> </a>.
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

    }
}