/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <summary>Logging Enabled
    /// </summary>
    public class S3BucketLoggingConfig
    {
        private List<S3Grant> targetGrants = new List<S3Grant>();

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
        /// </summary>
        public List<S3Grant> Grants
        {
            get { return this.targetGrants; }
            set { this.targetGrants = value; }
        }

        // Check to see if TargetGrants property is set
        internal bool IsSetGrants()
        {
            return this.targetGrants.Count > 0;
        }

        /// <summary>
        /// This element lets you specify a prefix for the keys that the log files will be stored under.
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
            foreach (S3Grant grant in Grants)
            {
                if (grant.Grantee.Equals(grantee) && grant.Permission == permission)
                {
                    Grants.Remove(grant);
                    break;
                }
            }
        }

        /// <summary>
        /// Removes all permissions for the given grantee.
        /// </summary>
        /// <param name="grantee"></param>
        public void RemoveGrant(S3Grantee grantee)
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
