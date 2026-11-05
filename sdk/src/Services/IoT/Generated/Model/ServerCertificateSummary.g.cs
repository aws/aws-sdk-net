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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// An object that contains information about a server certificate.
    /// </summary>
    public partial class ServerCertificateSummary
    {
        /// <summary>
        /// Gets and sets the property ServerCertificateArn. 
        /// <para>
        /// The ARN of the server certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ServerCertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the ServerCertificateArn property is set.
        /// </summary>
        internal bool IsSetServerCertificateArn() => this.ServerCertificateArn != null;

        /// <summary>
        /// Gets and sets the property ServerCertificateStatus. 
        /// <para>
        /// The status of the server certificate.
        /// </para>
        /// </summary>
        public ServerCertificateStatus ServerCertificateStatus { get; set; }

        /// <summary>
        /// Checks to see if the ServerCertificateStatus property is set.
        /// </summary>
        internal bool IsSetServerCertificateStatus() => this.ServerCertificateStatus != null;

        /// <summary>
        /// Gets and sets the property ServerCertificateStatusDetail. 
        /// <para>
        /// Details that explain the status of the server certificate.
        /// </para>
        /// </summary>
        public string ServerCertificateStatusDetail { get; set; }

        /// <summary>
        /// Checks to see if the ServerCertificateStatusDetail property is set.
        /// </summary>
        internal bool IsSetServerCertificateStatusDetail() => this.ServerCertificateStatusDetail != null;
    }
}
