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

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// This is the response object from the DescribeMetricsExport operation.
    /// </summary>
    public partial class DescribeMetricsExportResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// Explains the error that occurred while exporting the metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property ExportLocation. 
        /// <para>
        /// Specifies the name of the Amazon S3 bucket where the exported metrics is stored.
        /// </para>
        /// </summary>
        public S3Location ExportLocation { get; set; }

        /// <summary>
        /// Checks to see if the ExportLocation property is set.
        /// </summary>
        internal bool IsSetExportLocation() => this.ExportLocation != null;

        /// <summary>
        /// Gets and sets the property MetricsExportId. 
        /// <para>
        /// Identifier for the metrics export task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string MetricsExportId { get; set; }

        /// <summary>
        /// Checks to see if the MetricsExportId property is set.
        /// </summary>
        internal bool IsSetMetricsExportId() => this.MetricsExportId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates the status of the metrics export task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MetricsExportStatusType Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
