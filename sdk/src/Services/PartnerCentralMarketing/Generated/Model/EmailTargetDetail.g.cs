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

namespace Amazon.PartnerCentralMarketing.Model
{
    /// <summary>
    /// The campaign's attached recipient list, as read — metadata only. 
    /// &lt;para&gt;
    /// No URL and no `S3Uri`, presigned or otherwise. The file is a list of email addresses
    /// belonging to people who are not the partner, so there is no read path for the bytes
    /// at all; what a caller needs is whether the list was accepted and how many recipients
    /// it resolved to. 
    /// &lt;para&gt;
    /// The three counts describe the file as it was read when attached. They are absent for
    /// a list attached before the service began reading lists at upload.
    /// </summary>
    public partial class EmailTargetDetail
    {
        /// <summary>
        /// Gets and sets the property AttachedAt. When the list was attached.
        /// </summary>
        public DateTime? AttachedAt { get; set; }

        /// <summary>
        /// Checks to see if the AttachedAt property is set.
        /// </summary>
        internal bool IsSetAttachedAt() => this.AttachedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DuplicateCount. Rows repeating an address already counted.
        /// Not an error: each address is sent to once.
        /// </summary>
        public int? DuplicateCount { get; set; }

        /// <summary>
        /// Checks to see if the DuplicateCount property is set.
        /// </summary>
        internal bool IsSetDuplicateCount() => this.DuplicateCount.HasValue;

        /// <summary>
        /// Gets and sets the property FileName. The display name of the uploaded file, as the
        /// partner named it, with no path: for example `Q4 leads.csv`. Absent for a list attached
        /// before the service kept the name. There is no link to the file: the list is never
        /// downloadable from the campaign.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Checks to see if the FileName property is set.
        /// </summary>
        internal bool IsSetFileName() => this.FileName != null;

        /// <summary>
        /// Gets and sets the property RejectedCount. Rows skipped because their email cell is
        /// not a usable address.
        /// </summary>
        public int? RejectedCount { get; set; }

        /// <summary>
        /// Checks to see if the RejectedCount property is set.
        /// </summary>
        internal bool IsSetRejectedCount() => this.RejectedCount.HasValue;

        /// <summary>
        /// Gets and sets the property ScanStatus. The scan verdict for the attached list.
        /// </summary>
        public ScanStatus ScanStatus { get; set; }

        /// <summary>
        /// Checks to see if the ScanStatus property is set.
        /// </summary>
        internal bool IsSetScanStatus() => this.ScanStatus != null;

        /// <summary>
        /// Gets and sets the property ValidCount. Distinct usable addresses — the recipients
        /// an email activation sends to.
        /// </summary>
        public int? ValidCount { get; set; }

        /// <summary>
        /// Checks to see if the ValidCount property is set.
        /// </summary>
        internal bool IsSetValidCount() => this.ValidCount.HasValue;
    }
}
