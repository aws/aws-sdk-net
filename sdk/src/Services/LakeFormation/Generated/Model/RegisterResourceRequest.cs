/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterResource operation.
    /// Registers the resource as managed by the Data Catalog.
    /// 
    ///  
    /// <para>
    /// To add or update data, Lake Formation needs read/write access to the chosen Amazon
    /// S3 path. Choose a role that you know has permission to do this, or choose the AWSServiceRoleForLakeFormationDataAccess
    /// service-linked role. When you register the first Amazon S3 path, the service-linked
    /// role and a new inline policy are created on your behalf. Lake Formation adds the first
    /// path to the inline policy and attaches it to the service-linked role. When you register
    /// subsequent paths, Lake Formation adds the path to the existing policy.
    /// </para>
    /// </summary>
    public partial class RegisterResourceRequest : AmazonLakeFormationRequest
    {
        private string _resourceArn;
        private string _roleArn;
        private bool? _useServiceLinkedRole;

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
        /// The identifier for the role.
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
        /// Designates a trusted caller, an IAM principal, by registering this caller with the
        /// Data Catalog. 
        /// </para>
        /// </summary>
        public bool UseServiceLinkedRole
        {
            get { return this._useServiceLinkedRole.GetValueOrDefault(); }
            set { this._useServiceLinkedRole = value; }
        }

        // Check to see if UseServiceLinkedRole property is set
        internal bool IsSetUseServiceLinkedRole()
        {
            return this._useServiceLinkedRole.HasValue; 
        }

    }
}