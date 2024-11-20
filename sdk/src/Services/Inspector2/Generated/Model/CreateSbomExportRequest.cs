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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSbomExport operation.
    /// Creates a software bill of materials (SBOM) report.
    /// </summary>
    public partial class CreateSbomExportRequest : AmazonInspector2Request
    {
        private SbomReportFormat _reportFormat;
        private ResourceFilterCriteria _resourceFilterCriteria;
        private Destination _s3Destination;

        /// <summary>
        /// Gets and sets the property ReportFormat. 
        /// <para>
        /// The output format for the software bill of materials (SBOM) report.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SbomReportFormat ReportFormat
        {
            get { return this._reportFormat; }
            set { this._reportFormat = value; }
        }

        // Check to see if ReportFormat property is set
        internal bool IsSetReportFormat()
        {
            return this._reportFormat != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceFilterCriteria. 
        /// <para>
        /// The resource filter criteria for the software bill of materials (SBOM) report.
        /// </para>
        /// </summary>
        public ResourceFilterCriteria ResourceFilterCriteria
        {
            get { return this._resourceFilterCriteria; }
            set { this._resourceFilterCriteria = value; }
        }

        // Check to see if ResourceFilterCriteria property is set
        internal bool IsSetResourceFilterCriteria()
        {
            return this._resourceFilterCriteria != null;
        }

        /// <summary>
        /// Gets and sets the property S3Destination. 
        /// <para>
        /// Contains details of the Amazon S3 bucket and KMS key used to export findings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Destination S3Destination
        {
            get { return this._s3Destination; }
            set { this._s3Destination = value; }
        }

        // Check to see if S3Destination property is set
        internal bool IsSetS3Destination()
        {
            return this._s3Destination != null;
        }

    }
}