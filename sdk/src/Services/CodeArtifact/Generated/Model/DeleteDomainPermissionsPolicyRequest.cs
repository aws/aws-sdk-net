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
 * Do not modify this file. This file is generated from the codeartifact-2018-09-22.normal.json service model.
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
    /// Container for the parameters to the DeleteDomainPermissionsPolicy operation.
    /// Deletes the resource policy set on a domain.
    /// </summary>
    public partial class DeleteDomainPermissionsPolicyRequest : AmazonCodeArtifactRequest
    {
        private string _domain;
        private string _domainOwner;
        private string _policyRevision;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        ///  The name of the domain associated with the resource policy to be deleted. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=50)]
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property DomainOwner. 
        /// <para>
        ///  The 12-digit account number of the Amazon Web Services account that owns the domain.
        /// It does not include dashes or spaces. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string DomainOwner
        {
            get { return this._domainOwner; }
            set { this._domainOwner = value; }
        }

        // Check to see if DomainOwner property is set
        internal bool IsSetDomainOwner()
        {
            return this._domainOwner != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyRevision. 
        /// <para>
        ///  The current revision of the resource policy to be deleted. This revision is used
        /// for optimistic locking, which prevents others from overwriting your changes to the
        /// domain's resource policy. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string PolicyRevision
        {
            get { return this._policyRevision; }
            set { this._policyRevision = value; }
        }

        // Check to see if PolicyRevision property is set
        internal bool IsSetPolicyRevision()
        {
            return this._policyRevision != null;
        }

    }
}