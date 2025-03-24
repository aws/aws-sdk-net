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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
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
    /// Container for the parameters to the RegisterResource operation.
    /// Registers the resource as managed by the Data Catalog.
    /// 
    ///  
    /// <para>
    /// To add or update data, Lake Formation needs read/write access to the chosen data location.
    /// Choose a role that you know has permission to do this, or choose the AWSServiceRoleForLakeFormationDataAccess
    /// service-linked role. When you register the first Amazon S3 path, the service-linked
    /// role and a new inline policy are created on your behalf. Lake Formation adds the first
    /// path to the inline policy and attaches it to the service-linked role. When you register
    /// subsequent paths, Lake Formation adds the path to the existing policy.
    /// </para>
    ///  
    /// <para>
    /// The following request registers a new location and gives Lake Formation permission
    /// to use the service-linked role to access that location.
    /// </para>
    ///  
    /// <para>
    ///  <c>ResourceArn = arn:aws:s3:::my-bucket/ UseServiceLinkedRole = true</c> 
    /// </para>
    ///  
    /// <para>
    /// If <c>UseServiceLinkedRole</c> is not set to true, you must provide or set the <c>RoleArn</c>:
    /// </para>
    ///  
    /// <para>
    ///  <c>arn:aws:iam::12345:role/my-data-access-role</c> 
    /// </para>
    /// </summary>
    public partial class RegisterResourceRequest : AmazonLakeFormationRequest
    {
        private bool? _hybridAccessEnabled;
        private string _resourceArn;
        private string _roleArn;
        private bool? _useServiceLinkedRole;
        private bool? _withFederation;
        private bool? _withPrivilegedAccess;

        /// <summary>
        /// Gets and sets the property HybridAccessEnabled. 
        /// <para>
        ///  Specifies whether the data access of tables pointing to the location can be managed
        /// by both Lake Formation permissions as well as Amazon S3 bucket policies. 
        /// </para>
        /// </summary>
        public bool? HybridAccessEnabled
        {
            get { return this._hybridAccessEnabled; }
            set { this._hybridAccessEnabled = value; }
        }

        // Check to see if HybridAccessEnabled property is set
        internal bool IsSetHybridAccessEnabled()
        {
            return this._hybridAccessEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource that you want to register.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The identifier for the role that registers the resource.
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

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
        public bool? UseServiceLinkedRole
        {
            get { return this._useServiceLinkedRole; }
            set { this._useServiceLinkedRole = value; }
        }

        // Check to see if UseServiceLinkedRole property is set
        internal bool IsSetUseServiceLinkedRole()
        {
            return this._useServiceLinkedRole.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WithFederation. 
        /// <para>
        /// Whether or not the resource is a federated resource.
        /// </para>
        /// </summary>
        public bool? WithFederation
        {
            get { return this._withFederation; }
            set { this._withFederation = value; }
        }

        // Check to see if WithFederation property is set
        internal bool IsSetWithFederation()
        {
            return this._withFederation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WithPrivilegedAccess. 
        /// <para>
        /// Grants the calling principal the permissions to perform all supported Lake Formation
        /// operations on the registered data location. 
        /// </para>
        /// </summary>
        public bool? WithPrivilegedAccess
        {
            get { return this._withPrivilegedAccess; }
            set { this._withPrivilegedAccess = value; }
        }

        // Check to see if WithPrivilegedAccess property is set
        internal bool IsSetWithPrivilegedAccess()
        {
            return this._withPrivilegedAccess.HasValue; 
        }

    }
}