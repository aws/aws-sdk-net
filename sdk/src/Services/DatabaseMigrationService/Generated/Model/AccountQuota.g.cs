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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Describes a quota for an Amazon Web Services account, for example the number of replication
    /// instances allowed.
    /// </summary>
    public partial class AccountQuota
    {
        /// <summary>
        /// Gets and sets the property AccountQuotaName. 
        /// <para>
        /// The name of the DMS quota for this Amazon Web Services account.
        /// </para>
        /// </summary>
        public string AccountQuotaName { get; set; }

        /// <summary>
        /// Checks to see if the AccountQuotaName property is set.
        /// </summary>
        internal bool IsSetAccountQuotaName() => this.AccountQuotaName != null;

        /// <summary>
        /// Gets and sets the property Max. 
        /// <para>
        /// The maximum allowed value for the quota.
        /// </para>
        /// </summary>
        public long? Max { get; set; }

        /// <summary>
        /// Checks to see if the Max property is set.
        /// </summary>
        internal bool IsSetMax() => this.Max.HasValue;

        /// <summary>
        /// Gets and sets the property Used. 
        /// <para>
        /// The amount currently used toward the quota maximum.
        /// </para>
        /// </summary>
        public long? Used { get; set; }

        /// <summary>
        /// Checks to see if the Used property is set.
        /// </summary>
        internal bool IsSetUsed() => this.Used.HasValue;
    }
}
