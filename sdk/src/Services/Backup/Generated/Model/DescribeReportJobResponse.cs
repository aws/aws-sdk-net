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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Backup.Model
{
    /// <summary>
    /// This is the response object from the DescribeReportJob operation.
    /// </summary>
    public partial class DescribeReportJobResponse : AmazonWebServiceResponse
    {
        private ReportJob _reportJob;

        /// <summary>
        /// Gets and sets the property ReportJob. 
        /// <para>
        /// A list of information about a report job, including its completion and creation times,
        /// report destination, unique report job ID, Amazon Resource Name (ARN), report template,
        /// status, and status message.
        /// </para>
        /// </summary>
        public ReportJob ReportJob
        {
            get { return this._reportJob; }
            set { this._reportJob = value; }
        }

        // Check to see if ReportJob property is set
        internal bool IsSetReportJob()
        {
            return this._reportJob != null;
        }

    }
}