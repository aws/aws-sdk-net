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
    /// A report of a migration: the prefix it is written under and, once it is written, its
    /// key, its checksum and, for the compatibility reports, the number of blocking findings
    /// in each category.
    /// </summary>
    public partial class ReportOverview
    {
        /// <summary>
        /// Gets and sets the property ChecksumCRC64NVME. 
        /// <para>
        /// The Base64-encoded CRC64NVME checksum of the object that <c>key</c> names. For a report
        /// that has a manifest, the manifest lists the checksum of each report file. This value
        /// is returned after the migration writes the report.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string ChecksumCRC64NVME { get; set; }

        /// <summary>
        /// Checks to see if the ChecksumCRC64NVME property is set.
        /// </summary>
        internal bool IsSetChecksumCRC64NVME() => this.ChecksumCRC64NVME != null;

        /// <summary>
        /// Gets and sets the property InvalidFindings. 
        /// <para>
        /// For the compatibility reports, the number of blocking findings in each category. The
        /// object compatibility report counts each blocked object once, under its most severe
        /// finding. Categories with no blocking findings are left out.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, long> InvalidFindings { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, long>() : null;

        /// <summary>
        /// Checks to see if the InvalidFindings property is set.
        /// </summary>
        internal bool IsSetInvalidFindings() => this.InvalidFindings != null && (this.InvalidFindings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The key of the report object in the bucket. For the object compatibility and object
        /// migration reports, this is the report's manifest; for the table compatibility report,
        /// it is the report itself. This value is returned after the migration writes the report.
        /// A migration doesn't always write every report. For example, a migration that fails
        /// during planning doesn't write the object migration report.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The key prefix that the report is written under.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 512)]
        public string Prefix { get; set; }

        /// <summary>
        /// Checks to see if the Prefix property is set.
        /// </summary>
        internal bool IsSetPrefix() => this.Prefix != null;
    }
}
