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
    /// Container for the parameters to the UpdatePackageGroup operation. Updates a package
    /// group. This API cannot be used to update a package group's origin configuration or
    /// pattern. To update a package group's origin configuration, use <a href="https://docs.aws.amazon.com/codeartifact/latest/APIReference/API_UpdatePackageGroupOriginConfiguration.html">UpdatePackageGroupOriginConfiguration</a>.
    /// </summary>
    public partial class UpdatePackageGroupRequest : AmazonCodeArtifactRequest
    {
        /// <summary>
        /// Gets and sets the property ContactInfo. 
        /// <para>
        ///  Contact information which you want to update the requested package group with. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string ContactInfo { get; set; }

        /// <summary>
        /// Checks to see if the ContactInfo property is set.
        /// </summary>
        internal bool IsSetContactInfo() => this.ContactInfo != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description you want to update the requested package group with. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        ///  The name of the domain which contains the package group to be updated. 
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
        /// Gets and sets the property PackageGroup. 
        /// <para>
        ///  The pattern of the package group to be updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 520)]
        public string PackageGroup { get; set; }

        /// <summary>
        /// Checks to see if the PackageGroup property is set.
        /// </summary>
        internal bool IsSetPackageGroup() => this.PackageGroup != null;
    }
}
