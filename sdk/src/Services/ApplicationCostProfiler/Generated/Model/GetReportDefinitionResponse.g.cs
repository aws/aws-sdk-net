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

namespace Amazon.ApplicationCostProfiler.Model
{
    /// <summary>
    /// This is the response object from the GetReportDefinition operation.
    /// </summary>
    public partial class GetReportDefinitionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Timestamp (milliseconds) when this report definition was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DestinationS3Location. 
        /// <para>
        /// Amazon Simple Storage Service (Amazon S3) location where the report is uploaded.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public S3Location DestinationS3Location { get; set; }

        /// <summary>
        /// Checks to see if the DestinationS3Location property is set.
        /// </summary>
        internal bool IsSetDestinationS3Location() => this.DestinationS3Location != null;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// Format of the generated report.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Format Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// Timestamp (milliseconds) when this report definition was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdated property is set.
        /// </summary>
        internal bool IsSetLastUpdated() => this.LastUpdated.HasValue;

        /// <summary>
        /// Gets and sets the property ReportDescription. 
        /// <para>
        /// Description of the report.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string ReportDescription { get; set; }

        /// <summary>
        /// Checks to see if the ReportDescription property is set.
        /// </summary>
        internal bool IsSetReportDescription() => this.ReportDescription != null;

        /// <summary>
        /// Gets and sets the property ReportFrequency. 
        /// <para>
        /// Cadence used to generate the report.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReportFrequency ReportFrequency { get; set; }

        /// <summary>
        /// Checks to see if the ReportFrequency property is set.
        /// </summary>
        internal bool IsSetReportFrequency() => this.ReportFrequency != null;

        /// <summary>
        /// Gets and sets the property ReportId. 
        /// <para>
        /// ID of the report retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ReportId { get; set; }

        /// <summary>
        /// Checks to see if the ReportId property is set.
        /// </summary>
        internal bool IsSetReportId() => this.ReportId != null;
    }
}
