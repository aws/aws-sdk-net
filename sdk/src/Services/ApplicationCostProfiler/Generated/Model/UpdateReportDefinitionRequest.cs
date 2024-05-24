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
 * Do not modify this file. This file is generated from the applicationcostprofiler-2020-09-10.normal.json service model.
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
    /// Container for the parameters to the UpdateReportDefinition operation.
    /// Updates existing report in AWS Application Cost Profiler.
    /// </summary>
    public partial class UpdateReportDefinitionRequest : AmazonApplicationCostProfilerRequest
    {
        private S3Location _destinations3Location;
        private Format _format;
        private string _reportDescription;
        private ReportFrequency _reportFrequency;
        private string _reportId;

        /// <summary>
        /// Gets and sets the property DestinationS3Location. 
        /// <para>
        /// Required. Amazon Simple Storage Service (Amazon S3) location where Application Cost
        /// Profiler uploads the report.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3Location DestinationS3Location
        {
            get { return this._destinations3Location; }
            set { this._destinations3Location = value; }
        }

        // Check to see if DestinationS3Location property is set
        internal bool IsSetDestinationS3Location()
        {
            return this._destinations3Location != null;
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// Required. The format to use for the generated report.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Format Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property ReportDescription. 
        /// <para>
        /// Required. Description of the report.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string ReportDescription
        {
            get { return this._reportDescription; }
            set { this._reportDescription = value; }
        }

        // Check to see if ReportDescription property is set
        internal bool IsSetReportDescription()
        {
            return this._reportDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ReportFrequency. 
        /// <para>
        /// Required. The cadence to generate the report.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReportFrequency ReportFrequency
        {
            get { return this._reportFrequency; }
            set { this._reportFrequency = value; }
        }

        // Check to see if ReportFrequency property is set
        internal bool IsSetReportFrequency()
        {
            return this._reportFrequency != null;
        }

        /// <summary>
        /// Gets and sets the property ReportId. 
        /// <para>
        /// Required. ID of the report to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ReportId
        {
            get { return this._reportId; }
            set { this._reportId = value; }
        }

        // Check to see if ReportId property is set
        internal bool IsSetReportId()
        {
            return this._reportId != null;
        }

    }
}