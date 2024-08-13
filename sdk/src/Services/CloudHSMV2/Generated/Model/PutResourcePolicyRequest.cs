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
 * Do not modify this file. This file is generated from the cloudhsmv2-2017-04-28.normal.json service model.
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
namespace Amazon.CloudHSMV2.Model
{
    /// <summary>
    /// Container for the parameters to the PutResourcePolicy operation.
    /// Creates or updates an CloudHSM resource policy. A resource policy helps you to define
    /// the IAM entity (for example, an Amazon Web Services account) that can manage your
    /// CloudHSM resources. The following resources support CloudHSM resource policies: 
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  Backup - The resource policy allows you to describe the backup and restore a cluster
    /// from the backup in another Amazon Web Services account.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// In order to share a backup, it must be in a 'READY' state and you must own it.
    /// </para>
    ///  <important> 
    /// <para>
    /// While you can share a backup using the CloudHSM PutResourcePolicy operation, we recommend
    /// using Resource Access Manager (RAM) instead. Using RAM provides multiple benefits
    /// as it creates the policy for you, allows multiple resources to be shared at one time,
    /// and increases the discoverability of shared resources. If you use PutResourcePolicy
    /// and want consumers to be able to describe the backups you share with them, you must
    /// promote the backup to a standard RAM Resource Share using the RAM PromoteResourceShareCreatedFromPolicy
    /// API operation. For more information, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/sharing.html">
    /// Working with shared backups</a> in the CloudHSM User Guide
    /// </para>
    ///  </important> 
    /// <para>
    ///  <b>Cross-account use:</b> No. You cannot perform this operation on an CloudHSM resource
    /// in a different Amazon Web Services account.
    /// </para>
    /// </summary>
    public partial class PutResourcePolicyRequest : AmazonCloudHSMV2Request
    {
        private string _policy;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The policy you want to associate with a resource. 
        /// </para>
        ///  
        /// <para>
        /// For an example policy, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/sharing.html">
        /// Working with shared backups</a> in the CloudHSM User Guide
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20000)]
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

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the resource to which you want to attach a policy. 
        /// </para>
        /// </summary>
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}