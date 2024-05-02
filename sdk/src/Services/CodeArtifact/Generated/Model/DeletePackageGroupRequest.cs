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
    /// Container for the parameters to the DeletePackageGroup operation.
    /// Deletes a package group. Deleting a package group does not delete packages or package
    /// versions associated with the package group. When a package group is deleted, the direct
    /// child package groups will become children of the package group's direct parent package
    /// group. Therefore, if any of the child groups are inheriting any settings from the
    /// parent, those settings could change.
    /// </summary>
    public partial class DeletePackageGroupRequest : AmazonCodeArtifactRequest
    {
        private string _domain;
        private string _domainOwner;
        private string _packageGroup;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        ///  The domain that contains the package group to be deleted. 
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
        /// Gets and sets the property PackageGroup. 
        /// <para>
        /// The pattern of the package group to be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PackageGroup
        {
            get { return this._packageGroup; }
            set { this._packageGroup = value; }
        }

        // Check to see if PackageGroup property is set
        internal bool IsSetPackageGroup()
        {
            return this._packageGroup != null;
        }

    }
}