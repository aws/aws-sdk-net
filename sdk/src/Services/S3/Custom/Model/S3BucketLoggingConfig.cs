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
    public partial class S3BucketLoggingConfig
    {
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
