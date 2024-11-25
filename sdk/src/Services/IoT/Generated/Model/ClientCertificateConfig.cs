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
    /// An object that speciﬁes the client certificate conﬁguration for a domain.
    /// </summary>
    public partial class ClientCertificateConfig
    {
        private string _clientCertificateCallbackArn;

        /// <summary>
        /// Gets and sets the property ClientCertificateCallbackArn. 
        /// <para>
        /// The ARN of the Lambda function that IoT invokes after mutual TLS authentication during
        /// the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string ClientCertificateCallbackArn
        {
            get { return this._clientCertificateCallbackArn; }
            set { this._clientCertificateCallbackArn = value; }
        }

        // Check to see if ClientCertificateCallbackArn property is set
        internal bool IsSetClientCertificateCallbackArn()
        {
            return this._clientCertificateCallbackArn != null;
        }

    }
}