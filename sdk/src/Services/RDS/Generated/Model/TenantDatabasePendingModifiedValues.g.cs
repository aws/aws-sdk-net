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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// A response element in the <c>ModifyTenantDatabase</c> operation that describes changes
    /// that will be applied. Specific changes are identified by subelements.
    /// </summary>
    public partial class TenantDatabasePendingModifiedValues
    {
        /// <summary>
        /// Gets and sets the property MasterUserPassword. 
        /// <para>
        /// The master password for the tenant database.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string MasterUserPassword { get; set; }

        /// <summary>
        /// Checks to see if the MasterUserPassword property is set.
        /// </summary>
        internal bool IsSetMasterUserPassword() => this.MasterUserPassword != null;

        /// <summary>
        /// Gets and sets the property TenantDBName. 
        /// <para>
        /// The name of the tenant database.
        /// </para>
        /// </summary>
        public string TenantDBName { get; set; }

        /// <summary>
        /// Checks to see if the TenantDBName property is set.
        /// </summary>
        internal bool IsSetTenantDBName() => this.TenantDBName != null;
    }
}
