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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// Container for the parameters to the PutFileSystemPolicy operation.
    /// Applies an Amazon EFS <code>FileSystemPolicy</code> to an Amazon EFS file system.
    /// A file system policy is an IAM resource-based policy and can contain multiple policy
    /// statements. A file system always has exactly one file system policy, which can be
    /// the default policy or an explicit policy set or updated using this API operation.
    /// EFS file system policies have a 20,000 character limit. When an explicit policy is
    /// set, it overrides the default policy. For more information about the default file
    /// system policy, see <a href="https://docs.aws.amazon.com/efs/latest/ug/iam-access-control-nfs-efs.html#default-filesystempolicy">Default
    /// EFS File System Policy</a>. 
    /// 
    ///  <note> 
    /// <para>
    /// EFS file system policies have a 20,000 character limit.
    /// </para>
    ///  </note> 
    /// <para>
    /// This operation requires permissions for the <code>elasticfilesystem:PutFileSystemPolicy</code>
    /// action.
    /// </para>
    /// </summary>
    public partial class PutFileSystemPolicyRequest : AmazonElasticFileSystemRequest
    {
        private bool? _bypassPolicyLockoutSafetyCheck;
        private string _fileSystemId;
        private string _policy;

        /// <summary>
        /// Gets and sets the property BypassPolicyLockoutSafetyCheck. 
        /// <para>
        /// (Optional) A flag to indicate whether to bypass the <code>FileSystemPolicy</code>
        /// lockout safety check. The policy lockout safety check determines whether the policy
        /// in the request will prevent the principal making the request will be locked out from
        /// making future <code>PutFileSystemPolicy</code> requests on the file system. Set <code>BypassPolicyLockoutSafetyCheck</code>
        /// to <code>True</code> only when you intend to prevent the principal that is making
        /// the request from making a subsequent <code>PutFileSystemPolicy</code> request on the
        /// file system. The default value is False. 
        /// </para>
        /// </summary>
        public bool BypassPolicyLockoutSafetyCheck
        {
            get { return this._bypassPolicyLockoutSafetyCheck.GetValueOrDefault(); }
            set { this._bypassPolicyLockoutSafetyCheck = value; }
        }

        // Check to see if BypassPolicyLockoutSafetyCheck property is set
        internal bool IsSetBypassPolicyLockoutSafetyCheck()
        {
            return this._bypassPolicyLockoutSafetyCheck.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The ID of the EFS file system that you want to create or update the <code>FileSystemPolicy</code>
        /// for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string FileSystemId
        {
            get { return this._fileSystemId; }
            set { this._fileSystemId = value; }
        }

        // Check to see if FileSystemId property is set
        internal bool IsSetFileSystemId()
        {
            return this._fileSystemId != null;
        }

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The <code>FileSystemPolicy</code> that you're creating. Accepts a JSON formatted policy
        /// definition. EFS file system policies have a 20,000 character limit. To find out more
        /// about the elements that make up a file system policy, see <a href="https://docs.aws.amazon.com/efs/latest/ug/access-control-overview.html#access-control-manage-access-intro-resource-policies">EFS
        /// Resource-based Policies</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20000)]
        public string Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

    }
}