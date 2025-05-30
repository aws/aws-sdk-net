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
    /// A structure containing information about an Lake Formation resource.
    /// </summary>
    public partial class ResourceInfo
    {
        private bool? _hybridAccessEnabled;
        private DateTime? _lastModified;
        private string _resourceArn;
        private string _roleArn;
        private bool? _withFederation;
        private bool? _withPrivilegedAccess;

        /// <summary>
        /// Gets and sets the property HybridAccessEnabled. 
        /// <para>
        ///  Indicates whether the data access of tables pointing to the location can be managed
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
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The date and time the resource was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModified
        {
            get { return this._lastModified; }
            set { this._lastModified = value; }
        }

        // Check to see if LastModified property is set
        internal bool IsSetLastModified()
        {
            return this._lastModified.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource.
        /// </para>
        /// </summary>
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
        /// The IAM role that registered a resource.
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