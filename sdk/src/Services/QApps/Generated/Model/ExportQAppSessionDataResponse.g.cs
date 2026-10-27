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

namespace Amazon.QApps.Model
{
    /// <summary>
    /// This is the response object from the ExportQAppSessionData operation.
    /// </summary>
    public partial class ExportQAppSessionDataResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CsvFileLink. 
        /// <para>
        /// The link where the exported Q App session data can be downloaded from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CsvFileLink { get; set; }

        /// <summary>
        /// Checks to see if the CsvFileLink property is set.
        /// </summary>
        internal bool IsSetCsvFileLink() => this.CsvFileLink != null;

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// The date and time when the link for the exported Q App session data expires.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresAt property is set.
        /// </summary>
        internal bool IsSetExpiresAt() => this.ExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property SessionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Q App data collection session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SessionArn { get; set; }

        /// <summary>
        /// Checks to see if the SessionArn property is set.
        /// </summary>
        internal bool IsSetSessionArn() => this.SessionArn != null;
    }
}
