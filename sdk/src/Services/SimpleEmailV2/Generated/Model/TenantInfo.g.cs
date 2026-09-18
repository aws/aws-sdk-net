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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// A structure that contains basic information about a tenant.
    /// </summary>
    public partial class TenantInfo
    {
        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The date and time when the tenant was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property TenantArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the tenant.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string TenantArn { get; set; }

        /// <summary>
        /// Checks to see if the TenantArn property is set.
        /// </summary>
        internal bool IsSetTenantArn() => this.TenantArn != null;

        /// <summary>
        /// Gets and sets the property TenantId. 
        /// <para>
        /// A unique identifier for the tenant.
        /// </para>
        /// </summary>
        public string TenantId { get; set; }

        /// <summary>
        /// Checks to see if the TenantId property is set.
        /// </summary>
        internal bool IsSetTenantId() => this.TenantId != null;

        /// <summary>
        /// Gets and sets the property TenantName. 
        /// <para>
        /// The name of the tenant.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string TenantName { get; set; }

        /// <summary>
        /// Checks to see if the TenantName property is set.
        /// </summary>
        internal bool IsSetTenantName() => this.TenantName != null;
    }
}
