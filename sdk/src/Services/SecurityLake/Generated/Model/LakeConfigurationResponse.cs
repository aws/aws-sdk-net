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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// Provides details of Amazon Security Lake lake configuration object.
    /// </summary>
    public partial class LakeConfigurationResponse
    {
        private string _encryptionKey;
        private List<string> _replicationDestinationRegions = new List<string>();
        private string _replicationRoleArn;
        private List<RetentionSetting> _retentionSettings = new List<RetentionSetting>();
        private string _s3BucketArn;
        private SettingsStatus _status;
        private Dictionary<string, string> _tagsMap = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property EncryptionKey. 
        /// <para>
        /// The type of encryption key used by secure the Security Lake configuration object.
        /// </para>
        /// </summary>
        public string EncryptionKey
        {
            get { return this._encryptionKey; }
            set { this._encryptionKey = value; }
        }

        // Check to see if EncryptionKey property is set
        internal bool IsSetEncryptionKey()
        {
            return this._encryptionKey != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationDestinationRegions. 
        /// <para>
        /// Replication enables automatic, asynchronous copying of objects across Amazon S3 buckets.
        /// Amazon S3 buckets that are configured for object replication can be owned by the same
        /// Amazon Web Services account or by different accounts. You can replicate objects to
        /// a single destination bucket or to multiple destination buckets. The destination buckets
        /// can be in different Amazon Web Services Regions or within the same Region as the source
        /// bucket.
        /// </para>
        ///  
        /// <para>
        /// Set up one or more rollup Regions by providing the Region or Regions that should contribute
        /// to the central rollup Region. 
        /// </para>
        /// </summary>
        public List<string> ReplicationDestinationRegions
        {
            get { return this._replicationDestinationRegions; }
            set { this._replicationDestinationRegions = value; }
        }

        // Check to see if ReplicationDestinationRegions property is set
        internal bool IsSetReplicationDestinationRegions()
        {
            return this._replicationDestinationRegions != null && this._replicationDestinationRegions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReplicationRoleArn. 
        /// <para>
        /// Replication settings for the Amazon S3 buckets. This parameter uses the IAM role you
        /// created that is managed by Security Lake, to ensure the replication setting is correct.
        /// 
        /// </para>
        /// </summary>
        public string ReplicationRoleArn
        {
            get { return this._replicationRoleArn; }
            set { this._replicationRoleArn = value; }
        }

        // Check to see if ReplicationRoleArn property is set
        internal bool IsSetReplicationRoleArn()
        {
            return this._replicationRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property RetentionSettings. 
        /// <para>
        /// Retention settings for the destination Amazon S3 buckets. 
        /// </para>
        /// </summary>
        public List<RetentionSetting> RetentionSettings
        {
            get { return this._retentionSettings; }
            set { this._retentionSettings = value; }
        }

        // Check to see if RetentionSettings property is set
        internal bool IsSetRetentionSettings()
        {
            return this._retentionSettings != null && this._retentionSettings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property S3BucketArn. 
        /// <para>
        /// Amazon Resource Names (ARNs) uniquely identify Amazon Web Services resources. Security
        /// Lake requires an ARN when you need to specify a resource unambiguously across all
        /// of Amazon Web Services, such as in IAM policies, Amazon Relational Database Service
        /// (Amazon RDS) tags, and API calls. 
        /// </para>
        /// </summary>
        public string S3BucketArn
        {
            get { return this._s3BucketArn; }
            set { this._s3BucketArn = value; }
        }

        // Check to see if S3BucketArn property is set
        internal bool IsSetS3BucketArn()
        {
            return this._s3BucketArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Retrieves the status of the configuration operation for an account in Amazon Security
        /// Lake. 
        /// </para>
        /// </summary>
        public SettingsStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TagsMap. 
        /// <para>
        /// A tag is a label that you assign to an Amazon Web Services resource. Each tag consists
        /// of a key and an optional value, both of which you define.
        /// </para>
        /// </summary>
        public Dictionary<string, string> TagsMap
        {
            get { return this._tagsMap; }
            set { this._tagsMap = value; }
        }

        // Check to see if TagsMap property is set
        internal bool IsSetTagsMap()
        {
            return this._tagsMap != null && this._tagsMap.Count > 0; 
        }

    }
}