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

namespace Amazon.CodeArtifact.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteRepositoryPermissionsPolicy operation. Deletes
    /// the resource policy that is set on a repository. After a resource policy is deleted,
    /// the permissions allowed and denied by the deleted policy are removed. The effect of
    /// deleting a resource policy might not be immediate. <important> <para> Use <c>DeleteRepositoryPermissionsPolicy</c>
    /// with caution. After a policy is deleted, Amazon Web Services users, roles, and accounts
    /// lose permissions to perform the repository actions granted by the deleted policy.
    /// </para> </important>
    /// </summary>
    public partial class DeleteRepositoryPermissionsPolicyRequest : AmazonCodeArtifactRequest
    {
        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        ///  The name of the domain that contains the repository associated with the resource
        /// policy to be deleted. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 50)]
        public string Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property DomainOwner. 
        /// <para>
        ///  The 12-digit account number of the Amazon Web Services account that owns the domain.
        /// It does not include dashes or spaces. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string DomainOwner { get; set; }

        /// <summary>
        /// Checks to see if the DomainOwner property is set.
        /// </summary>
        internal bool IsSetDomainOwner() => this.DomainOwner != null;

        /// <summary>
        /// Gets and sets the property PolicyRevision. 
        /// <para>
        ///  The revision of the repository's resource policy to be deleted. This revision is
        /// used for optimistic locking, which prevents others from accidentally overwriting your
        /// changes to the repository's resource policy. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string PolicyRevision { get; set; }

        /// <summary>
        /// Checks to see if the PolicyRevision property is set.
        /// </summary>
        internal bool IsSetPolicyRevision() => this.PolicyRevision != null;

        /// <summary>
        /// Gets and sets the property Repository. 
        /// <para>
        ///  The name of the repository that is associated with the resource policy to be deleted
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 100)]
        public string Repository { get; set; }

        /// <summary>
        /// Checks to see if the Repository property is set.
        /// </summary>
        internal bool IsSetRepository() => this.Repository != null;
    }
}
