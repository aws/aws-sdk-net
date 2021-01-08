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
 * Do not modify this file. This file is generated from the cur-2017-01-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostAndUsageReport.Model
{
    /// <summary>
    /// The definition of AWS Cost and Usage Report. You can specify the report name, time
    /// unit, report format, compression format, S3 bucket, additional artifacts, and schema
    /// elements in the definition.
    /// </summary>
    public partial class ReportDefinition
    {
        private List<string> _additionalArtifacts = new List<string>();
        private List<string> _additionalSchemaElements = new List<string>();
        private CompressionFormat _compression;
        private ReportFormat _format;
        private bool? _refreshClosedReports;
        private string _reportName;
        private ReportVersioning _reportVersioning;
        private string _s3Bucket;
        private string _s3Prefix;
        private AWSRegion _s3Region;
        private TimeUnit _timeUnit;

        /// <summary>
        /// Gets and sets the property AdditionalArtifacts. 
        /// <para>
        /// A list of manifests that you want Amazon Web Services to create for this report.
        /// </para>
        /// </summary>
        public List<string> AdditionalArtifacts
        {
            get { return this._additionalArtifacts; }
            set { this._additionalArtifacts = value; }
        }

        // Check to see if AdditionalArtifacts property is set
        internal bool IsSetAdditionalArtifacts()
        {
            return this._additionalArtifacts != null && this._additionalArtifacts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AdditionalSchemaElements. 
        /// <para>
        /// A list of strings that indicate additional content that Amazon Web Services includes
        /// in the report, such as individual resource IDs. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AdditionalSchemaElements
        {
            get { return this._additionalSchemaElements; }
            set { this._additionalSchemaElements = value; }
        }

        // Check to see if AdditionalSchemaElements property is set
        internal bool IsSetAdditionalSchemaElements()
        {
            return this._additionalSchemaElements != null && this._additionalSchemaElements.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Compression.
        /// </summary>
        [AWSProperty(Required=true)]
        public CompressionFormat Compression
        {
            get { return this._compression; }
            set { this._compression = value; }
        }

        // Check to see if Compression property is set
        internal bool IsSetCompression()
        {
            return this._compression != null;
        }

        /// <summary>
        /// Gets and sets the property Format.
        /// </summary>
        [AWSProperty(Required=true)]
        public ReportFormat Format
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
        /// Gets and sets the property RefreshClosedReports. 
        /// <para>
        /// Whether you want Amazon Web Services to update your reports after they have been finalized
        /// if Amazon Web Services detects charges related to previous months. These charges can
        /// include refunds, credits, or support fees.
        /// </para>
        /// </summary>
        public bool RefreshClosedReports
        {
            get { return this._refreshClosedReports.GetValueOrDefault(); }
            set { this._refreshClosedReports = value; }
        }

        // Check to see if RefreshClosedReports property is set
        internal bool IsSetRefreshClosedReports()
        {
            return this._refreshClosedReports.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReportName.
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string ReportName
        {
            get { return this._reportName; }
            set { this._reportName = value; }
        }

        // Check to see if ReportName property is set
        internal bool IsSetReportName()
        {
            return this._reportName != null;
        }

        /// <summary>
        /// Gets and sets the property ReportVersioning. 
        /// <para>
        /// Whether you want Amazon Web Services to overwrite the previous version of each report
        /// or to deliver the report in addition to the previous versions.
        /// </para>
        /// </summary>
        public ReportVersioning ReportVersioning
        {
            get { return this._reportVersioning; }
            set { this._reportVersioning = value; }
        }

        // Check to see if ReportVersioning property is set
        internal bool IsSetReportVersioning()
        {
            return this._reportVersioning != null;
        }

        /// <summary>
        /// Gets and sets the property S3Bucket.
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string S3Bucket
        {
            get { return this._s3Bucket; }
            set { this._s3Bucket = value; }
        }

        // Check to see if S3Bucket property is set
        internal bool IsSetS3Bucket()
        {
            return this._s3Bucket != null;
        }

        /// <summary>
        /// Gets and sets the property S3Prefix.
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string S3Prefix
        {
            get { return this._s3Prefix; }
            set { this._s3Prefix = value; }
        }

        // Check to see if S3Prefix property is set
        internal bool IsSetS3Prefix()
        {
            return this._s3Prefix != null;
        }

        /// <summary>
        /// Gets and sets the property S3Region.
        /// </summary>
        [AWSProperty(Required=true)]
        public AWSRegion S3Region
        {
            get { return this._s3Region; }
            set { this._s3Region = value; }
        }

        // Check to see if S3Region property is set
        internal bool IsSetS3Region()
        {
            return this._s3Region != null;
        }

        /// <summary>
        /// Gets and sets the property TimeUnit.
        /// </summary>
        [AWSProperty(Required=true)]
        public TimeUnit TimeUnit
        {
            get { return this._timeUnit; }
            set { this._timeUnit = value; }
        }

        // Check to see if TimeUnit property is set
        internal bool IsSetTimeUnit()
        {
            return this._timeUnit != null;
        }

    }
}