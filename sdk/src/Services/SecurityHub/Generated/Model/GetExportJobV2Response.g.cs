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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// This is the response object from the GetExportJobV2 operation.
    /// </summary>
    public partial class GetExportJobV2Response : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// The category of data that the export job produces.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExportDataType DataType { get; set; }

        /// <summary>
        /// Checks to see if the DataType property is set.
        /// </summary>
        internal bool IsSetDataType() => this.DataType != null;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The destination that the export job writes to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExportDestination Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The time when the export job reached a terminal state (<c>SUCCEEDED</c>, <c>FAILED</c>,
        /// or <c>CANCELLED</c>). This parameter is absent while the job is <c>RUNNING</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public DateTime? EndedAt { get; set; }

        /// <summary>
        /// Checks to see if the EndedAt property is set.
        /// </summary>
        internal bool IsSetEndedAt() => this.EndedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ExportJobId. 
        /// <para>
        /// The unique identifier of the export job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ExportJobId { get; set; }

        /// <summary>
        /// Checks to see if the ExportJobId property is set.
        /// </summary>
        internal bool IsSetExportJobId() => this.ExportJobId != null;

        /// <summary>
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// A code that classifies why the export job failed. Present only when <c>Status</c>
        /// is <c>FAILED</c>.
        /// </para>
        /// </summary>
        public ExportFailureCode FailureCode { get; set; }

        /// <summary>
        /// Checks to see if the FailureCode property is set.
        /// </summary>
        internal bool IsSetFailureCode() => this.FailureCode != null;

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// A human-readable message that provides more detail about why the export job failed.
        /// Present only when <c>Status</c> is <c>FAILED</c>.
        /// </para>
        /// </summary>
        public string FailureMessage { get; set; }

        /// <summary>
        /// Checks to see if the FailureMessage property is set.
        /// </summary>
        internal bool IsSetFailureMessage() => this.FailureMessage != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The user-provided name of the export job, if one was specified when the job was started.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OutputConfiguration. 
        /// <para>
        /// The output configuration that the export job was started with, including the format
        /// and any filters or selected fields.
        /// </para>
        /// </summary>
        public ExportOutput OutputConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OutputConfiguration property is set.
        /// </summary>
        internal bool IsSetOutputConfiguration() => this.OutputConfiguration != null;

        /// <summary>
        /// Gets and sets the property Scopes. 
        /// <para>
        /// The organization scopes that the export job was started with, echoed verbatim. This
        /// parameter is absent if the caller didn't supply <c>Scopes</c>. It contains only the
        /// organization or organizational unit (OU) identifiers that the caller submitted; it
        /// never contains resolved member-account identifiers.
        /// </para>
        /// </summary>
        public ExportScopes Scopes { get; set; }

        /// <summary>
        /// Checks to see if the Scopes property is set.
        /// </summary>
        internal bool IsSetScopes() => this.Scopes != null;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The time when the export job was created.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of the export job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExportStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
