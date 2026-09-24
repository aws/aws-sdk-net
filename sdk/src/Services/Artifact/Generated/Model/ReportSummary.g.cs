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

namespace Amazon.Artifact.Model
{
    /// <summary>
    /// Summary for report resource.
    /// </summary>
    public partial class ReportSummary
    {
        /// <summary>
        /// Gets and sets the property AcceptanceType. 
        /// <para>
        /// Acceptance type for report.
        /// </para>
        /// </summary>
        public AcceptanceType AcceptanceType { get; set; }

        /// <summary>
        /// Checks to see if the AcceptanceType property is set.
        /// </summary>
        internal bool IsSetAcceptanceType() => this.AcceptanceType != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// ARN for the report resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// Category for the report resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property CompanyName. 
        /// <para>
        /// Associated company name for the report resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Checks to see if the CompanyName property is set.
        /// </summary>
        internal bool IsSetCompanyName() => this.CompanyName != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description for the report resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Unique resource ID for the report resource.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name for the report resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PeriodEnd. 
        /// <para>
        /// Timestamp indicating the report resource effective end.
        /// </para>
        /// </summary>
        public DateTime? PeriodEnd { get; set; }

        /// <summary>
        /// Checks to see if the PeriodEnd property is set.
        /// </summary>
        internal bool IsSetPeriodEnd() => this.PeriodEnd.HasValue;

        /// <summary>
        /// Gets and sets the property PeriodStart. 
        /// <para>
        /// Timestamp indicating the report resource effective start.
        /// </para>
        /// </summary>
        public DateTime? PeriodStart { get; set; }

        /// <summary>
        /// Checks to see if the PeriodStart property is set.
        /// </summary>
        internal bool IsSetPeriodStart() => this.PeriodStart.HasValue;

        /// <summary>
        /// Gets and sets the property ProductName. 
        /// <para>
        /// Associated product name for the report resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ProductName { get; set; }

        /// <summary>
        /// Checks to see if the ProductName property is set.
        /// </summary>
        internal bool IsSetProductName() => this.ProductName != null;

        /// <summary>
        /// Gets and sets the property Series. 
        /// <para>
        /// Series for the report resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Series { get; set; }

        /// <summary>
        /// Checks to see if the Series property is set.
        /// </summary>
        internal bool IsSetSeries() => this.Series != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Current state of the report resource.
        /// </para>
        /// </summary>
        public PublishedState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The message associated with the current upload state.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property UploadState. 
        /// <para>
        /// The current state of the document upload.
        /// </para>
        /// </summary>
        public UploadState UploadState { get; set; }

        /// <summary>
        /// Checks to see if the UploadState property is set.
        /// </summary>
        internal bool IsSetUploadState() => this.UploadState != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// Version for the report resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version.HasValue;
    }
}
