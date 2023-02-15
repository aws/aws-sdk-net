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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the CancelExportTask operation.
    /// Cancels an export task in progress that is exporting a snapshot or cluster to Amazon
    /// S3. Any data that has already been written to the S3 bucket isn't removed.
    /// </summary>
    public partial class CancelExportTaskRequest : AmazonRDSRequest
    {
        private string _exportTaskIdentifier;

        /// <summary>
        /// Gets and sets the property ExportTaskIdentifier. 
        /// <para>
        /// The identifier of the snapshot or cluster export task to cancel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ExportTaskIdentifier
        {
            get { return this._exportTaskIdentifier; }
            set { this._exportTaskIdentifier = value; }
        }

        // Check to see if ExportTaskIdentifier property is set
        internal bool IsSetExportTaskIdentifier()
        {
            return this._exportTaskIdentifier != null;
        }

    }
}