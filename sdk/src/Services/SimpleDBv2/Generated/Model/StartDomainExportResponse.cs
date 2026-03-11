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
 * Do not modify this file. This file is generated from the simpledbv2-2025-09-26.normal.json service model.
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
        private string _clientToken;
        private string _exportArn;
        private DateTime? _requestedAt;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client token that was provided in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ExportArn. 
        /// <para>
        /// Unique ARN identifier of the export.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ExportArn
        {
            get { return this._exportArn; }
            set { this._exportArn = value; }
        }

        // Check to see if ExportArn property is set
        internal bool IsSetExportArn()
        {
            return this._exportArn != null;
        }

        /// <summary>
        /// Gets and sets the property RequestedAt. 
        /// <para>
        /// Timestamp when the export request was received by the service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime RequestedAt
        {
            get { return this._requestedAt.GetValueOrDefault(); }
            set { this._requestedAt = value; }
        }

        // Check to see if RequestedAt property is set
        internal bool IsSetRequestedAt()
        {
            return this._requestedAt.HasValue; 
        }

    }
}