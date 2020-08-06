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
    /// This is the response object from the DescribeCopyJob operation.
    /// </summary>
    public partial class DescribeCopyJobResponse : AmazonWebServiceResponse
    {
        private CopyJob _copyJob;

        /// <summary>
        /// Gets and sets the property CopyJob. 
        /// <para>
        /// Contains detailed information about a copy job.
        /// </para>
        /// </summary>
        public CopyJob CopyJob
        {
            get { return this._copyJob; }
            set { this._copyJob = value; }
        }

        // Check to see if CopyJob property is set
        internal bool IsSetCopyJob()
        {
            return this._copyJob != null;
        }

    }
}