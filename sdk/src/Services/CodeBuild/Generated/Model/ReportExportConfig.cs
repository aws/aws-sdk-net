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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
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
namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Information about the location where the run of a report is exported.
    /// </summary>
    public partial class ReportExportConfig
    {
        private ReportExportConfigType _exportConfigType;
        private S3ReportExportConfig _s3Destination;

        /// <summary>
        /// Gets and sets the property ExportConfigType. 
        /// <para>
        ///  The export configuration type. Valid values are: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>S3</c>: The report results are exported to an S3 bucket. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NO_EXPORT</c>: The report results are not exported. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ReportExportConfigType ExportConfigType
        {
            get { return this._exportConfigType; }
            set { this._exportConfigType = value; }
        }

        // Check to see if ExportConfigType property is set
        internal bool IsSetExportConfigType()
        {
            return this._exportConfigType != null;
        }

        /// <summary>
        /// Gets and sets the property S3Destination. 
        /// <para>
        ///  A <c>S3ReportExportConfig</c> object that contains information about the S3 bucket
        /// where the run of a report is exported. 
        /// </para>
        /// </summary>
        public S3ReportExportConfig S3Destination
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