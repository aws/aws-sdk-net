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
    /// Container for the parameters to the PutRepositoryPermissionsPolicy operation. Sets
    /// the resource policy on a repository that specifies permissions to access it. <para>
    /// When you call <c>PutRepositoryPermissionsPolicy</c>, the resource policy on the repository
    /// is ignored when evaluting permissions. This ensures that the owner of a repository
    /// cannot lock themselves out of the repository, which would prevent them from being
    /// able to update the resource policy. </para>
    /// </summary>
    public partial class PutRepositoryPermissionsPolicyRequest : AmazonCodeArtifactRequest
    {
        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        ///  The name of the domain containing the repository to set the resource policy on. 
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
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        ///  A valid displayable JSON Aspen policy string to be set as the access control resource
        /// policy on the provided repository. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 7168)]
        public string PolicyDocument { get; set; }

        /// <summary>
        /// Checks to see if the PolicyDocument property is set.
        /// </summary>
        internal bool IsSetPolicyDocument() => this.PolicyDocument != null;

        /// <summary>
        /// Gets and sets the property PolicyRevision. 
        /// <para>
        ///  Sets the revision of the resource policy that specifies permissions to access the
        /// repository. This revision is used for optimistic locking, which prevents others from
        /// overwriting your changes to the repository's resource policy. 
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
        ///  The name of the repository to set the resource policy on. 
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
