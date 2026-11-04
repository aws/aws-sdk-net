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
    /// The key prefix for each report. If you don't specify a prefix for a report, its keys
    /// start at the root of the bucket.
    /// </summary>
    public partial class MigrationReportPrefixes
    {
        /// <summary>
        /// Gets and sets the property ObjectCompatibilityReport. 
        /// <para>
        /// The key prefix for the object compatibility report, up to 512 bytes. If not specified,
        /// the report's keys start at the root of the bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 512)]
        public string ObjectCompatibilityReport { get; set; }

        /// <summary>
        /// Checks to see if the ObjectCompatibilityReport property is set.
        /// </summary>
        internal bool IsSetObjectCompatibilityReport() => this.ObjectCompatibilityReport != null;

        /// <summary>
        /// Gets and sets the property ObjectMigrationReport. 
        /// <para>
        /// The key prefix for the object migration report, up to 512 bytes. If not specified,
        /// the report's keys start at the root of the bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 512)]
        public string ObjectMigrationReport { get; set; }

        /// <summary>
        /// Checks to see if the ObjectMigrationReport property is set.
        /// </summary>
        internal bool IsSetObjectMigrationReport() => this.ObjectMigrationReport != null;

        /// <summary>
        /// Gets and sets the property TableCompatibilityReport. 
        /// <para>
        /// The key prefix for the table compatibility report, up to 512 bytes. If not specified,
        /// the report's keys start at the root of the bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 512)]
        public string TableCompatibilityReport { get; set; }

        /// <summary>
        /// Checks to see if the TableCompatibilityReport property is set.
        /// </summary>
        internal bool IsSetTableCompatibilityReport() => this.TableCompatibilityReport != null;
    }
}
