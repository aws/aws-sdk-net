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
 * Do not modify this file. This file is generated from the timestream-write-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TimestreamWrite.Model
{
    /// <summary>
    /// Report configuration for a batch load task. This contains details about where error
    /// reports are stored.
    /// </summary>
    public partial class ReportConfiguration
    {
        private ReportS3Configuration _reportS3Configuration;

        /// <summary>
        /// Gets and sets the property ReportS3Configuration. 
        /// <para>
        /// Configuration of an S3 location to write error reports and events for a batch load.
        /// </para>
        /// </summary>
        public ReportS3Configuration ReportS3Configuration
        {
            get { return this._reportS3Configuration; }
            set { this._reportS3Configuration = value; }
        }

        // Check to see if ReportS3Configuration property is set
        internal bool IsSetReportS3Configuration()
        {
            return this._reportS3Configuration != null;
        }

    }
}