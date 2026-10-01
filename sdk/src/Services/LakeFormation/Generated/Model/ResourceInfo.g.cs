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

namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// A structure containing information about an Lake Formation resource.
    /// </summary>
    public partial class ResourceInfo
    {
        /// <summary>
        /// Gets and sets the property ExpectedResourceOwnerAccount. 
        /// <para>
        /// The Amazon Web Services account that owns the Glue tables associated with specific
        /// Amazon S3 locations. 
        /// </para>
        /// </summary>
        public string ExpectedResourceOwnerAccount { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedResourceOwnerAccount property is set.
        /// </summary>
        internal bool IsSetExpectedResourceOwnerAccount() => this.ExpectedResourceOwnerAccount != null;

        /// <summary>
        /// Gets and sets the property HybridAccessEnabled. 
        /// <para>
        ///  Indicates whether the data access of tables pointing to the location can be managed
        /// by both Lake Formation permissions as well as Amazon S3 bucket policies. 
        /// </para>
        /// </summary>
        public bool? HybridAccessEnabled { get; set; }

        /// <summary>
        /// Checks to see if the HybridAccessEnabled property is set.
        /// </summary>
        internal bool IsSetHybridAccessEnabled() => this.HybridAccessEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The date and time the resource was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// Checks to see if the LastModified property is set.
        /// </summary>
        internal bool IsSetLastModified() => this.LastModified.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource.
        /// </para>
        /// </summary>
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The IAM role that registered a resource.
        /// </para>
        /// </summary>
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property VerificationStatus. 
        /// <para>
        /// Indicates whether the registered role has sufficient permissions to access registered
        /// Amazon S3 location. Verification Status can be one of the following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// VERIFIED - Registered role has sufficient permissions to access registered Amazon
        /// S3 location.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NOT_VERIFIED - Registered role does not have sufficient permissions to access registered
        /// Amazon S3 location.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// VERIFICATION_FAILED - Unable to verify if the registered role can access the registered
        /// Amazon S3 location.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public VerificationStatus VerificationStatus { get; set; }

        /// <summary>
        /// Checks to see if the VerificationStatus property is set.
        /// </summary>
        internal bool IsSetVerificationStatus() => this.VerificationStatus != null;

        /// <summary>
        /// Gets and sets the property WithFederation. 
        /// <para>
        /// Whether or not the resource is a federated resource.
        /// </para>
        /// </summary>
        public bool? WithFederation { get; set; }

        /// <summary>
        /// Checks to see if the WithFederation property is set.
        /// </summary>
        internal bool IsSetWithFederation() => this.WithFederation.HasValue;

        /// <summary>
        /// Gets and sets the property WithPrivilegedAccess. 
        /// <para>
        /// Grants the calling principal the permissions to perform all supported Lake Formation
        /// operations on the registered data location. 
        /// </para>
        /// </summary>
        public bool? WithPrivilegedAccess { get; set; }

        /// <summary>
        /// Checks to see if the WithPrivilegedAccess property is set.
        /// </summary>
        internal bool IsSetWithPrivilegedAccess() => this.WithPrivilegedAccess.HasValue;
    }
}
