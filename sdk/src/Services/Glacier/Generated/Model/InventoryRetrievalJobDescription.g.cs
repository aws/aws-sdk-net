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

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// Describes the options for a range inventory retrieval job.
    /// </summary>
    public partial class InventoryRetrievalJobDescription
    {
        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The end of the date range in UTC for vault inventory retrieval that includes archives
        /// created before this date. This value should be a string in the ISO 8601 date format,
        /// for example <c>2013-03-20T17:03:43Z</c>.
        /// </para>
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        /// Checks to see if the EndDate property is set.
        /// </summary>
        internal bool IsSetEndDate() => this.EndDate != null;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The output format for the vault inventory list, which is set by the <b>InitiateJob</b>
        /// request when initiating a job to retrieve a vault inventory. Valid values are <c>CSV</c>
        /// and <c>JSON</c>.
        /// </para>
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of inventory items returned per vault inventory retrieval request.
        /// This limit is set when initiating the job with the a <b>InitiateJob</b> request. 
        /// </para>
        /// </summary>
        public string Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit != null;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An opaque string that represents where to continue pagination of the vault inventory
        /// retrieval results. You use the marker in a new <b>InitiateJob</b> request to obtain
        /// additional inventory items. If there are no more inventory items, this value is <c>null</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/amazonglacier/latest/dev/api-initiate-job-post.html#api-initiate-job-post-vault-inventory-list-filtering">
        /// Range Inventory Retrieval</a>.
        /// </para>
        /// </summary>
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The start of the date range in Universal Coordinated Time (UTC) for vault inventory
        /// retrieval that includes archives created on or after this date. This value should
        /// be a string in the ISO 8601 date format, for example <c>2013-03-20T17:03:43Z</c>.
        /// </para>
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// Checks to see if the StartDate property is set.
        /// </summary>
        internal bool IsSetStartDate() => this.StartDate != null;
    }
}
