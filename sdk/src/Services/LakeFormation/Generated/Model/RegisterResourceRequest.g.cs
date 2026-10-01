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
    /// Container for the parameters to the RegisterResource operation. Registers the resource
    /// as managed by the Data Catalog. <para> To add or update data, Lake Formation needs
    /// read/write access to the chosen data location. Choose a role that you know has permission
    /// to do this, or choose the AWSServiceRoleForLakeFormationDataAccess service-linked
    /// role. When you register the first Amazon S3 path, the service-linked role and a new
    /// inline policy are created on your behalf. Lake Formation adds the first path to the
    /// inline policy and attaches it to the service-linked role. When you register subsequent
    /// paths, Lake Formation adds the path to the existing policy. </para> <para> The following
    /// request registers a new location and gives Lake Formation permission to use the service-linked
    /// role to access that location. </para> <para> <c>ResourceArn = arn:aws:s3:::my-bucket/
    /// UseServiceLinkedRole = true</c> </para> <para> If <c>UseServiceLinkedRole</c> is not
    /// set to true, you must provide or set the <c>RoleArn</c>: </para> <para> <c>arn:aws:iam::12345:role/my-data-access-role</c>
    /// </para>
    /// </summary>
    public partial class RegisterResourceRequest : AmazonLakeFormationRequest
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
        ///  Specifies whether the data access of tables pointing to the location can be managed
        /// by both Lake Formation permissions as well as Amazon S3 bucket policies. 
        /// </para>
        /// </summary>
        public bool? HybridAccessEnabled { get; set; }

        /// <summary>
        /// Checks to see if the HybridAccessEnabled property is set.
        /// </summary>
        internal bool IsSetHybridAccessEnabled() => this.HybridAccessEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource that you want to register.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The identifier for the role that registers the resource.
        /// </para>
        /// </summary>
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property UseServiceLinkedRole. 
        /// <para>
        /// Designates an Identity and Access Management (IAM) service-linked role by registering
        /// this role with the Data Catalog. A service-linked role is a unique type of IAM role
        /// that is linked directly to Lake Formation.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/lake-formation/latest/dg/service-linked-roles.html">Using
        /// Service-Linked Roles for Lake Formation</a>.
        /// </para>
        /// </summary>
        public bool? UseServiceLinkedRole { get; set; }

        /// <summary>
        /// Checks to see if the UseServiceLinkedRole property is set.
        /// </summary>
        internal bool IsSetUseServiceLinkedRole() => this.UseServiceLinkedRole.HasValue;

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
