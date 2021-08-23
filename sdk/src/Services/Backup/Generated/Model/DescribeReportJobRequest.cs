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
    /// Container for the parameters to the DescribeReportJob operation.
    /// Returns the details associated with creating a report as specified by its <code>ReportJobId</code>.
    /// </summary>
    public partial class DescribeReportJobRequest : AmazonBackupRequest
    {
        private string _reportJobId;

        /// <summary>
        /// Gets and sets the property ReportJobId. 
        /// <para>
        /// The identifier of the report job. A unique, randomly generated, Unicode, UTF-8 encoded
        /// string that is at most 1,024 bytes long. The report job ID cannot be edited.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ReportJobId
        {
            get { return this._reportJobId; }
            set { this._reportJobId = value; }
        }

        // Check to see if ReportJobId property is set
        internal bool IsSetReportJobId()
        {
            return this._reportJobId != null;
        }

    }
}