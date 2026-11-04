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

namespace Amazon.S3Tables.Model
{
    /// <summary>
    /// The reason that a migration failed: a code and, when there is one, the resource or
    /// reason it applies to. This value is returned only when the migration is in the <c>failed</c>
    /// state.
    /// </summary>
    public partial class MigrationFailureReason
    {
        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The failure code. It names the cause or the report that lists the findings. Valid
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>rolePermissions</c> - S3 Tables couldn't assume the migration role, or the role
        /// doesn't have a permission that the migration needs. <c>detail</c> is the role ARN.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sourcePermissions</c> - The migration role couldn't read the Amazon Web Services
        /// Glue table or the source objects. <c>detail</c> names the table (<c>database.table</c>)
        /// or the source bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>destinationPermissions</c> - The migration role couldn't write to the table bucket
        /// or the report bucket. <c>detail</c> names the bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>resourceNotFound</c> - A resource that you specified doesn't exist, such as the
        /// Amazon Web Services Glue table or the source bucket. <c>detail</c> names it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sourceNotSupported</c> - The source table can't be migrated, for example because
        /// it is empty, has too many objects, or has columns or partitions that can't be migrated.
        /// The table compatibility report lists the findings.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tableCompatibilityReport</c> - The migration couldn't create the destination table,
        /// for example because a table with that name already exists or the KMS key can't be
        /// used. For a sync, the destination table changed after the previous migration. The
        /// table compatibility report lists the finding.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>objectCompatibilityReport</c> - Some source objects can't be migrated, for example
        /// because they are archived, or because they were overwritten after an earlier migration
        /// migrated them. The object compatibility report lists them.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>objectMigrationReport</c> - Some source objects failed to migrate. The object
        /// migration report lists them and the cause for each.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>reportBucketNotSupported</c> - The report bucket can't receive the migration's
        /// reports, for example because it is in a different Region than the table bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>internalError</c> - S3 Tables encountered an internal error. Retry the migration,
        /// and contact Amazon Web Services Support if the error persists.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public MigrationFailureCode Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

        /// <summary>
        /// Gets and sets the property Detail. 
        /// <para>
        /// The resource that the failure applies to, such as the role ARN, the Amazon Web Services
        /// Glue table (<c>database.table</c>) or a bucket. For <c>sourceNotSupported</c>, the
        /// reason that the source isn't supported, such as <c>EMPTY_TABLE</c>. This value isn't
        /// returned for the report codes or for <c>internalError</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Detail { get; set; }

        /// <summary>
        /// Checks to see if the Detail property is set.
        /// </summary>
        internal bool IsSetDetail() => this.Detail != null;
    }
}
