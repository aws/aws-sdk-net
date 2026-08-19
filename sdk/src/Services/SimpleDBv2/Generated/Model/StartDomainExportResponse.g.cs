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

namespace Amazon.SimpleDBv2.Model
{
    /// <summary>
    /// This is the response object from the StartDomainExport operation.
    /// </summary>
    public partial class StartDomainExportResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ClientToken. The client token that was provided in the
        /// request.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ExportArn. Unique ARN identifier of the export.
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string ExportArn { get; set; }

        /// <summary>
        /// Checks to see if the ExportArn property is set.
        /// </summary>
        internal bool IsSetExportArn() => this.ExportArn != null;

        /// <summary>
        /// Gets and sets the property RequestedAt. Timestamp when the export request was received
        /// by the service.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? RequestedAt { get; set; }

        /// <summary>
        /// Checks to see if the RequestedAt property is set.
        /// </summary>
        internal bool IsSetRequestedAt() => this.RequestedAt.HasValue;
    }
}
