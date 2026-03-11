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
    /// Container for the parameters to the CreateTenantResourceAssociation operation.
    /// Associate a resource with a tenant.
    /// 
    ///  
    /// <para>
    ///  <i>Resources</i> can be email identities, configuration sets, or email templates.
    /// When you associate a resource with a tenant, you can use that resource when sending
    /// emails on behalf of that tenant.
    /// </para>
    ///  
    /// <para>
    /// A single resource can be associated with multiple tenants, allowing for resource sharing
    /// across different tenants while maintaining isolation in email sending operations.
    /// </para>
    /// </summary>
    public partial class CreateTenantResourceAssociationRequest : AmazonSimpleEmailServiceV2Request
    {
        private string _resourceArn;
        private string _tenantName;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource to associate with the tenant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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
        /// Gets and sets the property TenantName. 
        /// <para>
        /// The name of the tenant to associate the resource with.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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