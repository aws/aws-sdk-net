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

namespace Amazon.MailManager.Model
{
    /// <summary>
    /// Container for the parameters to the StartArchiveExport operation. Initiates an export
    /// of emails from the specified archive.
    /// </summary>
    public partial class StartArchiveExportRequest : AmazonMailManagerRequest
    {
        /// <summary>
        /// Gets and sets the property ArchiveId. 
        /// <para>
        /// The identifier of the archive to export emails from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 66)]
        public string ArchiveId { get; set; }

        /// <summary>
        /// Checks to see if the ArchiveId property is set.
        /// </summary>
        internal bool IsSetArchiveId() => this.ArchiveId != null;

        /// <summary>
        /// Gets and sets the property ExportDestinationConfiguration. 
        /// <para>
        /// Details on where to deliver the exported email data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExportDestinationConfiguration ExportDestinationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ExportDestinationConfiguration property is set.
        /// </summary>
        internal bool IsSetExportDestinationConfiguration() => this.ExportDestinationConfiguration != null;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Criteria to filter which emails are included in the export.
        /// </para>
        /// </summary>
        public ArchiveFilters Filters { get; set; }

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null;

        /// <summary>
        /// Gets and sets the property FromTimestamp. 
        /// <para>
        /// The start of the timestamp range to include emails from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? FromTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the FromTimestamp property is set.
        /// </summary>
        internal bool IsSetFromTimestamp() => this.FromTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeMetadata. 
        /// <para>
        /// Whether to include message metadata as JSON files in the export.
        /// </para>
        /// </summary>
        public bool? IncludeMetadata { get; set; }

        /// <summary>
        /// Checks to see if the IncludeMetadata property is set.
        /// </summary>
        internal bool IsSetIncludeMetadata() => this.IncludeMetadata.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of email items to include in the export.
        /// </para>
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property ToTimestamp. 
        /// <para>
        /// The end of the timestamp range to include emails from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? ToTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ToTimestamp property is set.
        /// </summary>
        internal bool IsSetToTimestamp() => this.ToTimestamp.HasValue;
    }
}
