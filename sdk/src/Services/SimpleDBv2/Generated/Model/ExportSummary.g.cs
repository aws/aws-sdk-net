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

namespace Amazon.SimpleDBv2.Model
{
    /// <summary>
    /// Summary information about an export, including its unique identifier, current status,
    /// creation time, and the domain being exported.
    /// </summary>
    public partial class ExportSummary
    {
        /// <summary>
        /// Gets and sets the property DomainName. The name of the domain for which the export
        /// was created.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property ExportArn. Unique ARN identifier of the export.
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string ExportArn { get; set; }

        /// <summary>
        /// Checks to see if the ExportArn property is set.
        /// </summary>
        internal bool IsSetExportArn() => this.ExportArn != null;

        /// <summary>
        /// Gets and sets the property ExportStatus. The current state of the export. Current
        /// possible values include : PENDING - export request received, IN_PROGRESS - export
        /// is being processed, SUCCEEDED - export completed successfully, and FAILED - export
        /// encountered an error.
        /// </summary>
        [AWSProperty(Required = true)]
        public ExportStatus ExportStatus { get; set; }

        /// <summary>
        /// Checks to see if the ExportStatus property is set.
        /// </summary>
        internal bool IsSetExportStatus() => this.ExportStatus != null;

        /// <summary>
        /// Gets and sets the property RequestedAt. Timestamp when the export request was received
        /// by the service
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? RequestedAt { get; set; }

        /// <summary>
        /// Checks to see if the RequestedAt property is set.
        /// </summary>
        internal bool IsSetRequestedAt() => this.RequestedAt.HasValue;
    }
}
