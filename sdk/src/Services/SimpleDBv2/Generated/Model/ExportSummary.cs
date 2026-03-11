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
 * Do not modify this file. This file is generated from the simpledbv2-2025-09-26.normal.json service model.
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
        private string _domainName;
        private string _exportArn;
        private ExportStatus _exportStatus;
        private DateTime? _requestedAt;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the domain for which the export was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property ExportArn. 
        /// <para>
        /// Unique ARN identifier of the export.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ExportArn
        {
            get { return this._exportArn; }
            set { this._exportArn = value; }
        }

        // Check to see if ExportArn property is set
        internal bool IsSetExportArn()
        {
            return this._exportArn != null;
        }

        /// <summary>
        /// Gets and sets the property ExportStatus. 
        /// <para>
        /// The current state of the export. Current possible values include : PENDING - export
        /// request received, IN_PROGRESS - export is being processed, SUCCEEDED - export completed
        /// successfully, and FAILED - export encountered an error.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExportStatus ExportStatus
        {
            get { return this._exportStatus; }
            set { this._exportStatus = value; }
        }

        // Check to see if ExportStatus property is set
        internal bool IsSetExportStatus()
        {
            return this._exportStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RequestedAt. 
        /// <para>
        /// Timestamp when the export request was received by the service
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime RequestedAt
        {
            get { return this._requestedAt.GetValueOrDefault(); }
            set { this._requestedAt = value; }
        }

        // Check to see if RequestedAt property is set
        internal bool IsSetRequestedAt()
        {
            return this._requestedAt.HasValue; 
        }

    }
}