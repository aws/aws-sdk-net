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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// This is the response object from the CancelExportJobV2 operation.
    /// </summary>
    public partial class CancelExportJobV2Response : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ExportJobId. 
        /// <para>
        /// The unique identifier of the export job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ExportJobId { get; set; }

        /// <summary>
        /// Checks to see if the ExportJobId property is set.
        /// </summary>
        internal bool IsSetExportJobId() => this.ExportJobId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The state of the export job after the cancel request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExportStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
