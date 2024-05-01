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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CancelExportTask operation.
    /// Cancels an active export task. The request removes all artifacts of the export, including
    /// any partially-created Amazon S3 objects. If the export task is complete or is in the
    /// process of transferring the final disk image, the command fails and returns an error.
    /// </summary>
    public partial class CancelExportTaskRequest : AmazonEC2Request
    {
        private string _exportTaskId;

        /// <summary>
        /// Gets and sets the property ExportTaskId. 
        /// <para>
        /// The ID of the export task. This is the ID returned by the <c>CreateInstanceExportTask</c>
        /// and <c>ExportImage</c> operations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ExportTaskId
        {
            get { return this._exportTaskId; }
            set { this._exportTaskId = value; }
        }

        // Check to see if ExportTaskId property is set
        internal bool IsSetExportTaskId()
        {
            return this._exportTaskId != null;
        }

    }
}