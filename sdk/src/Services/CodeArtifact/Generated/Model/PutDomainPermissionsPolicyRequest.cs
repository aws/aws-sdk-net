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

namespace Amazon.CodeArtifact.Model
{
    /// <summary>
    /// Container for the parameters to the PutDomainPermissionsPolicy operation.
    /// Sets a resource policy on a domain that specifies permissions to access it. 
    /// 
    ///  
    /// <para>
    ///  When you call <code>PutDomainPermissionsPolicy</code>, the resource policy on the
    /// domain is ignored when evaluting permissions. This ensures that the owner of a domain
    /// cannot lock themselves out of the domain, which would prevent them from being able
    /// to update the resource policy. 
    /// </para>
    /// </summary>
    public partial class PutDomainPermissionsPolicyRequest : AmazonCodeArtifactRequest
    {
        private string _domain;
        private string _domainOwner;
        private string _policyDocument;
        private string _policyRevision;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        ///  The name of the domain on which to set the resource policy. 
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
        ///  The 12-digit account number of the AWS account that owns the domain. It does not
        /// include dashes or spaces. 
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
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        ///  A valid displayable JSON Aspen policy string to be set as the access control resource
        /// policy on the provided domain. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5120)]
        public string PolicyDocument
        {
            get { return this._policyDocument; }
            set { this._policyDocument = value; }
        }

        // Check to see if PolicyDocument property is set
        internal bool IsSetPolicyDocument()
        {
            return this._policyDocument != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyRevision. 
        /// <para>
        ///  The current revision of the resource policy to be set. This revision is used for
        /// optimistic locking, which prevents others from overwriting your changes to the domain's
        /// resource policy. 
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