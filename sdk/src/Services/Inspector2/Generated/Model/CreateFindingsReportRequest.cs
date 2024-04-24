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
    /// Container for the parameters to the CreateFindingsReport operation.
    /// Creates a finding report. By default only <c>ACTIVE</c> findings are returned in the
    /// report. To see <c>SUPRESSED</c> or <c>CLOSED</c> findings you must specify a value
    /// for the <c>findingStatus</c> filter criteria.
    /// </summary>
    public partial class CreateFindingsReportRequest : AmazonInspector2Request
    {
        private FilterCriteria _filterCriteria;
        private ReportFormat _reportFormat;
        private Destination _s3Destination;

        /// <summary>
        /// Gets and sets the property FilterCriteria. 
        /// <para>
        /// The filter criteria to apply to the results of the finding report.
        /// </para>
        /// </summary>
        public FilterCriteria FilterCriteria
        {
            get { return this._filterCriteria; }
            set { this._filterCriteria = value; }
        }

        // Check to see if FilterCriteria property is set
        internal bool IsSetFilterCriteria()
        {
            return this._filterCriteria != null;
        }

        /// <summary>
        /// Gets and sets the property ReportFormat. 
        /// <para>
        /// The format to generate the report in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReportFormat ReportFormat
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
        /// Gets and sets the property S3Destination. 
        /// <para>
        /// The Amazon S3 export destination for the report.
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