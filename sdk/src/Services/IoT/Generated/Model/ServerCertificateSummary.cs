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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
        private string _serverCertificateArn;
        private ServerCertificateStatus _serverCertificateStatus;
        private string _serverCertificateStatusDetail;

        /// <summary>
        /// Gets and sets the property ServerCertificateArn. 
        /// <para>
        /// The ARN of the server certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ServerCertificateArn
        {
            get { return this._serverCertificateArn; }
            set { this._serverCertificateArn = value; }
        }

        // Check to see if ServerCertificateArn property is set
        internal bool IsSetServerCertificateArn()
        {
            return this._serverCertificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property ServerCertificateStatus. 
        /// <para>
        /// The status of the server certificate.
        /// </para>
        /// </summary>
        public ServerCertificateStatus ServerCertificateStatus
        {
            get { return this._serverCertificateStatus; }
            set { this._serverCertificateStatus = value; }
        }

        // Check to see if ServerCertificateStatus property is set
        internal bool IsSetServerCertificateStatus()
        {
            return this._serverCertificateStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ServerCertificateStatusDetail. 
        /// <para>
        /// Details that explain the status of the server certificate.
        /// </para>
        /// </summary>
        public string ServerCertificateStatusDetail
        {
            get { return this._serverCertificateStatusDetail; }
            set { this._serverCertificateStatusDetail = value; }
        }

        // Check to see if ServerCertificateStatusDetail property is set
        internal bool IsSetServerCertificateStatusDetail()
        {
            return this._serverCertificateStatusDetail != null;
        }

    }
}