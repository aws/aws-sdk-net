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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// A structure that contains information about a tenant associated with a resource.
    /// </summary>
    public partial class ResourceTenantMetadata
    {
        private DateTime? _associatedTimestamp;
        private string _resourceArn;
        private string _tenantId;
        private string _tenantName;

        /// <summary>
        /// Gets and sets the property AssociatedTimestamp. 
        /// <para>
        /// The date and time when the resource was associated with the tenant.
        /// </para>
        /// </summary>
        public DateTime? AssociatedTimestamp
        {
            get { return this._associatedTimestamp; }
            set { this._associatedTimestamp = value; }
        }

        // Check to see if AssociatedTimestamp property is set
        internal bool IsSetAssociatedTimestamp()
        {
            return this._associatedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property TenantId. 
        /// <para>
        /// A unique identifier for the tenant associated with the resource.
        /// </para>
        /// </summary>
        public string TenantId
        {
            get { return this._tenantId; }
            set { this._tenantId = value; }
        }

        // Check to see if TenantId property is set
        internal bool IsSetTenantId()
        {
            return this._tenantId != null;
        }

        /// <summary>
        /// Gets and sets the property TenantName. 
        /// <para>
        /// The name of the tenant associated with the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string TenantName
        {
            get { return this._tenantName; }
            set { this._tenantName = value; }
        }

        // Check to see if TenantName property is set
        internal bool IsSetTenantName()
        {
            return this._tenantName != null;
        }

    }
}