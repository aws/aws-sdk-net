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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Describes where logs are stored and the prefix that Amazon S3 assigns to all log object
    /// keys for a bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/RESTBucketPUTlogging.html">PUT
    /// Bucket logging</a> in the <i>Amazon S3 API Reference</i>.
    /// </summary>
    public class S3BucketLoggingConfig
    {
        private List<S3Grant> targetGrants = AWSConfigs.InitializeCollections ? new List<S3Grant>() : null;

        /// <summary>
        /// Specifies the bucket where you want Amazon S3 to store server access logs. You can have your logs delivered to any bucket that you own,
        /// including the same bucket that is being logged. You can also configure multiple buckets to deliver their logs to the same target bucket. In
        /// this case you should choose a different TargetPrefix for each source bucket so that the delivered log files can be distinguished by key.
        /// </summary>
        public string TargetBucketName { get; set; }

        // Check to see if TargetBucket property is set
        internal bool IsSetTargetBucket()
        {
            return this.TargetBucketName != null;
        }

        /// <summary>
        /// A collection of grants.
        /// 
        /// <para>
        /// Buckets that use the bucket owner enforced setting for Object Ownership don't support
        /// target grants. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/enable-server-access-logging.html#grant-log-delivery-permissions-general">Permissions
        /// for server access log delivery</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public List<S3Grant> Grants
        {
            get { return this.targetGrants; }
            set { this.targetGrants = value; }
        }

        // Check to see if TargetGrants property is set
        internal bool IsSetGrants()
        {
            return this.targetGrants != null && (this.targetGrants.Count > 0 || !AWSConfigs.InitializeCollections);
        }

        private TargetObjectKeyFormat _targetObjectKeyFormat;
        /// <summary>
        /// Gets and sets the property TargetObjectKeyFormat. 
        /// <para>
        /// Amazon S3 key format for log objects.
        /// </para>
        /// </summary>
        public TargetObjectKeyFormat TargetObjectKeyFormat
        {
            get { return this._targetObjectKeyFormat; }
            set { this._targetObjectKeyFormat = value; }
        }

        // Check to see if TargetObjectKeyFormat property is set
        internal bool IsSetTargetObjectKeyFormat()
        {
            return this._targetObjectKeyFormat != null;
        }

        /// <summary>
        /// Gets and sets the property TargetPrefix. 
        /// <para>
        /// A prefix for all log object keys. If you store log files from multiple Amazon S3 buckets
        /// in a single bucket, you can use a prefix to distinguish which log files came from
        /// which bucket.
        /// </para>
        /// </summary>
        public string TargetPrefix { get; set; }

        // Check to see if TargetPrefix property is set
        internal bool IsSetTargetPrefix()
        {
            return this.TargetPrefix != null;
        }

        /// <summary>
        /// Creates a S3Grant and adds it to the list of grants.
        /// </summary>
        /// <param name="grantee">The grantee for the grant.</param>
        /// <param name="permission">The permission for the grantee.</param>
        public void AddGrant(S3Grantee grantee, S3Permission permission)
        {
            if (Grants == null)
            {
                Grants = new List<S3Grant>();
            }

            S3Grant grant = new S3Grant{ Grantee = grantee, Permission = permission };
            Grants.Add(grant);
        }

        /// <summary>
        /// Removes a specific permission for the given grantee.
        /// </summary>
        /// <param name="grantee">The grantee</param>
        /// <param name="permission">The permission for the grantee to remove</param>
        public void RemoveGrant(S3Grantee grantee, S3Permission permission)
        {
            if (Grants != null)
            {
                foreach (S3Grant grant in Grants)
                {
                    if (grant.Grantee.Equals(grantee) && grant.Permission == permission)
                    {
                        Grants.Remove(grant);
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Removes all permissions for the given grantee.
        /// </summary>
        /// <param name="grantee"></param>
        public void RemoveGrant(S3Grantee grantee)
        {
            if (this.Grants != null)
            {
                List<S3Grant> removeList = new List<S3Grant>();
                foreach (S3Grant grant in Grants)
                {
                    if (grant.Grantee.Equals(grantee))
                    {
                        removeList.Add(grant);
                    }
                }
                foreach (S3Grant grant in removeList)
                {
                    this.Grants.Remove(grant);
                }
            }
        }
    }
}
